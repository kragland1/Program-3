namespace Program_3
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
            this.gardenLbl = new System.Windows.Forms.Label();
            this.entreeLbl = new System.Windows.Forms.Label();
            this.Qty = new System.Windows.Forms.Label();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.entreeBox = new System.Windows.Forms.TextBox();
            this.quantityBox = new System.Windows.Forms.TextBox();
            this.flowerbutton = new System.Windows.Forms.Button();
            this.costLbl = new System.Windows.Forms.Label();
            this.baseLbl = new System.Windows.Forms.Label();
            this.discountLbl = new System.Windows.Forms.Label();
            this.totalLbl = new System.Windows.Forms.Label();
            this.outputFlowers = new System.Windows.Forms.Label();
            this.outputBase = new System.Windows.Forms.Label();
            this.outputDiscount = new System.Windows.Forms.Label();
            this.outputTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gardenLbl
            // 
            this.gardenLbl.AutoSize = true;
            this.gardenLbl.Location = new System.Drawing.Point(137, 56);
            this.gardenLbl.Name = "gardenLbl";
            this.gardenLbl.Size = new System.Drawing.Size(45, 13);
            this.gardenLbl.TabIndex = 0;
            this.gardenLbl.Text = "Garden:";
            // 
            // entreeLbl
            // 
            this.entreeLbl.AutoSize = true;
            this.entreeLbl.Location = new System.Drawing.Point(76, 84);
            this.entreeLbl.Name = "entreeLbl";
            this.entreeLbl.Size = new System.Drawing.Size(106, 13);
            this.entreeLbl.TabIndex = 1;
            this.entreeLbl.Text = "Entree/Item Number:";
            // 
            // Qty
            // 
            this.Qty.AutoSize = true;
            this.Qty.Location = new System.Drawing.Point(133, 113);
            this.Qty.Name = "Qty";
            this.Qty.Size = new System.Drawing.Size(49, 13);
            this.Qty.TabIndex = 2;
            this.Qty.Text = "Quantity:";
            // 
            // typeComboBox
            // 
            this.typeComboBox.AutoCompleteCustomSource.AddRange(new string[] {
            "Premium",
            "Standard",
            "Discount"});
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Items.AddRange(new object[] {
            "",
            "Premium",
            "Standard",
            "Discount"});
            this.typeComboBox.Location = new System.Drawing.Point(188, 53);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(100, 21);
            this.typeComboBox.TabIndex = 3;
            // 
            // entreeBox
            // 
            this.entreeBox.Location = new System.Drawing.Point(188, 80);
            this.entreeBox.Name = "entreeBox";
            this.entreeBox.Size = new System.Drawing.Size(100, 20);
            this.entreeBox.TabIndex = 4;
            // 
            // quantityBox
            // 
            this.quantityBox.Location = new System.Drawing.Point(188, 110);
            this.quantityBox.Name = "quantityBox";
            this.quantityBox.Size = new System.Drawing.Size(100, 20);
            this.quantityBox.TabIndex = 5;
            // 
            // flowerbutton
            // 
            this.flowerbutton.Location = new System.Drawing.Point(200, 152);
            this.flowerbutton.Name = "flowerbutton";
            this.flowerbutton.Size = new System.Drawing.Size(75, 23);
            this.flowerbutton.TabIndex = 6;
            this.flowerbutton.Text = "Calculate";
            this.flowerbutton.UseVisualStyleBackColor = true;
            this.flowerbutton.Click += new System.EventHandler(this.flowerbutton_Click);
            // 
            // costLbl
            // 
            this.costLbl.AutoSize = true;
            this.costLbl.Location = new System.Drawing.Point(112, 193);
            this.costLbl.Name = "costLbl";
            this.costLbl.Size = new System.Drawing.Size(70, 13);
            this.costLbl.TabIndex = 7;
            this.costLbl.Text = "Flowers Cost:";
            // 
            // baseLbl
            // 
            this.baseLbl.AutoSize = true;
            this.baseLbl.Location = new System.Drawing.Point(80, 218);
            this.baseLbl.Name = "baseLbl";
            this.baseLbl.Size = new System.Drawing.Size(102, 13);
            this.baseLbl.TabIndex = 8;
            this.baseLbl.Text = "Base Adjusted Cost:";
            // 
            // discountLbl
            // 
            this.discountLbl.AutoSize = true;
            this.discountLbl.Location = new System.Drawing.Point(87, 250);
            this.discountLbl.Name = "discountLbl";
            this.discountLbl.Size = new System.Drawing.Size(95, 13);
            this.discountLbl.TabIndex = 9;
            this.discountLbl.Text = "Discount Percent: ";
            // 
            // totalLbl
            // 
            this.totalLbl.AutoSize = true;
            this.totalLbl.Location = new System.Drawing.Point(121, 273);
            this.totalLbl.Name = "totalLbl";
            this.totalLbl.Size = new System.Drawing.Size(61, 13);
            this.totalLbl.TabIndex = 10;
            this.totalLbl.Text = "Total Price:";
            // 
            // outputFlowers
            // 
            this.outputFlowers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputFlowers.Location = new System.Drawing.Point(188, 185);
            this.outputFlowers.Name = "outputFlowers";
            this.outputFlowers.Size = new System.Drawing.Size(100, 21);
            this.outputFlowers.TabIndex = 11;
            // 
            // outputBase
            // 
            this.outputBase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputBase.Location = new System.Drawing.Point(188, 210);
            this.outputBase.Name = "outputBase";
            this.outputBase.Size = new System.Drawing.Size(100, 21);
            this.outputBase.TabIndex = 12;
            // 
            // outputDiscount
            // 
            this.outputDiscount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputDiscount.Location = new System.Drawing.Point(188, 240);
            this.outputDiscount.Name = "outputDiscount";
            this.outputDiscount.Size = new System.Drawing.Size(100, 23);
            this.outputDiscount.TabIndex = 13;
            // 
            // outputTotal
            // 
            this.outputTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputTotal.Location = new System.Drawing.Point(188, 272);
            this.outputTotal.Name = "outputTotal";
            this.outputTotal.Size = new System.Drawing.Size(100, 23);
            this.outputTotal.TabIndex = 14;
            // 
            // Form1
            // 
            this.AcceptButton = this.flowerbutton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 347);
            this.Controls.Add(this.outputTotal);
            this.Controls.Add(this.outputDiscount);
            this.Controls.Add(this.outputBase);
            this.Controls.Add(this.outputFlowers);
            this.Controls.Add(this.totalLbl);
            this.Controls.Add(this.discountLbl);
            this.Controls.Add(this.baseLbl);
            this.Controls.Add(this.costLbl);
            this.Controls.Add(this.flowerbutton);
            this.Controls.Add(this.quantityBox);
            this.Controls.Add(this.entreeBox);
            this.Controls.Add(this.typeComboBox);
            this.Controls.Add(this.Qty);
            this.Controls.Add(this.entreeLbl);
            this.Controls.Add(this.gardenLbl);
            this.Name = "Form1";
            this.Text = "The Happy Garden";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label gardenLbl;
        private System.Windows.Forms.Label entreeLbl;
        private System.Windows.Forms.Label Qty;
        private System.Windows.Forms.ComboBox typeComboBox;
        private System.Windows.Forms.TextBox entreeBox;
        private System.Windows.Forms.TextBox quantityBox;
        private System.Windows.Forms.Button flowerbutton;
        private System.Windows.Forms.Label costLbl;
        private System.Windows.Forms.Label baseLbl;
        private System.Windows.Forms.Label discountLbl;
        private System.Windows.Forms.Label totalLbl;
        private System.Windows.Forms.Label outputFlowers;
        private System.Windows.Forms.Label outputBase;
        private System.Windows.Forms.Label outputDiscount;
        private System.Windows.Forms.Label outputTotal;
    }
}

