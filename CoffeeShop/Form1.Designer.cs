namespace CoffeeShop
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstSize = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnOrder = new System.Windows.Forms.Button();
            this.lstSyrup = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lstCoffee = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblAmountDue = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblOrder = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(238, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Java The Nut";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstSize);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnOrder);
            this.groupBox1.Controls.Add(this.lstSyrup);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lstCoffee);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(62, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(543, 382);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Coffee and Syrup";
            // 
            // lstSize
            // 
            this.lstSize.BackColor = System.Drawing.Color.Wheat;
            this.lstSize.FormattingEnabled = true;
            this.lstSize.ItemHeight = 22;
            this.lstSize.Items.AddRange(new object[] {
            "Tiny",
            "Medium",
            "Large",
            "Jumbo"});
            this.lstSize.Location = new System.Drawing.Point(202, 44);
            this.lstSize.Name = "lstSize";
            this.lstSize.Size = new System.Drawing.Size(120, 92);
            this.lstSize.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(131, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 22);
            this.label5.TabIndex = 5;
            this.label5.Text = "Size:";
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(194, 321);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(145, 38);
            this.btnOrder.TabIndex = 4;
            this.btnOrder.Text = "Place Order!";
            this.btnOrder.UseVisualStyleBackColor = true;
            // 
            // lstSyrup
            // 
            this.lstSyrup.BackColor = System.Drawing.Color.Wheat;
            this.lstSyrup.FormattingEnabled = true;
            this.lstSyrup.ItemHeight = 22;
            this.lstSyrup.Items.AddRange(new object[] {
            "None",
            "Chocolate",
            "Caramel",
            "Hazelnut",
            "Irish Cream",
            "Orange"});
            this.lstSyrup.Location = new System.Drawing.Point(284, 186);
            this.lstSyrup.Name = "lstSyrup";
            this.lstSyrup.Size = new System.Drawing.Size(205, 92);
            this.lstSyrup.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(280, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Syrup Flavor:";
            // 
            // lstCoffee
            // 
            this.lstCoffee.BackColor = System.Drawing.Color.Wheat;
            this.lstCoffee.FormattingEnabled = true;
            this.lstCoffee.ItemHeight = 22;
            this.lstCoffee.Items.AddRange(new object[] {
            "None",
            "Chocolate Almond",
            "Espresso Roast",
            "Jamaica Blue Mountain",
            "Kona Blend",
            "Vanilla Nut"});
            this.lstCoffee.Location = new System.Drawing.Point(23, 186);
            this.lstCoffee.Name = "lstCoffee";
            this.lstCoffee.Size = new System.Drawing.Size(206, 92);
            this.lstCoffee.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Coffee Flavor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(330, 540);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 22);
            this.label4.TabIndex = 2;
            this.label4.Text = "Amount Due:";
            // 
            // lblAmountDue
            // 
            this.lblAmountDue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAmountDue.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmountDue.Location = new System.Drawing.Point(451, 536);
            this.lblAmountDue.Name = "lblAmountDue";
            this.lblAmountDue.Size = new System.Drawing.Size(109, 34);
            this.lblAmountDue.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(58, 540);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 22);
            this.label6.TabIndex = 4;
            this.label6.Text = "Your Order:";
            // 
            // lblOrder
            // 
            this.lblOrder.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOrder.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrder.Location = new System.Drawing.Point(171, 515);
            this.lblOrder.Name = "lblOrder";
            this.lblOrder.Size = new System.Drawing.Size(120, 81);
            this.lblOrder.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(686, 639);
            this.Controls.Add(this.lblOrder);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblAmountDue);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Coffee Shop";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstSize;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.ListBox lstSyrup;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstCoffee;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblAmountDue;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblOrder;
    }
}

