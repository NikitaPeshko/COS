namespace DSP_LAB_2
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.cHarmonicOriginal = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cHarmonicRestored = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cHarmonicAmplitude = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cHarmonicPhase = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cHarmonicOriginal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHarmonicRestored)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHarmonicAmplitude)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHarmonicPhase)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cHarmonicOriginal
            // 
            chartArea1.Name = "ChartArea1";
            this.cHarmonicOriginal.ChartAreas.Add(chartArea1);
            this.cHarmonicOriginal.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.cHarmonicOriginal, "cHarmonicOriginal");
            legend1.Name = "Legend1";
            this.cHarmonicOriginal.Legends.Add(legend1);
            this.cHarmonicOriginal.Name = "cHarmonicOriginal";
            this.cHarmonicOriginal.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.cHarmonicOriginal.Series.Add(series1);
            // 
            // cHarmonicRestored
            // 
            chartArea2.Name = "ChartArea1";
            this.cHarmonicRestored.ChartAreas.Add(chartArea2);
            resources.ApplyResources(this.cHarmonicRestored, "cHarmonicRestored");
            legend2.Name = "Legend1";
            this.cHarmonicRestored.Legends.Add(legend2);
            this.cHarmonicRestored.Name = "cHarmonicRestored";
            this.cHarmonicRestored.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.cHarmonicRestored.Series.Add(series2);
            // 
            // cHarmonicAmplitude
            // 
            chartArea3.Name = "ChartArea1";
            this.cHarmonicAmplitude.ChartAreas.Add(chartArea3);
            resources.ApplyResources(this.cHarmonicAmplitude, "cHarmonicAmplitude");
            legend3.Name = "Legend1";
            this.cHarmonicAmplitude.Legends.Add(legend3);
            this.cHarmonicAmplitude.Name = "cHarmonicAmplitude";
            this.cHarmonicAmplitude.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.cHarmonicAmplitude.Series.Add(series3);
            // 
            // cHarmonicPhase
            // 
            chartArea4.Name = "ChartArea1";
            this.cHarmonicPhase.ChartAreas.Add(chartArea4);
            resources.ApplyResources(this.cHarmonicPhase, "cHarmonicPhase");
            legend4.Name = "Legend1";
            this.cHarmonicPhase.Legends.Add(legend4);
            this.cHarmonicPhase.Name = "cHarmonicPhase";
            this.cHarmonicPhase.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.cHarmonicPhase.Series.Add(series4);
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.cHarmonicPhase, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cHarmonicAmplitude, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.cHarmonicRestored, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.cHarmonicOriginal, 1, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // tableLayoutPanel2
            // 
            resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
            this.tableLayoutPanel2.Controls.Add(this.button1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.button2, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.button3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.button4, 0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            resources.ApplyResources(this.button3, "button3");
            this.button3.Name = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            resources.ApplyResources(this.button4, "button4");
            this.button4.Name = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.cHarmonicOriginal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHarmonicRestored)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHarmonicAmplitude)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHarmonicPhase)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart cHarmonicOriginal;
        private System.Windows.Forms.DataVisualization.Charting.Chart cHarmonicRestored;
        private System.Windows.Forms.DataVisualization.Charting.Chart cHarmonicAmplitude;
        private System.Windows.Forms.DataVisualization.Charting.Chart cHarmonicPhase;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

