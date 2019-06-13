namespace MandarinNews
{
    partial class UC_AllNews
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_AllNews));
            this.ResultLbl = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.NewsCountLbl = new System.Windows.Forms.Label();
            this.PreviousBtn = new System.Windows.Forms.Button();
            this.NextBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DescriptionPanel = new System.Windows.Forms.Panel();
            this.DescriptionRTB = new System.Windows.Forms.RichTextBox();
            this.TitleRTB = new System.Windows.Forms.RichTextBox();
            this.UrlRTB = new System.Windows.Forms.RichTextBox();
            this.AuthorRTB = new System.Windows.Forms.RichTextBox();
            this.SourceRTB = new System.Windows.Forms.RichTextBox();
            this.PublishAtRTB = new System.Windows.Forms.RichTextBox();
            this.ImageBox1 = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.RefreshBtn = new System.Windows.Forms.Button();
            this.WebPanel = new System.Windows.Forms.Panel();
            this.BrowserPanel = new System.Windows.Forms.Panel();
            this.BackBtn = new System.Windows.Forms.Button();
            this.AntiFocus = new System.Windows.Forms.Button();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.DescriptionPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageBox1)).BeginInit();
            this.WebPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ResultLbl
            // 
            this.ResultLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ResultLbl.AutoSize = true;
            this.ResultLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResultLbl.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResultLbl.Location = new System.Drawing.Point(1235, 53);
            this.ResultLbl.Name = "ResultLbl";
            this.ResultLbl.Size = new System.Drawing.Size(22, 24);
            this.ResultLbl.TabIndex = 22;
            this.ResultLbl.Text = "0";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(1197, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 24);
            this.label7.TabIndex = 19;
            this.label7.Text = "Results:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(4, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 36);
            this.label8.TabIndex = 21;
            this.label8.Text = "№";
            // 
            // NewsCountLbl
            // 
            this.NewsCountLbl.AutoSize = true;
            this.NewsCountLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewsCountLbl.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewsCountLbl.Location = new System.Drawing.Point(46, 23);
            this.NewsCountLbl.Name = "NewsCountLbl";
            this.NewsCountLbl.Size = new System.Drawing.Size(31, 36);
            this.NewsCountLbl.TabIndex = 20;
            this.NewsCountLbl.Text = "0";
            // 
            // PreviousBtn
            // 
            this.PreviousBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.PreviousBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PreviousBtn.BackgroundImage")));
            this.PreviousBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PreviousBtn.FlatAppearance.BorderSize = 0;
            this.PreviousBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PreviousBtn.Location = new System.Drawing.Point(16, 304);
            this.PreviousBtn.Name = "PreviousBtn";
            this.PreviousBtn.Size = new System.Drawing.Size(87, 79);
            this.PreviousBtn.TabIndex = 18;
            this.PreviousBtn.UseVisualStyleBackColor = true;
            this.PreviousBtn.Click += new System.EventHandler(this.PreviousBtn_Click);
            // 
            // NextBtn
            // 
            this.NextBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.NextBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("NextBtn.BackgroundImage")));
            this.NextBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.NextBtn.FlatAppearance.BorderSize = 0;
            this.NextBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NextBtn.Location = new System.Drawing.Point(1223, 304);
            this.NextBtn.Name = "NextBtn";
            this.NextBtn.Size = new System.Drawing.Size(87, 79);
            this.NextBtn.TabIndex = 17;
            this.NextBtn.UseVisualStyleBackColor = true;
            this.NextBtn.Click += new System.EventHandler(this.NextBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.DescriptionPanel);
            this.panel1.Controls.Add(this.TitleRTB);
            this.panel1.Controls.Add(this.UrlRTB);
            this.panel1.Controls.Add(this.AuthorRTB);
            this.panel1.Controls.Add(this.SourceRTB);
            this.panel1.Controls.Add(this.PublishAtRTB);
            this.panel1.Controls.Add(this.ImageBox1);
            this.panel1.Location = new System.Drawing.Point(113, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1085, 702);
            this.panel1.TabIndex = 16;
            // 
            // DescriptionPanel
            // 
            this.DescriptionPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DescriptionPanel.Controls.Add(this.DescriptionRTB);
            this.DescriptionPanel.Location = new System.Drawing.Point(4, 378);
            this.DescriptionPanel.Name = "DescriptionPanel";
            this.DescriptionPanel.Size = new System.Drawing.Size(1073, 319);
            this.DescriptionPanel.TabIndex = 13;
            // 
            // DescriptionRTB
            // 
            this.DescriptionRTB.BackColor = System.Drawing.Color.White;
            this.DescriptionRTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DescriptionRTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DescriptionRTB.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DescriptionRTB.Location = new System.Drawing.Point(0, 0);
            this.DescriptionRTB.Name = "DescriptionRTB";
            this.DescriptionRTB.ReadOnly = true;
            this.DescriptionRTB.Size = new System.Drawing.Size(1071, 317);
            this.DescriptionRTB.TabIndex = 12;
            this.DescriptionRTB.Text = "";
            // 
            // TitleRTB
            // 
            this.TitleRTB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TitleRTB.BackColor = System.Drawing.Color.White;
            this.TitleRTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TitleRTB.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TitleRTB.Location = new System.Drawing.Point(4, 64);
            this.TitleRTB.Name = "TitleRTB";
            this.TitleRTB.ReadOnly = true;
            this.TitleRTB.Size = new System.Drawing.Size(727, 162);
            this.TitleRTB.TabIndex = 11;
            this.TitleRTB.Text = "";
            // 
            // UrlRTB
            // 
            this.UrlRTB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.UrlRTB.BackColor = System.Drawing.Color.White;
            this.UrlRTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UrlRTB.Location = new System.Drawing.Point(4, 242);
            this.UrlRTB.Name = "UrlRTB";
            this.UrlRTB.ReadOnly = true;
            this.UrlRTB.Size = new System.Drawing.Size(1037, 50);
            this.UrlRTB.TabIndex = 10;
            this.UrlRTB.Text = "";
            this.UrlRTB.MouseClick += new System.Windows.Forms.MouseEventHandler(this.UrlRTB_MouseClick);
            // 
            // AuthorRTB
            // 
            this.AuthorRTB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.AuthorRTB.BackColor = System.Drawing.Color.White;
            this.AuthorRTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AuthorRTB.Location = new System.Drawing.Point(4, 344);
            this.AuthorRTB.Name = "AuthorRTB";
            this.AuthorRTB.ReadOnly = true;
            this.AuthorRTB.Size = new System.Drawing.Size(764, 38);
            this.AuthorRTB.TabIndex = 9;
            this.AuthorRTB.Text = "";
            // 
            // SourceRTB
            // 
            this.SourceRTB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SourceRTB.BackColor = System.Drawing.Color.White;
            this.SourceRTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SourceRTB.Location = new System.Drawing.Point(4, 294);
            this.SourceRTB.Name = "SourceRTB";
            this.SourceRTB.ReadOnly = true;
            this.SourceRTB.Size = new System.Drawing.Size(764, 45);
            this.SourceRTB.TabIndex = 8;
            this.SourceRTB.Text = "";
            // 
            // PublishAtRTB
            // 
            this.PublishAtRTB.BackColor = System.Drawing.Color.White;
            this.PublishAtRTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PublishAtRTB.Location = new System.Drawing.Point(4, 10);
            this.PublishAtRTB.Name = "PublishAtRTB";
            this.PublishAtRTB.ReadOnly = true;
            this.PublishAtRTB.Size = new System.Drawing.Size(548, 34);
            this.PublishAtRTB.TabIndex = 7;
            this.PublishAtRTB.Text = "";
            // 
            // ImageBox1
            // 
            this.ImageBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ImageBox1.Location = new System.Drawing.Point(773, 6);
            this.ImageBox1.Name = "ImageBox1";
            this.ImageBox1.Size = new System.Drawing.Size(304, 231);
            this.ImageBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImageBox1.TabIndex = 6;
            this.ImageBox1.TabStop = false;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RefreshBtn.BackgroundImage")));
            this.RefreshBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RefreshBtn.FlatAppearance.BorderSize = 0;
            this.RefreshBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RefreshBtn.Location = new System.Drawing.Point(17, 78);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(74, 53);
            this.RefreshBtn.TabIndex = 23;
            this.RefreshBtn.UseVisualStyleBackColor = true;
            this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // WebPanel
            // 
            this.WebPanel.BackColor = System.Drawing.Color.White;
            this.WebPanel.Controls.Add(this.BrowserPanel);
            this.WebPanel.Controls.Add(this.BackBtn);
            this.WebPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WebPanel.Location = new System.Drawing.Point(0, 0);
            this.WebPanel.Name = "WebPanel";
            this.WebPanel.Size = new System.Drawing.Size(1329, 735);
            this.WebPanel.TabIndex = 24;
            this.WebPanel.Visible = false;
            // 
            // BrowserPanel
            // 
            this.BrowserPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BrowserPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BrowserPanel.Location = new System.Drawing.Point(114, 0);
            this.BrowserPanel.Name = "BrowserPanel";
            this.BrowserPanel.Size = new System.Drawing.Size(1215, 735);
            this.BrowserPanel.TabIndex = 20;
            // 
            // BackBtn
            // 
            this.BackBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BackBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BackBtn.BackgroundImage")));
            this.BackBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BackBtn.FlatAppearance.BorderSize = 0;
            this.BackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackBtn.Location = new System.Drawing.Point(18, 304);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(87, 79);
            this.BackBtn.TabIndex = 19;
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // AntiFocus
            // 
            this.AntiFocus.Location = new System.Drawing.Point(30, 17);
            this.AntiFocus.Name = "AntiFocus";
            this.AntiFocus.Size = new System.Drawing.Size(0, 0);
            this.AntiFocus.TabIndex = 0;
            this.AntiFocus.Text = "button1";
            this.AntiFocus.UseVisualStyleBackColor = true;
            // 
            // rightPanel
            // 
            this.rightPanel.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.rightPanel.Location = new System.Drawing.Point(1319, 0);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(10, 726);
            this.rightPanel.TabIndex = 26;
            // 
            // bottomPanel
            // 
            this.bottomPanel.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.bottomPanel.Location = new System.Drawing.Point(0, 725);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(1329, 10);
            this.bottomPanel.TabIndex = 25;
            // 
            // UC_AllNews
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.rightPanel);
            this.Controls.Add(this.bottomPanel);
            this.Controls.Add(this.AntiFocus);
            this.Controls.Add(this.WebPanel);
            this.Controls.Add(this.RefreshBtn);
            this.Controls.Add(this.ResultLbl);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.NewsCountLbl);
            this.Controls.Add(this.PreviousBtn);
            this.Controls.Add(this.NextBtn);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "UC_AllNews";
            this.Size = new System.Drawing.Size(1329, 735);
            this.BackColorChanged += new System.EventHandler(this.UC_AllNews_BackColorChanged);
            this.panel1.ResumeLayout(false);
            this.DescriptionPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ImageBox1)).EndInit();
            this.WebPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ResultLbl;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label NewsCountLbl;
        private System.Windows.Forms.Button PreviousBtn;
        private System.Windows.Forms.Button NextBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox DescriptionRTB;
        private System.Windows.Forms.RichTextBox TitleRTB;
        private System.Windows.Forms.RichTextBox UrlRTB;
        private System.Windows.Forms.RichTextBox AuthorRTB;
        private System.Windows.Forms.RichTextBox SourceRTB;
        private System.Windows.Forms.RichTextBox PublishAtRTB;
        private System.Windows.Forms.PictureBox ImageBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button RefreshBtn;
        private System.Windows.Forms.Panel DescriptionPanel;
        private System.Windows.Forms.Panel WebPanel;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Panel BrowserPanel;
        private System.Windows.Forms.Button AntiFocus;
        private System.Windows.Forms.Panel rightPanel;
        private System.Windows.Forms.Panel bottomPanel;
    }
}
