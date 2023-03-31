
namespace Adalyn_Pizza
{
    partial class Receipt
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.txtPostcode = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblStreet = new System.Windows.Forms.Label();
            this.lblPostcode = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.bntPrint = new System.Windows.Forms.Button();
            this.btnComplete = new System.Windows.Forms.Button();
            this.listOrder = new System.Windows.Forms.ListView();
            this.item = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Location = new System.Drawing.Point(0, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(284, 46);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Thank you for using our Ordering service.\r\nhere is your receipt\r\n----------------" +
    "-----------------------------------------";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(12, 58);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(130, 23);
            this.txtName.TabIndex = 1;
            this.txtName.Visible = false;
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(12, 87);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.ReadOnly = true;
            this.txtStreet.Size = new System.Drawing.Size(130, 23);
            this.txtStreet.TabIndex = 2;
            this.txtStreet.Visible = false;
            // 
            // txtPostcode
            // 
            this.txtPostcode.Location = new System.Drawing.Point(12, 116);
            this.txtPostcode.Name = "txtPostcode";
            this.txtPostcode.ReadOnly = true;
            this.txtPostcode.Size = new System.Drawing.Size(130, 23);
            this.txtPostcode.TabIndex = 3;
            this.txtPostcode.Visible = false;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(12, 145);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.ReadOnly = true;
            this.txtPhone.Size = new System.Drawing.Size(130, 23);
            this.txtPhone.TabIndex = 4;
            this.txtPhone.Visible = false;
            this.txtPhone.TextChanged += new System.EventHandler(this.txtPhone_TextChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(148, 61);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(39, 15);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Name";
            this.lblName.Visible = false;
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Location = new System.Drawing.Point(148, 90);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(49, 15);
            this.lblStreet.TabIndex = 6;
            this.lblStreet.Text = "Address";
            this.lblStreet.Visible = false;
            // 
            // lblPostcode
            // 
            this.lblPostcode.AutoSize = true;
            this.lblPostcode.Location = new System.Drawing.Point(148, 119);
            this.lblPostcode.Name = "lblPostcode";
            this.lblPostcode.Size = new System.Drawing.Size(56, 15);
            this.lblPostcode.TabIndex = 7;
            this.lblPostcode.Text = "Postcode";
            this.lblPostcode.Visible = false;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(148, 148);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(83, 15);
            this.lblPhone.TabIndex = 8;
            this.lblPhone.Text = "Phonenumber";
            this.lblPhone.Visible = false;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(12, 442);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(272, 23);
            this.txtPrice.TabIndex = 10;
            // 
            // bntPrint
            // 
            this.bntPrint.Font = new System.Drawing.Font("Vineta BT", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.bntPrint.Location = new System.Drawing.Point(12, 471);
            this.bntPrint.Name = "bntPrint";
            this.bntPrint.Size = new System.Drawing.Size(272, 23);
            this.bntPrint.TabIndex = 11;
            this.bntPrint.Text = "Print Receipt";
            this.bntPrint.UseVisualStyleBackColor = true;
            this.bntPrint.Click += new System.EventHandler(this.bntPrint_Click);
            // 
            // btnComplete
            // 
            this.btnComplete.Font = new System.Drawing.Font("Vineta BT", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btnComplete.Location = new System.Drawing.Point(12, 500);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(272, 23);
            this.btnComplete.TabIndex = 12;
            this.btnComplete.Text = "Complete Order";
            this.btnComplete.UseVisualStyleBackColor = true;
            // 
            // listOrder
            // 
            this.listOrder.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.item});
            this.listOrder.HideSelection = false;
            this.listOrder.Location = new System.Drawing.Point(12, 174);
            this.listOrder.Name = "listOrder";
            this.listOrder.Size = new System.Drawing.Size(272, 262);
            this.listOrder.TabIndex = 13;
            this.listOrder.UseCompatibleStateImageBehavior = false;
            this.listOrder.SelectedIndexChanged += new System.EventHandler(this.listOrder_SelectedIndexChanged);
            // 
            // item
            // 
            this.item.Text = "RECEIPT";
            // 
            // Receipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 662);
            this.Controls.Add(this.listOrder);
            this.Controls.Add(this.btnComplete);
            this.Controls.Add(this.bntPrint);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblPostcode);
            this.Controls.Add(this.lblStreet);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtPostcode);
            this.Controls.Add(this.txtStreet);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblTitle);
            this.Name = "Receipt";
            this.Text = "Receipt";
            this.Load += new System.EventHandler(this.Receipt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.TextBox txtPostcode;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.Label lblPostcode;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button bntPrint;
        private System.Windows.Forms.Button btnComplete;
        private System.Windows.Forms.ListView listOrder;
        private System.Windows.Forms.ColumnHeader item;
        private System.Windows.Forms.ColumnHeader price;
    }
}