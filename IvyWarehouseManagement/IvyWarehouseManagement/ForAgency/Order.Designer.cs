
namespace IvyWarehouseManagement
{
    partial class Order
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.orderTable = new System.Windows.Forms.DataGridView();
            this.update = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.AreYouSure = new System.Windows.Forms.Panel();
            this.nobtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.yesbtn = new System.Windows.Forms.Button();
            this.receivedNoteID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.orderTable)).BeginInit();
            this.AreYouSure.SuspendLayout();
            this.SuspendLayout();
            // 
            // orderTable
            // 
            this.orderTable.AllowUserToAddRows = false;
            this.orderTable.AllowUserToDeleteRows = false;
            this.orderTable.AllowUserToResizeColumns = false;
            this.orderTable.AllowUserToResizeRows = false;
            this.orderTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(219)))), ((int)(((byte)(252)))));
            this.orderTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.orderTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.orderTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderTable.Location = new System.Drawing.Point(87, 78);
            this.orderTable.Name = "orderTable";
            this.orderTable.RowHeadersVisible = false;
            this.orderTable.RowTemplate.Height = 35;
            this.orderTable.Size = new System.Drawing.Size(608, 374);
            this.orderTable.TabIndex = 0;
            // 
            // update
            // 
            this.update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.update.IconChar = FontAwesome.Sharp.IconChar.ShoppingBasket;
            this.update.IconColor = System.Drawing.Color.Black;
            this.update.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.update.IconSize = 25;
            this.update.Location = new System.Drawing.Point(744, 130);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(99, 47);
            this.update.TabIndex = 3;
            this.update.Text = "Order";
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
            this.label2.Size = new System.Drawing.Size(401, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Enter the quantity you want to buy in \"Quantity\" box";
            // 
            // AreYouSure
            // 
            this.AreYouSure.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(239)))), ((int)(((byte)(251)))));
            this.AreYouSure.Controls.Add(this.nobtn);
            this.AreYouSure.Controls.Add(this.label1);
            this.AreYouSure.Controls.Add(this.yesbtn);
            this.AreYouSure.Location = new System.Drawing.Point(290, 116);
            this.AreYouSure.Name = "AreYouSure";
            this.AreYouSure.Size = new System.Drawing.Size(347, 184);
            this.AreYouSure.TabIndex = 6;
            this.AreYouSure.Visible = false;
            // 
            // nobtn
            // 
            this.nobtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nobtn.Location = new System.Drawing.Point(196, 121);
            this.nobtn.Name = "nobtn";
            this.nobtn.Size = new System.Drawing.Size(75, 23);
            this.nobtn.TabIndex = 9;
            this.nobtn.Text = "NO";
            this.nobtn.UseVisualStyleBackColor = true;
            this.nobtn.Click += new System.EventHandler(this.nobtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "These are all the products you want to buy?";
            // 
            // yesbtn
            // 
            this.yesbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.yesbtn.Location = new System.Drawing.Point(76, 121);
            this.yesbtn.Name = "yesbtn";
            this.yesbtn.Size = new System.Drawing.Size(75, 23);
            this.yesbtn.TabIndex = 8;
            this.yesbtn.Text = "YES";
            this.yesbtn.UseVisualStyleBackColor = true;
            this.yesbtn.Click += new System.EventHandler(this.yesbtn_Click);
            // 
            // receivedNoteID
            // 
            this.receivedNoteID.Location = new System.Drawing.Point(744, 104);
            this.receivedNoteID.Name = "receivedNoteID";
            this.receivedNoteID.Size = new System.Drawing.Size(100, 20);
            this.receivedNoteID.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(741, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Create your order ID:";
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(219)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(911, 464);
            this.Controls.Add(this.receivedNoteID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AreYouSure);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.update);
            this.Controls.Add(this.orderTable);
            this.Name = "Order";
            this.Text = "Order";
            this.Load += new System.EventHandler(this.Order_Load);
            ((System.ComponentModel.ISupportInitialize)(this.orderTable)).EndInit();
            this.AreYouSure.ResumeLayout(false);
            this.AreYouSure.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView orderTable;
        private FontAwesome.Sharp.IconButton update;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel AreYouSure;
        private System.Windows.Forms.Button nobtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button yesbtn;
        private System.Windows.Forms.TextBox receivedNoteID;
        private System.Windows.Forms.Label label4;
    }
}