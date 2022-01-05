
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.AreYouSure = new System.Windows.Forms.Panel();
            this.nobtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.yesbtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.update = new FontAwesome.Sharp.IconButton();
            this.orderTable = new System.Windows.Forms.DataGridView();
            this.exportTable = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.AreYouSure.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exportTable)).BeginInit();
            this.SuspendLayout();
            // 
            // AreYouSure
            // 
            this.AreYouSure.BackColor = System.Drawing.Color.White;
            this.AreYouSure.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AreYouSure.Controls.Add(this.exportTable);
            this.AreYouSure.Controls.Add(this.label3);
            this.AreYouSure.Controls.Add(this.nobtn);
            this.AreYouSure.Controls.Add(this.yesbtn);
            this.AreYouSure.Controls.Add(this.label1);
            this.AreYouSure.Location = new System.Drawing.Point(87, 31);
            this.AreYouSure.Name = "AreYouSure";
            this.AreYouSure.Size = new System.Drawing.Size(741, 394);
            this.AreYouSure.TabIndex = 7;
            this.AreYouSure.Visible = false;
            // 
            // nobtn
            // 
            this.nobtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(219)))), ((int)(((byte)(252)))));
            this.nobtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nobtn.FlatAppearance.BorderSize = 0;
            this.nobtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.nobtn.Location = new System.Drawing.Point(547, 345);
            this.nobtn.Name = "nobtn";
            this.nobtn.Size = new System.Drawing.Size(77, 31);
            this.nobtn.TabIndex = 10;
            this.nobtn.Text = "NO";
            this.nobtn.UseVisualStyleBackColor = false;
            this.nobtn.Click += new System.EventHandler(this.nobtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(454, 315);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Do you want to export this order?";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // yesbtn
            // 
            this.yesbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(219)))), ((int)(((byte)(252)))));
            this.yesbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.yesbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.yesbtn.Location = new System.Drawing.Point(630, 345);
            this.yesbtn.Name = "yesbtn";
            this.yesbtn.Size = new System.Drawing.Size(77, 31);
            this.yesbtn.TabIndex = 9;
            this.yesbtn.Text = "YES";
            this.yesbtn.UseVisualStyleBackColor = false;
            this.yesbtn.Click += new System.EventHandler(this.yesbtn_Click);
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
            // update
            // 
            this.update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.update.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.update.IconColor = System.Drawing.Color.Black;
            this.update.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.update.IconSize = 25;
            this.update.Location = new System.Drawing.Point(727, 78);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(99, 47);
            this.update.TabIndex = 6;
            this.update.Text = "Export";
            this.update.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // orderTable
            // 
            this.orderTable.AllowUserToAddRows = false;
            this.orderTable.AllowUserToDeleteRows = false;
            this.orderTable.AllowUserToResizeColumns = false;
            this.orderTable.AllowUserToResizeRows = false;
            this.orderTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.orderTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(219)))), ((int)(((byte)(252)))));
            this.orderTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.orderTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.orderTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderTable.Location = new System.Drawing.Point(87, 78);
            this.orderTable.MultiSelect = false;
            this.orderTable.Name = "orderTable";
            this.orderTable.RowHeadersVisible = false;
            this.orderTable.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.orderTable.RowTemplate.Height = 35;
            this.orderTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.orderTable.Size = new System.Drawing.Size(608, 374);
            this.orderTable.TabIndex = 10;
            this.orderTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.orderTable_CellContentClick);
            // 
            // exportTable
            // 
            this.exportTable.AllowUserToAddRows = false;
            this.exportTable.AllowUserToDeleteRows = false;
            this.exportTable.AllowUserToResizeColumns = false;
            this.exportTable.AllowUserToResizeRows = false;
            this.exportTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.exportTable.BackgroundColor = System.Drawing.Color.White;
            this.exportTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.exportTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.exportTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(219)))), ((int)(((byte)(252)))));
            this.exportTable.Location = new System.Drawing.Point(29, 47);
            this.exportTable.Name = "exportTable";
            this.exportTable.RowHeadersVisible = false;
            this.exportTable.ShowCellErrors = false;
            this.exportTable.ShowCellToolTips = false;
            this.exportTable.ShowEditingIcon = false;
            this.exportTable.ShowRowErrors = false;
            this.exportTable.Size = new System.Drawing.Size(678, 257);
            this.exportTable.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Order detailed information";
            // 
            // Export
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(219)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(911, 464);
            this.Controls.Add(this.AreYouSure);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.update);
            this.Controls.Add(this.orderTable);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Export";
            this.Text = "Export";
            this.Load += new System.EventHandler(this.Export_Load);
            this.AreYouSure.ResumeLayout(false);
            this.AreYouSure.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exportTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FontAwesome.Sharp.IconButton update;
        private System.Windows.Forms.Panel AreYouSure;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button nobtn;
        private System.Windows.Forms.Button yesbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView orderTable;
        private System.Windows.Forms.DataGridView exportTable;
        private System.Windows.Forms.Label label3;
    }
}