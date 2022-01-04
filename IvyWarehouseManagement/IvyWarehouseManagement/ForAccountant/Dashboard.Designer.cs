
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
            ((System.ComponentModel.ISupportInitialize)(this.importTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exportTable)).BeginInit();
            this.SuspendLayout();
            // 
            // importTable
            // 
            this.importTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(219)))), ((int)(((byte)(252)))));
            this.importTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.importTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.importTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.importTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.importTable.Location = new System.Drawing.Point(37, 107);
            this.importTable.Name = "importTable";
            this.importTable.RowHeadersVisible = false;
            this.importTable.RowTemplate.Height = 35;
            this.importTable.Size = new System.Drawing.Size(368, 316);
            this.importTable.TabIndex = 0;
            // 
            // exportTable
            // 
            this.exportTable.AllowUserToAddRows = false;
            this.exportTable.AllowUserToDeleteRows = false;
            this.exportTable.AllowUserToResizeColumns = false;
            this.exportTable.AllowUserToResizeRows = false;
            this.exportTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(219)))), ((int)(((byte)(252)))));
            this.exportTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.exportTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.exportTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.exportTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.exportTable.Location = new System.Drawing.Point(495, 107);
            this.exportTable.Name = "exportTable";
            this.exportTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.exportTable.RowHeadersVisible = false;
            this.exportTable.RowTemplate.Height = 35;
            this.exportTable.Size = new System.Drawing.Size(368, 316);
            this.exportTable.TabIndex = 1;
            this.exportTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.exportTable_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Import Table";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(492, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Export Table";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(219)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(911, 464);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exportTable);
            this.Controls.Add(this.importTable);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.importTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exportTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView importTable;
        private System.Windows.Forms.DataGridView exportTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}