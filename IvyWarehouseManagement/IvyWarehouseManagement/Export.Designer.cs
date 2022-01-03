
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.exportTable = new System.Windows.Forms.DataGridView();
            this.ordererList = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.update = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.exportTable)).BeginInit();
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.exportTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
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
            this.ordererList.Location = new System.Drawing.Point(718, 100);
            this.ordererList.Name = "ordererList";
            this.ordererList.Size = new System.Drawing.Size(164, 24);
            this.ordererList.TabIndex = 1;
            this.ordererList.SelectedIndexChanged += new System.EventHandler(this.ordererList_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(715, 78);
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
            this.update.Location = new System.Drawing.Point(718, 130);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(99, 47);
            this.update.TabIndex = 6;
            this.update.Text = "Export";
            this.update.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.update.UseVisualStyleBackColor = true;
            // 
            // Export
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(219)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(911, 464);
            this.Controls.Add(this.update);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ordererList);
            this.Controls.Add(this.exportTable);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Export";
            this.Text = "Export";
            this.Load += new System.EventHandler(this.Export_Load);
            ((System.ComponentModel.ISupportInitialize)(this.exportTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView exportTable;
        private System.Windows.Forms.ComboBox ordererList;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton update;
    }
}