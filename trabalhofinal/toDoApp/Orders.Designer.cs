
namespace toDoApp
{
    partial class Orders
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
            this.PanelOrder = new System.Windows.Forms.Panel();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureOrder = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.PanelOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelOrder
            // 
            this.PanelOrder.BackColor = System.Drawing.Color.White;
            this.PanelOrder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelOrder.Controls.Add(this.lblDescription);
            this.PanelOrder.Controls.Add(this.lblPrice);
            this.PanelOrder.Controls.Add(this.lblDate);
            this.PanelOrder.Controls.Add(this.lblId);
            this.PanelOrder.Controls.Add(this.label4);
            this.PanelOrder.Controls.Add(this.label3);
            this.PanelOrder.Controls.Add(this.label2);
            this.PanelOrder.Controls.Add(this.label1);
            this.PanelOrder.Controls.Add(this.pictureOrder);
            this.PanelOrder.Location = new System.Drawing.Point(12, 12);
            this.PanelOrder.Name = "PanelOrder";
            this.PanelOrder.Size = new System.Drawing.Size(320, 374);
            this.PanelOrder.TabIndex = 0;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(83, 135);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(11, 13);
            this.lblDescription.TabIndex = 8;
            this.lblDescription.Text = "*";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(173, 71);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(11, 13);
            this.lblPrice.TabIndex = 7;
            this.lblPrice.Text = "*";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(173, 44);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(11, 13);
            this.lblDate.TabIndex = 6;
            this.lblDate.Text = "*";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(173, 16);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(11, 13);
            this.lblId.TabIndex = 5;
            this.lblId.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(133, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Price:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(134, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Description:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(146, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID:";
            // 
            // pictureOrder
            // 
            this.pictureOrder.Location = new System.Drawing.Point(17, 16);
            this.pictureOrder.Name = "pictureOrder";
            this.pictureOrder.Size = new System.Drawing.Size(111, 103);
            this.pictureOrder.TabIndex = 0;
            this.pictureOrder.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(12, 392);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(94, 34);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 438);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.PanelOrder);
            this.Name = "Orders";
            this.Text = "Order";
            this.Load += new System.EventHandler(this.Orders_Load);
            this.Shown += new System.EventHandler(this.Orders_Shown);
            this.PanelOrder.ResumeLayout(false);
            this.PanelOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureOrder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelOrder;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureOrder;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Button btnExit;
    }
}