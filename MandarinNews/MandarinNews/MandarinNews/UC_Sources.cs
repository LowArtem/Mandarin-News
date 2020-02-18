using System;
using System.Drawing;
using System.Windows.Forms;

namespace MandarinNews
{
    public partial class UC_Sources : UserControl
    {
        public static int selectedMode;

        public UC_Sources()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            this.AutoScaleMode = AutoScaleMode.Inherit;

            ChangeColor();

            ModeCB.SelectedIndex = 0;
            selectedMode = 0;
        }


        private void SourcesController(CheckBox cb, string sourceID)
        {
            if (cb.CheckState == CheckState.Checked)
            {
                Form1.Sources.Add(sourceID);
            }
            else
            {
                try
                {
                    foreach (var i in Form1.Sources)
                    {
                        if (i == sourceID)
                            Form1.Sources.Remove(i);
                    }
                }
                catch { }

            }

            try
            {
                foreach (var i in Form1.Sources)
                {
                    if (i == "")
                        Form1.Sources.Remove(i);
                }
            }
            catch { }
        }


        public void SelectAll()
        {            
            Form1.Sources.Add("ABC News");
            Form1.Sources.Add("BBC news");
            Form1.Sources.Add("Bloomberg");
            Form1.Sources.Add("Die Zeit");
            Form1.Sources.Add("CNN");
            Form1.Sources.Add("Google News");
            Form1.Sources.Add("TechCrunch");
            Form1.Sources.Add("Reddit /r/all");
            Form1.Sources.Add("RBC");
            Form1.Sources.Add("Lenta");
            Form1.Sources.Add("Rambler.ru");
            Form1.Sources.Add("Autoreview.ru");
            Form1.Sources.Add("RT");
            Form1.Sources.Add("Google News (Russia)");
            Form1.Sources.Add("Habr.com");
            Form1.Sources.Add("Ria.ru");

            try
            {
                foreach (var i in Form1.Sources)
                {
                    if (i == "")
                        Form1.Sources.Remove(i);
                }
            }
            catch { }
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            SourcesController(checkBox1, "ABC News");
            Form1.isParamChanged = true;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            SourcesController(checkBox2, "BBC news");
            Form1.isParamChanged = true;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            SourcesController(checkBox2, "Bloomberg");
            Form1.isParamChanged = true;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            SourcesController(checkBox4, "Die Zeit");
            Form1.isParamChanged = true;
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            SourcesController(checkBox5, "CNN");
            Form1.isParamChanged = true;
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            SourcesController(checkBox6, "Google News");
            Form1.isParamChanged = true;
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            SourcesController(checkBox7, "TechCrunch");
            Form1.isParamChanged = true;
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            SourcesController(checkBox8, "Reddit /r/all");
            Form1.isParamChanged = true;
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            SourcesController(checkBox9, "RBC");
            Form1.isParamChanged = true;
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            SourcesController(checkBox10, "Lenta");
            Form1.isParamChanged = true;
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            SourcesController(checkBox11, "Rambler.ru");
            Form1.isParamChanged = true;
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            SourcesController(checkBox12, "Autoreview.ru");
            Form1.isParamChanged = true;
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            SourcesController(checkBox13, "RT");
            Form1.isParamChanged = true;
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            SourcesController(checkBox1, "Google News (Russia)");
            Form1.isParamChanged = true;
        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            SourcesController(checkBox15, "Habr.com");
            Form1.isParamChanged = true;
        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            SourcesController(checkBox16, "Ria.ru");
            Form1.isParamChanged = true;
        }

        private void UC_Sources_BackColorChanged(object sender, EventArgs e)
        {
            ChangeColor();
        }

        private void ModeCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedMode = ModeCB.SelectedIndex;

            Form1.isParamChanged = true;
        }

        public void ChangeColor()
        {
            bottomPanel.BackColor = Form1.ThemeSetting;
            rightPanel.BackColor = Form1.ThemeSetting;

            if (Form1.ThemeSetting == Color.Black || Form1.ThemeSetting == Color.DarkBlue)
            {
                checkBox1.BackColor = this.BackColor;
                checkBox1.ForeColor = Color.White;

                checkBox2.BackColor = this.BackColor;
                checkBox2.ForeColor = Color.White;

                checkBox3.BackColor = this.BackColor;
                checkBox3.ForeColor = Color.White;

                checkBox4.BackColor = this.BackColor;
                checkBox4.ForeColor = Color.White;

                checkBox5.BackColor = this.BackColor;
                checkBox5.ForeColor = Color.White;

                checkBox6.BackColor = this.BackColor;
                checkBox6.ForeColor = Color.White;

                checkBox7.BackColor = this.BackColor;
                checkBox7.ForeColor = Color.White;

                checkBox8.BackColor = this.BackColor;
                checkBox8.ForeColor = Color.White;

                checkBox9.BackColor = this.BackColor;
                checkBox9.ForeColor = Color.White;

                checkBox10.BackColor = this.BackColor;
                checkBox10.ForeColor = Color.White;

                checkBox11.BackColor = this.BackColor;
                checkBox11.ForeColor = Color.White;

                checkBox12.BackColor = this.BackColor;
                checkBox12.ForeColor = Color.White;

                checkBox13.BackColor = this.BackColor;
                checkBox13.ForeColor = Color.White;

                checkBox14.BackColor = this.BackColor;
                checkBox14.ForeColor = Color.White;

                checkBox15.BackColor = this.BackColor;
                checkBox15.ForeColor = Color.White;

                checkBox16.BackColor = this.BackColor;
                checkBox16.ForeColor = Color.White;

                ModeCB.BackColor = this.BackColor;
                ModeCB.ForeColor = Color.White;

                label1.ForeColor = Color.White;

                bottomPanel.BackColor = Form1.ThemeSetting;
                rightPanel.BackColor = Form1.ThemeSetting;
            }
            else
            {
                checkBox1.BackColor = this.BackColor;
                checkBox1.ForeColor = Color.Black;

                checkBox2.BackColor = this.BackColor;
                checkBox2.ForeColor = Color.Black;

                checkBox3.BackColor = this.BackColor;
                checkBox3.ForeColor = Color.Black;

                checkBox4.BackColor = this.BackColor;
                checkBox4.ForeColor = Color.Black;

                checkBox5.BackColor = this.BackColor;
                checkBox5.ForeColor = Color.Black;

                checkBox6.BackColor = this.BackColor;
                checkBox6.ForeColor = Color.Black;

                checkBox7.BackColor = this.BackColor;
                checkBox7.ForeColor = Color.Black;

                checkBox8.BackColor = this.BackColor;
                checkBox8.ForeColor = Color.Black;

                checkBox9.BackColor = this.BackColor;
                checkBox9.ForeColor = Color.Black;

                checkBox10.BackColor = this.BackColor;
                checkBox10.ForeColor = Color.Black;

                checkBox11.BackColor = this.BackColor;
                checkBox11.ForeColor = Color.Black;

                checkBox12.BackColor = this.BackColor;
                checkBox12.ForeColor = Color.Black;

                checkBox13.BackColor = this.BackColor;
                checkBox13.ForeColor = Color.Black;

                checkBox14.BackColor = this.BackColor;
                checkBox14.ForeColor = Color.Black;

                checkBox15.BackColor = this.BackColor;
                checkBox15.ForeColor = Color.Black;

                checkBox16.BackColor = this.BackColor;
                checkBox16.ForeColor = Color.Black;

                ModeCB.BackColor = Color.WhiteSmoke;
                ModeCB.ForeColor = Color.Black;

                label1.ForeColor = Color.Black;

                bottomPanel.BackColor = Form1.ThemeSetting;
                rightPanel.BackColor = Form1.ThemeSetting;
            }
        }

        public void SetLanguage()
        {
            int index = ModeCB.SelectedIndex;

            if (Form1.InterfaceLanguage == "en")
            {
                label1.Text = "Select youre mode";

                ModeCB.Items.Clear();
                ModeCB.Items.Add("All sources");
                ModeCB.Items.Add("Custom sources");
            }
            else
            {
                label1.Text = "Выберите режим";

                ModeCB.Items.Clear();
                ModeCB.Items.Add("Все источники");
                ModeCB.Items.Add("Выбранные источники");
            }

            ModeCB.SelectedIndex = index;
        }
    }
}
