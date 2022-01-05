
namespace IvyWarehouseManagement.Forms
{
    partial class Dashboard
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
            this.importTable = new System.Windows.Forms.DataGridView();
            this.exportTable = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIncome = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSpend = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTurnover = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.importTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exportTable)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // importTable
            // 
            this.importTable.AllowUserToAddRows = false;
            this.importTable.AllowUserToDeleteRows = false;
            this.importTable.AllowUserToResizeColumns = false;
            this.importTable.AllowUserToResizeRows = false;
            this.importTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.importTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(219)))), ((int)(((byte)(252)))));
            this.importTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.importTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.importTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.importTable.Location = new System.Drawing.Point(49, 35);
            this.importTable.Name = "importTable";
            this.importTable.RowHeadersVisible = false;
            this.importTable.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.importTable.RowTemplate.Height = 35;
            this.importTable.Size = new System.Drawing.Size(600, 178);
            this.importTable.TabIndex = 0;
            // 
            // exportTable
            // 
            this.exportTable.AllowUserToAddRows = false;
            this.exportTable.AllowUserToDeleteRows = false;
            this.exportTable.AllowUserToResizeColumns = false;
            this.exportTable.AllowUserToResizeRows = false;
            this.exportTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.exportTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(219)))), ((int)(((byte)(252)))));
            this.exportTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.exportTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.exportTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.exportTable.Location = new System.Drawing.Point(49, 256);
            this.exportTable.Name = "exportTable";
            this.exportTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.exportTable.RowHeadersVisible = false;
            this.exportTable.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.exportTable.RowTemplate.Height = 35;
            this.exportTable.Size = new System.Drawing.Size(600, 178);
            this.exportTable.TabIndex = 1;
            this.exportTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.exportTable_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Import Table";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Export Table";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(219)))), ((int)(((byte)(252)))));
            this.panel1.Controls.Add(this.txtTurnover);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtSpend);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtIncome);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(720, 273);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(179, 170);
            this.panel1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 28);
            this.label3.TabIndex = 0;
            this.label3.Text = "Income:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtIncome
            // 
            this.txtIncome.Location = new System.Drawing.Point(12, 37);
            this.txtIncome.Name = "txtIncome";
            this.txtIncome.Size = new System.Drawing.Size(161, 24);
            this.txtIncome.TabIndex = 1;
            this.txtIncome.Text = "label4";
            this.txtIncome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label5.Location = new System.Drawing.Point(12, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 27);
            this.label5.TabIndex = 2;
            this.label5.Text = "Spend: ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSpend
            // 
            this.txtSpend.Location = new System.Drawing.Point(12, 88);
            this.txtSpend.Name = "txtSpend";
            this.txtSpend.Size = new System.Drawing.Size(161, 26);
            this.txtSpend.TabIndex = 3;
            this.txtSpend.Text = "label6";
            this.txtSpend.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.label7.Location = new System.Drawing.Point(12, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 28);
            this.label7.TabIndex = 4;
            this.label7.Text = "Turnover:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTurnover
            // 
            this.txtTurnover.Location = new System.Drawing.Point(12, 140);
            this.txtTurnover.Name = "txtTurnover";
            this.txtTurnover.Size = new System.Drawing.Size(161, 26);
            this.txtTurnover.TabIndex = 5;
            this.txtTurnover.Text = "label8";
            this.txtTurnover.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(219)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(911, 464);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exportTable);
            this.Controls.Add(this.importTable);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.importTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exportTable)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView importTable;
        private System.Windows.Forms.DataGridView exportTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label txtTurnover;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label txtSpend;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label txtIncome;
        private System.Windows.Forms.Label label3;
    }
}