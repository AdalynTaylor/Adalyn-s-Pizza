
namespace Adalyn_Pizza
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            boxTopping1 = new System.Windows.Forms.ComboBox();
            lblTitle = new System.Windows.Forms.Label();
            lblTopping1 = new System.Windows.Forms.Label();
            lblTopping2 = new System.Windows.Forms.Label();
            lblTopping3 = new System.Windows.Forms.Label();
            boxTopping2 = new System.Windows.Forms.ComboBox();
            boxTopping3 = new System.Windows.Forms.ComboBox();
            lblPizzaSize = new System.Windows.Forms.Label();
            boxPizzaSize = new System.Windows.Forms.ComboBox();
            boxCrust = new System.Windows.Forms.ComboBox();
            lblCrust = new System.Windows.Forms.Label();
            boxSauce = new System.Windows.Forms.ComboBox();
            lblSauce = new System.Windows.Forms.Label();
            boxSide = new System.Windows.Forms.ComboBox();
            lblSide = new System.Windows.Forms.Label();
            btnFinish = new System.Windows.Forms.Button();
            cmbExtra = new System.Windows.Forms.ComboBox();
            btnExtra = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // boxTopping1
            // 
            boxTopping1.FormattingEnabled = true;
            boxTopping1.Items.AddRange(new object[] { "Pepperoni", "Ham", "Extra Cheese", "Bacon", "Chicken" });
            boxTopping1.Location = new System.Drawing.Point(12, 72);
            boxTopping1.Name = "boxTopping1";
            boxTopping1.Size = new System.Drawing.Size(189, 23);
            boxTopping1.TabIndex = 0;
            boxTopping1.SelectedIndexChanged += boxTopping1_SelectedIndexChanged;
            // 
            // lblTitle
            // 
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblTitle.Location = new System.Drawing.Point(2, 1);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(434, 45);
            lblTitle.TabIndex = 1;
            lblTitle.Text = resources.GetString("lblTitle.Text");
            lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTopping1
            // 
            lblTopping1.AutoSize = true;
            lblTopping1.Location = new System.Drawing.Point(12, 54);
            lblTopping1.Name = "lblTopping1";
            lblTopping1.Size = new System.Drawing.Size(78, 15);
            lblTopping1.TabIndex = 2;
            lblTopping1.Text = "Topping One:";
            // 
            // lblTopping2
            // 
            lblTopping2.AutoSize = true;
            lblTopping2.Location = new System.Drawing.Point(12, 98);
            lblTopping2.Name = "lblTopping2";
            lblTopping2.Size = new System.Drawing.Size(77, 15);
            lblTopping2.TabIndex = 3;
            lblTopping2.Text = "Topping Two:";
            // 
            // lblTopping3
            // 
            lblTopping3.AutoSize = true;
            lblTopping3.Location = new System.Drawing.Point(12, 142);
            lblTopping3.Name = "lblTopping3";
            lblTopping3.Size = new System.Drawing.Size(85, 15);
            lblTopping3.TabIndex = 4;
            lblTopping3.Text = "Topping Three:";
            // 
            // boxTopping2
            // 
            boxTopping2.FormattingEnabled = true;
            boxTopping2.Items.AddRange(new object[] { "Pepperoni", "Ham", "Extra Cheese", "Bacon", "Chicken" });
            boxTopping2.Location = new System.Drawing.Point(12, 116);
            boxTopping2.Name = "boxTopping2";
            boxTopping2.Size = new System.Drawing.Size(189, 23);
            boxTopping2.TabIndex = 5;
            // 
            // boxTopping3
            // 
            boxTopping3.FormattingEnabled = true;
            boxTopping3.Items.AddRange(new object[] { "Pepperoni", "Ham", "Extra Cheese", "Bacon", "Chicken" });
            boxTopping3.Location = new System.Drawing.Point(12, 160);
            boxTopping3.Name = "boxTopping3";
            boxTopping3.Size = new System.Drawing.Size(189, 23);
            boxTopping3.TabIndex = 6;
            // 
            // lblPizzaSize
            // 
            lblPizzaSize.AutoSize = true;
            lblPizzaSize.Location = new System.Drawing.Point(235, 54);
            lblPizzaSize.Name = "lblPizzaSize";
            lblPizzaSize.Size = new System.Drawing.Size(59, 15);
            lblPizzaSize.TabIndex = 19;
            lblPizzaSize.Text = "Pizza Size:";
            // 
            // boxPizzaSize
            // 
            boxPizzaSize.FormattingEnabled = true;
            boxPizzaSize.Items.AddRange(new object[] { "Small", "Medium", "Large", "Extra-Large" });
            boxPizzaSize.Location = new System.Drawing.Point(235, 72);
            boxPizzaSize.Name = "boxPizzaSize";
            boxPizzaSize.Size = new System.Drawing.Size(189, 23);
            boxPizzaSize.TabIndex = 20;
            boxPizzaSize.SelectedIndexChanged += boxPizzaSize_SelectedIndexChanged;
            // 
            // boxCrust
            // 
            boxCrust.FormattingEnabled = true;
            boxCrust.Items.AddRange(new object[] { "Sausage Stuffed", "Cracker", "Flat Bread", "Thin", "Cheese stuffed", "Thick Crust", "Gluten Free" });
            boxCrust.Location = new System.Drawing.Point(235, 116);
            boxCrust.Name = "boxCrust";
            boxCrust.Size = new System.Drawing.Size(189, 23);
            boxCrust.TabIndex = 22;
            // 
            // lblCrust
            // 
            lblCrust.AutoSize = true;
            lblCrust.Location = new System.Drawing.Point(235, 98);
            lblCrust.Name = "lblCrust";
            lblCrust.Size = new System.Drawing.Size(78, 15);
            lblCrust.TabIndex = 21;
            lblCrust.Text = "Crust Choice:";
            // 
            // boxSauce
            // 
            boxSauce.FormattingEnabled = true;
            boxSauce.Items.AddRange(new object[] { "Tomato", "Pesto", "Garlic Ranch", "Hummus", "Buffalo Sauce", "Marinara Sauce" });
            boxSauce.Location = new System.Drawing.Point(235, 160);
            boxSauce.Name = "boxSauce";
            boxSauce.Size = new System.Drawing.Size(189, 23);
            boxSauce.TabIndex = 24;
            // 
            // lblSauce
            // 
            lblSauce.AutoSize = true;
            lblSauce.Location = new System.Drawing.Point(235, 142);
            lblSauce.Name = "lblSauce";
            lblSauce.Size = new System.Drawing.Size(81, 15);
            lblSauce.TabIndex = 23;
            lblSauce.Text = "Sauce Choice:";
            // 
            // boxSide
            // 
            boxSide.FormattingEnabled = true;
            boxSide.Items.AddRange(new object[] { "Chips", "Salad", "Garlic Bread" });
            boxSide.Location = new System.Drawing.Point(127, 204);
            boxSide.Name = "boxSide";
            boxSide.Size = new System.Drawing.Size(189, 23);
            boxSide.TabIndex = 26;
            // 
            // lblSide
            // 
            lblSide.AutoSize = true;
            lblSide.Location = new System.Drawing.Point(188, 186);
            lblSide.Name = "lblSide";
            lblSide.Size = new System.Drawing.Size(72, 15);
            lblSide.TabIndex = 25;
            lblSide.Text = "Side Choice:";
            // 
            // btnFinish
            // 
            btnFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            btnFinish.Location = new System.Drawing.Point(160, 388);
            btnFinish.Name = "btnFinish";
            btnFinish.Size = new System.Drawing.Size(115, 62);
            btnFinish.TabIndex = 27;
            btnFinish.Text = "Complete the Order";
            btnFinish.UseVisualStyleBackColor = true;
            btnFinish.Click += btnFinish_Click;
            // 
            // cmbExtra
            // 
            cmbExtra.FormattingEnabled = true;
            cmbExtra.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            cmbExtra.Items.AddRange(new object[] { "Pepperoni", "Ham", "Extra Cheese", "Bacon", "Chicken" });
            cmbExtra.Location = new System.Drawing.Point(123, 264);
            cmbExtra.Name = "cmbExtra";
            cmbExtra.Size = new System.Drawing.Size(193, 23);
            cmbExtra.TabIndex = 28;
            // 
            // btnExtra
            // 
            btnExtra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnExtra.Location = new System.Drawing.Point(123, 307);
            btnExtra.Name = "btnExtra";
            btnExtra.Size = new System.Drawing.Size(190, 23);
            btnExtra.TabIndex = 29;
            btnExtra.Text = "More Toppings?";
            btnExtra.UseVisualStyleBackColor = true;
            btnExtra.Click += btnExtra_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(157, 246);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(137, 15);
            label1.TabIndex = 30;
            label1.Text = "Limit of 4 Extra Toppings";
            // 
            // Menu
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(435, 462);
            Controls.Add(label1);
            Controls.Add(btnExtra);
            Controls.Add(cmbExtra);
            Controls.Add(btnFinish);
            Controls.Add(boxSide);
            Controls.Add(lblSide);
            Controls.Add(boxSauce);
            Controls.Add(lblSauce);
            Controls.Add(boxCrust);
            Controls.Add(lblCrust);
            Controls.Add(boxPizzaSize);
            Controls.Add(lblPizzaSize);
            Controls.Add(boxTopping3);
            Controls.Add(boxTopping2);
            Controls.Add(lblTopping3);
            Controls.Add(lblTopping2);
            Controls.Add(lblTopping1);
            Controls.Add(lblTitle);
            Controls.Add(boxTopping1);
            Name = "Menu";
            Text = "Menu";
            Load += Menu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ComboBox boxTopping1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblTopping1;
        private System.Windows.Forms.Label lblTopping2;
        private System.Windows.Forms.Label lblTopping3;
        private System.Windows.Forms.ComboBox boxTopping2;
        private System.Windows.Forms.ComboBox boxTopping3;
        private System.Windows.Forms.Label lblPizzaSize;
        private System.Windows.Forms.ComboBox boxPizzaSize;
        private System.Windows.Forms.ComboBox boxCrust;
        private System.Windows.Forms.Label lblCrust;
        private System.Windows.Forms.ComboBox boxSauce;
        private System.Windows.Forms.Label lblSauce;
        private System.Windows.Forms.ComboBox boxSide;
        private System.Windows.Forms.Label lblSide;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.ComboBox cmbExtra;
        private System.Windows.Forms.Button btnExtra;
        private System.Windows.Forms.Label label1;
    }
}