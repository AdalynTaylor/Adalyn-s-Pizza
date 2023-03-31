
namespace Adalyn_Pizza
{
    partial class CustomerDetails
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerDetails));
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblCustDetails = new System.Windows.Forms.Label();
            this.txtCustName = new System.Windows.Forms.TextBox();
            this.txtCustStreet = new System.Windows.Forms.TextBox();
            this.txtCustPostcode = new System.Windows.Forms.TextBox();
            this.txtCustPhone = new System.Windows.Forms.TextBox();
            this.lblCustName = new System.Windows.Forms.Label();
            this.lblCustStreet = new System.Windows.Forms.Label();
            this.lblCustPostcode = new System.Windows.Forms.Label();
            this.lblCustPhone = new System.Windows.Forms.Label();
            this.btnSelectPizza = new System.Windows.Forms.Button();
            this.btnDeliver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblInfo
            // 
            this.lblInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblInfo.Location = new System.Drawing.Point(-51, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(848, 86);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = resources.GetString("lblInfo.Text");
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblCustDetails
            // 
            this.lblCustDetails.Font = new System.Drawing.Font("Vineta BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCustDetails.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblCustDetails.Location = new System.Drawing.Point(237, 86);
            this.lblCustDetails.Name = "lblCustDetails";
            this.lblCustDetails.Size = new System.Drawing.Size(289, 23);
            this.lblCustDetails.TabIndex = 1;
            this.lblCustDetails.Text = "Customer Details";
            this.lblCustDetails.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtCustName
            // 
            this.txtCustName.Location = new System.Drawing.Point(135, 185);
            this.txtCustName.Name = "txtCustName";
            this.txtCustName.Size = new System.Drawing.Size(180, 23);
            this.txtCustName.TabIndex = 2;
            // 
            // txtCustStreet
            // 
            this.txtCustStreet.Location = new System.Drawing.Point(135, 237);
            this.txtCustStreet.Name = "txtCustStreet";
            this.txtCustStreet.Size = new System.Drawing.Size(180, 23);
            this.txtCustStreet.TabIndex = 3;
            // 
            // txtCustPostcode
            // 
            this.txtCustPostcode.Location = new System.Drawing.Point(466, 237);
            this.txtCustPostcode.Name = "txtCustPostcode";
            this.txtCustPostcode.Size = new System.Drawing.Size(180, 23);
            this.txtCustPostcode.TabIndex = 4;
            // 
            // txtCustPhone
            // 
            this.txtCustPhone.Location = new System.Drawing.Point(466, 185);
            this.txtCustPhone.Name = "txtCustPhone";
            this.txtCustPhone.Size = new System.Drawing.Size(180, 23);
            this.txtCustPhone.TabIndex = 5;
            this.txtCustPhone.TextChanged += new System.EventHandler(this.txtCustPhone_TextChanged);
            this.txtCustPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCustPhone_KeyPress);
            // 
            // lblCustName
            // 
            this.lblCustName.Location = new System.Drawing.Point(135, 159);
            this.lblCustName.Name = "lblCustName";
            this.lblCustName.Size = new System.Drawing.Size(180, 23);
            this.lblCustName.TabIndex = 6;
            this.lblCustName.Text = "Customer Name:";
            // 
            // lblCustStreet
            // 
            this.lblCustStreet.Location = new System.Drawing.Point(135, 211);
            this.lblCustStreet.Name = "lblCustStreet";
            this.lblCustStreet.Size = new System.Drawing.Size(180, 23);
            this.lblCustStreet.TabIndex = 7;
            this.lblCustStreet.Text = "Customer Street:";
            // 
            // lblCustPostcode
            // 
            this.lblCustPostcode.Location = new System.Drawing.Point(466, 159);
            this.lblCustPostcode.Name = "lblCustPostcode";
            this.lblCustPostcode.Size = new System.Drawing.Size(180, 23);
            this.lblCustPostcode.TabIndex = 8;
            this.lblCustPostcode.Text = "Customer Phonenumber:";
            // 
            // lblCustPhone
            // 
            this.lblCustPhone.Location = new System.Drawing.Point(466, 211);
            this.lblCustPhone.Name = "lblCustPhone";
            this.lblCustPhone.Size = new System.Drawing.Size(180, 23);
            this.lblCustPhone.TabIndex = 9;
            this.lblCustPhone.Text = "Customer Postcode:";
            // 
            // btnSelectPizza
            // 
            this.btnSelectPizza.Font = new System.Drawing.Font("Vineta BT", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btnSelectPizza.Location = new System.Drawing.Point(12, 159);
            this.btnSelectPizza.Name = "btnSelectPizza";
            this.btnSelectPizza.Size = new System.Drawing.Size(117, 117);
            this.btnSelectPizza.TabIndex = 10;
            this.btnSelectPizza.Text = "Select Pizza if no delivery needed";
            this.btnSelectPizza.UseVisualStyleBackColor = true;
            this.btnSelectPizza.Click += new System.EventHandler(this.btnSelectPizza_Click);
            // 
            // btnDeliver
            // 
            this.btnDeliver.Font = new System.Drawing.Font("Vineta BT", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btnDeliver.Location = new System.Drawing.Point(652, 159);
            this.btnDeliver.Name = "btnDeliver";
            this.btnDeliver.Size = new System.Drawing.Size(117, 118);
            this.btnDeliver.TabIndex = 11;
            this.btnDeliver.Text = "Deliver Pizza";
            this.btnDeliver.UseVisualStyleBackColor = true;
            this.btnDeliver.Click += new System.EventHandler(this.btnDeliver_Click);
            // 
            // CustomerDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 282);
            this.Controls.Add(this.btnDeliver);
            this.Controls.Add(this.btnSelectPizza);
            this.Controls.Add(this.lblCustPhone);
            this.Controls.Add(this.lblCustPostcode);
            this.Controls.Add(this.lblCustStreet);
            this.Controls.Add(this.lblCustName);
            this.Controls.Add(this.txtCustPhone);
            this.Controls.Add(this.txtCustPostcode);
            this.Controls.Add(this.txtCustStreet);
            this.Controls.Add(this.txtCustName);
            this.Controls.Add(this.lblCustDetails);
            this.Controls.Add(this.lblInfo);
            this.Name = "CustomerDetails";
            this.Text = "Order Pizza";
            this.Load += new System.EventHandler(this.CustomerDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblCustDetails;
        private System.Windows.Forms.TextBox txtCustName;
        private System.Windows.Forms.TextBox txtCustStreet;
        private System.Windows.Forms.TextBox txtCustPostcode;
        private System.Windows.Forms.TextBox txtCustPhone;
        private System.Windows.Forms.Label lblCustName;
        private System.Windows.Forms.Label lblCustStreet;
        private System.Windows.Forms.Label lblCustPostcode;
        private System.Windows.Forms.Label lblCustPhone;
        private System.Windows.Forms.Button btnSelectPizza;
        private System.Windows.Forms.Button btnDeliver;
    }
}

