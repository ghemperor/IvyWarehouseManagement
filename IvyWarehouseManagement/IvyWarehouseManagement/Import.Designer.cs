
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.importTable = new System.Windows.Forms.DataGridView();
            this.AreYouSure = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.yesbtn = new System.Windows.Forms.Button();
            this.nobtn = new System.Windows.Forms.Button();
            this.update = new FontAwesome.Sharp.IconButton();
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
            this.importTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(239)))), ((int)(((byte)(251)))));
            this.importTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.importTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.importTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.importTable.GridColor = System.Drawing.SystemColors.ControlLight;
            this.importTable.Location = new System.Drawing.Point(81, 36);
            this.importTable.Name = "importTable";
            this.importTable.RowHeadersVisible = false;
            this.importTable.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.importTable.RowTemplate.Height = 28;
            this.importTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.importTable.Size = new System.Drawing.Size(599, 393);
            this.importTable.TabIndex = 0;
            // 
            // AreYouSure
            // 
            this.AreYouSure.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.AreYouSure.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AreYouSure.Controls.Add(this.nobtn);
            this.AreYouSure.Controls.Add(this.yesbtn);
            this.AreYouSure.Controls.Add(this.label1);
            this.AreYouSure.Location = new System.Drawing.Point(300, 116);
            this.AreYouSure.Name = "AreYouSure";
            this.AreYouSure.Size = new System.Drawing.Size(326, 184);
            this.AreYouSure.TabIndex = 1;
            this.AreYouSure.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sure what you entered is correct?";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // yesbtn
            // 
            this.yesbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.yesbtn.Location = new System.Drawing.Point(66, 116);
            this.yesbtn.Name = "yesbtn";
            this.yesbtn.Size = new System.Drawing.Size(75, 23);
            this.yesbtn.TabIndex = 1;
            this.yesbtn.Text = "YES";
            this.yesbtn.UseVisualStyleBackColor = true;
            this.yesbtn.Click += new System.EventHandler(this.yesbtn_Click);
            // 
            // nobtn
            // 
            this.nobtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nobtn.Location = new System.Drawing.Point(181, 116);
            this.nobtn.Name = "nobtn";
            this.nobtn.Size = new System.Drawing.Size(75, 23);
            this.nobtn.TabIndex = 2;
            this.nobtn.Text = "NO";
            this.nobtn.UseVisualStyleBackColor = true;
            this.nobtn.Click += new System.EventHandler(this.nobtn_Click);
            // 
            // update
            // 
            this.update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.update.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.update.IconColor = System.Drawing.Color.Black;
            this.update.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.update.IconSize = 25;
            this.update.Location = new System.Drawing.Point(718, 36);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(99, 47);
            this.update.TabIndex = 2;
            this.update.Text = " Update";
            this.update.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // Import
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(239)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(911, 464);
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

        }

        #endregion

        private System.Windows.Forms.DataGridView importTable;
        private System.Windows.Forms.Panel AreYouSure;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button nobtn;
        private System.Windows.Forms.Button yesbtn;
        private FontAwesome.Sharp.IconButton update;
    }
}