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
                    //Başvuru yok ama silme program kapanırken açılıyo kendisi
            }

            base.OnFormClosing(e);
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

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Txt_saat(object sender, EventArgs e)
        {
            TextBox ydk_txt = sender as TextBox;
            if (ydk_txt.Text != "")
            {
                int veri = int.Parse(ydk_txt.Text);
                if (veri < 0 || veri > 23)
                {
                    MessageBox.Show("Girdiğiniz değer 24'ten küçük olmalıdır.");
                    ydk_txt.Clear();
                    
                }
            }
        }

        private void zamangiris1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tik_saat_panel(object sender, EventArgs e)
        {
            if (ders_saat_goster_gizle.Checked == true)
            {
                panel1.Visible = false;
            }
            else if (ders_saat_goster_gizle.Checked == false)
            {
                panel1.Visible = true;
            }
        }

        private void txt_dk(object sender, EventArgs e)
        {
            TextBox ydk_txt = sender as TextBox;
            if (ydk_txt.Text != "")
            {
                int veri = int.Parse(ydk_txt.Text);
                if (veri < 0 || veri > 61)
                {
                    MessageBox.Show("Girdiğiniz değer 60'tan küçük olmalıdır.");
                    ydk_txt.Clear();

                }
            }
        }
    }
}
/* private void textBox18_TextChanged(object sender, EventArgs e)
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
*/
