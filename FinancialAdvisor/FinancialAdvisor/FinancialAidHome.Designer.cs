namespace FinancialAdvisor
{
    partial class FinancialAid
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
            this.WelcomeBox = new System.Windows.Forms.TextBox();
            this.RiskQuizButton = new System.Windows.Forms.Button();
            this.QuizTB = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // WelcomeBox
            // 
            this.WelcomeBox.BackColor = System.Drawing.SystemColors.MenuText;
            this.WelcomeBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.WelcomeBox.Font = new System.Drawing.Font("Mongolian Baiti", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeBox.ForeColor = System.Drawing.Color.White;
            this.WelcomeBox.Location = new System.Drawing.Point(81, 26);
            this.WelcomeBox.Multiline = true;
            this.WelcomeBox.Name = "WelcomeBox";
            this.WelcomeBox.Size = new System.Drawing.Size(346, 85);
            this.WelcomeBox.TabIndex = 0;
            this.WelcomeBox.Text = "Hello, and welcome to FinancialAid.io! Please follow the instructions that follow" +
    ".";
            this.WelcomeBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.WelcomeBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // RiskQuizButton
            // 
            this.RiskQuizButton.BackColor = System.Drawing.Color.Navy;
            this.RiskQuizButton.ForeColor = System.Drawing.Color.White;
            this.RiskQuizButton.Location = new System.Drawing.Point(321, 145);
            this.RiskQuizButton.Name = "RiskQuizButton";
            this.RiskQuizButton.Size = new System.Drawing.Size(83, 55);
            this.RiskQuizButton.TabIndex = 1;
            this.RiskQuizButton.Text = "Risk Quiz";
            this.RiskQuizButton.UseVisualStyleBackColor = false;
            this.RiskQuizButton.Click += new System.EventHandler(this.RiskQuizButton_Click);
            // 
            // QuizTB
            // 
            this.QuizTB.BackColor = System.Drawing.SystemColors.MenuText;
            this.QuizTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.QuizTB.Font = new System.Drawing.Font("Mongolian Baiti", 9F);
            this.QuizTB.ForeColor = System.Drawing.Color.White;
            this.QuizTB.Location = new System.Drawing.Point(40, 144);
            this.QuizTB.Multiline = true;
            this.QuizTB.Name = "QuizTB";
            this.QuizTB.Size = new System.Drawing.Size(224, 73);
            this.QuizTB.TabIndex = 2;
            this.QuizTB.Text = "Please click the button to the right to take our personally designed quiz to dete" +
    "rmine your risk personality.";
            this.QuizTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.MenuText;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Mongolian Baiti", 9F);
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(40, 276);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(224, 72);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "After you have taken the previous quiz, please press the following button to dete" +
    "rmine your suggested Portfolio.";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Navy;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(321, 276);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 55);
            this.button1.TabIndex = 3;
            this.button1.Text = "Calculate Portfolio";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.MenuText;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Mongolian Baiti", 9F);
            this.textBox2.ForeColor = System.Drawing.Color.White;
            this.textBox2.Location = new System.Drawing.Point(4, 453);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(502, 36);
            this.textBox2.TabIndex = 5;
            this.textBox2.Text = "Thank you for using our services and hopefully this financial advise can help you" +
    " in your future financial decisions. Happy investing!";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // FinancialAid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(518, 501);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.QuizTB);
            this.Controls.Add(this.RiskQuizButton);
            this.Controls.Add(this.WelcomeBox);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "FinancialAid";
            this.Text = "FinancialAid.io";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox WelcomeBox;
        private System.Windows.Forms.Button RiskQuizButton;
        private System.Windows.Forms.TextBox QuizTB;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
    }
}