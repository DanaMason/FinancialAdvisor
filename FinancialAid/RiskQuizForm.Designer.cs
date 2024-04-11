namespace FinancialAid
{
    partial class RiskQuizForm
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
            this.TitleRisktxt = new System.Windows.Forms.TextBox();
            this.WelcomeInfoRisktxt = new System.Windows.Forms.TextBox();
            this.Timelinetxt = new System.Windows.Forms.TextBox();
            this.SHtxt = new System.Windows.Forms.TextBox();
            this.Risktxt = new System.Windows.Forms.TextBox();
            this.Goaltxt = new System.Windows.Forms.TextBox();
            this.Incometxt = new System.Windows.Forms.TextBox();
            this.Cashflowtxt = new System.Windows.Forms.TextBox();
            this.REtxt = new System.Windows.Forms.TextBox();
            this.RealEstateDB = new System.Windows.Forms.ComboBox();
            this.CashflowDB = new System.Windows.Forms.ComboBox();
            this.GoalsDB = new System.Windows.Forms.ComboBox();
            this.TimelineDB = new System.Windows.Forms.ComboBox();
            this.RiskDB = new System.Windows.Forms.ComboBox();
            this.IncomeDB = new System.Windows.Forms.ComboBox();
            this.SpendingHabitsDB = new System.Windows.Forms.ComboBox();
            this.SaveContinueBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TitleRisktxt
            // 
            this.TitleRisktxt.BackColor = System.Drawing.SystemColors.WindowText;
            this.TitleRisktxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleRisktxt.ForeColor = System.Drawing.SystemColors.Window;
            this.TitleRisktxt.Location = new System.Drawing.Point(117, 12);
            this.TitleRisktxt.Name = "TitleRisktxt";
            this.TitleRisktxt.ReadOnly = true;
            this.TitleRisktxt.Size = new System.Drawing.Size(267, 30);
            this.TitleRisktxt.TabIndex = 0;
            this.TitleRisktxt.Text = "Risk Assessment";
            this.TitleRisktxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // WelcomeInfoRisktxt
            // 
            this.WelcomeInfoRisktxt.BackColor = System.Drawing.SystemColors.WindowText;
            this.WelcomeInfoRisktxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeInfoRisktxt.ForeColor = System.Drawing.SystemColors.Window;
            this.WelcomeInfoRisktxt.Location = new System.Drawing.Point(117, 39);
            this.WelcomeInfoRisktxt.Multiline = true;
            this.WelcomeInfoRisktxt.Name = "WelcomeInfoRisktxt";
            this.WelcomeInfoRisktxt.ReadOnly = true;
            this.WelcomeInfoRisktxt.Size = new System.Drawing.Size(267, 61);
            this.WelcomeInfoRisktxt.TabIndex = 1;
            this.WelcomeInfoRisktxt.Text = "Please enter the following information for an educated recommendation for your in" +
    "vestment style:";
            this.WelcomeInfoRisktxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.WelcomeInfoRisktxt.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Timelinetxt
            // 
            this.Timelinetxt.BackColor = System.Drawing.SystemColors.WindowText;
            this.Timelinetxt.ForeColor = System.Drawing.SystemColors.Window;
            this.Timelinetxt.Location = new System.Drawing.Point(47, 192);
            this.Timelinetxt.Name = "Timelinetxt";
            this.Timelinetxt.ReadOnly = true;
            this.Timelinetxt.Size = new System.Drawing.Size(301, 22);
            this.Timelinetxt.TabIndex = 3;
            this.Timelinetxt.Text = "What is your investment timeline?";
            // 
            // SHtxt
            // 
            this.SHtxt.BackColor = System.Drawing.SystemColors.WindowText;
            this.SHtxt.ForeColor = System.Drawing.SystemColors.Window;
            this.SHtxt.Location = new System.Drawing.Point(47, 360);
            this.SHtxt.Name = "SHtxt";
            this.SHtxt.ReadOnly = true;
            this.SHtxt.Size = new System.Drawing.Size(301, 22);
            this.SHtxt.TabIndex = 4;
            this.SHtxt.Text = "How would you desscribe your spending habits?";
            // 
            // Risktxt
            // 
            this.Risktxt.BackColor = System.Drawing.SystemColors.WindowText;
            this.Risktxt.ForeColor = System.Drawing.SystemColors.Window;
            this.Risktxt.Location = new System.Drawing.Point(47, 248);
            this.Risktxt.Name = "Risktxt";
            this.Risktxt.ReadOnly = true;
            this.Risktxt.Size = new System.Drawing.Size(301, 22);
            this.Risktxt.TabIndex = 5;
            this.Risktxt.Text = "How much risk do you want to take on?";
            // 
            // Goaltxt
            // 
            this.Goaltxt.BackColor = System.Drawing.SystemColors.WindowText;
            this.Goaltxt.ForeColor = System.Drawing.SystemColors.Window;
            this.Goaltxt.Location = new System.Drawing.Point(47, 136);
            this.Goaltxt.Name = "Goaltxt";
            this.Goaltxt.ReadOnly = true;
            this.Goaltxt.Size = new System.Drawing.Size(301, 22);
            this.Goaltxt.TabIndex = 7;
            this.Goaltxt.Text = "What is your investment goal?";
            // 
            // Incometxt
            // 
            this.Incometxt.BackColor = System.Drawing.SystemColors.WindowText;
            this.Incometxt.ForeColor = System.Drawing.SystemColors.Window;
            this.Incometxt.Location = new System.Drawing.Point(47, 304);
            this.Incometxt.Name = "Incometxt";
            this.Incometxt.ReadOnly = true;
            this.Incometxt.Size = new System.Drawing.Size(301, 22);
            this.Incometxt.TabIndex = 8;
            this.Incometxt.Text = "What is your investable income range?";
            // 
            // Cashflowtxt
            // 
            this.Cashflowtxt.BackColor = System.Drawing.SystemColors.WindowText;
            this.Cashflowtxt.ForeColor = System.Drawing.SystemColors.Window;
            this.Cashflowtxt.Location = new System.Drawing.Point(47, 432);
            this.Cashflowtxt.Name = "Cashflowtxt";
            this.Cashflowtxt.ReadOnly = true;
            this.Cashflowtxt.Size = new System.Drawing.Size(301, 22);
            this.Cashflowtxt.TabIndex = 9;
            this.Cashflowtxt.Text = "Is cashflow a priority?";
            // 
            // REtxt
            // 
            this.REtxt.BackColor = System.Drawing.SystemColors.WindowText;
            this.REtxt.ForeColor = System.Drawing.SystemColors.Window;
            this.REtxt.Location = new System.Drawing.Point(47, 488);
            this.REtxt.Name = "REtxt";
            this.REtxt.ReadOnly = true;
            this.REtxt.Size = new System.Drawing.Size(301, 22);
            this.REtxt.TabIndex = 10;
            this.REtxt.Text = "Would you invest in real estate?";
            // 
            // RealEstateDB
            // 
            this.RealEstateDB.AllowDrop = true;
            this.RealEstateDB.BackColor = System.Drawing.Color.Navy;
            this.RealEstateDB.ForeColor = System.Drawing.SystemColors.Window;
            this.RealEstateDB.FormattingEnabled = true;
            this.RealEstateDB.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.RealEstateDB.Location = new System.Drawing.Point(382, 488);
            this.RealEstateDB.Name = "RealEstateDB";
            this.RealEstateDB.Size = new System.Drawing.Size(159, 24);
            this.RealEstateDB.TabIndex = 19;
            this.RealEstateDB.Text = "- Select -";
            // 
            // CashflowDB
            // 
            this.CashflowDB.AllowDrop = true;
            this.CashflowDB.BackColor = System.Drawing.Color.Navy;
            this.CashflowDB.ForeColor = System.Drawing.SystemColors.Window;
            this.CashflowDB.FormattingEnabled = true;
            this.CashflowDB.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.CashflowDB.Location = new System.Drawing.Point(382, 430);
            this.CashflowDB.Name = "CashflowDB";
            this.CashflowDB.Size = new System.Drawing.Size(159, 24);
            this.CashflowDB.TabIndex = 20;
            this.CashflowDB.Text = "- Select -";
            // 
            // GoalsDB
            // 
            this.GoalsDB.AllowDrop = true;
            this.GoalsDB.BackColor = System.Drawing.Color.Navy;
            this.GoalsDB.ForeColor = System.Drawing.SystemColors.Window;
            this.GoalsDB.FormattingEnabled = true;
            this.GoalsDB.Items.AddRange(new object[] {
            "Growth/Value",
            "Dividends",
            "Retirement",
            "Diversifying"});
            this.GoalsDB.Location = new System.Drawing.Point(382, 134);
            this.GoalsDB.Name = "GoalsDB";
            this.GoalsDB.Size = new System.Drawing.Size(159, 24);
            this.GoalsDB.TabIndex = 22;
            this.GoalsDB.Text = "- Select -";
            this.GoalsDB.SelectedIndexChanged += new System.EventHandler(this.GoalsDB_SelectedIndexChanged);
            // 
            // TimelineDB
            // 
            this.TimelineDB.AllowDrop = true;
            this.TimelineDB.BackColor = System.Drawing.Color.Navy;
            this.TimelineDB.ForeColor = System.Drawing.SystemColors.Window;
            this.TimelineDB.FormattingEnabled = true;
            this.TimelineDB.Items.AddRange(new object[] {
            "<5 Years",
            "5 - 15 Years",
            "15+ Years"});
            this.TimelineDB.Location = new System.Drawing.Point(382, 192);
            this.TimelineDB.Name = "TimelineDB";
            this.TimelineDB.Size = new System.Drawing.Size(159, 24);
            this.TimelineDB.TabIndex = 21;
            this.TimelineDB.Text = "- Select -";
            // 
            // RiskDB
            // 
            this.RiskDB.AllowDrop = true;
            this.RiskDB.BackColor = System.Drawing.Color.Navy;
            this.RiskDB.ForeColor = System.Drawing.SystemColors.Window;
            this.RiskDB.FormattingEnabled = true;
            this.RiskDB.Items.AddRange(new object[] {
            "Low Risk Tolerance",
            "Moderate Risk Tolerance",
            "High Risk Tolerance"});
            this.RiskDB.Location = new System.Drawing.Point(382, 246);
            this.RiskDB.Name = "RiskDB";
            this.RiskDB.Size = new System.Drawing.Size(159, 24);
            this.RiskDB.TabIndex = 24;
            this.RiskDB.Text = "- Select -";
            // 
            // IncomeDB
            // 
            this.IncomeDB.AllowDrop = true;
            this.IncomeDB.BackColor = System.Drawing.Color.Navy;
            this.IncomeDB.ForeColor = System.Drawing.SystemColors.Window;
            this.IncomeDB.FormattingEnabled = true;
            this.IncomeDB.Items.AddRange(new object[] {
            "Almost Nothing",
            "Low",
            "Moderate",
            "High"});
            this.IncomeDB.Location = new System.Drawing.Point(382, 304);
            this.IncomeDB.Name = "IncomeDB";
            this.IncomeDB.Size = new System.Drawing.Size(159, 24);
            this.IncomeDB.TabIndex = 23;
            this.IncomeDB.Text = "- Select -";
            // 
            // SpendingHabitsDB
            // 
            this.SpendingHabitsDB.AllowDrop = true;
            this.SpendingHabitsDB.BackColor = System.Drawing.Color.Navy;
            this.SpendingHabitsDB.ForeColor = System.Drawing.SystemColors.Window;
            this.SpendingHabitsDB.FormattingEnabled = true;
            this.SpendingHabitsDB.Items.AddRange(new object[] {
            "I can control myself",
            "I have a problem..."});
            this.SpendingHabitsDB.Location = new System.Drawing.Point(382, 360);
            this.SpendingHabitsDB.Name = "SpendingHabitsDB";
            this.SpendingHabitsDB.Size = new System.Drawing.Size(159, 24);
            this.SpendingHabitsDB.TabIndex = 25;
            this.SpendingHabitsDB.Text = "- Select -";
            // 
            // SaveContinueBtn
            // 
            this.SaveContinueBtn.BackColor = System.Drawing.Color.Navy;
            this.SaveContinueBtn.Location = new System.Drawing.Point(180, 537);
            this.SaveContinueBtn.Name = "SaveContinueBtn";
            this.SaveContinueBtn.Size = new System.Drawing.Size(204, 46);
            this.SaveContinueBtn.TabIndex = 26;
            this.SaveContinueBtn.Text = "Save and Continue";
            this.SaveContinueBtn.UseVisualStyleBackColor = false;
            this.SaveContinueBtn.Click += new System.EventHandler(this.SaveContinueBtn_Click);
            // 
            // RiskQuizForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.ClientSize = new System.Drawing.Size(576, 609);
            this.Controls.Add(this.SaveContinueBtn);
            this.Controls.Add(this.SpendingHabitsDB);
            this.Controls.Add(this.RiskDB);
            this.Controls.Add(this.IncomeDB);
            this.Controls.Add(this.GoalsDB);
            this.Controls.Add(this.TimelineDB);
            this.Controls.Add(this.CashflowDB);
            this.Controls.Add(this.RealEstateDB);
            this.Controls.Add(this.REtxt);
            this.Controls.Add(this.Cashflowtxt);
            this.Controls.Add(this.Incometxt);
            this.Controls.Add(this.Goaltxt);
            this.Controls.Add(this.Risktxt);
            this.Controls.Add(this.SHtxt);
            this.Controls.Add(this.Timelinetxt);
            this.Controls.Add(this.WelcomeInfoRisktxt);
            this.Controls.Add(this.TitleRisktxt);
            this.ForeColor = System.Drawing.SystemColors.Menu;
            this.MaximumSize = new System.Drawing.Size(594, 656);
            this.MinimumSize = new System.Drawing.Size(594, 656);
            this.Name = "RiskQuizForm";
            this.Text = "RiskQuizForm";
            this.Load += new System.EventHandler(this.RiskQuizForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TitleRisktxt;
        private System.Windows.Forms.TextBox WelcomeInfoRisktxt;
        private System.Windows.Forms.TextBox Timelinetxt;
        private System.Windows.Forms.TextBox SHtxt;
        private System.Windows.Forms.TextBox Risktxt;
        private System.Windows.Forms.TextBox Goaltxt;
        private System.Windows.Forms.TextBox Incometxt;
        private System.Windows.Forms.TextBox Cashflowtxt;
        private System.Windows.Forms.TextBox REtxt;
        private System.Windows.Forms.ComboBox RealEstateDB;
        private System.Windows.Forms.ComboBox CashflowDB;
        private System.Windows.Forms.ComboBox GoalsDB;
        private System.Windows.Forms.ComboBox TimelineDB;
        private System.Windows.Forms.ComboBox RiskDB;
        private System.Windows.Forms.ComboBox IncomeDB;
        private System.Windows.Forms.ComboBox SpendingHabitsDB;
        private System.Windows.Forms.Button SaveContinueBtn;
    }
}