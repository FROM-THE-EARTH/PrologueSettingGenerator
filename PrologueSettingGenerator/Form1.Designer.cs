namespace PrologueSettingGenerator
{
    partial class PrologueSettingGeneratorForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrologueSettingGeneratorForm));
            this.settings = new System.Windows.Forms.GroupBox();
            this.setting_write = new System.Windows.Forms.Button();
            this.wind_model = new System.Windows.Forms.GroupBox();
            this.power_constant = new System.Windows.Forms.NumericUpDown();
            this.realdata_filename_label = new System.Windows.Forms.Label();
            this.type = new System.Windows.Forms.ComboBox();
            this.type_label = new System.Windows.Forms.Label();
            this.power_constant_label = new System.Windows.Forms.Label();
            this.simulation = new System.Windows.Forms.GroupBox();
            this.detect_peak_threshold = new System.Windows.Forms.NumericUpDown();
            this.scatter = new System.Windows.Forms.GroupBox();
            this.wind_dir_interval = new System.Windows.Forms.NumericUpDown();
            this.wind_speed_max = new System.Windows.Forms.NumericUpDown();
            this.wind_speed_min = new System.Windows.Forms.NumericUpDown();
            this.wind_dir_interval_deg = new System.Windows.Forms.Label();
            this.wind_dir_interval_label = new System.Windows.Forms.Label();
            this.wind_speed_max_ms = new System.Windows.Forms.Label();
            this.wind_speed_min_ms = new System.Windows.Forms.Label();
            this.wind_speed_max_label = new System.Windows.Forms.Label();
            this.wind_speed_min_label = new System.Windows.Forms.Label();
            this.detect_peak_threshold_m = new System.Windows.Forms.Label();
            this.detect_peak_threshold_label = new System.Windows.Forms.Label();
            this.processing = new System.Windows.Forms.GroupBox();
            this.multi_thread = new System.Windows.Forms.CheckBox();
            this.rocket = new System.Windows.Forms.GroupBox();
            this.spec_write = new System.Windows.Forms.Button();
            this.environment = new System.Windows.Forms.GroupBox();
            this.rail_elev_deg = new System.Windows.Forms.Label();
            this.rail_len_m = new System.Windows.Forms.Label();
            this.rail_azi_deg = new System.Windows.Forms.Label();
            this.rail_elev = new System.Windows.Forms.NumericUpDown();
            this.rail_azi = new System.Windows.Forms.NumericUpDown();
            this.rail_len = new System.Windows.Forms.NumericUpDown();
            this.place = new System.Windows.Forms.ComboBox();
            this.rail_elev_label = new System.Windows.Forms.Label();
            this.rail_azi_label = new System.Windows.Forms.Label();
            this.rail_len_label = new System.Windows.Forms.Label();
            this.place_label = new System.Windows.Forms.Label();
            this.parameter = new System.Windows.Forms.GroupBox();
            this.Cna = new System.Windows.Forms.NumericUpDown();
            this.Cd_alpha2_rad2 = new System.Windows.Forms.Label();
            this.Cp_alpha_mrad = new System.Windows.Forms.Label();
            this.CPlen_m = new System.Windows.Forms.Label();
            this.delay_time_1st_s = new System.Windows.Forms.Label();
            this.op_time_1st_s = new System.Windows.Forms.Label();
            this.vel_1st_ms = new System.Windows.Forms.Label();
            this.Iyz_f_kgm2 = new System.Windows.Forms.Label();
            this.Iyz_i_kgm2 = new System.Windows.Forms.Label();
            this.Cd_alpha2 = new System.Windows.Forms.NumericUpDown();
            this.Cd = new System.Windows.Forms.NumericUpDown();
            this.Cp_alpha = new System.Windows.Forms.NumericUpDown();
            this.CPlen = new System.Windows.Forms.NumericUpDown();
            this.delay_time_1st = new System.Windows.Forms.NumericUpDown();
            this.op_time_1st = new System.Windows.Forms.NumericUpDown();
            this.op_type_1st = new System.Windows.Forms.ComboBox();
            this.vel_1st = new System.Windows.Forms.NumericUpDown();
            this.Cmq = new System.Windows.Forms.NumericUpDown();
            this.Iyz_f = new System.Windows.Forms.NumericUpDown();
            this.Iyz_i = new System.Windows.Forms.NumericUpDown();
            this.mass_f_kg = new System.Windows.Forms.Label();
            this.mass_i_kg = new System.Windows.Forms.Label();
            this.CGlen_f_m = new System.Windows.Forms.Label();
            this.CGlen_i_m = new System.Windows.Forms.Label();
            this.mass_f = new System.Windows.Forms.NumericUpDown();
            this.mass_i = new System.Windows.Forms.NumericUpDown();
            this.CGlen_f = new System.Windows.Forms.NumericUpDown();
            this.CGlen_i = new System.Windows.Forms.NumericUpDown();
            this.diam_m = new System.Windows.Forms.Label();
            this.diam = new System.Windows.Forms.NumericUpDown();
            this.ref_len_m = new System.Windows.Forms.Label();
            this.ref_len = new System.Windows.Forms.NumericUpDown();
            this.Cna_label = new System.Windows.Forms.Label();
            this.Cp_alpha_label = new System.Windows.Forms.Label();
            this.CPlen_label = new System.Windows.Forms.Label();
            this.Cd_label = new System.Windows.Forms.Label();
            this.airspeed_param_file_label = new System.Windows.Forms.Label();
            this.Cd_alpha2_label = new System.Windows.Forms.Label();
            this.motor_file_label = new System.Windows.Forms.Label();
            this.op_type_1st_label = new System.Windows.Forms.Label();
            this.delay_time_1st_label = new System.Windows.Forms.Label();
            this.op_time_1st_label = new System.Windows.Forms.Label();
            this.vel_1st_label = new System.Windows.Forms.Label();
            this.Cmq_label = new System.Windows.Forms.Label();
            this.Iyz_f_label = new System.Windows.Forms.Label();
            this.Iyz_i_label = new System.Windows.Forms.Label();
            this.mass_f_label = new System.Windows.Forms.Label();
            this.mass_i_label = new System.Windows.Forms.Label();
            this.CGlen_f_label = new System.Windows.Forms.Label();
            this.CGlen_i_label = new System.Windows.Forms.Label();
            this.diam_label = new System.Windows.Forms.Label();
            this.ref_len_label = new System.Windows.Forms.Label();
            this.info = new System.Windows.Forms.GroupBox();
            this.version = new System.Windows.Forms.TextBox();
            this.experiment_date_date_label = new System.Windows.Forms.Label();
            this.experiment_date_date = new System.Windows.Forms.NumericUpDown();
            this.experiment_date_month_label = new System.Windows.Forms.Label();
            this.experiment_date_month = new System.Windows.Forms.NumericUpDown();
            this.experiment_date_year_label = new System.Windows.Forms.Label();
            this.experiment_date_year = new System.Windows.Forms.NumericUpDown();
            this.rocket_name = new System.Windows.Forms.TextBox();
            this.team_name = new System.Windows.Forms.TextBox();
            this.version_label = new System.Windows.Forms.Label();
            this.experiment_date_label = new System.Windows.Forms.Label();
            this.rocket_name_label = new System.Windows.Forms.Label();
            this.team_name_label = new System.Windows.Forms.Label();
            this.realdata_filename_select = new System.Windows.Forms.ComboBox();
            this.airspeed_param_file_select = new System.Windows.Forms.ComboBox();
            this.motor_file_select = new System.Windows.Forms.ComboBox();
            this.settings.SuspendLayout();
            this.wind_model.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.power_constant)).BeginInit();
            this.simulation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.detect_peak_threshold)).BeginInit();
            this.scatter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wind_dir_interval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wind_speed_max)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wind_speed_min)).BeginInit();
            this.processing.SuspendLayout();
            this.rocket.SuspendLayout();
            this.environment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rail_elev)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rail_azi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rail_len)).BeginInit();
            this.parameter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Cna)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cd_alpha2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cp_alpha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CPlen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.delay_time_1st)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.op_time_1st)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vel_1st)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cmq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Iyz_f)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Iyz_i)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mass_f)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mass_i)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CGlen_f)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CGlen_i)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ref_len)).BeginInit();
            this.info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.experiment_date_date)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.experiment_date_month)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.experiment_date_year)).BeginInit();
            this.SuspendLayout();
            // 
            // settings
            // 
            this.settings.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.settings.Controls.Add(this.setting_write);
            this.settings.Controls.Add(this.wind_model);
            this.settings.Controls.Add(this.simulation);
            this.settings.Controls.Add(this.processing);
            this.settings.Location = new System.Drawing.Point(12, 12);
            this.settings.Name = "settings";
            this.settings.Padding = new System.Windows.Forms.Padding(20);
            this.settings.Size = new System.Drawing.Size(776, 366);
            this.settings.TabIndex = 0;
            this.settings.TabStop = false;
            this.settings.Text = "設定";
            // 
            // setting_write
            // 
            this.setting_write.Location = new System.Drawing.Point(678, 330);
            this.setting_write.Name = "setting_write";
            this.setting_write.Size = new System.Drawing.Size(75, 23);
            this.setting_write.TabIndex = 4;
            this.setting_write.Text = "保存/上書き";
            this.setting_write.UseVisualStyleBackColor = true;
            this.setting_write.Click += new System.EventHandler(this.setting_write_Click);
            // 
            // wind_model
            // 
            this.wind_model.Controls.Add(this.realdata_filename_select);
            this.wind_model.Controls.Add(this.power_constant);
            this.wind_model.Controls.Add(this.realdata_filename_label);
            this.wind_model.Controls.Add(this.type);
            this.wind_model.Controls.Add(this.type_label);
            this.wind_model.Controls.Add(this.power_constant_label);
            this.wind_model.Dock = System.Windows.Forms.DockStyle.Top;
            this.wind_model.Location = new System.Drawing.Point(20, 224);
            this.wind_model.Name = "wind_model";
            this.wind_model.Size = new System.Drawing.Size(736, 100);
            this.wind_model.TabIndex = 3;
            this.wind_model.TabStop = false;
            this.wind_model.Text = "風モデル";
            // 
            // power_constant
            // 
            this.power_constant.Cursor = System.Windows.Forms.Cursors.Default;
            this.power_constant.DecimalPlaces = 1;
            this.power_constant.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.power_constant.Location = new System.Drawing.Point(119, 17);
            this.power_constant.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.power_constant.Name = "power_constant";
            this.power_constant.Size = new System.Drawing.Size(56, 19);
            this.power_constant.TabIndex = 12;
            this.power_constant.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            // 
            // realdata_filename_label
            // 
            this.realdata_filename_label.AutoSize = true;
            this.realdata_filename_label.Location = new System.Drawing.Point(7, 71);
            this.realdata_filename_label.Name = "realdata_filename_label";
            this.realdata_filename_label.Size = new System.Drawing.Size(115, 12);
            this.realdata_filename_label.TabIndex = 14;
            this.realdata_filename_label.Text = "風向風速データファイル";
            // 
            // type
            // 
            this.type.FormattingEnabled = true;
            this.type.Location = new System.Drawing.Point(102, 42);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(335, 20);
            this.type.TabIndex = 12;
            this.type.SelectedIndexChanged += new System.EventHandler(this.type_SelectedIndexChanged);
            // 
            // type_label
            // 
            this.type_label.AutoSize = true;
            this.type_label.Location = new System.Drawing.Point(7, 45);
            this.type_label.Name = "type_label";
            this.type_label.Size = new System.Drawing.Size(89, 12);
            this.type_label.TabIndex = 11;
            this.type_label.Text = "使用する風モデル";
            // 
            // power_constant_label
            // 
            this.power_constant_label.AutoSize = true;
            this.power_constant_label.Location = new System.Drawing.Point(7, 19);
            this.power_constant_label.Name = "power_constant_label";
            this.power_constant_label.Size = new System.Drawing.Size(72, 12);
            this.power_constant_label.TabIndex = 0;
            this.power_constant_label.Text = "べき法則係数";
            // 
            // simulation
            // 
            this.simulation.Controls.Add(this.detect_peak_threshold);
            this.simulation.Controls.Add(this.scatter);
            this.simulation.Controls.Add(this.detect_peak_threshold_m);
            this.simulation.Controls.Add(this.detect_peak_threshold_label);
            this.simulation.Dock = System.Windows.Forms.DockStyle.Top;
            this.simulation.Location = new System.Drawing.Point(20, 78);
            this.simulation.Name = "simulation";
            this.simulation.Size = new System.Drawing.Size(736, 146);
            this.simulation.TabIndex = 2;
            this.simulation.TabStop = false;
            this.simulation.Text = "シミュレーション";
            // 
            // detect_peak_threshold
            // 
            this.detect_peak_threshold.Cursor = System.Windows.Forms.Cursors.Default;
            this.detect_peak_threshold.DecimalPlaces = 1;
            this.detect_peak_threshold.Location = new System.Drawing.Point(138, 16);
            this.detect_peak_threshold.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.detect_peak_threshold.Name = "detect_peak_threshold";
            this.detect_peak_threshold.Size = new System.Drawing.Size(56, 19);
            this.detect_peak_threshold.TabIndex = 4;
            this.detect_peak_threshold.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // scatter
            // 
            this.scatter.Controls.Add(this.wind_dir_interval);
            this.scatter.Controls.Add(this.wind_speed_max);
            this.scatter.Controls.Add(this.wind_speed_min);
            this.scatter.Controls.Add(this.wind_dir_interval_deg);
            this.scatter.Controls.Add(this.wind_dir_interval_label);
            this.scatter.Controls.Add(this.wind_speed_max_ms);
            this.scatter.Controls.Add(this.wind_speed_min_ms);
            this.scatter.Controls.Add(this.wind_speed_max_label);
            this.scatter.Controls.Add(this.wind_speed_min_label);
            this.scatter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.scatter.Location = new System.Drawing.Point(3, 46);
            this.scatter.Name = "scatter";
            this.scatter.Size = new System.Drawing.Size(730, 97);
            this.scatter.TabIndex = 3;
            this.scatter.TabStop = false;
            this.scatter.Text = "散乱シミュレーション設定";
            // 
            // wind_dir_interval
            // 
            this.wind_dir_interval.Cursor = System.Windows.Forms.Cursors.Default;
            this.wind_dir_interval.DecimalPlaces = 1;
            this.wind_dir_interval.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.wind_dir_interval.Location = new System.Drawing.Point(110, 65);
            this.wind_dir_interval.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.wind_dir_interval.Name = "wind_dir_interval";
            this.wind_dir_interval.Size = new System.Drawing.Size(56, 19);
            this.wind_dir_interval.TabIndex = 11;
            this.wind_dir_interval.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // wind_speed_max
            // 
            this.wind_speed_max.Cursor = System.Windows.Forms.Cursors.Default;
            this.wind_speed_max.DecimalPlaces = 1;
            this.wind_speed_max.Location = new System.Drawing.Point(110, 42);
            this.wind_speed_max.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.wind_speed_max.Name = "wind_speed_max";
            this.wind_speed_max.Size = new System.Drawing.Size(56, 19);
            this.wind_speed_max.TabIndex = 10;
            this.wind_speed_max.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            // 
            // wind_speed_min
            // 
            this.wind_speed_min.Cursor = System.Windows.Forms.Cursors.Default;
            this.wind_speed_min.DecimalPlaces = 1;
            this.wind_speed_min.Location = new System.Drawing.Point(110, 19);
            this.wind_speed_min.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.wind_speed_min.Name = "wind_speed_min";
            this.wind_speed_min.Size = new System.Drawing.Size(56, 19);
            this.wind_speed_min.TabIndex = 5;
            // 
            // wind_dir_interval_deg
            // 
            this.wind_dir_interval_deg.AutoSize = true;
            this.wind_dir_interval_deg.Location = new System.Drawing.Point(172, 67);
            this.wind_dir_interval_deg.Name = "wind_dir_interval_deg";
            this.wind_dir_interval_deg.Size = new System.Drawing.Size(23, 12);
            this.wind_dir_interval_deg.TabIndex = 9;
            this.wind_dir_interval_deg.Text = "deg";
            // 
            // wind_dir_interval_label
            // 
            this.wind_dir_interval_label.AutoSize = true;
            this.wind_dir_interval_label.Location = new System.Drawing.Point(7, 67);
            this.wind_dir_interval_label.Name = "wind_dir_interval_label";
            this.wind_dir_interval_label.Size = new System.Drawing.Size(53, 12);
            this.wind_dir_interval_label.TabIndex = 7;
            this.wind_dir_interval_label.Text = "風向間隔";
            // 
            // wind_speed_max_ms
            // 
            this.wind_speed_max_ms.AutoSize = true;
            this.wind_speed_max_ms.Location = new System.Drawing.Point(172, 44);
            this.wind_speed_max_ms.Name = "wind_speed_max_ms";
            this.wind_speed_max_ms.Size = new System.Drawing.Size(26, 12);
            this.wind_speed_max_ms.TabIndex = 6;
            this.wind_speed_max_ms.Text = "m/s";
            // 
            // wind_speed_min_ms
            // 
            this.wind_speed_min_ms.AutoSize = true;
            this.wind_speed_min_ms.Location = new System.Drawing.Point(172, 21);
            this.wind_speed_min_ms.Name = "wind_speed_min_ms";
            this.wind_speed_min_ms.Size = new System.Drawing.Size(26, 12);
            this.wind_speed_min_ms.TabIndex = 4;
            this.wind_speed_min_ms.Text = "m/s";
            // 
            // wind_speed_max_label
            // 
            this.wind_speed_max_label.AutoSize = true;
            this.wind_speed_max_label.Location = new System.Drawing.Point(7, 44);
            this.wind_speed_max_label.Name = "wind_speed_max_label";
            this.wind_speed_max_label.Size = new System.Drawing.Size(53, 12);
            this.wind_speed_max_label.TabIndex = 1;
            this.wind_speed_max_label.Text = "最大風速";
            // 
            // wind_speed_min_label
            // 
            this.wind_speed_min_label.AutoSize = true;
            this.wind_speed_min_label.Location = new System.Drawing.Point(7, 19);
            this.wind_speed_min_label.Name = "wind_speed_min_label";
            this.wind_speed_min_label.Size = new System.Drawing.Size(53, 12);
            this.wind_speed_min_label.TabIndex = 0;
            this.wind_speed_min_label.Text = "最小風速";
            // 
            // detect_peak_threshold_m
            // 
            this.detect_peak_threshold_m.AutoSize = true;
            this.detect_peak_threshold_m.Location = new System.Drawing.Point(200, 19);
            this.detect_peak_threshold_m.Name = "detect_peak_threshold_m";
            this.detect_peak_threshold_m.Size = new System.Drawing.Size(14, 12);
            this.detect_peak_threshold_m.TabIndex = 2;
            this.detect_peak_threshold_m.Text = "m";
            // 
            // detect_peak_threshold_label
            // 
            this.detect_peak_threshold_label.AutoSize = true;
            this.detect_peak_threshold_label.Location = new System.Drawing.Point(7, 19);
            this.detect_peak_threshold_label.Name = "detect_peak_threshold_label";
            this.detect_peak_threshold_label.Size = new System.Drawing.Size(125, 12);
            this.detect_peak_threshold_label.TabIndex = 0;
            this.detect_peak_threshold_label.Text = "頂点検知開傘落下距離";
            // 
            // processing
            // 
            this.processing.Controls.Add(this.multi_thread);
            this.processing.Dock = System.Windows.Forms.DockStyle.Top;
            this.processing.Location = new System.Drawing.Point(20, 32);
            this.processing.Name = "processing";
            this.processing.Size = new System.Drawing.Size(736, 46);
            this.processing.TabIndex = 1;
            this.processing.TabStop = false;
            this.processing.Text = "処理";
            // 
            // multi_thread
            // 
            this.multi_thread.AutoSize = true;
            this.multi_thread.Location = new System.Drawing.Point(6, 18);
            this.multi_thread.Name = "multi_thread";
            this.multi_thread.Size = new System.Drawing.Size(86, 16);
            this.multi_thread.TabIndex = 0;
            this.multi_thread.Text = "マルチスレッド";
            this.multi_thread.UseVisualStyleBackColor = true;
            // 
            // rocket
            // 
            this.rocket.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.rocket.Controls.Add(this.spec_write);
            this.rocket.Controls.Add(this.environment);
            this.rocket.Controls.Add(this.parameter);
            this.rocket.Controls.Add(this.info);
            this.rocket.Location = new System.Drawing.Point(12, 415);
            this.rocket.Name = "rocket";
            this.rocket.Padding = new System.Windows.Forms.Padding(20);
            this.rocket.Size = new System.Drawing.Size(776, 940);
            this.rocket.TabIndex = 1;
            this.rocket.TabStop = false;
            this.rocket.Text = "機体諸元";
            // 
            // spec_write
            // 
            this.spec_write.Location = new System.Drawing.Point(678, 904);
            this.spec_write.Name = "spec_write";
            this.spec_write.Size = new System.Drawing.Size(75, 23);
            this.spec_write.TabIndex = 3;
            this.spec_write.Text = "保存/上書き";
            this.spec_write.UseVisualStyleBackColor = true;
            this.spec_write.Click += new System.EventHandler(this.spec_write_Click);
            // 
            // environment
            // 
            this.environment.Controls.Add(this.rail_elev_deg);
            this.environment.Controls.Add(this.rail_len_m);
            this.environment.Controls.Add(this.rail_azi_deg);
            this.environment.Controls.Add(this.rail_elev);
            this.environment.Controls.Add(this.rail_azi);
            this.environment.Controls.Add(this.rail_len);
            this.environment.Controls.Add(this.place);
            this.environment.Controls.Add(this.rail_elev_label);
            this.environment.Controls.Add(this.rail_azi_label);
            this.environment.Controls.Add(this.rail_len_label);
            this.environment.Controls.Add(this.place_label);
            this.environment.Dock = System.Windows.Forms.DockStyle.Top;
            this.environment.Location = new System.Drawing.Point(20, 773);
            this.environment.Name = "environment";
            this.environment.Size = new System.Drawing.Size(736, 124);
            this.environment.TabIndex = 2;
            this.environment.TabStop = false;
            this.environment.Text = "射点情報";
            // 
            // rail_elev_deg
            // 
            this.rail_elev_deg.AutoSize = true;
            this.rail_elev_deg.Location = new System.Drawing.Point(154, 95);
            this.rail_elev_deg.Name = "rail_elev_deg";
            this.rail_elev_deg.Size = new System.Drawing.Size(23, 12);
            this.rail_elev_deg.TabIndex = 58;
            this.rail_elev_deg.Text = "deg";
            // 
            // rail_len_m
            // 
            this.rail_len_m.AutoSize = true;
            this.rail_len_m.Location = new System.Drawing.Point(155, 45);
            this.rail_len_m.Name = "rail_len_m";
            this.rail_len_m.Size = new System.Drawing.Size(14, 12);
            this.rail_len_m.TabIndex = 51;
            this.rail_len_m.Text = "m";
            // 
            // rail_azi_deg
            // 
            this.rail_azi_deg.AutoSize = true;
            this.rail_azi_deg.Location = new System.Drawing.Point(155, 70);
            this.rail_azi_deg.Name = "rail_azi_deg";
            this.rail_azi_deg.Size = new System.Drawing.Size(23, 12);
            this.rail_azi_deg.TabIndex = 57;
            this.rail_azi_deg.Text = "deg";
            // 
            // rail_elev
            // 
            this.rail_elev.Cursor = System.Windows.Forms.Cursors.Default;
            this.rail_elev.Location = new System.Drawing.Point(93, 93);
            this.rail_elev.Maximum = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.rail_elev.Name = "rail_elev";
            this.rail_elev.Size = new System.Drawing.Size(56, 19);
            this.rail_elev.TabIndex = 56;
            // 
            // rail_azi
            // 
            this.rail_azi.Cursor = System.Windows.Forms.Cursors.Default;
            this.rail_azi.Location = new System.Drawing.Point(93, 68);
            this.rail_azi.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.rail_azi.Minimum = new decimal(new int[] {
            360,
            0,
            0,
            -2147483648});
            this.rail_azi.Name = "rail_azi";
            this.rail_azi.Size = new System.Drawing.Size(56, 19);
            this.rail_azi.TabIndex = 55;
            // 
            // rail_len
            // 
            this.rail_len.Cursor = System.Windows.Forms.Cursors.Default;
            this.rail_len.DecimalPlaces = 1;
            this.rail_len.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.rail_len.Location = new System.Drawing.Point(93, 43);
            this.rail_len.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.rail_len.Name = "rail_len";
            this.rail_len.Size = new System.Drawing.Size(56, 19);
            this.rail_len.TabIndex = 51;
            this.rail_len.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // place
            // 
            this.place.FormattingEnabled = true;
            this.place.Location = new System.Drawing.Point(44, 17);
            this.place.Name = "place";
            this.place.Size = new System.Drawing.Size(121, 20);
            this.place.TabIndex = 51;
            // 
            // rail_elev_label
            // 
            this.rail_elev_label.AutoSize = true;
            this.rail_elev_label.Location = new System.Drawing.Point(7, 95);
            this.rail_elev_label.Name = "rail_elev_label";
            this.rail_elev_label.Size = new System.Drawing.Size(63, 12);
            this.rail_elev_label.TabIndex = 54;
            this.rail_elev_label.Text = "ランチャ迎角";
            // 
            // rail_azi_label
            // 
            this.rail_azi_label.AutoSize = true;
            this.rail_azi_label.Location = new System.Drawing.Point(8, 70);
            this.rail_azi_label.Name = "rail_azi_label";
            this.rail_azi_label.Size = new System.Drawing.Size(75, 12);
            this.rail_azi_label.TabIndex = 53;
            this.rail_azi_label.Text = "ランチャ方位角";
            // 
            // rail_len_label
            // 
            this.rail_len_label.AutoSize = true;
            this.rail_len_label.Location = new System.Drawing.Point(8, 45);
            this.rail_len_label.Name = "rail_len_label";
            this.rail_len_label.Size = new System.Drawing.Size(80, 12);
            this.rail_len_label.TabIndex = 52;
            this.rail_len_label.Text = "ランチャレール長";
            // 
            // place_label
            // 
            this.place_label.AutoSize = true;
            this.place_label.Location = new System.Drawing.Point(8, 20);
            this.place_label.Name = "place_label";
            this.place_label.Size = new System.Drawing.Size(30, 12);
            this.place_label.TabIndex = 51;
            this.place_label.Text = "マップ";
            // 
            // parameter
            // 
            this.parameter.Controls.Add(this.motor_file_select);
            this.parameter.Controls.Add(this.airspeed_param_file_select);
            this.parameter.Controls.Add(this.Cna);
            this.parameter.Controls.Add(this.Cd_alpha2_rad2);
            this.parameter.Controls.Add(this.Cp_alpha_mrad);
            this.parameter.Controls.Add(this.CPlen_m);
            this.parameter.Controls.Add(this.delay_time_1st_s);
            this.parameter.Controls.Add(this.op_time_1st_s);
            this.parameter.Controls.Add(this.vel_1st_ms);
            this.parameter.Controls.Add(this.Iyz_f_kgm2);
            this.parameter.Controls.Add(this.Iyz_i_kgm2);
            this.parameter.Controls.Add(this.Cd_alpha2);
            this.parameter.Controls.Add(this.Cd);
            this.parameter.Controls.Add(this.Cp_alpha);
            this.parameter.Controls.Add(this.CPlen);
            this.parameter.Controls.Add(this.delay_time_1st);
            this.parameter.Controls.Add(this.op_time_1st);
            this.parameter.Controls.Add(this.op_type_1st);
            this.parameter.Controls.Add(this.vel_1st);
            this.parameter.Controls.Add(this.Cmq);
            this.parameter.Controls.Add(this.Iyz_f);
            this.parameter.Controls.Add(this.Iyz_i);
            this.parameter.Controls.Add(this.mass_f_kg);
            this.parameter.Controls.Add(this.mass_i_kg);
            this.parameter.Controls.Add(this.CGlen_f_m);
            this.parameter.Controls.Add(this.CGlen_i_m);
            this.parameter.Controls.Add(this.mass_f);
            this.parameter.Controls.Add(this.mass_i);
            this.parameter.Controls.Add(this.CGlen_f);
            this.parameter.Controls.Add(this.CGlen_i);
            this.parameter.Controls.Add(this.diam_m);
            this.parameter.Controls.Add(this.diam);
            this.parameter.Controls.Add(this.ref_len_m);
            this.parameter.Controls.Add(this.ref_len);
            this.parameter.Controls.Add(this.Cna_label);
            this.parameter.Controls.Add(this.Cp_alpha_label);
            this.parameter.Controls.Add(this.CPlen_label);
            this.parameter.Controls.Add(this.Cd_label);
            this.parameter.Controls.Add(this.airspeed_param_file_label);
            this.parameter.Controls.Add(this.Cd_alpha2_label);
            this.parameter.Controls.Add(this.motor_file_label);
            this.parameter.Controls.Add(this.op_type_1st_label);
            this.parameter.Controls.Add(this.delay_time_1st_label);
            this.parameter.Controls.Add(this.op_time_1st_label);
            this.parameter.Controls.Add(this.vel_1st_label);
            this.parameter.Controls.Add(this.Cmq_label);
            this.parameter.Controls.Add(this.Iyz_f_label);
            this.parameter.Controls.Add(this.Iyz_i_label);
            this.parameter.Controls.Add(this.mass_f_label);
            this.parameter.Controls.Add(this.mass_i_label);
            this.parameter.Controls.Add(this.CGlen_f_label);
            this.parameter.Controls.Add(this.CGlen_i_label);
            this.parameter.Controls.Add(this.diam_label);
            this.parameter.Controls.Add(this.ref_len_label);
            this.parameter.Dock = System.Windows.Forms.DockStyle.Top;
            this.parameter.Location = new System.Drawing.Point(20, 173);
            this.parameter.Name = "parameter";
            this.parameter.Size = new System.Drawing.Size(736, 600);
            this.parameter.TabIndex = 1;
            this.parameter.TabStop = false;
            this.parameter.Text = "パラメーター";
            // 
            // Cna
            // 
            this.Cna.Cursor = System.Windows.Forms.Cursors.Default;
            this.Cna.DecimalPlaces = 3;
            this.Cna.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.Cna.Location = new System.Drawing.Point(93, 543);
            this.Cna.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.Cna.Name = "Cna";
            this.Cna.Size = new System.Drawing.Size(56, 19);
            this.Cna.TabIndex = 51;
            this.Cna.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Cd_alpha2_rad2
            // 
            this.Cd_alpha2_rad2.AutoSize = true;
            this.Cd_alpha2_rad2.Location = new System.Drawing.Point(154, 517);
            this.Cd_alpha2_rad2.Name = "Cd_alpha2_rad2";
            this.Cd_alpha2_rad2.Size = new System.Drawing.Size(30, 12);
            this.Cd_alpha2_rad2.TabIndex = 50;
            this.Cd_alpha2_rad2.Text = "/rad²";
            // 
            // Cp_alpha_mrad
            // 
            this.Cp_alpha_mrad.AutoSize = true;
            this.Cp_alpha_mrad.Location = new System.Drawing.Point(152, 460);
            this.Cp_alpha_mrad.Name = "Cp_alpha_mrad";
            this.Cp_alpha_mrad.Size = new System.Drawing.Size(36, 12);
            this.Cp_alpha_mrad.TabIndex = 49;
            this.Cp_alpha_mrad.Text = "m/rad";
            // 
            // CPlen_m
            // 
            this.CPlen_m.AutoSize = true;
            this.CPlen_m.Location = new System.Drawing.Point(152, 435);
            this.CPlen_m.Name = "CPlen_m";
            this.CPlen_m.Size = new System.Drawing.Size(14, 12);
            this.CPlen_m.TabIndex = 48;
            this.CPlen_m.Text = "m";
            // 
            // delay_time_1st_s
            // 
            this.delay_time_1st_s.AutoSize = true;
            this.delay_time_1st_s.Location = new System.Drawing.Point(208, 367);
            this.delay_time_1st_s.Name = "delay_time_1st_s";
            this.delay_time_1st_s.Size = new System.Drawing.Size(17, 12);
            this.delay_time_1st_s.TabIndex = 47;
            this.delay_time_1st_s.Text = "秒";
            // 
            // op_time_1st_s
            // 
            this.op_time_1st_s.AutoSize = true;
            this.op_time_1st_s.Location = new System.Drawing.Point(208, 342);
            this.op_time_1st_s.Name = "op_time_1st_s";
            this.op_time_1st_s.Size = new System.Drawing.Size(17, 12);
            this.op_time_1st_s.TabIndex = 46;
            this.op_time_1st_s.Text = "秒";
            // 
            // vel_1st_ms
            // 
            this.vel_1st_ms.AutoSize = true;
            this.vel_1st_ms.Location = new System.Drawing.Point(184, 291);
            this.vel_1st_ms.Name = "vel_1st_ms";
            this.vel_1st_ms.Size = new System.Drawing.Size(26, 12);
            this.vel_1st_ms.TabIndex = 45;
            this.vel_1st_ms.Text = "m/s";
            // 
            // Iyz_f_kgm2
            // 
            this.Iyz_f_kgm2.AutoSize = true;
            this.Iyz_f_kgm2.Location = new System.Drawing.Point(200, 225);
            this.Iyz_f_kgm2.Name = "Iyz_f_kgm2";
            this.Iyz_f_kgm2.Size = new System.Drawing.Size(35, 12);
            this.Iyz_f_kgm2.TabIndex = 44;
            this.Iyz_f_kgm2.Text = "kg・㎡";
            // 
            // Iyz_i_kgm2
            // 
            this.Iyz_i_kgm2.AutoSize = true;
            this.Iyz_i_kgm2.Location = new System.Drawing.Point(200, 200);
            this.Iyz_i_kgm2.Name = "Iyz_i_kgm2";
            this.Iyz_i_kgm2.Size = new System.Drawing.Size(35, 12);
            this.Iyz_i_kgm2.TabIndex = 43;
            this.Iyz_i_kgm2.Text = "kg・㎡";
            // 
            // Cd_alpha2
            // 
            this.Cd_alpha2.Cursor = System.Windows.Forms.Cursors.Default;
            this.Cd_alpha2.DecimalPlaces = 3;
            this.Cd_alpha2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.Cd_alpha2.Location = new System.Drawing.Point(92, 515);
            this.Cd_alpha2.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.Cd_alpha2.Name = "Cd_alpha2";
            this.Cd_alpha2.Size = new System.Drawing.Size(56, 19);
            this.Cd_alpha2.TabIndex = 41;
            this.Cd_alpha2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Cd
            // 
            this.Cd.Cursor = System.Windows.Forms.Cursors.Default;
            this.Cd.DecimalPlaces = 3;
            this.Cd.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.Cd.Location = new System.Drawing.Point(92, 490);
            this.Cd.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Cd.Name = "Cd";
            this.Cd.Size = new System.Drawing.Size(56, 19);
            this.Cd.TabIndex = 40;
            this.Cd.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Cp_alpha
            // 
            this.Cp_alpha.Cursor = System.Windows.Forms.Cursors.Default;
            this.Cp_alpha.DecimalPlaces = 3;
            this.Cp_alpha.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.Cp_alpha.Location = new System.Drawing.Point(90, 458);
            this.Cp_alpha.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.Cp_alpha.Name = "Cp_alpha";
            this.Cp_alpha.Size = new System.Drawing.Size(56, 19);
            this.Cp_alpha.TabIndex = 39;
            this.Cp_alpha.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // CPlen
            // 
            this.CPlen.Cursor = System.Windows.Forms.Cursors.Default;
            this.CPlen.DecimalPlaces = 3;
            this.CPlen.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.CPlen.Location = new System.Drawing.Point(90, 433);
            this.CPlen.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.CPlen.Name = "CPlen";
            this.CPlen.Size = new System.Drawing.Size(56, 19);
            this.CPlen.TabIndex = 38;
            this.CPlen.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // delay_time_1st
            // 
            this.delay_time_1st.Cursor = System.Windows.Forms.Cursors.Default;
            this.delay_time_1st.DecimalPlaces = 3;
            this.delay_time_1st.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.delay_time_1st.Location = new System.Drawing.Point(146, 365);
            this.delay_time_1st.Name = "delay_time_1st";
            this.delay_time_1st.Size = new System.Drawing.Size(56, 19);
            this.delay_time_1st.TabIndex = 37;
            this.delay_time_1st.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // op_time_1st
            // 
            this.op_time_1st.Cursor = System.Windows.Forms.Cursors.Default;
            this.op_time_1st.DecimalPlaces = 3;
            this.op_time_1st.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.op_time_1st.Location = new System.Drawing.Point(146, 340);
            this.op_time_1st.Name = "op_time_1st";
            this.op_time_1st.Size = new System.Drawing.Size(56, 19);
            this.op_time_1st.TabIndex = 36;
            this.op_time_1st.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // op_type_1st
            // 
            this.op_type_1st.FormattingEnabled = true;
            this.op_type_1st.Location = new System.Drawing.Point(122, 314);
            this.op_type_1st.Name = "op_type_1st";
            this.op_type_1st.Size = new System.Drawing.Size(121, 20);
            this.op_type_1st.TabIndex = 35;
            this.op_type_1st.SelectedIndexChanged += new System.EventHandler(this.op_type_1st_SelectedIndexChanged);
            // 
            // vel_1st
            // 
            this.vel_1st.Cursor = System.Windows.Forms.Cursors.Default;
            this.vel_1st.DecimalPlaces = 3;
            this.vel_1st.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.vel_1st.Location = new System.Drawing.Point(122, 289);
            this.vel_1st.Name = "vel_1st";
            this.vel_1st.Size = new System.Drawing.Size(56, 19);
            this.vel_1st.TabIndex = 34;
            this.vel_1st.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Cmq
            // 
            this.Cmq.Cursor = System.Windows.Forms.Cursors.Default;
            this.Cmq.DecimalPlaces = 3;
            this.Cmq.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.Cmq.Location = new System.Drawing.Point(135, 248);
            this.Cmq.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.Cmq.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.Cmq.Name = "Cmq";
            this.Cmq.Size = new System.Drawing.Size(56, 19);
            this.Cmq.TabIndex = 33;
            // 
            // Iyz_f
            // 
            this.Iyz_f.Cursor = System.Windows.Forms.Cursors.Default;
            this.Iyz_f.DecimalPlaces = 3;
            this.Iyz_f.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.Iyz_f.Location = new System.Drawing.Point(135, 223);
            this.Iyz_f.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.Iyz_f.Name = "Iyz_f";
            this.Iyz_f.Size = new System.Drawing.Size(56, 19);
            this.Iyz_f.TabIndex = 32;
            this.Iyz_f.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Iyz_i
            // 
            this.Iyz_i.Cursor = System.Windows.Forms.Cursors.Default;
            this.Iyz_i.DecimalPlaces = 3;
            this.Iyz_i.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.Iyz_i.Location = new System.Drawing.Point(135, 198);
            this.Iyz_i.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.Iyz_i.Name = "Iyz_i";
            this.Iyz_i.Size = new System.Drawing.Size(56, 19);
            this.Iyz_i.TabIndex = 31;
            this.Iyz_i.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // mass_f_kg
            // 
            this.mass_f_kg.AutoSize = true;
            this.mass_f_kg.Location = new System.Drawing.Point(196, 167);
            this.mass_f_kg.Name = "mass_f_kg";
            this.mass_f_kg.Size = new System.Drawing.Size(17, 12);
            this.mass_f_kg.TabIndex = 30;
            this.mass_f_kg.Text = "kg";
            // 
            // mass_i_kg
            // 
            this.mass_i_kg.AutoSize = true;
            this.mass_i_kg.Location = new System.Drawing.Point(196, 140);
            this.mass_i_kg.Name = "mass_i_kg";
            this.mass_i_kg.Size = new System.Drawing.Size(17, 12);
            this.mass_i_kg.TabIndex = 29;
            this.mass_i_kg.Text = "kg";
            // 
            // CGlen_f_m
            // 
            this.CGlen_f_m.AutoSize = true;
            this.CGlen_f_m.Location = new System.Drawing.Point(154, 105);
            this.CGlen_f_m.Name = "CGlen_f_m";
            this.CGlen_f_m.Size = new System.Drawing.Size(14, 12);
            this.CGlen_f_m.TabIndex = 28;
            this.CGlen_f_m.Text = "m";
            // 
            // CGlen_i_m
            // 
            this.CGlen_i_m.AutoSize = true;
            this.CGlen_i_m.Location = new System.Drawing.Point(154, 80);
            this.CGlen_i_m.Name = "CGlen_i_m";
            this.CGlen_i_m.Size = new System.Drawing.Size(14, 12);
            this.CGlen_i_m.TabIndex = 27;
            this.CGlen_i_m.Text = "m";
            // 
            // mass_f
            // 
            this.mass_f.Cursor = System.Windows.Forms.Cursors.Default;
            this.mass_f.DecimalPlaces = 3;
            this.mass_f.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.mass_f.Location = new System.Drawing.Point(134, 163);
            this.mass_f.Name = "mass_f";
            this.mass_f.Size = new System.Drawing.Size(56, 19);
            this.mass_f.TabIndex = 26;
            this.mass_f.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // mass_i
            // 
            this.mass_i.Cursor = System.Windows.Forms.Cursors.Default;
            this.mass_i.DecimalPlaces = 3;
            this.mass_i.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.mass_i.Location = new System.Drawing.Point(134, 138);
            this.mass_i.Name = "mass_i";
            this.mass_i.Size = new System.Drawing.Size(56, 19);
            this.mass_i.TabIndex = 25;
            this.mass_i.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // CGlen_f
            // 
            this.CGlen_f.Cursor = System.Windows.Forms.Cursors.Default;
            this.CGlen_f.DecimalPlaces = 2;
            this.CGlen_f.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.CGlen_f.Location = new System.Drawing.Point(92, 103);
            this.CGlen_f.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.CGlen_f.Name = "CGlen_f";
            this.CGlen_f.Size = new System.Drawing.Size(56, 19);
            this.CGlen_f.TabIndex = 24;
            this.CGlen_f.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // CGlen_i
            // 
            this.CGlen_i.Cursor = System.Windows.Forms.Cursors.Default;
            this.CGlen_i.DecimalPlaces = 2;
            this.CGlen_i.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.CGlen_i.Location = new System.Drawing.Point(92, 78);
            this.CGlen_i.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.CGlen_i.Name = "CGlen_i";
            this.CGlen_i.Size = new System.Drawing.Size(56, 19);
            this.CGlen_i.TabIndex = 23;
            this.CGlen_i.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // diam_m
            // 
            this.diam_m.AutoSize = true;
            this.diam_m.Location = new System.Drawing.Point(130, 44);
            this.diam_m.Name = "diam_m";
            this.diam_m.Size = new System.Drawing.Size(14, 12);
            this.diam_m.TabIndex = 22;
            this.diam_m.Text = "m";
            // 
            // diam
            // 
            this.diam.Cursor = System.Windows.Forms.Cursors.Default;
            this.diam.DecimalPlaces = 2;
            this.diam.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.diam.Location = new System.Drawing.Point(68, 42);
            this.diam.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.diam.Name = "diam";
            this.diam.Size = new System.Drawing.Size(56, 19);
            this.diam.TabIndex = 21;
            this.diam.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ref_len_m
            // 
            this.ref_len_m.AutoSize = true;
            this.ref_len_m.Location = new System.Drawing.Point(130, 19);
            this.ref_len_m.Name = "ref_len_m";
            this.ref_len_m.Size = new System.Drawing.Size(14, 12);
            this.ref_len_m.TabIndex = 12;
            this.ref_len_m.Text = "m";
            // 
            // ref_len
            // 
            this.ref_len.Cursor = System.Windows.Forms.Cursors.Default;
            this.ref_len.DecimalPlaces = 2;
            this.ref_len.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.ref_len.Location = new System.Drawing.Point(68, 17);
            this.ref_len.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ref_len.Name = "ref_len";
            this.ref_len.Size = new System.Drawing.Size(56, 19);
            this.ref_len.TabIndex = 20;
            this.ref_len.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Cna_label
            // 
            this.Cna_label.AutoSize = true;
            this.Cna_label.Location = new System.Drawing.Point(10, 545);
            this.Cna_label.Name = "Cna_label";
            this.Cna_label.Size = new System.Drawing.Size(65, 12);
            this.Cna_label.TabIndex = 19;
            this.Cna_label.Text = "法線力係数";
            // 
            // Cp_alpha_label
            // 
            this.Cp_alpha_label.AutoSize = true;
            this.Cp_alpha_label.Location = new System.Drawing.Point(10, 460);
            this.Cp_alpha_label.Name = "Cp_alpha_label";
            this.Cp_alpha_label.Size = new System.Drawing.Size(77, 12);
            this.Cp_alpha_label.TabIndex = 18;
            this.Cp_alpha_label.Text = "圧力中心傾斜";
            // 
            // CPlen_label
            // 
            this.CPlen_label.AutoSize = true;
            this.CPlen_label.Location = new System.Drawing.Point(10, 435);
            this.CPlen_label.Name = "CPlen_label";
            this.CPlen_label.Size = new System.Drawing.Size(77, 12);
            this.CPlen_label.TabIndex = 17;
            this.CPlen_label.Text = "圧力中心位置";
            // 
            // Cd_label
            // 
            this.Cd_label.AutoSize = true;
            this.Cd_label.Location = new System.Drawing.Point(9, 492);
            this.Cd_label.Name = "Cd_label";
            this.Cd_label.Size = new System.Drawing.Size(53, 12);
            this.Cd_label.TabIndex = 16;
            this.Cd_label.Text = "抗力係数";
            // 
            // airspeed_param_file_label
            // 
            this.airspeed_param_file_label.AutoSize = true;
            this.airspeed_param_file_label.Location = new System.Drawing.Point(10, 577);
            this.airspeed_param_file_label.Name = "airspeed_param_file_label";
            this.airspeed_param_file_label.Size = new System.Drawing.Size(117, 12);
            this.airspeed_param_file_label.TabIndex = 15;
            this.airspeed_param_file_label.Text = "空力パラメーターファイル";
            // 
            // Cd_alpha2_label
            // 
            this.Cd_alpha2_label.AutoSize = true;
            this.Cd_alpha2_label.Location = new System.Drawing.Point(9, 517);
            this.Cd_alpha2_label.Name = "Cd_alpha2_label";
            this.Cd_alpha2_label.Size = new System.Drawing.Size(77, 12);
            this.Cd_alpha2_label.TabIndex = 14;
            this.Cd_alpha2_label.Text = "抗力係数傾斜";
            // 
            // motor_file_label
            // 
            this.motor_file_label.AutoSize = true;
            this.motor_file_label.Location = new System.Drawing.Point(10, 400);
            this.motor_file_label.Name = "motor_file_label";
            this.motor_file_label.Size = new System.Drawing.Size(101, 12);
            this.motor_file_label.TabIndex = 13;
            this.motor_file_label.Text = "スラストデータファイル";
            // 
            // op_type_1st_label
            // 
            this.op_type_1st_label.AutoSize = true;
            this.op_type_1st_label.Location = new System.Drawing.Point(9, 317);
            this.op_type_1st_label.Name = "op_type_1st_label";
            this.op_type_1st_label.Size = new System.Drawing.Size(107, 12);
            this.op_type_1st_label.TabIndex = 12;
            this.op_type_1st_label.Text = "パラシュート開傘方式";
            // 
            // delay_time_1st_label
            // 
            this.delay_time_1st_label.AutoSize = true;
            this.delay_time_1st_label.Location = new System.Drawing.Point(9, 367);
            this.delay_time_1st_label.Name = "delay_time_1st_label";
            this.delay_time_1st_label.Size = new System.Drawing.Size(131, 12);
            this.delay_time_1st_label.TabIndex = 11;
            this.delay_time_1st_label.Text = "パラシュート開傘所要時間";
            // 
            // op_time_1st_label
            // 
            this.op_time_1st_label.AutoSize = true;
            this.op_time_1st_label.Location = new System.Drawing.Point(9, 342);
            this.op_time_1st_label.Name = "op_time_1st_label";
            this.op_time_1st_label.Size = new System.Drawing.Size(107, 12);
            this.op_time_1st_label.TabIndex = 10;
            this.op_time_1st_label.Text = "パラシュート開傘時間";
            // 
            // vel_1st_label
            // 
            this.vel_1st_label.AutoSize = true;
            this.vel_1st_label.Location = new System.Drawing.Point(9, 291);
            this.vel_1st_label.Name = "vel_1st_label";
            this.vel_1st_label.Size = new System.Drawing.Size(107, 12);
            this.vel_1st_label.TabIndex = 9;
            this.vel_1st_label.Text = "パラシュート終端速度";
            // 
            // Cmq_label
            // 
            this.Cmq_label.AutoSize = true;
            this.Cmq_label.Location = new System.Drawing.Point(10, 250);
            this.Cmq_label.Name = "Cmq_label";
            this.Cmq_label.Size = new System.Drawing.Size(122, 12);
            this.Cmq_label.TabIndex = 8;
            this.Cmq_label.Text = "ピッチ減衰モーメント係数";
            // 
            // Iyz_f_label
            // 
            this.Iyz_f_label.AutoSize = true;
            this.Iyz_f_label.Location = new System.Drawing.Point(10, 225);
            this.Iyz_f_label.Name = "Iyz_f_label";
            this.Iyz_f_label.Size = new System.Drawing.Size(102, 12);
            this.Iyz_f_label.TabIndex = 7;
            this.Iyz_f_label.Text = "最終ロールモーメント";
            // 
            // Iyz_i_label
            // 
            this.Iyz_i_label.AutoSize = true;
            this.Iyz_i_label.Location = new System.Drawing.Point(9, 200);
            this.Iyz_i_label.Name = "Iyz_i_label";
            this.Iyz_i_label.Size = new System.Drawing.Size(102, 12);
            this.Iyz_i_label.TabIndex = 6;
            this.Iyz_i_label.Text = "初期ロールモーメント";
            // 
            // mass_f_label
            // 
            this.mass_f_label.AutoSize = true;
            this.mass_f_label.Location = new System.Drawing.Point(9, 167);
            this.mass_f_label.Name = "mass_f_label";
            this.mass_f_label.Size = new System.Drawing.Size(53, 12);
            this.mass_f_label.TabIndex = 5;
            this.mass_f_label.Text = "乾燥質量";
            // 
            // mass_i_label
            // 
            this.mass_i_label.AutoSize = true;
            this.mass_i_label.Location = new System.Drawing.Point(9, 142);
            this.mass_i_label.Name = "mass_i_label";
            this.mass_i_label.Size = new System.Drawing.Size(119, 12);
            this.mass_i_label.TabIndex = 4;
            this.mass_i_label.Text = "乾燥質量+酸化剤質量";
            // 
            // CGlen_f_label
            // 
            this.CGlen_f_label.AutoSize = true;
            this.CGlen_f_label.Location = new System.Drawing.Point(9, 105);
            this.CGlen_f_label.Name = "CGlen_f_label";
            this.CGlen_f_label.Size = new System.Drawing.Size(77, 12);
            this.CGlen_f_label.TabIndex = 3;
            this.CGlen_f_label.Text = "最終重心位置";
            // 
            // CGlen_i_label
            // 
            this.CGlen_i_label.AutoSize = true;
            this.CGlen_i_label.Location = new System.Drawing.Point(9, 80);
            this.CGlen_i_label.Name = "CGlen_i_label";
            this.CGlen_i_label.Size = new System.Drawing.Size(77, 12);
            this.CGlen_i_label.TabIndex = 2;
            this.CGlen_i_label.Text = "初期重心位置";
            // 
            // diam_label
            // 
            this.diam_label.AutoSize = true;
            this.diam_label.Location = new System.Drawing.Point(9, 44);
            this.diam_label.Name = "diam_label";
            this.diam_label.Size = new System.Drawing.Size(53, 12);
            this.diam_label.TabIndex = 1;
            this.diam_label.Text = "機体直径";
            // 
            // ref_len_label
            // 
            this.ref_len_label.AutoSize = true;
            this.ref_len_label.Location = new System.Drawing.Point(9, 19);
            this.ref_len_label.Name = "ref_len_label";
            this.ref_len_label.Size = new System.Drawing.Size(53, 12);
            this.ref_len_label.TabIndex = 0;
            this.ref_len_label.Text = "機体全長";
            // 
            // info
            // 
            this.info.Controls.Add(this.version);
            this.info.Controls.Add(this.experiment_date_date_label);
            this.info.Controls.Add(this.experiment_date_date);
            this.info.Controls.Add(this.experiment_date_month_label);
            this.info.Controls.Add(this.experiment_date_month);
            this.info.Controls.Add(this.experiment_date_year_label);
            this.info.Controls.Add(this.experiment_date_year);
            this.info.Controls.Add(this.rocket_name);
            this.info.Controls.Add(this.team_name);
            this.info.Controls.Add(this.version_label);
            this.info.Controls.Add(this.experiment_date_label);
            this.info.Controls.Add(this.rocket_name_label);
            this.info.Controls.Add(this.team_name_label);
            this.info.Dock = System.Windows.Forms.DockStyle.Top;
            this.info.Location = new System.Drawing.Point(20, 32);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(736, 141);
            this.info.TabIndex = 0;
            this.info.TabStop = false;
            this.info.Text = "情報";
            // 
            // version
            // 
            this.version.Location = new System.Drawing.Point(59, 96);
            this.version.Name = "version";
            this.version.Size = new System.Drawing.Size(225, 19);
            this.version.TabIndex = 12;
            // 
            // experiment_date_date_label
            // 
            this.experiment_date_date_label.AutoSize = true;
            this.experiment_date_date_label.Location = new System.Drawing.Point(267, 73);
            this.experiment_date_date_label.Name = "experiment_date_date_label";
            this.experiment_date_date_label.Size = new System.Drawing.Size(17, 12);
            this.experiment_date_date_label.TabIndex = 11;
            this.experiment_date_date_label.Text = "日";
            // 
            // experiment_date_date
            // 
            this.experiment_date_date.Location = new System.Drawing.Point(223, 66);
            this.experiment_date_date.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.experiment_date_date.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.experiment_date_date.Name = "experiment_date_date";
            this.experiment_date_date.Size = new System.Drawing.Size(38, 19);
            this.experiment_date_date.TabIndex = 10;
            this.experiment_date_date.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // experiment_date_month_label
            // 
            this.experiment_date_month_label.AutoSize = true;
            this.experiment_date_month_label.Location = new System.Drawing.Point(200, 73);
            this.experiment_date_month_label.Name = "experiment_date_month_label";
            this.experiment_date_month_label.Size = new System.Drawing.Size(17, 12);
            this.experiment_date_month_label.TabIndex = 9;
            this.experiment_date_month_label.Text = "月";
            // 
            // experiment_date_month
            // 
            this.experiment_date_month.Location = new System.Drawing.Point(156, 66);
            this.experiment_date_month.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.experiment_date_month.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.experiment_date_month.Name = "experiment_date_month";
            this.experiment_date_month.Size = new System.Drawing.Size(38, 19);
            this.experiment_date_month.TabIndex = 8;
            this.experiment_date_month.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // experiment_date_year_label
            // 
            this.experiment_date_year_label.AutoSize = true;
            this.experiment_date_year_label.Location = new System.Drawing.Point(136, 73);
            this.experiment_date_year_label.Name = "experiment_date_year_label";
            this.experiment_date_year_label.Size = new System.Drawing.Size(17, 12);
            this.experiment_date_year_label.TabIndex = 7;
            this.experiment_date_year_label.Text = "年";
            // 
            // experiment_date_year
            // 
            this.experiment_date_year.Location = new System.Drawing.Point(74, 66);
            this.experiment_date_year.Maximum = new decimal(new int[] {
            2050,
            0,
            0,
            0});
            this.experiment_date_year.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.experiment_date_year.Name = "experiment_date_year";
            this.experiment_date_year.Size = new System.Drawing.Size(58, 19);
            this.experiment_date_year.TabIndex = 6;
            this.experiment_date_year.Value = new decimal(new int[] {
            2021,
            0,
            0,
            0});
            // 
            // rocket_name
            // 
            this.rocket_name.Location = new System.Drawing.Point(59, 41);
            this.rocket_name.Name = "rocket_name";
            this.rocket_name.Size = new System.Drawing.Size(225, 19);
            this.rocket_name.TabIndex = 5;
            // 
            // team_name
            // 
            this.team_name.Location = new System.Drawing.Point(59, 16);
            this.team_name.Name = "team_name";
            this.team_name.Size = new System.Drawing.Size(225, 19);
            this.team_name.TabIndex = 4;
            // 
            // version_label
            // 
            this.version_label.AutoSize = true;
            this.version_label.Location = new System.Drawing.Point(7, 99);
            this.version_label.Name = "version_label";
            this.version_label.Size = new System.Drawing.Size(50, 12);
            this.version_label.TabIndex = 3;
            this.version_label.Text = "バージョン";
            // 
            // experiment_date_label
            // 
            this.experiment_date_label.AutoSize = true;
            this.experiment_date_label.Location = new System.Drawing.Point(7, 68);
            this.experiment_date_label.Name = "experiment_date_label";
            this.experiment_date_label.Size = new System.Drawing.Size(60, 12);
            this.experiment_date_label.TabIndex = 2;
            this.experiment_date_label.Text = "打ち上げ日";
            // 
            // rocket_name_label
            // 
            this.rocket_name_label.AutoSize = true;
            this.rocket_name_label.Location = new System.Drawing.Point(7, 44);
            this.rocket_name_label.Name = "rocket_name_label";
            this.rocket_name_label.Size = new System.Drawing.Size(41, 12);
            this.rocket_name_label.TabIndex = 1;
            this.rocket_name_label.Text = "機体名";
            // 
            // team_name_label
            // 
            this.team_name_label.AutoSize = true;
            this.team_name_label.Location = new System.Drawing.Point(7, 19);
            this.team_name_label.Name = "team_name_label";
            this.team_name_label.Size = new System.Drawing.Size(46, 12);
            this.team_name_label.TabIndex = 0;
            this.team_name_label.Text = "チーム名";
            // 
            // realdata_filename_select
            // 
            this.realdata_filename_select.FormattingEnabled = true;
            this.realdata_filename_select.Location = new System.Drawing.Point(128, 68);
            this.realdata_filename_select.Name = "realdata_filename_select";
            this.realdata_filename_select.Size = new System.Drawing.Size(309, 20);
            this.realdata_filename_select.TabIndex = 15;
            // 
            // airspeed_param_file_select
            // 
            this.airspeed_param_file_select.FormattingEnabled = true;
            this.airspeed_param_file_select.Location = new System.Drawing.Point(157, 574);
            this.airspeed_param_file_select.Name = "airspeed_param_file_select";
            this.airspeed_param_file_select.Size = new System.Drawing.Size(573, 20);
            this.airspeed_param_file_select.TabIndex = 52;
            this.airspeed_param_file_select.SelectedIndexChanged += new System.EventHandler(this.airspeed_param_file_select_SelectedIndexChanged);
            // 
            // motor_file_select
            // 
            this.motor_file_select.FormattingEnabled = true;
            this.motor_file_select.Location = new System.Drawing.Point(113, 397);
            this.motor_file_select.Name = "motor_file_select";
            this.motor_file_select.Size = new System.Drawing.Size(617, 20);
            this.motor_file_select.TabIndex = 53;
            // 
            // PrologueSettingGeneratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(0, 10);
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(817, 704);
            this.Controls.Add(this.rocket);
            this.Controls.Add(this.settings);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(833, 1920);
            this.MinimumSize = new System.Drawing.Size(833, 39);
            this.Name = "PrologueSettingGeneratorForm";
            this.Text = "PrologueSettingGenerator";
            this.Load += new System.EventHandler(this.PrologueSettingGeneratorForm_Load);
            this.settings.ResumeLayout(false);
            this.wind_model.ResumeLayout(false);
            this.wind_model.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.power_constant)).EndInit();
            this.simulation.ResumeLayout(false);
            this.simulation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.detect_peak_threshold)).EndInit();
            this.scatter.ResumeLayout(false);
            this.scatter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wind_dir_interval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wind_speed_max)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wind_speed_min)).EndInit();
            this.processing.ResumeLayout(false);
            this.processing.PerformLayout();
            this.rocket.ResumeLayout(false);
            this.environment.ResumeLayout(false);
            this.environment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rail_elev)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rail_azi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rail_len)).EndInit();
            this.parameter.ResumeLayout(false);
            this.parameter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Cna)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cd_alpha2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cp_alpha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CPlen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.delay_time_1st)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.op_time_1st)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vel_1st)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cmq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Iyz_f)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Iyz_i)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mass_f)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mass_i)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CGlen_f)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CGlen_i)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ref_len)).EndInit();
            this.info.ResumeLayout(false);
            this.info.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.experiment_date_date)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.experiment_date_month)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.experiment_date_year)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox settings;
        private System.Windows.Forms.GroupBox wind_model;
        private System.Windows.Forms.Label realdata_filename_label;
        private System.Windows.Forms.ComboBox type;
        private System.Windows.Forms.Label type_label;
        private System.Windows.Forms.Label power_constant_label;
        private System.Windows.Forms.GroupBox simulation;
        private System.Windows.Forms.GroupBox scatter;
        private System.Windows.Forms.Label wind_dir_interval_deg;
        private System.Windows.Forms.Label wind_dir_interval_label;
        private System.Windows.Forms.Label wind_speed_max_ms;
        private System.Windows.Forms.Label wind_speed_min_ms;
        private System.Windows.Forms.Label wind_speed_max_label;
        private System.Windows.Forms.Label wind_speed_min_label;
        private System.Windows.Forms.Label detect_peak_threshold_m;
        private System.Windows.Forms.Label detect_peak_threshold_label;
        private System.Windows.Forms.GroupBox processing;
        private System.Windows.Forms.CheckBox multi_thread;
        private System.Windows.Forms.NumericUpDown power_constant;
        private System.Windows.Forms.NumericUpDown detect_peak_threshold;
        private System.Windows.Forms.NumericUpDown wind_dir_interval;
        private System.Windows.Forms.NumericUpDown wind_speed_max;
        private System.Windows.Forms.NumericUpDown wind_speed_min;
        private System.Windows.Forms.GroupBox rocket;
        private System.Windows.Forms.GroupBox info;
        private System.Windows.Forms.TextBox version;
        private System.Windows.Forms.Label experiment_date_date_label;
        private System.Windows.Forms.NumericUpDown experiment_date_date;
        private System.Windows.Forms.Label experiment_date_month_label;
        private System.Windows.Forms.NumericUpDown experiment_date_month;
        private System.Windows.Forms.Label experiment_date_year_label;
        private System.Windows.Forms.NumericUpDown experiment_date_year;
        private System.Windows.Forms.TextBox rocket_name;
        private System.Windows.Forms.TextBox team_name;
        private System.Windows.Forms.Label version_label;
        private System.Windows.Forms.Label experiment_date_label;
        private System.Windows.Forms.Label rocket_name_label;
        private System.Windows.Forms.Label team_name_label;
        private System.Windows.Forms.GroupBox parameter;
        private System.Windows.Forms.NumericUpDown ref_len;
        private System.Windows.Forms.Label Cna_label;
        private System.Windows.Forms.Label Cp_alpha_label;
        private System.Windows.Forms.Label CPlen_label;
        private System.Windows.Forms.Label Cd_label;
        private System.Windows.Forms.Label airspeed_param_file_label;
        private System.Windows.Forms.Label Cd_alpha2_label;
        private System.Windows.Forms.Label motor_file_label;
        private System.Windows.Forms.Label op_type_1st_label;
        private System.Windows.Forms.Label delay_time_1st_label;
        private System.Windows.Forms.Label op_time_1st_label;
        private System.Windows.Forms.Label vel_1st_label;
        private System.Windows.Forms.Label Cmq_label;
        private System.Windows.Forms.Label Iyz_f_label;
        private System.Windows.Forms.Label Iyz_i_label;
        private System.Windows.Forms.Label mass_f_label;
        private System.Windows.Forms.Label mass_i_label;
        private System.Windows.Forms.Label CGlen_f_label;
        private System.Windows.Forms.Label CGlen_i_label;
        private System.Windows.Forms.Label diam_label;
        private System.Windows.Forms.Label ref_len_label;
        private System.Windows.Forms.NumericUpDown Cd_alpha2;
        private System.Windows.Forms.NumericUpDown Cd;
        private System.Windows.Forms.NumericUpDown Cp_alpha;
        private System.Windows.Forms.NumericUpDown CPlen;
        private System.Windows.Forms.NumericUpDown delay_time_1st;
        private System.Windows.Forms.NumericUpDown op_time_1st;
        private System.Windows.Forms.ComboBox op_type_1st;
        private System.Windows.Forms.NumericUpDown vel_1st;
        private System.Windows.Forms.NumericUpDown Cmq;
        private System.Windows.Forms.NumericUpDown Iyz_f;
        private System.Windows.Forms.NumericUpDown Iyz_i;
        private System.Windows.Forms.Label mass_f_kg;
        private System.Windows.Forms.Label mass_i_kg;
        private System.Windows.Forms.Label CGlen_f_m;
        private System.Windows.Forms.Label CGlen_i_m;
        private System.Windows.Forms.NumericUpDown mass_f;
        private System.Windows.Forms.NumericUpDown mass_i;
        private System.Windows.Forms.NumericUpDown CGlen_f;
        private System.Windows.Forms.NumericUpDown CGlen_i;
        private System.Windows.Forms.Label diam_m;
        private System.Windows.Forms.NumericUpDown diam;
        private System.Windows.Forms.Label ref_len_m;
        private System.Windows.Forms.GroupBox environment;
        private System.Windows.Forms.ComboBox place;
        private System.Windows.Forms.Label rail_elev_label;
        private System.Windows.Forms.Label rail_azi_label;
        private System.Windows.Forms.Label rail_len_label;
        private System.Windows.Forms.Label place_label;
        private System.Windows.Forms.Label Cd_alpha2_rad2;
        private System.Windows.Forms.Label Cp_alpha_mrad;
        private System.Windows.Forms.Label CPlen_m;
        private System.Windows.Forms.Label delay_time_1st_s;
        private System.Windows.Forms.Label op_time_1st_s;
        private System.Windows.Forms.Label vel_1st_ms;
        private System.Windows.Forms.Label Iyz_f_kgm2;
        private System.Windows.Forms.Label Iyz_i_kgm2;
        private System.Windows.Forms.NumericUpDown rail_azi;
        private System.Windows.Forms.NumericUpDown rail_len;
        private System.Windows.Forms.NumericUpDown rail_elev;
        private System.Windows.Forms.Label rail_len_m;
        private System.Windows.Forms.Label rail_azi_deg;
        private System.Windows.Forms.Label rail_elev_deg;
        private System.Windows.Forms.NumericUpDown Cna;
        private System.Windows.Forms.Button setting_write;
        private System.Windows.Forms.Button spec_write;
        private System.Windows.Forms.ComboBox realdata_filename_select;
        private System.Windows.Forms.ComboBox airspeed_param_file_select;
        private System.Windows.Forms.ComboBox motor_file_select;
    }
}

