namespace MandarinNews
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.PageLbl = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.AccountPanel = new System.Windows.Forms.Panel();
            this.WorldPanel = new System.Windows.Forms.Panel();
            this.HomePanel = new System.Windows.Forms.Panel();
            this.SettingsPanel = new System.Windows.Forms.Panel();
            this.SignInBtn = new System.Windows.Forms.Button();
            this.AllNewsBtn = new System.Windows.Forms.Button();
            this.homeBtn = new System.Windows.Forms.Button();
            this.settingsBtn = new System.Windows.Forms.Button();
            this.FillPanel = new System.Windows.Forms.Panel();
            this.dragControl1 = new MandarinNews.DragControl();
            this.HeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.LeftPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.HeaderPanel.Controls.Add(this.PageLbl);
            this.HeaderPanel.Controls.Add(this.button5);
            this.HeaderPanel.Controls.Add(this.textBox1);
            this.HeaderPanel.Controls.Add(this.label1);
            this.HeaderPanel.Controls.Add(this.pictureBox2);
            this.HeaderPanel.Controls.Add(this.button3);
            this.HeaderPanel.Controls.Add(this.button2);
            this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(1372, 53);
            this.HeaderPanel.TabIndex = 8;
            // 
            // PageLbl
            // 
            this.PageLbl.AutoSize = true;
            this.PageLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PageLbl.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PageLbl.ForeColor = System.Drawing.Color.Wheat;
            this.PageLbl.Location = new System.Drawing.Point(414, 3);
            this.PageLbl.Name = "PageLbl";
            this.PageLbl.Size = new System.Drawing.Size(128, 44);
            this.PageLbl.TabIndex = 14;
            this.PageLbl.Text = "Home";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(677, 10);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(56, 36);
            this.button5.TabIndex = 13;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox1.Location = new System.Drawing.Point(737, 14);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(302, 30);
            this.textBox1.TabIndex = 11;
            this.textBox1.Text = "Search...";
            this.textBox1.Click += new System.EventHandler(this.textBox1_Click);
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Orange;
            this.label1.Location = new System.Drawing.Point(81, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 44);
            this.label1.TabIndex = 10;
            this.label1.Text = "Mandarin News";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(16, 7);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Right;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(1222, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 53);
            this.button3.TabIndex = 10;
            this.button3.Text = "_";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Right;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(1297, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 53);
            this.button2.TabIndex = 9;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // LeftPanel
            // 
            this.LeftPanel.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.LeftPanel.Controls.Add(this.AccountPanel);
            this.LeftPanel.Controls.Add(this.WorldPanel);
            this.LeftPanel.Controls.Add(this.HomePanel);
            this.LeftPanel.Controls.Add(this.SettingsPanel);
            this.LeftPanel.Controls.Add(this.SignInBtn);
            this.LeftPanel.Controls.Add(this.AllNewsBtn);
            this.LeftPanel.Controls.Add(this.homeBtn);
            this.LeftPanel.Controls.Add(this.settingsBtn);
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPanel.Location = new System.Drawing.Point(0, 53);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(79, 720);
            this.LeftPanel.TabIndex = 9;
            // 
            // AccountPanel
            // 
            this.AccountPanel.BackColor = System.Drawing.Color.White;
            this.AccountPanel.Location = new System.Drawing.Point(3, 320);
            this.AccountPanel.Name = "AccountPanel";
            this.AccountPanel.Size = new System.Drawing.Size(11, 64);
            this.AccountPanel.TabIndex = 1;
            // 
            // WorldPanel
            // 
            this.WorldPanel.BackColor = System.Drawing.Color.White;
            this.WorldPanel.Location = new System.Drawing.Point(3, 220);
            this.WorldPanel.Name = "WorldPanel";
            this.WorldPanel.Size = new System.Drawing.Size(11, 64);
            this.WorldPanel.TabIndex = 1;
            // 
            // HomePanel
            // 
            this.HomePanel.BackColor = System.Drawing.Color.White;
            this.HomePanel.Location = new System.Drawing.Point(3, 20);
            this.HomePanel.Name = "HomePanel";
            this.HomePanel.Size = new System.Drawing.Size(11, 64);
            this.HomePanel.TabIndex = 1;
            // 
            // SettingsPanel
            // 
            this.SettingsPanel.BackColor = System.Drawing.Color.White;
            this.SettingsPanel.Location = new System.Drawing.Point(3, 120);
            this.SettingsPanel.Name = "SettingsPanel";
            this.SettingsPanel.Size = new System.Drawing.Size(11, 64);
            this.SettingsPanel.TabIndex = 0;
            // 
            // SignInBtn
            // 
            this.SignInBtn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.SignInBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SignInBtn.BackgroundImage")));
            this.SignInBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SignInBtn.FlatAppearance.BorderSize = 0;
            this.SignInBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.SignInBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.SignInBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignInBtn.Location = new System.Drawing.Point(12, 320);
            this.SignInBtn.Name = "SignInBtn";
            this.SignInBtn.Size = new System.Drawing.Size(67, 64);
            this.SignInBtn.TabIndex = 17;
            this.SignInBtn.UseVisualStyleBackColor = false;
            this.SignInBtn.Click += new System.EventHandler(this.SignInBtn_Click);
            // 
            // AllNewsBtn
            // 
            this.AllNewsBtn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.AllNewsBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AllNewsBtn.BackgroundImage")));
            this.AllNewsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AllNewsBtn.FlatAppearance.BorderSize = 0;
            this.AllNewsBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.AllNewsBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.AllNewsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AllNewsBtn.Location = new System.Drawing.Point(12, 220);
            this.AllNewsBtn.Name = "AllNewsBtn";
            this.AllNewsBtn.Size = new System.Drawing.Size(67, 64);
            this.AllNewsBtn.TabIndex = 16;
            this.AllNewsBtn.UseVisualStyleBackColor = false;
            this.AllNewsBtn.Click += new System.EventHandler(this.AllNewsBtn_Click);
            // 
            // homeBtn
            // 
            this.homeBtn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.homeBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("homeBtn.BackgroundImage")));
            this.homeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.homeBtn.FlatAppearance.BorderSize = 0;
            this.homeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.homeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.homeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeBtn.Location = new System.Drawing.Point(12, 20);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Size = new System.Drawing.Size(67, 64);
            this.homeBtn.TabIndex = 15;
            this.homeBtn.UseVisualStyleBackColor = false;
            this.homeBtn.Click += new System.EventHandler(this.homeBtn_Click);
            // 
            // settingsBtn
            // 
            this.settingsBtn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.settingsBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("settingsBtn.BackgroundImage")));
            this.settingsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.settingsBtn.FlatAppearance.BorderSize = 0;
            this.settingsBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.settingsBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.settingsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsBtn.Location = new System.Drawing.Point(12, 120);
            this.settingsBtn.Name = "settingsBtn";
            this.settingsBtn.Size = new System.Drawing.Size(67, 64);
            this.settingsBtn.TabIndex = 14;
            this.settingsBtn.UseVisualStyleBackColor = false;
            this.settingsBtn.Click += new System.EventHandler(this.settingsBtn_Click);
            // 
            // FillPanel
            // 
            this.FillPanel.BackColor = System.Drawing.Color.White;
            this.FillPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FillPanel.Location = new System.Drawing.Point(79, 53);
            this.FillPanel.Name = "FillPanel";
            this.FillPanel.Size = new System.Drawing.Size(1293, 720);
            this.FillPanel.TabIndex = 10;
            // 
            // dragControl1
            // 
            this.dragControl1.SelectControl = this.HeaderPanel;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1372, 773);
            this.Controls.Add(this.FillPanel);
            this.Controls.Add(this.LeftPanel);
            this.Controls.Add(this.HeaderPanel);
            this.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Test";
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.LeftPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DragControl dragControl1;
        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.Panel FillPanel;
        private System.Windows.Forms.Button settingsBtn;
        private System.Windows.Forms.Button AllNewsBtn;
        private System.Windows.Forms.Button homeBtn;
        private System.Windows.Forms.Button SignInBtn;
        private System.Windows.Forms.Panel SettingsPanel;
        private System.Windows.Forms.Panel AccountPanel;
        private System.Windows.Forms.Panel WorldPanel;
        private System.Windows.Forms.Panel HomePanel;
        private System.Windows.Forms.Label PageLbl;
    }
}

