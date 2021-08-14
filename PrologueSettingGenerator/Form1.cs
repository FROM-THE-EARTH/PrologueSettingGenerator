using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.IO;
using System.Net.Http.Headers;

namespace PrologueSettingGenerator
{
    public partial class PrologueSettingGeneratorForm : Form
    {
        readonly static List<string> wind_models = new List<string>() { "real", "original", "only_powerlow" };
        readonly static List<string> op_types = new List<string>() {"頂点検知","発射後指定秒数","頂点検知後秒数"};
        readonly static List<string> places = new List<string>() { "能代/海打ち", "能代/陸打ち", "伊豆/海打ち", "伊豆/陸打ち" };

        public class Processing
        {
            public bool multi_thread { get; set; }//マルチスレッドによる処理の高速化。Scatterモードでのみ有効。
        }
        public class Scatter
        {
            public decimal wind_speed_min { get; set; } //Scatterモード時、シミュレーション対象の風速の最小値[m]
            public decimal wind_speed_max { get; set; } //Scatterモード時、シミュレーション対象の風速の最大値[m]
            public decimal wind_dir_interval { get; set; } //Scatterモード時、風向を何度ずつ変更してシミュレーションするか[deg]
        }
        public class Simulation
        {
            public decimal dt { get; set; } //delta time
            public decimal detect_peak_threshold { get; set; } //頂点検知によるパラシュート開傘時、最高高度から何m落下したら開傘するかどうか[m]
            public Scatter scatter { get; set; }
            public Simulation()
            {
                scatter = new Scatter();
            }
        }

        public class Wind_model
        {
            public decimal power_constant { get; set; } //べき法則の係数
            public string type { get; set; } //使用する風モデル　real, original, only_powerlow
            public string realdata_filename { get; set; } //風向風速データのファイル名。typeがrealの場合のみ有効。
        }

        public class Setting
        {
            public Processing processing { get; set; }
            public Simulation simulation { get; set; }
            public Wind_model wind_model { get; set; }
            public Setting()
            {
                processing = new Processing();
                simulation = new Simulation();
                wind_model = new Wind_model();
            }

            public void ReadJson(string json)
            {
                using (JsonDocument document = JsonDocument.Parse(json))
                {
                    processing.multi_thread = document.RootElement.GetProperty("processing").GetProperty("multi_thread").GetBoolean();

                    simulation.dt = document.RootElement.GetProperty("simulation").GetProperty("dt").GetDecimal();
                    simulation.detect_peak_threshold = document.RootElement.GetProperty("simulation").GetProperty("detect_peak_threshold").GetDecimal();

                    simulation.scatter.wind_speed_min = document.RootElement.GetProperty("simulation").GetProperty("scatter").GetProperty("wind_speed_min").GetDecimal();
                    simulation.scatter.wind_speed_max = document.RootElement.GetProperty("simulation").GetProperty("scatter").GetProperty("wind_speed_max").GetDecimal();
                    simulation.scatter.wind_dir_interval = document.RootElement.GetProperty("simulation").GetProperty("scatter").GetProperty("wind_dir_interval").GetDecimal();

                    wind_model.power_constant = document.RootElement.GetProperty("wind_model").GetProperty("power_constant").GetDecimal();
                    switch (document.RootElement.GetProperty("wind_model").GetProperty("type").GetString())
                    {
                        case "real":
                            wind_model.type = wind_models[0];
                            break;
                        case "original":
                            wind_model.type = wind_models[1];
                            break;
                        case "only_powerlow":
                            wind_model.type = wind_models[2];
                            break;
                        default:
                            wind_model.type = wind_models[0];
                            break;
                    }
                    wind_model.realdata_filename = document.RootElement.GetProperty("wind_model").GetProperty("realdata_filename").GetString();
                }
            }
        }
        
        public class Info
        {
            public string TEAM { get; set; }
            public string NAME { get; set; }
            public string DATE { get; set; }
            public string VERSION { get; set; }
        }

        public class Rocket
        {
            public decimal ref_len { get; set; }//"Rocket length[m]",
            public decimal diam { get; set; }//"Rocket diameter[m]",
            public decimal CGlen_i { get; set; }//"Initial CG place from nose[m] 重心",
            public decimal CGlen_f { get; set; }//"Final CG place from nose[m]　重心",
            public decimal mass_i { get; set; }//"Initial mass[kg] 乾燥質量+酸化剤質量」",
            public decimal mass_f { get; set; }//"Final mass[kg] 乾燥質量",
            public decimal Iyz_i { get; set; }//"Initial inertia moment of rolling[kg*m^2]　ピッチ/ヨー",
            public decimal Iyz_f { get; set; }//"Final inertia moment of rolling[kg*m^2] ピッチ/ヨー",
            public decimal Cmq { get; set; }//"Pitch damping moment coefficient ピッチ減衰モーメント係数",
            public decimal vel_1st { get; set; }//"Terminal velocity of 1st parachute",
            public int op_type_1st { get; set; }//"0:detect-peak, 1:fixed-time 2:time-from-detect-peak",
            public decimal op_time_1st { get; set; }//"open time",
            public decimal delay_time_1st { get; set; }//"パラシュートが開くのにかかる時間",
            public string motor_file { get; set; }//"エンジンの推力履歴ファイル名　分離後1段目などの場合は空白にする",
            public decimal CPlen { get; set; }//"CP place from nose[m] 圧力中心(airspeed_param_fileがある場合は無効)",
		    public decimal Cp_alpha { get; set; }//"圧力中心傾斜[m/rad] from nose(airspeed_param_fileがある場合は無効)",
            public decimal Cd { get; set; }//"Drag coefficient 抗力係数(airspeed_param_fileがある場合は無効)",
            public decimal Cd_alpha2 { get; set; }//"抗力係数傾斜[/rad^2](airspeed_param_fileがある場合は無効)",
            public decimal Cna { get; set; }//"Normal force coefficient 法線力整数(airspeed_param_fileがある場合は無効)",
            public string airspeed_param_file { get; set; }//"圧力中心（傾斜），抗力係数（傾斜），法線力係数 vs 機体速度　のcsvファイル名"

            public void ReadJsonElement(JsonElement jsonElement)
            {
                JsonElement tmp_e;
                if (jsonElement.TryGetProperty("ref_len",out tmp_e))ref_len = tmp_e.GetDecimal();
                if (jsonElement.TryGetProperty("diam", out tmp_e))diam = tmp_e.GetDecimal();
                if (jsonElement.TryGetProperty("CGlen_i", out tmp_e))CGlen_i = tmp_e.GetDecimal();
                if (jsonElement.TryGetProperty("CGlen_f", out tmp_e))CGlen_f = tmp_e.GetDecimal();
                if (jsonElement.TryGetProperty("mass_i", out tmp_e))mass_i = tmp_e.GetDecimal();
                if (jsonElement.TryGetProperty("mass_f", out tmp_e))mass_f = tmp_e.GetDecimal();
                if (jsonElement.TryGetProperty("Iyz_i", out tmp_e))Iyz_i = tmp_e.GetDecimal();
                if (jsonElement.TryGetProperty("Iyz_f", out tmp_e))Iyz_f = tmp_e.GetDecimal();
                if (jsonElement.TryGetProperty("Cmq", out tmp_e))Cmq = tmp_e.GetDecimal();
                if (jsonElement.TryGetProperty("vel_1st", out tmp_e))vel_1st = tmp_e.GetDecimal();
                if (jsonElement.TryGetProperty("op_type_1st", out tmp_e))op_type_1st = tmp_e.GetInt32();
                if (op_type_1st != 0)
                    if (jsonElement.TryGetProperty("op_time_1st", out tmp_e))op_time_1st = tmp_e.GetDecimal();
                if (jsonElement.TryGetProperty("delay_time_1st", out tmp_e))delay_time_1st = tmp_e.GetDecimal();
                if (jsonElement.TryGetProperty("motor_file", out tmp_e)) motor_file = tmp_e.GetString();
                if (jsonElement.TryGetProperty("CPlen", out tmp_e))CPlen = tmp_e.GetDecimal();
                if (jsonElement.TryGetProperty("Cp_alpha", out tmp_e)) Cp_alpha = tmp_e.GetDecimal();
                if (jsonElement.TryGetProperty("Cd", out tmp_e))Cd = tmp_e.GetDecimal();
                if (jsonElement.TryGetProperty("Cd_alpha2", out tmp_e))Cd_alpha2 = tmp_e.GetDecimal();
                if (jsonElement.TryGetProperty("Cna", out tmp_e))Cna = tmp_e.GetDecimal();
                if (jsonElement.TryGetProperty("airspeed_param_file", out tmp_e)) airspeed_param_file = tmp_e.GetString();
            }
        }

        public class Environment
        {
            public string place { get; set; }//"マップ名称: nosiro_sea nosiro_land izu_sea izu_land",
            public decimal rail_len { get; set; }//"ランチャレール長[m]",
            public decimal rail_azi { get; set; }//"ランチャ方位角[degree] 北から右回り",
            public decimal rail_elev { get; set; }//"ランチャ迎角[degree]"
        }

        public class Spec_Single
        {
            public Info info { get; set; }
            public Rocket rocket { get; set; }
            public Environment environment { get; set; }
            public Spec_Single()
            {
                info = new Info();
                rocket = new Rocket();
                environment = new Environment();
            }
        }

        public class Spec
        {
            public Info info { get; set; }
            public List<Rocket> rockets { get; set; }
            public Environment environment { get; set; }
            public Spec()
            {
                info = new Info();
                rockets = new List<Rocket>();
                environment = new Environment();
            }
            public void ReadJson(string json)
            {
                using (JsonDocument document = JsonDocument.Parse(json))
                {
                    info.TEAM = document.RootElement.GetProperty("info").GetProperty("TEAM").GetString();
                    info.NAME = document.RootElement.GetProperty("info").GetProperty("NAME").GetString();
                    info.DATE = document.RootElement.GetProperty("info").GetProperty("DATE").GetString();
                    info.VERSION = document.RootElement.GetProperty("info").GetProperty("VERSION").GetString();

                    JsonElement tmp_e;
                    if (document.RootElement.TryGetProperty("rocket", out tmp_e))
                    {
                        Rocket rocket = new Rocket();
                        rocket.ReadJsonElement(tmp_e);
                        rockets.Add(rocket);
                    }
                    else if (document.RootElement.TryGetProperty("rocket1", out tmp_e))
                    {
                        Rocket rocket1 = new Rocket();
                        rocket1.ReadJsonElement(tmp_e);
                        rockets.Add(rocket1);
                    }
                    if (document.RootElement.TryGetProperty("rocket2", out tmp_e))
                    {
                        MessageBox.Show("多段ロケット未対応です。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Application.Exit();

                        Rocket rocket2 = new Rocket();
                        rocket2.ReadJsonElement(tmp_e);
                        rockets.Add(rocket2);
                    }
                    if (document.RootElement.TryGetProperty("rocket3", out tmp_e))
                    {
                        MessageBox.Show("多段ロケット未対応です。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Application.Exit();

                        Rocket rocket3 = new Rocket();
                        rocket3.ReadJsonElement(tmp_e);
                        rockets.Add(rocket3);
                    }

                    environment.place = document.RootElement.GetProperty("environment").GetProperty("place").GetString();
                    environment.rail_len = document.RootElement.GetProperty("environment").GetProperty("rail_len").GetDecimal();
                    environment.rail_azi = document.RootElement.GetProperty("environment").GetProperty("rail_azi").GetDecimal();
                    environment.rail_elev = document.RootElement.GetProperty("environment").GetProperty("rail_elev").GetDecimal();
                }
            }
        }

        public PrologueSettingGeneratorForm()
        {
            InitializeComponent();
        }

        private void PrologueSettingGeneratorForm_Load(object sender, EventArgs e)
        {
            type.Items.AddRange(wind_models.ToArray());
            op_type_1st.Items.AddRange(op_types.ToArray());
            place.Items.AddRange(places.ToArray());

            type.SelectedIndex = 0;
            op_type_1st.SelectedIndex = 0;
            place.SelectedIndex = 0;

            string setteing_filename = "prologue.settings.json";
            if (File.Exists(setteing_filename))
            {
                using (StreamReader reader = File.OpenText(setteing_filename))
                {
                    string text = reader.ReadToEnd();
                    
                    Setting current_setting = new Setting();
                    current_setting.ReadJson(text);

                    multi_thread.Checked = current_setting.processing.multi_thread;
                    dt.Value = current_setting.simulation.dt;
                    detect_peak_threshold.Value = current_setting.simulation.detect_peak_threshold;
                    wind_speed_min.Value = current_setting.simulation.scatter.wind_speed_min;
                    wind_speed_max.Value = current_setting.simulation.scatter.wind_speed_max;
                    wind_dir_interval.Value = current_setting.simulation.scatter.wind_dir_interval;
                    power_constant.Value = current_setting.wind_model.power_constant;

                    switch (current_setting.wind_model.type)
                    {
                        case "real":
                            type.Text = wind_models[0];
                            break;
                        case "original":
                            type.Text = wind_models[1];
                            break;
                        case "only_powerlow":
                            type.Text = wind_models[2];
                            break;
                        default:
                            type.Text = wind_models[0];
                            break;
                    }

                    string[] files = Directory.GetFiles("./input/wind");
                    for (int i = 0; i < files.Length; i++)files[i] = files[i].Replace(@"./input/wind\", "");
                    realdata_filename_select.Items.AddRange(files);
                    if (files.Length > 0) realdata_filename_select.SelectedItem = files[0];

                    files = Directory.GetFiles("./input/thrust");
                    for (int i = 0; i < files.Length; i++) files[i] = files[i].Replace(@"./input/thrust\", "");
                    motor_file_select.Items.AddRange(files);
                    if (files.Length > 0) motor_file_select.SelectedItem = files[0];


                    airspeed_param_file_select.Items.Add("none");
                    airspeed_param_file_select.SelectedIndex = 0;
                    files = Directory.GetFiles("./input/airspeed_param");
                    for (int i = 0; i < files.Length; i++)files[i] = files[i].Replace(@"./input/airspeed_param\", "");
                    airspeed_param_file_select.Items.AddRange(files);
                }
            }

            string spec_filename = "./input/json/spec_single.json";
            if (File.Exists(spec_filename))
            {
                using (StreamReader reader = File.OpenText(spec_filename))
                {
                    string text = reader.ReadToEnd();
                    Spec current_spec = new Spec();
                    current_spec.ReadJson(text);

                    team_name.Text = current_spec.info.TEAM;
                    rocket_name.Text = current_spec.info.NAME;

                    int date = int.Parse(current_spec.info.DATE);
                    experiment_date_year.Value = date / 10000;
                    experiment_date_month.Value = (date - (date / 10000) * 10000) / 100;
                    experiment_date_date.Value = date - (date / 100) * 100;

                    version.Text = current_spec.info.VERSION;

                    ref_len.Value = current_spec.rockets[0].ref_len;
                    diam.Value = current_spec.rockets[0].diam;
                    CGlen_i.Value = current_spec.rockets[0].CGlen_i;
                    CGlen_f.Value = current_spec.rockets[0].CGlen_f;
                    mass_i.Value = current_spec.rockets[0].mass_i;
                    mass_f.Value = current_spec.rockets[0].mass_f;
                    Iyz_i.Value = current_spec.rockets[0].Iyz_i;
                    Iyz_f.Value = current_spec.rockets[0].Iyz_f;
                    Cmq.Value = current_spec.rockets[0].Cmq;
                    vel_1st.Value = current_spec.rockets[0].vel_1st;
                    switch (current_spec.rockets[0].op_type_1st)
                    {
                        case 0:
                            op_type_1st.Text = op_types[0];
                            break;
                        case 1:
                            op_type_1st.Text = op_types[1];
                            break;
                        case 2:
                            op_type_1st.Text = op_types[2];
                            break;
                        default:
                            op_type_1st.Text = op_types[0];
                            break;
                    }
                    op_time_1st.Value = current_spec.rockets[0].op_time_1st;
                    delay_time_1st.Value = current_spec.rockets[0].delay_time_1st;
                    motor_file_select.Text = current_spec.rockets[0].motor_file;
                    CPlen.Value = current_spec.rockets[0].CPlen;
                    Cp_alpha.Value = current_spec.rockets[0].Cp_alpha;
                    Cd.Value = current_spec.rockets[0].Cd;
                    Cd_alpha2.Value = current_spec.rockets[0].Cd_alpha2;
                    Cna.Value = current_spec.rockets[0].Cna;

                    switch (current_spec.environment.place)
                    {
                        case "nosiro_sea":
                            place.Text = places[0];
                            break;
                        case "nosiro_land":
                            place.Text = places[1];
                            break;
                        case "izu_sea":
                            place.Text = places[2];
                            break;
                        case "izu_land":
                            place.Text = places[3];
                            break;
                        default:
                            place.Text = places[0];
                            break;
                    }

                    rail_len.Value = current_spec.environment.rail_len;
                    rail_azi.Value = current_spec.environment.rail_azi;
                    rail_elev.Value = current_spec.environment.rail_elev;
                }
            }
        }

        private void setting_write_Click(object sender, EventArgs e)
        {
            Setting new_setting = new Setting();

            new_setting.processing.multi_thread = multi_thread.Checked;
            new_setting.simulation.dt = dt.Value;
            new_setting.simulation.detect_peak_threshold = detect_peak_threshold.Value;
            new_setting.simulation.scatter.wind_speed_min = wind_speed_min.Value;
            new_setting.simulation.scatter.wind_speed_max = wind_speed_max.Value;
            new_setting.simulation.scatter.wind_dir_interval = wind_dir_interval.Value;
            new_setting.wind_model.power_constant = power_constant.Value;
            new_setting.wind_model.type = type.SelectedItem.ToString();
            new_setting.wind_model.realdata_filename
                = realdata_filename_select.SelectedItem.ToString()=="none" ? "" : realdata_filename_select.SelectedItem.ToString();

            string setteing_filename = "prologue.settings.json";
            using (StreamWriter writer = File.CreateText(setteing_filename))
            {
                string text = JsonSerializer.Serialize(new_setting, new JsonSerializerOptions { WriteIndented = true });
                writer.Write(text);
            }
        }

        private void spec_write_Click(object sender, EventArgs e)
        {
            Spec_Single new_spec = new Spec_Single();

            new_spec.info.TEAM = team_name.Text;
            new_spec.info.NAME = rocket_name.Text;
            new_spec.info.DATE 
                = (experiment_date_year.Value * 10000 
                + experiment_date_month.Value * 100 
                + experiment_date_date.Value).ToString();
            new_spec.info.VERSION = version.Text;

            new_spec.rocket.ref_len = ref_len.Value;
            new_spec.rocket.diam = diam.Value;
            new_spec.rocket.CGlen_i = CGlen_i.Value;
            new_spec.rocket.CGlen_f = CGlen_f.Value;
            new_spec.rocket.mass_i = mass_i.Value;
            new_spec.rocket.mass_f = mass_f.Value;
            new_spec.rocket.Iyz_i = Iyz_i.Value;
            new_spec.rocket.Iyz_f = Iyz_f.Value;
            new_spec.rocket.Cmq = Cmq.Value;
            new_spec.rocket.vel_1st = vel_1st.Value;
            new_spec.rocket.op_type_1st = op_type_1st.SelectedIndex;
            new_spec.rocket.op_time_1st = op_time_1st.Value;
            new_spec.rocket.delay_time_1st = delay_time_1st.Value;
            new_spec.rocket.motor_file = motor_file_select.SelectedItem.ToString();
            new_spec.rocket.CPlen = CPlen.Value;
            new_spec.rocket.Cp_alpha = Cp_alpha.Value;
            new_spec.rocket.Cd = Cd.Value;
            new_spec.rocket.Cd_alpha2 = Cd_alpha2.Value;
            new_spec.rocket.Cna = Cna.Value;
            new_spec.rocket.airspeed_param_file = airspeed_param_file_select.SelectedItem.ToString();

            switch (place.SelectedIndex)
            {
                case 0:
                    new_spec.environment.place = "nosiro_sea";
                    break;
                case 1:
                    new_spec.environment.place = "nosiro_land";
                    break;
                case 2:
                    new_spec.environment.place = "izu_sea";
                    break;
                case 3:
                    new_spec.environment.place = "izu_land";
                    break;
                default:
                    new_spec.environment.place = "nosiro_sea";
                    break;
            }

            new_spec.environment.rail_len = rail_len.Value;
            new_spec.environment.rail_azi = rail_azi.Value;
            new_spec.environment.rail_elev = rail_elev.Value;

            string spec_filename = "./input/json/spec_single.json";
            if (!Directory.Exists("./input/json")) Directory.CreateDirectory("./input/json");
            using (StreamWriter writer = File.CreateText(spec_filename))
            {
                string text = JsonSerializer.Serialize(new_spec, new JsonSerializerOptions { WriteIndented = true });
                writer.Write(text);
            }
        }

        private void type_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (type.SelectedItem.ToString() == wind_models[0]) realdata_filename_select.Enabled = true;
            else realdata_filename_select.Enabled = false;
        }

        private void op_type_1st_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (op_type_1st.SelectedItem.ToString() != op_types[0]) op_time_1st.Enabled = true;
            else op_time_1st.Enabled = false;
        }

        private void airspeed_param_file_select_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (airspeed_param_file_select.SelectedItem.ToString() != "none")
            {
                CPlen.Enabled = false;
                Cp_alpha.Enabled = false;
                Cd.Enabled = false;
                Cd_alpha2.Enabled = false;
                Cna.Enabled = false;
            }
            else
            {
                CPlen.Enabled = true;
                Cp_alpha.Enabled = true;
                Cd.Enabled = true;
                Cd_alpha2.Enabled = true;
                Cna.Enabled = true;
            }
        }
    }
}
