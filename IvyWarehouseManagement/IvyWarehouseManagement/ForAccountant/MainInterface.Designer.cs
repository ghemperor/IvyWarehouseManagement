
namespace IvyWarehouseManagement
{
    partial class MainInterface
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainInterface));
            this.Menu = new System.Windows.Forms.Panel();
            this.export = new FontAwesome.Sharp.IconButton();
            this.import = new FontAwesome.Sharp.IconButton();
            this.dashboard = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.home = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.time = new System.Windows.Forms.Label();
            this.day = new System.Windows.Forms.Label();
            this.maximize = new FontAwesome.Sharp.IconPictureBox();
            this.minimize = new FontAwesome.Sharp.IconPictureBox();
            this.exit = new FontAwesome.Sharp.IconPictureBox();
            this.labelChild = new System.Windows.Forms.Label();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.account = new FontAwesome.Sharp.IconButton();
            this.Menu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.home)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(203)))), ((int)(((byte)(249)))));
            this.Menu.Controls.Add(this.account);
            this.Menu.Controls.Add(this.export);
            this.Menu.Controls.Add(this.import);
            this.Menu.Controls.Add(this.dashboard);
            this.Menu.Controls.Add(this.panelLogo);
            this.Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(220, 592);
            this.Menu.TabIndex = 0;
            // 
            // export
            // 
            this.export.Cursor = System.Windows.Forms.Cursors.Hand;
            this.export.Dock = System.Windows.Forms.DockStyle.Top;
            this.export.FlatAppearance.BorderSize = 0;
            this.export.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.export.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.export.ForeColor = System.Drawing.Color.White;
            this.export.IconChar = FontAwesome.Sharp.IconChar.ArrowCircleLeft;
            this.export.IconColor = System.Drawing.Color.White;
            this.export.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.export.IconSize = 38;
            this.export.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.export.Location = new System.Drawing.Point(0, 260);
            this.export.Name = "export";
            this.export.Size = new System.Drawing.Size(220, 60);
            this.export.TabIndex = 2;
            this.export.Text = "Export";
            this.export.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.export.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.export.UseVisualStyleBackColor = true;
            this.export.Click += new System.EventHandler(this.export_Click);
            // 
            // import
            // 
            this.import.Cursor = System.Windows.Forms.Cursors.Hand;
            this.import.Dock = System.Windows.Forms.DockStyle.Top;
            this.import.FlatAppearance.BorderSize = 0;
            this.import.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.import.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.import.ForeColor = System.Drawing.Color.White;
            this.import.IconChar = FontAwesome.Sharp.IconChar.ArrowCircleRight;
            this.import.IconColor = System.Drawing.Color.White;
            this.import.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.import.IconSize = 38;
            this.import.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.import.Location = new System.Drawing.Point(0, 200);
            this.import.Name = "import";
            this.import.Size = new System.Drawing.Size(220, 60);
            this.import.TabIndex = 1;
            this.import.Text = "Import";
            this.import.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.import.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.import.UseVisualStyleBackColor = true;
            this.import.Click += new System.EventHandler(this.import_Click);
            // 
            // dashboard
            // 
            this.dashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.dashboard.FlatAppearance.BorderSize = 0;
            this.dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboard.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboard.ForeColor = System.Drawing.Color.White;
            this.dashboard.IconChar = FontAwesome.Sharp.IconChar.ChartBar;
            this.dashboard.IconColor = System.Drawing.Color.White;
            this.dashboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.dashboard.IconSize = 38;
            this.dashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboard.Location = new System.Drawing.Point(0, 140);
            this.dashboard.Name = "dashboard";
            this.dashboard.Size = new System.Drawing.Size(220, 60);
            this.dashboard.TabIndex = 0;
            this.dashboard.Text = "Dashboard";
            this.dashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.dashboard.UseVisualStyleBackColor = true;
            this.dashboard.Click += new System.EventHandler(this.dashboard_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.label1);
            this.panelLogo.Controls.Add(this.home);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 140);
            this.panelLogo.TabIndex = 0;
            this.panelLogo.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "CORPORATION";
            // 
            // home
            // 
            this.home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.home.Image = global::IvyWarehouseManagement.Properties.Resources._24752648943_removebg_preview_removebg_preview;
            this.home.Location = new System.Drawing.Point(24, 12);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(163, 106);
            this.home.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.home.TabIndex = 0;
            this.home.TabStop = false;
            this.home.Click += new System.EventHandler(this.home_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(176)))), ((int)(((byte)(239)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.labelChild);
            this.panel1.Controls.Add(this.iconCurrentChildForm);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(220, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(927, 80);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.time);
            this.panel2.Controls.Add(this.day);
            this.panel2.Controls.Add(this.maximize);
            this.panel2.Controls.Add(this.minimize);
            this.panel2.Controls.Add(this.exit);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(815, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(112, 80);
            this.panel2.TabIndex = 5;
            // 
            // time
            // 
            this.time.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.time.AutoSize = true;
            this.time.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time.Location = new System.Drawing.Point(33, 64);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(55, 15);
            this.time.TabIndex = 6;
            this.time.Text = "18:04:00";
            // 
            // day
            // 
            this.day.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.day.AutoSize = true;
            this.day.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.day.Location = new System.Drawing.Point(16, 42);
            this.day.Name = "day";
            this.day.Size = new System.Drawing.Size(89, 20);
            this.day.TabIndex = 5;
            this.day.Text = "29/12/2021";
            this.day.Click += new System.EventHandler(this.day_Click);
            // 
            // maximize
            // 
            this.maximize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(176)))), ((int)(((byte)(239)))));
            this.maximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.maximize.ForeColor = System.Drawing.SystemColors.ControlText;
            this.maximize.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.maximize.IconColor = System.Drawing.SystemColors.ControlText;
            this.maximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.maximize.IconSize = 25;
            this.maximize.Location = new System.Drawing.Point(48, 5);
            this.maximize.Name = "maximize";
            this.maximize.Size = new System.Drawing.Size(25, 25);
            this.maximize.TabIndex = 3;
            this.maximize.TabStop = false;
            this.maximize.Click += new System.EventHandler(this.maximize_Click);
            // 
            // minimize
            // 
            this.minimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(176)))), ((int)(((byte)(239)))));
            this.minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimize.ForeColor = System.Drawing.SystemColors.ControlText;
            this.minimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.minimize.IconColor = System.Drawing.SystemColors.ControlText;
            this.minimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.minimize.IconSize = 25;
            this.minimize.Location = new System.Drawing.Point(16, 1);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(25, 25);
            this.minimize.TabIndex = 2;
            this.minimize.TabStop = false;
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(176)))), ((int)(((byte)(239)))));
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.exit.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.exit.IconColor = System.Drawing.SystemColors.ControlText;
            this.exit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.exit.IconSize = 25;
            this.exit.Location = new System.Drawing.Point(80, 5);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(25, 25);
            this.exit.TabIndex = 4;
            this.exit.TabStop = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // labelChild
            // 
            this.labelChild.AutoSize = true;
            this.labelChild.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChild.ForeColor = System.Drawing.Color.White;
            this.labelChild.Location = new System.Drawing.Point(59, 33);
            this.labelChild.Name = "labelChild";
            this.labelChild.Size = new System.Drawing.Size(66, 25);
            this.labelChild.TabIndex = 1;
            this.labelChild.Text = "Home";
            this.labelChild.Click += new System.EventHandler(this.labelChild_Click);
            this.labelChild.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelChild_MouseDown);
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(176)))), ((int)(((byte)(239)))));
            this.iconCurrentChildForm.ForeColor = System.Drawing.Color.GhostWhite;
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.GhostWhite;
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.IconSize = 40;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(20, 28);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(40, 40);
            this.iconCurrentChildForm.TabIndex = 0;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // panelShadow
            // 
            this.panelShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(176)))), ((int)(((byte)(239)))));
            this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShadow.Location = new System.Drawing.Point(220, 80);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(927, 9);
            this.panelShadow.TabIndex = 2;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(219)))), ((int)(((byte)(252)))));
            this.panelDesktop.Controls.Add(this.pictureBox1);
            this.panelDesktop.Controls.Add(this.label5);
            this.panelDesktop.Controls.Add(this.label3);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(220, 89);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(927, 503);
            this.panelDesktop.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(151, 152);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(625, 348);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(342, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(240, 36);
            this.label5.TabIndex = 7;
            this.label5.Text = "Welcome to the";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(164, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(612, 41);
            this.label3.TabIndex = 6;
            this.label3.Text = "WAREHOUSE MANAGEMENT SYSTEM";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // account
            // 
            this.account.AutoEllipsis = true;
            this.account.Cursor = System.Windows.Forms.Cursors.Hand;
            this.account.Dock = System.Windows.Forms.DockStyle.Top;
            this.account.FlatAppearance.BorderSize = 0;
            this.account.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.account.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.account.ForeColor = System.Drawing.Color.White;
            this.account.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.account.IconColor = System.Drawing.Color.White;
            this.account.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.account.IconSize = 38;
            this.account.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.account.Location = new System.Drawing.Point(0, 320);
            this.account.Name = "account";
            this.account.Size = new System.Drawing.Size(220, 60);
            this.account.TabIndex = 3;
            this.account.Text = "Account";
            this.account.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.account.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.account.UseVisualStyleBackColor = true;
            this.account.Click += new System.EventHandler(this.account_Click);
            // 
            // MainInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 592);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelShadow);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Menu);
            this.Name = "MainInterface";
            this.Text = "MainInterface";
            this.Load += new System.EventHandler(this.MainInterface_Load);
            this.Menu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.home)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.panelDesktop.ResumeLayout(false);
            this.panelDesktop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Menu;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton export;
        private FontAwesome.Sharp.IconButton import;
        private FontAwesome.Sharp.IconButton dashboard;
        private System.Windows.Forms.PictureBox home;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Label labelChild;
        private System.Windows.Forms.Panel panelShadow;
        private System.Windows.Forms.Panel panelDesktop;
        private FontAwesome.Sharp.IconPictureBox exit;
        private FontAwesome.Sharp.IconPictureBox maximize;
        private FontAwesome.Sharp.IconPictureBox minimize;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Label day;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton account;
    }
}