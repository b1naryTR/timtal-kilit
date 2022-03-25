using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace timtal_tahta
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
            this.TopMost = true;
            this.ShowInTaskbar = false;
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Form_KeyDown);
            label1.AutoSize = false;
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Dock = DockStyle.Fill;
            timer1.Start();
            GoFullscreen(true);



        }

        void GoFullscreen(bool fullscreen)
        {
            if (fullscreen)
            {
                this.WindowState = FormWindowState.Normal;
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                this.Bounds = Screen.PrimaryScreen.Bounds;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            }
        }

        void Form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.K)     
            {
                Application.Exit();
            }
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            switch (e.CloseReason)
            {
                case CloseReason.UserClosing:
                    e.Cancel = true;
                    break;
            }

            base.OnFormClosing(e);
        }

        private void label1_Click(object sender, EventArgs e)
        {
        
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //int result = DateTime.Compare(DateTime.Now, );
            label2.AutoSize = false;
            label2.Text = DateTime.Now.ToString("HH:mm");
            label2.TextAlign = ContentAlignment.TopLeft;

            if (label2.Text == "00:00")
            {

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (Convert.ToInt32(textBox1.Text.Trim()) > 24)
                {
                    MessageBox.Show("Değer 24'ten küçük olmalıdır");
                    textBox1.Text = "";
                }
                else
                {
                    int saat1 = Convert.ToInt32(textBox1.Text.Trim());

                }
            }
        }

        private void dogrula24_Text(object sender, CancelEventArgs e)
        {
            TextBox tb = sender as TextBox;
            if (tb != null)
            {
                int i;
                if (int.TryParse(tb.Text, out i))
                {
                    if (i >= 0 && i <= 24)
                        return;
                }
            }
            MessageBox.Show("invalid input");
            e.Cancel = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {
            if (textBox18.Text != "")
            {
                if (Convert.ToInt32(textBox18.Text.Trim()) > 60)
                {
                    MessageBox.Show("Değer 60'dan küçük olmalıdır");
                    textBox18.Text = "";
                }
                else
                {
                    int dk1 = Convert.ToInt32(textBox18.Text.Trim());

                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                if (Convert.ToInt32(textBox2.Text.Trim()) > 24)
                {
                    MessageBox.Show("Değer 24'ten küçük olmalıdır");
                    textBox2.Text = "";
                }
                else
                {
                    int saat2 = Convert.ToInt32(textBox2.Text.Trim());

                }
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text != "")
            {
                if (Convert.ToInt32(textBox3.Text.Trim()) > 24)
                {
                    MessageBox.Show("Değer 24'ten küçük olmalıdır");
                    textBox3.Text = "";
                }
                else
                {
                    int saat3 = Convert.ToInt32(textBox3.Text.Trim());

                }
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox4.Text != "")
            {
                if (Convert.ToInt32(textBox4.Text.Trim()) > 24)
                {
                    MessageBox.Show("Değer 24'ten küçük olmalıdır");
                    textBox4.Text = "";
                }
                else
                {
                    int saat4 = Convert.ToInt32(textBox4.Text.Trim());

                }
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (textBox5.Text != "")
            {
                if (Convert.ToInt32(textBox5.Text.Trim()) > 24)
                {
                    MessageBox.Show("Değer 24'ten küçük olmalıdır");
                    textBox5.Text = "";
                }
                else
                {
                    int saat5 = Convert.ToInt32(textBox5.Text.Trim());

                }
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (textBox6.Text != "")
            {
                if (Convert.ToInt32(textBox6.Text.Trim()) > 24)
                {
                    MessageBox.Show("Değer 24'ten küçük olmalıdır");
                    textBox6.Text = "";
                }
                else
                {
                    int saat6 = Convert.ToInt32(textBox6.Text.Trim());

                }
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            if (textBox7.Text != "")
            {
                if (Convert.ToInt32(textBox7.Text.Trim()) > 24)
                {
                    MessageBox.Show("Değer 24'ten küçük olmalıdır");
                    textBox7.Text = "";
                }
                else
                {
                    int saat7 = Convert.ToInt32(textBox7.Text.Trim());

                }
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            if (textBox8.Text != "")
            {
                if (Convert.ToInt32(textBox8.Text.Trim()) > 24)
                {
                    MessageBox.Show("Değer 24'ten küçük olmalıdır");
                    textBox8.Text = "";
                }
                else
                {
                    int saat8 = Convert.ToInt32(textBox8.Text.Trim());

                }
            }
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            if (textBox9.Text != "")
            {
                if (Convert.ToInt32(textBox9.Text.Trim()) > 24)
                {
                    MessageBox.Show("Değer 24'ten küçük olmalıdır");
                    textBox9.Text = "";
                }
                else
                {
                    int saat9 = Convert.ToInt32(textBox9.Text.Trim());

                }
            }
        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {
            if (textBox17.Text != "")
            {
                if (Convert.ToInt32(textBox17.Text.Trim()) > 60)
                {
                    MessageBox.Show("Değer 60'dan küçük olmalıdır");
                    textBox17.Text = "";
                }
                else
                {
                    int dk2 = Convert.ToInt32(textBox17.Text.Trim());

                }
            }
        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {
            if (textBox16.Text != "")
            {
                if (Convert.ToInt32(textBox16.Text.Trim()) > 60)
                {
                    MessageBox.Show("Değer 60'dan küçük olmalıdır");
                    textBox16.Text = "";
                }
                else
                {
                    int dk3 = Convert.ToInt32(textBox16.Text.Trim());

                }
            }
        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {
            if (textBox15.Text != "")
            {
                if (Convert.ToInt32(textBox15.Text.Trim()) > 60)
                {
                    MessageBox.Show("Değer 60'dan küçük olmalıdır");
                    textBox15.Text = "";
                }
                else
                {
                    int dk4 = Convert.ToInt32(textBox15.Text.Trim());

                }
            }
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {
            if (textBox14.Text != "")
            {
                if (Convert.ToInt32(textBox14.Text.Trim()) > 60)
                {
                    MessageBox.Show("Değer 60'dan küçük olmalıdır");
                    textBox14.Text = "";
                }
                else
                {
                    int dk5 = Convert.ToInt32(textBox14.Text.Trim());

                }
            }
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            if (textBox13.Text != "")
            {
                if (Convert.ToInt32(textBox13.Text.Trim()) > 60)
                {
                    MessageBox.Show("Değer 60'dan küçük olmalıdır");
                    textBox13.Text = "";
                }
                else
                {
                    int dk6 = Convert.ToInt32(textBox13.Text.Trim());

                }
            }
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            if (textBox12.Text != "")
            {
                if (Convert.ToInt32(textBox12.Text.Trim()) > 60)
                {
                    MessageBox.Show("Değer 60'dan küçük olmalıdır");
                    textBox12.Text = "";
                }
                else
                {
                    int dk7 = Convert.ToInt32(textBox12.Text.Trim());

                }
            }
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            if (textBox11.Text != "")
            {
                if (Convert.ToInt32(textBox11.Text.Trim()) > 60)
                {
                    MessageBox.Show("Değer 60'dan küçük olmalıdır");
                    textBox11.Text = "";
                }
                else
                {
                    int dk8 = Convert.ToInt32(textBox11.Text.Trim());

                }
            }
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            if (textBox10.Text != "")
            {
                if (Convert.ToInt32(textBox10.Text.Trim()) > 60)
                {
                    MessageBox.Show("Değer 60'dan küçük olmalıdır");
                    textBox10.Text = "";
                }
                else
                {
                    int dk9 = Convert.ToInt32(textBox10.Text.Trim());

                }
            }
        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    }

