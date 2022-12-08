namespace DSP.Lab1.Presentation
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.ResultChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.TaskComboBox = new System.Windows.Forms.ComboBox();
            this.TaskLabel = new System.Windows.Forms.Label();
            this.NLabel = new System.Windows.Forms.Label();
            this.NComboBox = new System.Windows.Forms.ComboBox();
            this.J1Label = new System.Windows.Forms.Label();
            this.J2Label = new System.Windows.Forms.Label();
            this.A1TextBox = new System.Windows.Forms.TextBox();
            this.ALabel = new System.Windows.Forms.Label();
            this.FLabel = new System.Windows.Forms.Label();
            this.FiLabel = new System.Windows.Forms.Label();
            this.A2TextBox = new System.Windows.Forms.TextBox();
            this.F2TextBox = new System.Windows.Forms.TextBox();
            this.F1TextBox = new System.Windows.Forms.TextBox();
            this.Fi2TextBox = new System.Windows.Forms.TextBox();
            this.Fi1TextBox = new System.Windows.Forms.TextBox();
            this.SignalLabel = new System.Windows.Forms.Label();
            this.SignalComboBox = new System.Windows.Forms.ComboBox();
            this.WellRateTrackBar = new System.Windows.Forms.TrackBar();
            this.WellRateLabel = new System.Windows.Forms.Label();
            this.WellRateValuelabel = new System.Windows.Forms.Label();
            this.ModulatingSignalLabel = new System.Windows.Forms.Label();
            this.ModulatingSignalComboBox = new System.Windows.Forms.ComboBox();
            this.ModulationComboBox = new System.Windows.Forms.ComboBox();
            this.ModulationLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.построитьГрафикToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сгенерироватьЗвукToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.построитьГрафикToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.показатьФайлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.ResultChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WellRateTrackBar)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ResultChart
            // 
            chartArea4.Name = "ChartArea1";
            this.ResultChart.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.ResultChart.Legends.Add(legend4);
            this.ResultChart.Location = new System.Drawing.Point(513, 35);
            this.ResultChart.Margin = new System.Windows.Forms.Padding(7);
            this.ResultChart.Name = "ResultChart";
            this.ResultChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.ResultChart.Series.Add(series4);
            this.ResultChart.Size = new System.Drawing.Size(729, 312);
            this.ResultChart.TabIndex = 0;
            this.ResultChart.Text = "chart";
            // 
            // TaskComboBox
            // 
            this.TaskComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TaskComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaskComboBox.FormattingEnabled = true;
            this.TaskComboBox.Items.AddRange(new object[] {
            "2 а",
            "2 б",
            "2 в",
            "3",
            "4"});
            this.TaskComboBox.Location = new System.Drawing.Point(153, 35);
            this.TaskComboBox.Margin = new System.Windows.Forms.Padding(7);
            this.TaskComboBox.Name = "TaskComboBox";
            this.TaskComboBox.Size = new System.Drawing.Size(295, 32);
            this.TaskComboBox.TabIndex = 1;
            this.TaskComboBox.SelectedIndexChanged += new System.EventHandler(this.TaskComboBox_SelectedIndexChanged);
            this.TaskComboBox.TextChanged += new System.EventHandler(this.comboBox1_TextChanged);
            // 
            // TaskLabel
            // 
            this.TaskLabel.AutoSize = true;
            this.TaskLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TaskLabel.Location = new System.Drawing.Point(50, 35);
            this.TaskLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.TaskLabel.Name = "TaskLabel";
            this.TaskLabel.Size = new System.Drawing.Size(93, 24);
            this.TaskLabel.TabIndex = 2;
            this.TaskLabel.Text = "Задание:";
            this.TaskLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // NLabel
            // 
            this.NLabel.AutoSize = true;
            this.NLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NLabel.Location = new System.Drawing.Point(105, 81);
            this.NLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.NLabel.Name = "NLabel";
            this.NLabel.Size = new System.Drawing.Size(29, 24);
            this.NLabel.TabIndex = 3;
            this.NLabel.Text = "N:";
            this.NLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // NComboBox
            // 
            this.NComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NComboBox.FormattingEnabled = true;
            this.NComboBox.Items.AddRange(new object[] {
            "512",
            "1024",
            "2048"});
            this.NComboBox.Location = new System.Drawing.Point(153, 77);
            this.NComboBox.Margin = new System.Windows.Forms.Padding(7);
            this.NComboBox.Name = "NComboBox";
            this.NComboBox.Size = new System.Drawing.Size(295, 32);
            this.NComboBox.TabIndex = 4;
            // 
            // J1Label
            // 
            this.J1Label.AutoSize = true;
            this.J1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.J1Label.Location = new System.Drawing.Point(99, 382);
            this.J1Label.Name = "J1Label";
            this.J1Label.Size = new System.Drawing.Size(29, 24);
            this.J1Label.TabIndex = 5;
            this.J1Label.Text = "J1";
            // 
            // J2Label
            // 
            this.J2Label.AutoSize = true;
            this.J2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.J2Label.Location = new System.Drawing.Point(99, 420);
            this.J2Label.Name = "J2Label";
            this.J2Label.Size = new System.Drawing.Size(29, 24);
            this.J2Label.TabIndex = 6;
            this.J2Label.Text = "J2";
            // 
            // A1TextBox
            // 
            this.A1TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A1TextBox.Location = new System.Drawing.Point(143, 377);
            this.A1TextBox.Name = "A1TextBox";
            this.A1TextBox.Size = new System.Drawing.Size(51, 28);
            this.A1TextBox.TabIndex = 10;
            this.A1TextBox.TextChanged += new System.EventHandler(this.A1TextBox_TextChanged);
            // 
            // ALabel
            // 
            this.ALabel.AutoSize = true;
            this.ALabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ALabel.Location = new System.Drawing.Point(153, 345);
            this.ALabel.Name = "ALabel";
            this.ALabel.Size = new System.Drawing.Size(23, 24);
            this.ALabel.TabIndex = 11;
            this.ALabel.Text = "A";
            // 
            // FLabel
            // 
            this.FLabel.AutoSize = true;
            this.FLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FLabel.Location = new System.Drawing.Point(212, 345);
            this.FLabel.Name = "FLabel";
            this.FLabel.Size = new System.Drawing.Size(22, 24);
            this.FLabel.TabIndex = 12;
            this.FLabel.Text = "F";
            // 
            // FiLabel
            // 
            this.FiLabel.AutoSize = true;
            this.FiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FiLabel.Location = new System.Drawing.Point(257, 345);
            this.FiLabel.Name = "FiLabel";
            this.FiLabel.Size = new System.Drawing.Size(56, 24);
            this.FiLabel.TabIndex = 13;
            this.FiLabel.Text = "Фаза";
            // 
            // A2TextBox
            // 
            this.A2TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A2TextBox.Location = new System.Drawing.Point(143, 415);
            this.A2TextBox.Name = "A2TextBox";
            this.A2TextBox.Size = new System.Drawing.Size(51, 28);
            this.A2TextBox.TabIndex = 14;
            // 
            // F2TextBox
            // 
            this.F2TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.F2TextBox.Location = new System.Drawing.Point(200, 415);
            this.F2TextBox.Name = "F2TextBox";
            this.F2TextBox.Size = new System.Drawing.Size(51, 28);
            this.F2TextBox.TabIndex = 19;
            // 
            // F1TextBox
            // 
            this.F1TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.F1TextBox.Location = new System.Drawing.Point(200, 377);
            this.F1TextBox.Name = "F1TextBox";
            this.F1TextBox.Size = new System.Drawing.Size(51, 28);
            this.F1TextBox.TabIndex = 18;
            // 
            // Fi2TextBox
            // 
            this.Fi2TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fi2TextBox.Location = new System.Drawing.Point(257, 415);
            this.Fi2TextBox.Name = "Fi2TextBox";
            this.Fi2TextBox.Size = new System.Drawing.Size(51, 28);
            this.Fi2TextBox.TabIndex = 24;
            // 
            // Fi1TextBox
            // 
            this.Fi1TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fi1TextBox.Location = new System.Drawing.Point(257, 377);
            this.Fi1TextBox.Name = "Fi1TextBox";
            this.Fi1TextBox.Size = new System.Drawing.Size(51, 28);
            this.Fi1TextBox.TabIndex = 23;
            // 
            // SignalLabel
            // 
            this.SignalLabel.AutoSize = true;
            this.SignalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SignalLabel.Location = new System.Drawing.Point(46, 120);
            this.SignalLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.SignalLabel.Name = "SignalLabel";
            this.SignalLabel.Size = new System.Drawing.Size(94, 24);
            this.SignalLabel.TabIndex = 30;
            this.SignalLabel.Text = "Сигнал 1:";
            this.SignalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SignalComboBox
            // 
            this.SignalComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SignalComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignalComboBox.FormattingEnabled = true;
            this.SignalComboBox.Location = new System.Drawing.Point(153, 119);
            this.SignalComboBox.Margin = new System.Windows.Forms.Padding(7);
            this.SignalComboBox.Name = "SignalComboBox";
            this.SignalComboBox.Size = new System.Drawing.Size(295, 32);
            this.SignalComboBox.TabIndex = 29;
            this.SignalComboBox.TextChanged += new System.EventHandler(this.SignalComboBox_TextChanged);
            // 
            // WellRateTrackBar
            // 
            this.WellRateTrackBar.Enabled = false;
            this.WellRateTrackBar.Location = new System.Drawing.Point(171, 267);
            this.WellRateTrackBar.Maximum = 100;
            this.WellRateTrackBar.Name = "WellRateTrackBar";
            this.WellRateTrackBar.Size = new System.Drawing.Size(213, 56);
            this.WellRateTrackBar.TabIndex = 32;
            this.WellRateTrackBar.Scroll += new System.EventHandler(this.WellRateTrackBar_Scroll);
            // 
            // WellRateLabel
            // 
            this.WellRateLabel.AutoSize = true;
            this.WellRateLabel.Enabled = false;
            this.WellRateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WellRateLabel.Location = new System.Drawing.Point(39, 267);
            this.WellRateLabel.Name = "WellRateLabel";
            this.WellRateLabel.Size = new System.Drawing.Size(125, 24);
            this.WellRateLabel.TabIndex = 33;
            this.WellRateLabel.Text = "Скважность:";
            this.WellRateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // WellRateValuelabel
            // 
            this.WellRateValuelabel.AutoSize = true;
            this.WellRateValuelabel.Enabled = false;
            this.WellRateValuelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WellRateValuelabel.Location = new System.Drawing.Point(390, 267);
            this.WellRateValuelabel.Name = "WellRateValuelabel";
            this.WellRateValuelabel.Size = new System.Drawing.Size(0, 24);
            this.WellRateValuelabel.TabIndex = 34;
            // 
            // ModulatingSignalLabel
            // 
            this.ModulatingSignalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ModulatingSignalLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ModulatingSignalLabel.Location = new System.Drawing.Point(-81, 158);
            this.ModulatingSignalLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.ModulatingSignalLabel.Name = "ModulatingSignalLabel";
            this.ModulatingSignalLabel.Size = new System.Drawing.Size(213, 30);
            this.ModulatingSignalLabel.TabIndex = 36;
            this.ModulatingSignalLabel.Text = "Сигнал 2:";
            this.ModulatingSignalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ModulatingSignalComboBox
            // 
            this.ModulatingSignalComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ModulatingSignalComboBox.Enabled = false;
            this.ModulatingSignalComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModulatingSignalComboBox.FormattingEnabled = true;
            this.ModulatingSignalComboBox.Location = new System.Drawing.Point(153, 159);
            this.ModulatingSignalComboBox.Margin = new System.Windows.Forms.Padding(7);
            this.ModulatingSignalComboBox.Name = "ModulatingSignalComboBox";
            this.ModulatingSignalComboBox.Size = new System.Drawing.Size(295, 32);
            this.ModulatingSignalComboBox.TabIndex = 35;
            // 
            // ModulationComboBox
            // 
            this.ModulationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ModulationComboBox.Enabled = false;
            this.ModulationComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModulationComboBox.FormattingEnabled = true;
            this.ModulationComboBox.Items.AddRange(new object[] {
            "512",
            "1024",
            "2048",
            "44100"});
            this.ModulationComboBox.Location = new System.Drawing.Point(153, 206);
            this.ModulationComboBox.Margin = new System.Windows.Forms.Padding(7);
            this.ModulationComboBox.Name = "ModulationComboBox";
            this.ModulationComboBox.Size = new System.Drawing.Size(295, 32);
            this.ModulationComboBox.TabIndex = 38;
            // 
            // ModulationLabel
            // 
            this.ModulationLabel.AutoSize = true;
            this.ModulationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.12727F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ModulationLabel.Location = new System.Drawing.Point(27, 210);
            this.ModulationLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.ModulationLabel.Name = "ModulationLabel";
            this.ModulationLabel.Size = new System.Drawing.Size(115, 24);
            this.ModulationLabel.TabIndex = 37;
            this.ModulationLabel.Text = "Модуляция:";
            this.ModulationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.построитьГрафикToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1275, 28);
            this.menuStrip1.TabIndex = 39;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // построитьГрафикToolStripMenuItem
            // 
            this.построитьГрафикToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сгенерироватьЗвукToolStripMenuItem1,
            this.построитьГрафикToolStripMenuItem1,
            this.показатьФайлToolStripMenuItem});
            this.построитьГрафикToolStripMenuItem.Name = "построитьГрафикToolStripMenuItem";
            this.построитьГрафикToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.построитьГрафикToolStripMenuItem.Text = "Файл";
            this.построитьГрафикToolStripMenuItem.Click += new System.EventHandler(this.построитьГрафикToolStripMenuItem_Click);
            // 
            // сгенерироватьЗвукToolStripMenuItem1
            // 
            this.сгенерироватьЗвукToolStripMenuItem1.Name = "сгенерироватьЗвукToolStripMenuItem1";
            this.сгенерироватьЗвукToolStripMenuItem1.Size = new System.Drawing.Size(231, 26);
            this.сгенерироватьЗвукToolStripMenuItem1.Text = "Сгенерировать звук";
            this.сгенерироватьЗвукToolStripMenuItem1.Click += new System.EventHandler(this.сгенерироватьЗвукToolStripMenuItem1_Click);
            // 
            // построитьГрафикToolStripMenuItem1
            // 
            this.построитьГрафикToolStripMenuItem1.Name = "построитьГрафикToolStripMenuItem1";
            this.построитьГрафикToolStripMenuItem1.Size = new System.Drawing.Size(231, 26);
            this.построитьГрафикToolStripMenuItem1.Text = "Построить график";
            this.построитьГрафикToolStripMenuItem1.Click += new System.EventHandler(this.построитьГрафикToolStripMenuItem1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.SignalComboBox);
            this.panel1.Controls.Add(this.TaskComboBox);
            this.panel1.Controls.Add(this.TaskLabel);
            this.panel1.Controls.Add(this.NLabel);
            this.panel1.Controls.Add(this.Fi2TextBox);
            this.panel1.Controls.Add(this.ModulationComboBox);
            this.panel1.Controls.Add(this.Fi1TextBox);
            this.panel1.Controls.Add(this.NComboBox);
            this.panel1.Controls.Add(this.F2TextBox);
            this.panel1.Controls.Add(this.ModulationLabel);
            this.panel1.Controls.Add(this.F1TextBox);
            this.panel1.Controls.Add(this.A2TextBox);
            this.panel1.Controls.Add(this.SignalLabel);
            this.panel1.Controls.Add(this.FiLabel);
            this.panel1.Controls.Add(this.ModulatingSignalLabel);
            this.panel1.Controls.Add(this.FLabel);
            this.panel1.Controls.Add(this.WellRateTrackBar);
            this.panel1.Controls.Add(this.ALabel);
            this.panel1.Controls.Add(this.ModulatingSignalComboBox);
            this.panel1.Controls.Add(this.A1TextBox);
            this.panel1.Controls.Add(this.WellRateLabel);
            this.panel1.Controls.Add(this.J2Label);
            this.panel1.Controls.Add(this.WellRateValuelabel);
            this.panel1.Controls.Add(this.J1Label);
            this.panel1.Location = new System.Drawing.Point(0, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(489, 807);
            this.panel1.TabIndex = 43;
            // 
            // показатьФайлToolStripMenuItem
            // 
            this.показатьФайлToolStripMenuItem.Name = "показатьФайлToolStripMenuItem";
            this.показатьФайлToolStripMenuItem.Size = new System.Drawing.Size(231, 26);
            this.показатьФайлToolStripMenuItem.Text = "Показать файл";
            this.показатьФайлToolStripMenuItem.Click += new System.EventHandler(this.показатьФайлToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1275, 553);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ResultChart);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(7);
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "Form1";
            this.Text = "DSP Lab 1";
            ((System.ComponentModel.ISupportInitialize)(this.ResultChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WellRateTrackBar)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.DataVisualization.Charting.Chart ResultChart;
        internal System.Windows.Forms.ComboBox TaskComboBox;
        internal System.Windows.Forms.Label TaskLabel;
        internal System.Windows.Forms.Label NLabel;
        internal System.Windows.Forms.ComboBox NComboBox;
        internal System.Windows.Forms.Label J1Label;
        internal System.Windows.Forms.Label J2Label;
        internal System.Windows.Forms.TextBox A1TextBox;
        internal System.Windows.Forms.Label ALabel;
        internal System.Windows.Forms.Label FLabel;
        internal System.Windows.Forms.Label FiLabel;
        internal System.Windows.Forms.TextBox A2TextBox;
        internal System.Windows.Forms.TextBox F2TextBox;
        internal System.Windows.Forms.TextBox F1TextBox;
        internal System.Windows.Forms.TextBox Fi2TextBox;
        internal System.Windows.Forms.TextBox Fi1TextBox;
        internal System.Windows.Forms.Label SignalLabel;
        internal System.Windows.Forms.ComboBox SignalComboBox;
        internal System.Windows.Forms.TrackBar WellRateTrackBar;
        internal System.Windows.Forms.Label WellRateLabel;
        internal System.Windows.Forms.Label WellRateValuelabel;
        internal System.Windows.Forms.Label ModulatingSignalLabel;
        internal System.Windows.Forms.ComboBox ModulatingSignalComboBox;
        internal System.Windows.Forms.ComboBox ModulationComboBox;
        internal System.Windows.Forms.Label ModulationLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem построитьГрафикToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сгенерироватьЗвукToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem построитьГрафикToolStripMenuItem1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem показатьФайлToolStripMenuItem;
    }
}

