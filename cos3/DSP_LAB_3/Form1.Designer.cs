namespace DSP_LAB_3
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbSourceImage = new System.Windows.Forms.PictureBox();
            this.pbFilteredImage = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnGaussianFilter = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnMedian = new System.Windows.Forms.Button();
            this.tbWindowSize = new System.Windows.Forms.TextBox();
            this.lblWindowSize = new System.Windows.Forms.Label();
            this.btnSobelFilter = new System.Windows.Forms.Button();
            this.tbSigma = new System.Windows.Forms.TextBox();
            this.lblSigma = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBoxBlur = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbSourceImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFilteredImage)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbSourceImage
            // 
            this.pbSourceImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbSourceImage.Location = new System.Drawing.Point(3, 2);
            this.pbSourceImage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbSourceImage.Name = "pbSourceImage";
            this.pbSourceImage.Size = new System.Drawing.Size(673, 661);
            this.pbSourceImage.TabIndex = 1;
            this.pbSourceImage.TabStop = false;
            // 
            // pbFilteredImage
            // 
            this.pbFilteredImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbFilteredImage.Location = new System.Drawing.Point(682, 2);
            this.pbFilteredImage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbFilteredImage.Name = "pbFilteredImage";
            this.pbFilteredImage.Size = new System.Drawing.Size(706, 661);
            this.pbFilteredImage.TabIndex = 2;
            this.pbFilteredImage.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.Window;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.71429F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 712F));
            this.tableLayoutPanel1.Controls.Add(this.pbFilteredImage, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pbSourceImage, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(377, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1391, 665);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // btnGaussianFilter
            // 
            this.btnGaussianFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGaussianFilter.Location = new System.Drawing.Point(35, 165);
            this.btnGaussianFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGaussianFilter.Name = "btnGaussianFilter";
            this.btnGaussianFilter.Size = new System.Drawing.Size(301, 37);
            this.btnGaussianFilter.TabIndex = 3;
            this.btnGaussianFilter.Text = "Фильтр Гаусса";
            this.btnGaussianFilter.UseVisualStyleBackColor = true;
            this.btnGaussianFilter.Click += new System.EventHandler(this.btnGaussianFilter_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOpen.Location = new System.Drawing.Point(35, 11);
            this.btnOpen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(301, 37);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "Загрузить файл";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnMedian
            // 
            this.btnMedian.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMedian.Location = new System.Drawing.Point(31, 220);
            this.btnMedian.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMedian.Name = "btnMedian";
            this.btnMedian.Size = new System.Drawing.Size(301, 37);
            this.btnMedian.TabIndex = 4;
            this.btnMedian.Text = "Медианный фильтр";
            this.btnMedian.UseVisualStyleBackColor = true;
            this.btnMedian.Click += new System.EventHandler(this.btnMedian_Click);
            // 
            // tbWindowSize
            // 
            this.tbWindowSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbWindowSize.Location = new System.Drawing.Point(260, 117);
            this.tbWindowSize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbWindowSize.Name = "tbWindowSize";
            this.tbWindowSize.Size = new System.Drawing.Size(71, 26);
            this.tbWindowSize.TabIndex = 5;
            this.tbWindowSize.Text = "3";
            // 
            // lblWindowSize
            // 
            this.lblWindowSize.AutoSize = true;
            this.lblWindowSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblWindowSize.Location = new System.Drawing.Point(35, 117);
            this.lblWindowSize.Name = "lblWindowSize";
            this.lblWindowSize.Size = new System.Drawing.Size(120, 20);
            this.lblWindowSize.TabIndex = 6;
            this.lblWindowSize.Text = "Размер окна:";
            // 
            // btnSobelFilter
            // 
            this.btnSobelFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSobelFilter.Location = new System.Drawing.Point(31, 289);
            this.btnSobelFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSobelFilter.Name = "btnSobelFilter";
            this.btnSobelFilter.Size = new System.Drawing.Size(301, 37);
            this.btnSobelFilter.TabIndex = 7;
            this.btnSobelFilter.Text = "Фильтр Собеля";
            this.btnSobelFilter.UseVisualStyleBackColor = true;
            this.btnSobelFilter.Click += new System.EventHandler(this.btnSobelFilter_Click);
            // 
            // tbSigma
            // 
            this.tbSigma.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbSigma.Location = new System.Drawing.Point(260, 68);
            this.tbSigma.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSigma.Name = "tbSigma";
            this.tbSigma.Size = new System.Drawing.Size(71, 26);
            this.tbSigma.TabIndex = 9;
            this.tbSigma.Text = "1";
            // 
            // lblSigma
            // 
            this.lblSigma.AutoSize = true;
            this.lblSigma.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSigma.Location = new System.Drawing.Point(35, 68);
            this.lblSigma.Name = "lblSigma";
            this.lblSigma.Size = new System.Drawing.Size(66, 20);
            this.lblSigma.TabIndex = 10;
            this.lblSigma.Text = "Сигма:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnBoxBlur);
            this.panel1.Controls.Add(this.lblSigma);
            this.panel1.Controls.Add(this.tbSigma);
            this.panel1.Controls.Add(this.btnSobelFilter);
            this.panel1.Controls.Add(this.lblWindowSize);
            this.panel1.Controls.Add(this.tbWindowSize);
            this.panel1.Controls.Add(this.btnMedian);
            this.panel1.Controls.Add(this.btnOpen);
            this.panel1.Controls.Add(this.btnGaussianFilter);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.MaximumSize = new System.Drawing.Size(377, 0);
            this.panel1.MinimumSize = new System.Drawing.Size(377, 345);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(377, 665);
            this.panel1.TabIndex = 4;
            // 
            // btnBoxBlur
            // 
            this.btnBoxBlur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBoxBlur.Location = new System.Drawing.Point(31, 358);
            this.btnBoxBlur.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBoxBlur.Name = "btnBoxBlur";
            this.btnBoxBlur.Size = new System.Drawing.Size(301, 37);
            this.btnBoxBlur.TabIndex = 11;
            this.btnBoxBlur.Text = "Box Blur";
            this.btnBoxBlur.UseVisualStyleBackColor = true;
            this.btnBoxBlur.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1768, 665);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(1594, 580);
            this.Name = "Form1";
            this.Text = "DSP LAB 3";
            ((System.ComponentModel.ISupportInitialize)(this.pbSourceImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFilteredImage)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pbSourceImage;
        private System.Windows.Forms.PictureBox pbFilteredImage;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnGaussianFilter;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnMedian;
        private System.Windows.Forms.TextBox tbWindowSize;
        private System.Windows.Forms.Label lblWindowSize;
        private System.Windows.Forms.Button btnSobelFilter;
        private System.Windows.Forms.TextBox tbSigma;
        private System.Windows.Forms.Label lblSigma;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBoxBlur;
    }
}

