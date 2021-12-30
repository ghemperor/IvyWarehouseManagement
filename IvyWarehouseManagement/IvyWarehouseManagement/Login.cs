using System;
using System.Windows.Forms;

namespace IvyWarehouseManagement
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox5_MouseDown(object sender, MouseEventArgs e)
        {
            pwbox.UseSystemPasswordChar = false;
        }

        private void pictureBox5_MouseUp(object sender, MouseEventArgs e)
        {
            pwbox.UseSystemPasswordChar = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(userbox.Text.Equals("admin") && pwbox.Text.Equals("admin"))
            {
                MainInterface next = new MainInterface();
                this.Hide();
                next.ShowDialog();
                this.Close();
            }
            else
            {
                notifyIcon1.ShowBalloonTip(100, "Oops!", "Wrong username or password.", ToolTipIcon.Info);
            }
        }

        private void userbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
