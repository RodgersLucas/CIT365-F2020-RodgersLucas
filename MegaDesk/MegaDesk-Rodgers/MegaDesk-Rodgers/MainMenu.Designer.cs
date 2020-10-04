namespace MegaDesk_Rodgers
{
    partial class MainMenu
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
            this.viewQuoteButton = new System.Windows.Forms.Button();
            this.searchQuoteButton = new System.Windows.Forms.Button();
            this.exitApplication = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addNewQuoteButton
            // 
            this.addNewQuoteButton.Font = new System.Drawing.Font("Poor Richard", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewQuoteButton.Location = new System.Drawing.Point(23, 24);
            this.addNewQuoteButton.Name = "addNewQuoteButton";
            this.addNewQuoteButton.Size = new System.Drawing.Size(155, 63);
            this.addNewQuoteButton.TabIndex = 0;
            this.addNewQuoteButton.Text = "Add New Quote";
            this.addNewQuoteButton.UseVisualStyleBackColor = true;
            this.addNewQuoteButton.Click += new System.EventHandler(this.addNewQuoteButton_Click);
            // 
            // viewQuoteButton
            // 
            this.viewQuoteButton.Font = new System.Drawing.Font("Poor Richard", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewQuoteButton.Location = new System.Drawing.Point(23, 93);
            this.viewQuoteButton.Name = "viewQuoteButton";
            this.viewQuoteButton.Size = new System.Drawing.Size(155, 63);
            this.viewQuoteButton.TabIndex = 1;
            this.viewQuoteButton.Text = "View Quotes";
            this.viewQuoteButton.UseVisualStyleBackColor = true;
            this.viewQuoteButton.Click += new System.EventHandler(this.viewQuoteButton_Click);
            // 
            // searchQuoteButton
            // 
            this.searchQuoteButton.Font = new System.Drawing.Font("Poor Richard", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchQuoteButton.Location = new System.Drawing.Point(23, 162);
            this.searchQuoteButton.Name = "searchQuoteButton";
            this.searchQuoteButton.Size = new System.Drawing.Size(155, 63);
            this.searchQuoteButton.TabIndex = 2;
            this.searchQuoteButton.Text = "Search Quotes";
            this.searchQuoteButton.UseVisualStyleBackColor = true;
            this.searchQuoteButton.Click += new System.EventHandler(this.searchQuoteButton_Click);
            // 
            // exitApplication
            // 
            this.exitApplication.Font = new System.Drawing.Font("Poor Richard", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitApplication.Location = new System.Drawing.Point(23, 231);
            this.exitApplication.Name = "exitApplication";
            this.exitApplication.Size = new System.Drawing.Size(155, 63);
            this.exitApplication.TabIndex = 3;
            this.exitApplication.Text = "Exit";
            this.exitApplication.UseVisualStyleBackColor = true;
            this.exitApplication.Click += new System.EventHandler(this.exitApplication_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.exitApplication);
            this.Controls.Add(this.searchQuoteButton);
            this.Controls.Add(this.viewQuoteButton);
            this.Controls.Add(this.addNewQuoteButton);
            this.Name = "MainMenu";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addNewQuoteButton;
        private System.Windows.Forms.Button viewQuoteButton;
        private System.Windows.Forms.Button searchQuoteButton;
        private System.Windows.Forms.Button exitApplication;
    }
}

