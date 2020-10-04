namespace MegaDesk_Rodgers
{
    partial class AddQuote
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
            this.addNewQuoteButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.addWidthBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addDepthBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.firstNameBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lastNameBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.totalSquaredLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.checkedListMaterial = new System.Windows.Forms.CheckedListBox();
            this.checkedListRush = new System.Windows.Forms.CheckedListBox();
            this.checkedListDrawers = new System.Windows.Forms.CheckedListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.totalPriceLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.acceptQuote = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addNewQuoteButton
            // 
            this.addNewQuoteButton.Font = new System.Drawing.Font("Poor Richard", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewQuoteButton.Location = new System.Drawing.Point(320, 286);
            this.addNewQuoteButton.Name = "addNewQuoteButton";
            this.addNewQuoteButton.Size = new System.Drawing.Size(155, 63);
            this.addNewQuoteButton.TabIndex = 1;
            this.addNewQuoteButton.Text = "Back to Main Menu";
            this.addNewQuoteButton.UseVisualStyleBackColor = true;
            this.addNewQuoteButton.Click += new System.EventHandler(this.addNewQuoteButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Info;
            this.textBox1.Location = new System.Drawing.Point(194, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Add a new quote";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // addWidthBox
            // 
            this.addWidthBox.Location = new System.Drawing.Point(25, 107);
            this.addWidthBox.Name = "addWidthBox";
            this.addWidthBox.Size = new System.Drawing.Size(100, 20);
            this.addWidthBox.TabIndex = 3;
            this.addWidthBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.addWidthBox_MouseClick);
            this.addWidthBox.Validating += new System.ComponentModel.CancelEventHandler(this.addWidthBox_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Width - Between 24 and 96 inches";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(199, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Depth - Between 24 and 96 inches";
            // 
            // addDepthBox
            // 
            this.addDepthBox.Location = new System.Drawing.Point(201, 106);
            this.addDepthBox.Name = "addDepthBox";
            this.addDepthBox.Size = new System.Drawing.Size(100, 20);
            this.addDepthBox.TabIndex = 6;
            this.addDepthBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.addDepthBox_MouseClick);
            this.addDepthBox.Validating += new System.ComponentModel.CancelEventHandler(this.addDepthBox_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "First Name";
            // 
            // firstNameBox
            // 
            this.firstNameBox.Location = new System.Drawing.Point(25, 51);
            this.firstNameBox.Name = "firstNameBox";
            this.firstNameBox.Size = new System.Drawing.Size(142, 20);
            this.firstNameBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(180, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Last name";
            // 
            // lastNameBox
            // 
            this.lastNameBox.Location = new System.Drawing.Point(183, 51);
            this.lastNameBox.Name = "lastNameBox";
            this.lastNameBox.Size = new System.Drawing.Size(142, 20);
            this.lastNameBox.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(390, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Total size (in²)";
            // 
            // totalSquaredLabel
            // 
            this.totalSquaredLabel.AutoSize = true;
            this.totalSquaredLabel.Location = new System.Drawing.Point(422, 114);
            this.totalSquaredLabel.Name = "totalSquaredLabel";
            this.totalSquaredLabel.Size = new System.Drawing.Size(13, 13);
            this.totalSquaredLabel.TabIndex = 13;
            this.totalSquaredLabel.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(454, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "in²";
            // 
            // label6
            // 
            this.label6.AllowDrop = true;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Number of Drawers ";
            // 
            // checkedListMaterial
            // 
            this.checkedListMaterial.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.checkedListMaterial.CheckOnClick = true;
            this.checkedListMaterial.FormattingEnabled = true;
            this.checkedListMaterial.Items.AddRange(new object[] {
            "Laminate",
            "Oak",
            "Pine",
            "Rosewood",
            "Veneer"});
            this.checkedListMaterial.Location = new System.Drawing.Point(183, 177);
            this.checkedListMaterial.Name = "checkedListMaterial";
            this.checkedListMaterial.Size = new System.Drawing.Size(77, 79);
            this.checkedListMaterial.Sorted = true;
            this.checkedListMaterial.TabIndex = 23;
            this.checkedListMaterial.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListMaterial_ItemCheck);
            // 
            // checkedListRush
            // 
            this.checkedListRush.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.checkedListRush.CheckOnClick = true;
            this.checkedListRush.FormattingEnabled = true;
            this.checkedListRush.Items.AddRange(new object[] {
            "Rushed - 3 Days",
            "Express - 5 Days",
            "Expidited - 7 Days",
            "Free Shipping - 14 Days"});
            this.checkedListRush.Location = new System.Drawing.Point(320, 177);
            this.checkedListRush.Name = "checkedListRush";
            this.checkedListRush.Size = new System.Drawing.Size(142, 64);
            this.checkedListRush.TabIndex = 24;
            this.checkedListRush.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListRush_ItemCheck);
            // 
            // checkedListDrawers
            // 
            this.checkedListDrawers.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.checkedListDrawers.CheckOnClick = true;
            this.checkedListDrawers.FormattingEnabled = true;
            this.checkedListDrawers.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.checkedListDrawers.Location = new System.Drawing.Point(25, 177);
            this.checkedListDrawers.Name = "checkedListDrawers";
            this.checkedListDrawers.Size = new System.Drawing.Size(54, 109);
            this.checkedListDrawers.Sorted = true;
            this.checkedListDrawers.TabIndex = 25;
            this.checkedListDrawers.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListDrawers_ItemCheck);
            // 
            // label8
            // 
            this.label8.AllowDrop = true;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(180, 146);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Type of Material";
            // 
            // label9
            // 
            this.label9.AllowDrop = true;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(317, 146);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "Shipping Options";
            // 
            // label10
            // 
            this.label10.AllowDrop = true;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(24, 161);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 13);
            this.label10.TabIndex = 28;
            this.label10.Text = "$50+ per drawer";
            // 
            // totalPriceLabel
            // 
            this.totalPriceLabel.AutoSize = true;
            this.totalPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPriceLabel.Location = new System.Drawing.Point(118, 321);
            this.totalPriceLabel.Name = "totalPriceLabel";
            this.totalPriceLabel.Size = new System.Drawing.Size(61, 25);
            this.totalPriceLabel.TabIndex = 30;
            this.totalPriceLabel.Text = "$0.00";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 292);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 63);
            this.button1.TabIndex = 31;
            this.button1.Text = "Get Total Price";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // acceptQuote
            // 
            this.acceptQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acceptQuote.Location = new System.Drawing.Point(214, 286);
            this.acceptQuote.Name = "acceptQuote";
            this.acceptQuote.Size = new System.Drawing.Size(100, 63);
            this.acceptQuote.TabIndex = 32;
            this.acceptQuote.Text = "Accept Quote";
            this.acceptQuote.UseVisualStyleBackColor = true;
            this.acceptQuote.Click += new System.EventHandler(this.acceptQuote_Click);
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.acceptQuote);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.totalPriceLabel);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.checkedListDrawers);
            this.Controls.Add(this.checkedListRush);
            this.Controls.Add(this.checkedListMaterial);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.totalSquaredLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lastNameBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.firstNameBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addDepthBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addWidthBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.addNewQuoteButton);
            this.Name = "AddQuote";
            this.Text = "Add a Quote";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addNewQuoteButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox addWidthBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox addDepthBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox firstNameBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox lastNameBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label totalSquaredLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckedListBox checkedListMaterial;
        private System.Windows.Forms.CheckedListBox checkedListRush;
        private System.Windows.Forms.CheckedListBox checkedListDrawers;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label totalPriceLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button acceptQuote;
    }
}