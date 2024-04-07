namespace FinancialAid
{
    partial class UserForm
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
            this.continueButton = new System.Windows.Forms.Button();
            this.nameButton = new System.Windows.Forms.Button();
            this.cashButton = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.cashTextBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // continueButton
            // 
            this.continueButton.Location = new System.Drawing.Point(151, 417);
            this.continueButton.Name = "continueButton";
            this.continueButton.Size = new System.Drawing.Size(150, 36);
            this.continueButton.TabIndex = 0;
            this.continueButton.Text = "Continue";
            this.continueButton.UseVisualStyleBackColor = true;
            this.continueButton.Click += new System.EventHandler(this.continueButton_Click);
            // 
            // nameButton
            // 
            this.nameButton.Location = new System.Drawing.Point(289, 118);
            this.nameButton.Name = "nameButton";
            this.nameButton.Size = new System.Drawing.Size(130, 50);
            this.nameButton.TabIndex = 1;
            this.nameButton.Text = "Save";
            this.nameButton.UseVisualStyleBackColor = true;
            this.nameButton.Click += new System.EventHandler(this.nameButton_Click);
            // 
            // cashButton
            // 
            this.cashButton.Location = new System.Drawing.Point(289, 265);
            this.cashButton.Name = "cashButton";
            this.cashButton.Size = new System.Drawing.Size(130, 50);
            this.cashButton.TabIndex = 2;
            this.cashButton.Text = "Save";
            this.cashButton.UseVisualStyleBackColor = true;
            this.cashButton.Click += new System.EventHandler(this.cashButton_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(55, 126);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(172, 22);
            this.nameTextBox.TabIndex = 3;
            // 
            // cashTextBox
            // 
            this.cashTextBox.Location = new System.Drawing.Point(43, 279);
            this.cashTextBox.Name = "cashTextBox";
            this.cashTextBox.Size = new System.Drawing.Size(172, 22);
            this.cashTextBox.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(55, 77);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(149, 22);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "Please input your name:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(49, 203);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(165, 40);
            this.textBox2.TabIndex = 6;
            this.textBox2.Text = "Please input the amount of money you want to invest:";
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 490);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cashTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.cashButton);
            this.Controls.Add(this.nameButton);
            this.Controls.Add(this.continueButton);
            this.Name = "UserForm";
            this.Text = "UserForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button continueButton;
        private System.Windows.Forms.Button nameButton;
        private System.Windows.Forms.Button cashButton;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox cashTextBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}