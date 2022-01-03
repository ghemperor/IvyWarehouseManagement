
namespace IvyWarehouseManagement.Forms
{
    partial class Import
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.importTable = new System.Windows.Forms.DataGridView();
            this.AreYouSure = new System.Windows.Forms.Panel();
            this.nobtn = new System.Windows.Forms.Button();
            this.yesbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.update = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.importTable)).BeginInit();
            this.AreYouSure.SuspendLayout();
            this.SuspendLayout();
            // 
            // importTable
            // 
            this.importTable.AllowUserToAddRows = false;
            this.importTable.AllowUserToDeleteRows = false;
            this.importTable.AllowUserToResizeRows = false;
            this.importTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.importTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(219)))), ((int)(((byte)(252)))));
            this.importTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.importTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.importTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.importTable.GridColor = System.Drawing.SystemColors.ControlLight;
            this.importTable.Location = new System.Drawing.Point(87, 78);
            this.importTable.Name = "importTable";
            this.importTable.RowHeadersVisible = false;
            this.importTable.RowTemplate.DefaultCellStyle.NullValue = "0";
            this.importTable.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.importTable.RowTemplate.Height = 35;
            this.importTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.importTable.Size = new System.Drawing.Size(608, 374);
            this.importTable.TabIndex = 0;
            // 
            // AreYouSure
            // 
            this.AreYouSure.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(239)))), ((int)(((byte)(251)))));
            this.AreYouSure.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AreYouSure.Controls.Add(this.nobtn);
            this.AreYouSure.Controls.Add(this.yesbtn);
            this.AreYouSure.Controls.Add(this.label1);
            this.AreYouSure.Location = new System.Drawing.Point(290, 116);
            this.AreYouSure.Name = "AreYouSure";
            this.AreYouSure.Size = new System.Drawing.Size(347, 184);
            this.AreYouSure.TabIndex = 1;
            this.AreYouSure.Visible = false;
            // 
            // nobtn
            // 
            this.nobtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nobtn.Location = new System.Drawing.Point(196, 116);
            this.nobtn.Name = "nobtn";
            this.nobtn.Size = new System.Drawing.Size(75, 23);
            this.nobtn.TabIndex = 2;
            this.nobtn.Text = "NO";
            this.nobtn.UseVisualStyleBackColor = true;
            this.nobtn.Click += new System.EventHandler(this.nobtn_Click);
            // 
            // yesbtn
            // 
            this.yesbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.yesbtn.Location = new System.Drawing.Point(76, 116);
            this.yesbtn.Name = "yesbtn";
            this.yesbtn.Size = new System.Drawing.Size(75, 23);
            this.yesbtn.TabIndex = 1;
            this.yesbtn.Text = "YES";
            this.yesbtn.UseVisualStyleBackColor = true;
            this.yesbtn.Click += new System.EventHandler(this.yesbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Are you sure what you entered is correct?";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // update
            // 
            this.update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.update.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.update.IconColor = System.Drawing.Color.Black;
            this.update.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.update.IconSize = 25;
            this.update.Location = new System.Drawing.Point(714, 78);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(99, 47);
            this.update.TabIndex = 2;
            this.update.Text = "Import";
            this.update.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(83, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(404, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fill in \"Import\" box to update quantity in warehouse.";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Import
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(219)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(911, 464);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.update);
            this.Controls.Add(this.AreYouSure);
            this.Controls.Add(this.importTable);
            this.Name = "Import";
            this.Text = "Import";
            this.Load += new System.EventHandler(this.Import_Load);
            ((System.ComponentModel.ISupportInitialize)(this.importTable)).EndInit();
            this.AreYouSure.ResumeLayout(false);
            this.AreYouSure.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView importTable;
        private System.Windows.Forms.Panel AreYouSure;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button nobtn;
        private System.Windows.Forms.Button yesbtn;
        private FontAwesome.Sharp.IconButton update;
        private System.Windows.Forms.Label label2;
    }
}