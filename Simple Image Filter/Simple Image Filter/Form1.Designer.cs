namespace Simple_Image_Filter
{
    partial class frmSimpleFilter
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
            this.btnExit = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnApplyFilter = new System.Windows.Forms.Button();
            this.btnOpenImage = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBoxFilters = new System.Windows.Forms.GroupBox();
            this.rbtInvert = new System.Windows.Forms.RadioButton();
            this.rbtGrayscale = new System.Windows.Forms.RadioButton();
            this.rbtCrazy = new System.Windows.Forms.RadioButton();
            this.rbtNoFIlter = new System.Windows.Forms.RadioButton();
            this.rbtPurple = new System.Windows.Forms.RadioButton();
            this.rbtYellow = new System.Windows.Forms.RadioButton();
            this.rbtRed = new System.Windows.Forms.RadioButton();
            this.rbtAzure = new System.Windows.Forms.RadioButton();
            this.rbtGreen = new System.Windows.Forms.RadioButton();
            this.rbtBlue = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBoxFilters.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(410, 316);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(83, 24);
            this.btnExit.TabIndex = 19;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(114, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(379, 298);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // btnApplyFilter
            // 
            this.btnApplyFilter.Location = new System.Drawing.Point(12, 316);
            this.btnApplyFilter.Name = "btnApplyFilter";
            this.btnApplyFilter.Size = new System.Drawing.Size(96, 24);
            this.btnApplyFilter.TabIndex = 16;
            this.btnApplyFilter.Text = "Apply Filter";
            this.btnApplyFilter.UseVisualStyleBackColor = true;
            this.btnApplyFilter.Click += new System.EventHandler(this.btnApplyFilter_Click_1);
            // 
            // btnOpenImage
            // 
            this.btnOpenImage.Location = new System.Drawing.Point(12, 12);
            this.btnOpenImage.Name = "btnOpenImage";
            this.btnOpenImage.Size = new System.Drawing.Size(96, 26);
            this.btnOpenImage.TabIndex = 17;
            this.btnOpenImage.Text = "Open Image";
            this.btnOpenImage.UseVisualStyleBackColor = true;
            this.btnOpenImage.Click += new System.EventHandler(this.btnOpenImage_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(114, 316);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(96, 24);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "Save Image";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBoxFilters
            // 
            this.groupBoxFilters.Controls.Add(this.rbtInvert);
            this.groupBoxFilters.Controls.Add(this.rbtGrayscale);
            this.groupBoxFilters.Controls.Add(this.rbtCrazy);
            this.groupBoxFilters.Controls.Add(this.rbtNoFIlter);
            this.groupBoxFilters.Controls.Add(this.rbtPurple);
            this.groupBoxFilters.Controls.Add(this.rbtYellow);
            this.groupBoxFilters.Controls.Add(this.rbtRed);
            this.groupBoxFilters.Controls.Add(this.rbtAzure);
            this.groupBoxFilters.Controls.Add(this.rbtGreen);
            this.groupBoxFilters.Controls.Add(this.rbtBlue);
            this.groupBoxFilters.Location = new System.Drawing.Point(12, 58);
            this.groupBoxFilters.Name = "groupBoxFilters";
            this.groupBoxFilters.Size = new System.Drawing.Size(96, 252);
            this.groupBoxFilters.TabIndex = 21;
            this.groupBoxFilters.TabStop = false;
            this.groupBoxFilters.Text = "Filters";
            // 
            // rbtInvert
            // 
            this.rbtInvert.AutoSize = true;
            this.rbtInvert.Location = new System.Drawing.Point(11, 203);
            this.rbtInvert.Name = "rbtInvert";
            this.rbtInvert.Size = new System.Drawing.Size(52, 17);
            this.rbtInvert.TabIndex = 15;
            this.rbtInvert.TabStop = true;
            this.rbtInvert.Text = "Invert";
            this.rbtInvert.UseVisualStyleBackColor = true;
            // 
            // rbtGrayscale
            // 
            this.rbtGrayscale.AutoSize = true;
            this.rbtGrayscale.Location = new System.Drawing.Point(11, 180);
            this.rbtGrayscale.Name = "rbtGrayscale";
            this.rbtGrayscale.Size = new System.Drawing.Size(72, 17);
            this.rbtGrayscale.TabIndex = 14;
            this.rbtGrayscale.TabStop = true;
            this.rbtGrayscale.Text = "Grayscale";
            this.rbtGrayscale.UseVisualStyleBackColor = true;
            // 
            // rbtCrazy
            // 
            this.rbtCrazy.AutoSize = true;
            this.rbtCrazy.Location = new System.Drawing.Point(11, 226);
            this.rbtCrazy.Name = "rbtCrazy";
            this.rbtCrazy.Size = new System.Drawing.Size(51, 17);
            this.rbtCrazy.TabIndex = 13;
            this.rbtCrazy.TabStop = true;
            this.rbtCrazy.Text = "Crazy";
            this.rbtCrazy.UseVisualStyleBackColor = true;
            // 
            // rbtNoFIlter
            // 
            this.rbtNoFIlter.AutoSize = true;
            this.rbtNoFIlter.Location = new System.Drawing.Point(11, 19);
            this.rbtNoFIlter.Name = "rbtNoFIlter";
            this.rbtNoFIlter.Size = new System.Drawing.Size(64, 17);
            this.rbtNoFIlter.TabIndex = 12;
            this.rbtNoFIlter.TabStop = true;
            this.rbtNoFIlter.Text = "No Filter";
            this.rbtNoFIlter.UseVisualStyleBackColor = true;
            // 
            // rbtPurple
            // 
            this.rbtPurple.AutoSize = true;
            this.rbtPurple.Location = new System.Drawing.Point(11, 111);
            this.rbtPurple.Name = "rbtPurple";
            this.rbtPurple.Size = new System.Drawing.Size(55, 17);
            this.rbtPurple.TabIndex = 9;
            this.rbtPurple.TabStop = true;
            this.rbtPurple.Text = "Purple";
            this.rbtPurple.UseVisualStyleBackColor = true;
            // 
            // rbtYellow
            // 
            this.rbtYellow.AutoSize = true;
            this.rbtYellow.Location = new System.Drawing.Point(11, 157);
            this.rbtYellow.Name = "rbtYellow";
            this.rbtYellow.Size = new System.Drawing.Size(56, 17);
            this.rbtYellow.TabIndex = 11;
            this.rbtYellow.TabStop = true;
            this.rbtYellow.Text = "Yellow";
            this.rbtYellow.UseVisualStyleBackColor = true;
            // 
            // rbtRed
            // 
            this.rbtRed.AutoSize = true;
            this.rbtRed.Location = new System.Drawing.Point(11, 42);
            this.rbtRed.Name = "rbtRed";
            this.rbtRed.Size = new System.Drawing.Size(45, 17);
            this.rbtRed.TabIndex = 6;
            this.rbtRed.TabStop = true;
            this.rbtRed.Text = "Red";
            this.rbtRed.UseVisualStyleBackColor = true;
            // 
            // rbtAzure
            // 
            this.rbtAzure.AutoSize = true;
            this.rbtAzure.Location = new System.Drawing.Point(11, 134);
            this.rbtAzure.Name = "rbtAzure";
            this.rbtAzure.Size = new System.Drawing.Size(52, 17);
            this.rbtAzure.TabIndex = 10;
            this.rbtAzure.TabStop = true;
            this.rbtAzure.Text = "Azure";
            this.rbtAzure.UseVisualStyleBackColor = true;
            // 
            // rbtGreen
            // 
            this.rbtGreen.AutoSize = true;
            this.rbtGreen.Location = new System.Drawing.Point(11, 65);
            this.rbtGreen.Name = "rbtGreen";
            this.rbtGreen.Size = new System.Drawing.Size(54, 17);
            this.rbtGreen.TabIndex = 7;
            this.rbtGreen.TabStop = true;
            this.rbtGreen.Text = "Green";
            this.rbtGreen.UseVisualStyleBackColor = true;
            // 
            // rbtBlue
            // 
            this.rbtBlue.AutoSize = true;
            this.rbtBlue.Location = new System.Drawing.Point(11, 88);
            this.rbtBlue.Name = "rbtBlue";
            this.rbtBlue.Size = new System.Drawing.Size(46, 17);
            this.rbtBlue.TabIndex = 8;
            this.rbtBlue.TabStop = true;
            this.rbtBlue.Text = "Blue";
            this.rbtBlue.UseVisualStyleBackColor = true;
            // 
            // frmSimpleFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 352);
            this.Controls.Add(this.groupBoxFilters);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnApplyFilter);
            this.Controls.Add(this.btnOpenImage);
            this.Name = "frmSimpleFilter";
            this.Text = "Simple Image Filter";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBoxFilters.ResumeLayout(false);
            this.groupBoxFilters.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnApplyFilter;
        private System.Windows.Forms.Button btnOpenImage;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupBoxFilters;
        private System.Windows.Forms.RadioButton rbtInvert;
        private System.Windows.Forms.RadioButton rbtGrayscale;
        private System.Windows.Forms.RadioButton rbtCrazy;
        private System.Windows.Forms.RadioButton rbtNoFIlter;
        private System.Windows.Forms.RadioButton rbtPurple;
        private System.Windows.Forms.RadioButton rbtYellow;
        private System.Windows.Forms.RadioButton rbtRed;
        private System.Windows.Forms.RadioButton rbtAzure;
        private System.Windows.Forms.RadioButton rbtGreen;
        private System.Windows.Forms.RadioButton rbtBlue;
    }
}

