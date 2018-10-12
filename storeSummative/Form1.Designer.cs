namespace storeSummative
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
            this.burgerLabel = new System.Windows.Forms.Label();
            this.friesLabel = new System.Windows.Forms.Label();
            this.drinkLabel = new System.Windows.Forms.Label();
            this.burgerBox = new System.Windows.Forms.TextBox();
            this.friesBox = new System.Windows.Forms.TextBox();
            this.drinkBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.subtotal = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.changeButton = new System.Windows.Forms.Button();
            this.subamountLabel = new System.Windows.Forms.Label();
            this.taxamountLabel = new System.Windows.Forms.Label();
            this.totalamountLabel = new System.Windows.Forms.Label();
            this.tenderedLabel = new System.Windows.Forms.Label();
            this.tenderedBox = new System.Windows.Forms.TextBox();
            this.receiptButton = new System.Windows.Forms.Button();
            this.changeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // burgerLabel
            // 
            this.burgerLabel.AutoSize = true;
            this.burgerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.burgerLabel.Location = new System.Drawing.Point(34, 35);
            this.burgerLabel.Name = "burgerLabel";
            this.burgerLabel.Size = new System.Drawing.Size(76, 24);
            this.burgerLabel.TabIndex = 0;
            this.burgerLabel.Text = "Burgers";
            // 
            // friesLabel
            // 
            this.friesLabel.AutoSize = true;
            this.friesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.friesLabel.Location = new System.Drawing.Point(34, 82);
            this.friesLabel.Name = "friesLabel";
            this.friesLabel.Size = new System.Drawing.Size(52, 24);
            this.friesLabel.TabIndex = 1;
            this.friesLabel.Text = "Fries";
            // 
            // drinkLabel
            // 
            this.drinkLabel.AutoSize = true;
            this.drinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drinkLabel.Location = new System.Drawing.Point(34, 134);
            this.drinkLabel.Name = "drinkLabel";
            this.drinkLabel.Size = new System.Drawing.Size(62, 24);
            this.drinkLabel.TabIndex = 2;
            this.drinkLabel.Text = "Drinks";
            // 
            // burgerBox
            // 
            this.burgerBox.Location = new System.Drawing.Point(162, 38);
            this.burgerBox.Name = "burgerBox";
            this.burgerBox.Size = new System.Drawing.Size(100, 20);
            this.burgerBox.TabIndex = 3;
            // 
            // friesBox
            // 
            this.friesBox.Location = new System.Drawing.Point(162, 87);
            this.friesBox.Name = "friesBox";
            this.friesBox.Size = new System.Drawing.Size(100, 20);
            this.friesBox.TabIndex = 4;
            // 
            // drinkBox
            // 
            this.drinkBox.Location = new System.Drawing.Point(162, 139);
            this.drinkBox.Name = "drinkBox";
            this.drinkBox.Size = new System.Drawing.Size(100, 20);
            this.drinkBox.TabIndex = 5;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(110, 174);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(101, 46);
            this.calculateButton.TabIndex = 6;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // subtotal
            // 
            this.subtotal.AutoSize = true;
            this.subtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtotal.Location = new System.Drawing.Point(34, 245);
            this.subtotal.Name = "subtotal";
            this.subtotal.Size = new System.Drawing.Size(77, 24);
            this.subtotal.TabIndex = 7;
            this.subtotal.Text = "Subtotal";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.Location = new System.Drawing.Point(33, 312);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(51, 24);
            this.totalLabel.TabIndex = 8;
            this.totalLabel.Text = "Total";
            // 
            // taxLabel
            // 
            this.taxLabel.AutoSize = true;
            this.taxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxLabel.Location = new System.Drawing.Point(33, 278);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(42, 24);
            this.taxLabel.TabIndex = 9;
            this.taxLabel.Text = "Tax";
            // 
            // changeButton
            // 
            this.changeButton.Location = new System.Drawing.Point(110, 412);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(100, 41);
            this.changeButton.TabIndex = 10;
            this.changeButton.Text = "Get Change";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // subamountLabel
            // 
            this.subamountLabel.AutoSize = true;
            this.subamountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subamountLabel.Location = new System.Drawing.Point(143, 245);
            this.subamountLabel.Name = "subamountLabel";
            this.subamountLabel.Size = new System.Drawing.Size(0, 24);
            this.subamountLabel.TabIndex = 11;
            // 
            // taxamountLabel
            // 
            this.taxamountLabel.AutoSize = true;
            this.taxamountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxamountLabel.Location = new System.Drawing.Point(143, 278);
            this.taxamountLabel.Name = "taxamountLabel";
            this.taxamountLabel.Size = new System.Drawing.Size(0, 24);
            this.taxamountLabel.TabIndex = 12;
            // 
            // totalamountLabel
            // 
            this.totalamountLabel.AutoSize = true;
            this.totalamountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalamountLabel.Location = new System.Drawing.Point(143, 312);
            this.totalamountLabel.Name = "totalamountLabel";
            this.totalamountLabel.Size = new System.Drawing.Size(0, 24);
            this.totalamountLabel.TabIndex = 13;
            // 
            // tenderedLabel
            // 
            this.tenderedLabel.AutoSize = true;
            this.tenderedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenderedLabel.Location = new System.Drawing.Point(34, 372);
            this.tenderedLabel.Name = "tenderedLabel";
            this.tenderedLabel.Size = new System.Drawing.Size(94, 24);
            this.tenderedLabel.TabIndex = 14;
            this.tenderedLabel.Text = "Tendered";
            // 
            // tenderedBox
            // 
            this.tenderedBox.Location = new System.Drawing.Point(162, 377);
            this.tenderedBox.Name = "tenderedBox";
            this.tenderedBox.Size = new System.Drawing.Size(100, 20);
            this.tenderedBox.TabIndex = 15;
            // 
            // receiptButton
            // 
            this.receiptButton.Location = new System.Drawing.Point(110, 480);
            this.receiptButton.Name = "receiptButton";
            this.receiptButton.Size = new System.Drawing.Size(100, 42);
            this.receiptButton.TabIndex = 16;
            this.receiptButton.Text = "Print Receipt";
            this.receiptButton.UseVisualStyleBackColor = true;
            this.receiptButton.Click += new System.EventHandler(this.receiptButton_Click);
            // 
            // changeLabel
            // 
            this.changeLabel.AutoSize = true;
            this.changeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeLabel.Location = new System.Drawing.Point(216, 418);
            this.changeLabel.Name = "changeLabel";
            this.changeLabel.Size = new System.Drawing.Size(0, 24);
            this.changeLabel.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 534);
            this.Controls.Add(this.changeLabel);
            this.Controls.Add(this.receiptButton);
            this.Controls.Add(this.tenderedBox);
            this.Controls.Add(this.tenderedLabel);
            this.Controls.Add(this.totalamountLabel);
            this.Controls.Add(this.taxamountLabel);
            this.Controls.Add(this.subamountLabel);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.taxLabel);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.subtotal);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.drinkBox);
            this.Controls.Add(this.friesBox);
            this.Controls.Add(this.burgerBox);
            this.Controls.Add(this.drinkLabel);
            this.Controls.Add(this.friesLabel);
            this.Controls.Add(this.burgerLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label burgerLabel;
        private System.Windows.Forms.Label friesLabel;
        private System.Windows.Forms.Label drinkLabel;
        private System.Windows.Forms.TextBox burgerBox;
        private System.Windows.Forms.TextBox friesBox;
        private System.Windows.Forms.TextBox drinkBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label subtotal;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Label subamountLabel;
        private System.Windows.Forms.Label taxamountLabel;
        private System.Windows.Forms.Label totalamountLabel;
        private System.Windows.Forms.Label tenderedLabel;
        private System.Windows.Forms.TextBox tenderedBox;
        private System.Windows.Forms.Button receiptButton;
        private System.Windows.Forms.Label changeLabel;
    }
}

