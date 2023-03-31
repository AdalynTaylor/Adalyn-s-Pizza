
namespace Adalyn_Pizza
{
    partial class deliver
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCustStreet = new System.Windows.Forms.TextBox();
            this.txtCustPostcode = new System.Windows.Forms.TextBox();
            this.txtCustPhone = new System.Windows.Forms.TextBox();
            this.txtCustName = new System.Windows.Forms.TextBox();
            this.lblCustName = new System.Windows.Forms.Label();
            this.lblCustStreet = new System.Windows.Forms.Label();
            this.lblCustPostcode = new System.Windows.Forms.Label();
            this.lblCustPhone = new System.Windows.Forms.Label();
            this.btnSelectPizza = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "The Order shall be delivered to:";
            // 
            // txtCustStreet
            // 
            this.txtCustStreet.Enabled = false;
            this.txtCustStreet.Location = new System.Drawing.Point(12, 56);
            this.txtCustStreet.Name = "txtCustStreet";
            this.txtCustStreet.Size = new System.Drawing.Size(170, 23);
            this.txtCustStreet.TabIndex = 1;
            // 
            // txtCustPostcode
            // 
            this.txtCustPostcode.Enabled = false;
            this.txtCustPostcode.Location = new System.Drawing.Point(12, 85);
            this.txtCustPostcode.Name = "txtCustPostcode";
            this.txtCustPostcode.Size = new System.Drawing.Size(170, 23);
            this.txtCustPostcode.TabIndex = 2;
            // 
            // txtCustPhone
            // 
            this.txtCustPhone.Enabled = false;
            this.txtCustPhone.Location = new System.Drawing.Point(12, 114);
            this.txtCustPhone.Name = "txtCustPhone";
            this.txtCustPhone.Size = new System.Drawing.Size(170, 23);
            this.txtCustPhone.TabIndex = 3;
            // 
            // txtCustName
            // 
            this.txtCustName.Enabled = false;
            this.txtCustName.Location = new System.Drawing.Point(12, 27);
            this.txtCustName.Name = "txtCustName";
            this.txtCustName.Size = new System.Drawing.Size(170, 23);
            this.txtCustName.TabIndex = 4;
            // 
            // lblCustName
            // 
            this.lblCustName.AutoSize = true;
            this.lblCustName.Location = new System.Drawing.Point(186, 30);
            this.lblCustName.Name = "lblCustName";
            this.lblCustName.Size = new System.Drawing.Size(39, 15);
            this.lblCustName.TabIndex = 5;
            this.lblCustName.Text = "Name";
            // 
            // lblCustStreet
            // 
            this.lblCustStreet.AutoSize = true;
            this.lblCustStreet.Location = new System.Drawing.Point(186, 59);
            this.lblCustStreet.Name = "lblCustStreet";
            this.lblCustStreet.Size = new System.Drawing.Size(37, 15);
            this.lblCustStreet.TabIndex = 6;
            this.lblCustStreet.Text = "Street";
            // 
            // lblCustPostcode
            // 
            this.lblCustPostcode.AutoSize = true;
            this.lblCustPostcode.Location = new System.Drawing.Point(186, 88);
            this.lblCustPostcode.Name = "lblCustPostcode";
            this.lblCustPostcode.Size = new System.Drawing.Size(56, 15);
            this.lblCustPostcode.TabIndex = 7;
            this.lblCustPostcode.Text = "Postcode";
            // 
            // lblCustPhone
            // 
            this.lblCustPhone.AutoSize = true;
            this.lblCustPhone.Location = new System.Drawing.Point(186, 117);
            this.lblCustPhone.Name = "lblCustPhone";
            this.lblCustPhone.Size = new System.Drawing.Size(88, 15);
            this.lblCustPhone.TabIndex = 8;
            this.lblCustPhone.Text = "Phone Number";
            // 
            // btnSelectPizza
            // 
            this.btnSelectPizza.Font = new System.Drawing.Font("Vineta BT", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btnSelectPizza.Location = new System.Drawing.Point(10, 143);
            this.btnSelectPizza.Name = "btnSelectPizza";
            this.btnSelectPizza.Size = new System.Drawing.Size(119, 88);
            this.btnSelectPizza.TabIndex = 9;
            this.btnSelectPizza.Text = "Select Pizza";
            this.btnSelectPizza.UseVisualStyleBackColor = true;
            this.btnSelectPizza.Click += new System.EventHandler(this.btnSelectPizza_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Vineta BT", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btnBack.Location = new System.Drawing.Point(135, 143);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(139, 88);
            this.btnBack.TabIndex = 10;
            this.btnBack.Text = "Incorrect? Go back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // deliver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 234);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSelectPizza);
            this.Controls.Add(this.lblCustPhone);
            this.Controls.Add(this.lblCustPostcode);
            this.Controls.Add(this.lblCustStreet);
            this.Controls.Add(this.lblCustName);
            this.Controls.Add(this.txtCustName);
            this.Controls.Add(this.txtCustPhone);
            this.Controls.Add(this.txtCustPostcode);
            this.Controls.Add(this.txtCustStreet);
            this.Controls.Add(this.label1);
            this.Name = "deliver";
            this.Text = "Deliver";
            this.Load += new System.EventHandler(this.deliver_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCustStreet;
        private System.Windows.Forms.TextBox txtCustPostcode;
        private System.Windows.Forms.TextBox txtCustPhone;
        private System.Windows.Forms.TextBox txtCustName;
        private System.Windows.Forms.Label lblCustName;
        private System.Windows.Forms.Label lblCustStreet;
        private System.Windows.Forms.Label lblCustPostcode;
        private System.Windows.Forms.Label lblCustPhone;
        private System.Windows.Forms.Button btnSelectPizza;
        private System.Windows.Forms.Button btnBack;
    }
}