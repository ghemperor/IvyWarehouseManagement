
namespace IvyWarehouseManagement.Forms
{
    partial class Export
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.exportTable = new System.Windows.Forms.DataGridView();
            this.ordererList = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.update = new FontAwesome.Sharp.IconButton();
            this.AreYouSure = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.nobtn = new System.Windows.Forms.Button();
            this.yesbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.receivedNoteID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.exportTable)).BeginInit();
            this.AreYouSure.SuspendLayout();
            this.SuspendLayout();
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
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.exportTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.exportTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.exportTable.Location = new System.Drawing.Point(87, 78);
            this.exportTable.Name = "exportTable";
            this.exportTable.RowHeadersVisible = false;
            this.exportTable.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.exportTable.RowTemplate.Height = 35;
            this.exportTable.Size = new System.Drawing.Size(608, 374);
            this.exportTable.TabIndex = 0;
            // 
            // ordererList
            // 
            this.ordererList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ordererList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ordererList.FormattingEnabled = true;
            this.ordererList.Location = new System.Drawing.Point(717, 157);
            this.ordererList.Name = "ordererList";
            this.ordererList.Size = new System.Drawing.Size(164, 24);
            this.ordererList.TabIndex = 1;
            this.ordererList.SelectedIndexChanged += new System.EventHandler(this.ordererList_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(714, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Choose the agency:";
            // 
            // update
            // 
            this.update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.update.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.update.IconColor = System.Drawing.Color.Black;
            this.update.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.update.IconSize = 25;
            this.update.Location = new System.Drawing.Point(717, 187);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(99, 47);
            this.update.TabIndex = 6;
            this.update.Text = "Export";
            this.update.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // AreYouSure
            // 
            this.AreYouSure.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(239)))), ((int)(((byte)(251)))));
            this.AreYouSure.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AreYouSure.Controls.Add(this.nobtn);
            this.AreYouSure.Controls.Add(this.label1);
            this.AreYouSure.Controls.Add(this.yesbtn);
            this.AreYouSure.Location = new System.Drawing.Point(290, 116);
            this.AreYouSure.Name = "AreYouSure";
            this.AreYouSure.Size = new System.Drawing.Size(347, 184);
            this.AreYouSure.TabIndex = 7;
            this.AreYouSure.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(83, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(401, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fill in \"Export\" box to update quantity in warehouse.";
            // 
            // nobtn
            // 
            this.nobtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nobtn.Location = new System.Drawing.Point(196, 116);
            this.nobtn.Name = "nobtn";
            this.nobtn.Size = new System.Drawing.Size(75, 23);
            this.nobtn.TabIndex = 10;
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
            this.yesbtn.TabIndex = 9;
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
            this.label1.TabIndex = 8;
            this.label1.Text = "Are you sure what you entered is correct?";
            // 
            // receivedNoteID
            // 
            this.receivedNoteID.Location = new System.Drawing.Point(717, 104);
            this.receivedNoteID.Name = "receivedNoteID";
            this.receivedNoteID.Size = new System.Drawing.Size(100, 20);
            this.receivedNoteID.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(714, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Enter delivery note ID:";
            // 
            // Export
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(219)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(911, 464);
            this.Controls.Add(this.receivedNoteID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AreYouSure);
            this.Controls.Add(this.update);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ordererList);
            this.Controls.Add(this.exportTable);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Export";
            this.Text = "Export";
            this.Load += new System.EventHandler(this.Export_Load);
            ((System.ComponentModel.ISupportInitialize)(this.exportTable)).EndInit();
            this.AreYouSure.ResumeLayout(false);
            this.AreYouSure.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView exportTable;
        private System.Windows.Forms.ComboBox ordererList;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton update;
        private System.Windows.Forms.Panel AreYouSure;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button nobtn;
        private System.Windows.Forms.Button yesbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox receivedNoteID;
        private System.Windows.Forms.Label label4;
    }
}