using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using IvyWarehouseManagement.Forms;

namespace IvyWarehouseManagement
{
    public partial class MainInterface : Form
    {
        private IconButton currentBtn;
        private Panel leftBorder;
        private Form currentChildForm;
        public MainInterface()
        {
            InitializeComponent();
            leftBorder = new Panel();
            leftBorder.Size = new Size(10, 60);
            Menu.Controls.Add(leftBorder);
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        // Button execute
        private void ActivateBtn(object sender, Color color)
        {
            if(sender != null)
            {
                DisableBtn();
                currentBtn = (IconButton)sender;
                currentBtn.BackColor = Color.FromArgb(143, 176, 239);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                leftBorder.BackColor = color;
                leftBorder.Location = new Point(0, currentBtn.Location.Y);
                leftBorder.Visible = true;
                leftBorder.BringToFront();
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = color;
            }
        }
        private struct colorBoard
        {
            public static Color clickColor = Color.FromArgb(61, 88, 155);
            public static Color clickColor2 = Color.FromArgb(204, 184, 250);
            public static Color clickColor3 = Color.FromArgb(230, 250, 183);
        }
        private void DisableBtn() {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(181, 203, 249);
                currentBtn.ForeColor = Color.White;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.White;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        // Onclick Execute
       


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MainInterface_Load(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void OpenChildForm(Form childForm)
        {
            if(currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            labelChild.Text = childForm.Text;
        }

        private void dashboard_Click(object sender, EventArgs e)
        {
            ActivateBtn(sender, colorBoard.clickColor);
            OpenChildForm(new Dashboard());
        }

        private void import_Click(object sender, EventArgs e)
        {
            ActivateBtn(sender, colorBoard.clickColor);
            OpenChildForm(new Import());
        }

        private void export_Click(object sender, EventArgs e)
        {
            ActivateBtn(sender, colorBoard.clickColor);
            OpenChildForm(new Export());
        }

        private void Reset()
        {
            DisableBtn();
            leftBorder.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.FromArgb(61, 88, 155);
            labelChild.Text = "Home"; 
        }

        private void labelChild_MouseDown(object sender, MouseEventArgs e)
        {

        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void home_Click(object sender, EventArgs e)
        {
            currentChildForm.Close();
            Reset();
        }

        private void labelChild_Click(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void maximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void day_Click(object sender, EventArgs e)
        {

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            time.Text = DateTime.Now.ToString("HH:mm:ss");
            day.Text = DateTime.Now.ToString("dd/MM/yyyy");

        }
    }
}
