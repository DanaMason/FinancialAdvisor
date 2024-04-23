namespace FinancialAid
{
    partial class PortfolioForm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.StockPercent = new System.Windows.Forms.TextBox();
            this.ETFPercent = new System.Windows.Forms.TextBox();
            this.REPercent = new System.Windows.Forms.TextBox();
            this.StablePercent = new System.Windows.Forms.TextBox();
            this.MoneyStocks = new System.Windows.Forms.TextBox();
            this.MoneyEtf = new System.Windows.Forms.TextBox();
            this.MoneyRE = new System.Windows.Forms.TextBox();
            this.MoneyStable = new System.Windows.Forms.TextBox();
            this.textBox21 = new System.Windows.Forms.TextBox();
            this.textBox22 = new System.Windows.Forms.TextBox();
            this.textBox23 = new System.Windows.Forms.TextBox();
            this.textBox25 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.MoneyRisky = new System.Windows.Forms.TextBox();
            this.RiskyPercent = new System.Windows.Forms.TextBox();
            this.textBox24 = new System.Windows.Forms.TextBox();
            this.totalCash = new System.Windows.Forms.TextBox();
            this.TotalPercent = new System.Windows.Forms.TextBox();
            this.Totaltxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.MenuText;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(12, 25);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(738, 72);
            this.textBox1.TabIndex = 0;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "Hello! Here you can view what concentration you should hold your portfolio at for" +
    " each sector. Information about each sector will also be given.";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.MenuText;
            this.textBox2.ForeColor = System.Drawing.Color.White;
            this.textBox2.Location = new System.Drawing.Point(12, 143);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(158, 22);
            this.textBox2.TabIndex = 1;
            this.textBox2.TabStop = false;
            this.textBox2.Text = "Investment Type";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.MenuText;
            this.textBox3.ForeColor = System.Drawing.Color.White;
            this.textBox3.Location = new System.Drawing.Point(185, 140);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(74, 25);
            this.textBox3.TabIndex = 2;
            this.textBox3.TabStop = false;
            this.textBox3.Text = "Percent";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.MenuText;
            this.textBox4.ForeColor = System.Drawing.Color.White;
            this.textBox4.Location = new System.Drawing.Point(270, 131);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(155, 44);
            this.textBox4.TabIndex = 3;
            this.textBox4.TabStop = false;
            this.textBox4.Text = "Cash equivalent (based on your portfolio total).";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.MenuText;
            this.textBox5.ForeColor = System.Drawing.Color.White;
            this.textBox5.Location = new System.Drawing.Point(442, 140);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(308, 25);
            this.textBox5.TabIndex = 4;
            this.textBox5.TabStop = false;
            this.textBox5.Text = "Descriptions of Sectors";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // textBox9
            // 
            this.textBox9.BackColor = System.Drawing.SystemColors.MenuText;
            this.textBox9.ForeColor = System.Drawing.Color.White;
            this.textBox9.Location = new System.Drawing.Point(12, 209);
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.Size = new System.Drawing.Size(157, 22);
            this.textBox9.TabIndex = 8;
            this.textBox9.TabStop = false;
            this.textBox9.Text = "Stable Investments";
            this.textBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.Color.Navy;
            this.ExitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.ForeColor = System.Drawing.Color.White;
            this.ExitBtn.Location = new System.Drawing.Point(434, 599);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(316, 79);
            this.ExitBtn.TabIndex = 11;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // textBox12
            // 
            this.textBox12.BackColor = System.Drawing.SystemColors.MenuText;
            this.textBox12.ForeColor = System.Drawing.Color.White;
            this.textBox12.Location = new System.Drawing.Point(12, 430);
            this.textBox12.Name = "textBox12";
            this.textBox12.ReadOnly = true;
            this.textBox12.Size = new System.Drawing.Size(157, 22);
            this.textBox12.TabIndex = 15;
            this.textBox12.TabStop = false;
            this.textBox12.Text = "Stocks";
            this.textBox12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox13
            // 
            this.textBox13.BackColor = System.Drawing.SystemColors.MenuText;
            this.textBox13.ForeColor = System.Drawing.Color.White;
            this.textBox13.Location = new System.Drawing.Point(12, 359);
            this.textBox13.Name = "textBox13";
            this.textBox13.ReadOnly = true;
            this.textBox13.Size = new System.Drawing.Size(157, 22);
            this.textBox13.TabIndex = 14;
            this.textBox13.TabStop = false;
            this.textBox13.Text = "ETFs";
            this.textBox13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox13.TextChanged += new System.EventHandler(this.textBox13_TextChanged);
            // 
            // textBox15
            // 
            this.textBox15.BackColor = System.Drawing.SystemColors.MenuText;
            this.textBox15.ForeColor = System.Drawing.Color.White;
            this.textBox15.Location = new System.Drawing.Point(12, 522);
            this.textBox15.Name = "textBox15";
            this.textBox15.ReadOnly = true;
            this.textBox15.Size = new System.Drawing.Size(157, 22);
            this.textBox15.TabIndex = 12;
            this.textBox15.TabStop = false;
            this.textBox15.Text = "Real Estate";
            this.textBox15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // StockPercent
            // 
            this.StockPercent.BackColor = System.Drawing.Color.Navy;
            this.StockPercent.ForeColor = System.Drawing.Color.White;
            this.StockPercent.Location = new System.Drawing.Point(185, 430);
            this.StockPercent.Name = "StockPercent";
            this.StockPercent.ReadOnly = true;
            this.StockPercent.Size = new System.Drawing.Size(74, 22);
            this.StockPercent.TabIndex = 20;
            this.StockPercent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.StockPercent.TextChanged += new System.EventHandler(this.StockPercent_TextChanged);
            // 
            // ETFPercent
            // 
            this.ETFPercent.BackColor = System.Drawing.Color.Navy;
            this.ETFPercent.ForeColor = System.Drawing.Color.White;
            this.ETFPercent.Location = new System.Drawing.Point(185, 359);
            this.ETFPercent.Name = "ETFPercent";
            this.ETFPercent.ReadOnly = true;
            this.ETFPercent.Size = new System.Drawing.Size(74, 22);
            this.ETFPercent.TabIndex = 19;
            this.ETFPercent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ETFPercent.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // REPercent
            // 
            this.REPercent.BackColor = System.Drawing.Color.Navy;
            this.REPercent.ForeColor = System.Drawing.Color.White;
            this.REPercent.Location = new System.Drawing.Point(185, 522);
            this.REPercent.Name = "REPercent";
            this.REPercent.ReadOnly = true;
            this.REPercent.Size = new System.Drawing.Size(74, 22);
            this.REPercent.TabIndex = 18;
            this.REPercent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.REPercent.TextChanged += new System.EventHandler(this.REPercent_TextChanged);
            // 
            // StablePercent
            // 
            this.StablePercent.BackColor = System.Drawing.Color.Navy;
            this.StablePercent.ForeColor = System.Drawing.Color.White;
            this.StablePercent.Location = new System.Drawing.Point(185, 209);
            this.StablePercent.Name = "StablePercent";
            this.StablePercent.ReadOnly = true;
            this.StablePercent.Size = new System.Drawing.Size(74, 22);
            this.StablePercent.TabIndex = 16;
            this.StablePercent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.StablePercent.TextChanged += new System.EventHandler(this.StablePercent_TextChanged);
            // 
            // MoneyStocks
            // 
            this.MoneyStocks.BackColor = System.Drawing.Color.Navy;
            this.MoneyStocks.ForeColor = System.Drawing.Color.White;
            this.MoneyStocks.Location = new System.Drawing.Point(270, 430);
            this.MoneyStocks.Name = "MoneyStocks";
            this.MoneyStocks.ReadOnly = true;
            this.MoneyStocks.Size = new System.Drawing.Size(157, 22);
            this.MoneyStocks.TabIndex = 25;
            this.MoneyStocks.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MoneyStocks.TextChanged += new System.EventHandler(this.MoneyStocks_TextChanged);
            // 
            // MoneyEtf
            // 
            this.MoneyEtf.BackColor = System.Drawing.Color.Navy;
            this.MoneyEtf.ForeColor = System.Drawing.Color.White;
            this.MoneyEtf.Location = new System.Drawing.Point(270, 359);
            this.MoneyEtf.Name = "MoneyEtf";
            this.MoneyEtf.ReadOnly = true;
            this.MoneyEtf.Size = new System.Drawing.Size(157, 22);
            this.MoneyEtf.TabIndex = 24;
            this.MoneyEtf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MoneyEtf.TextChanged += new System.EventHandler(this.textBox17_TextChanged);
            // 
            // MoneyRE
            // 
            this.MoneyRE.BackColor = System.Drawing.Color.Navy;
            this.MoneyRE.ForeColor = System.Drawing.Color.White;
            this.MoneyRE.Location = new System.Drawing.Point(270, 522);
            this.MoneyRE.Name = "MoneyRE";
            this.MoneyRE.ReadOnly = true;
            this.MoneyRE.Size = new System.Drawing.Size(157, 22);
            this.MoneyRE.TabIndex = 23;
            this.MoneyRE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MoneyRE.TextChanged += new System.EventHandler(this.MoneyRE_TextChanged);
            // 
            // MoneyStable
            // 
            this.MoneyStable.BackColor = System.Drawing.Color.Navy;
            this.MoneyStable.ForeColor = System.Drawing.Color.White;
            this.MoneyStable.Location = new System.Drawing.Point(270, 209);
            this.MoneyStable.Name = "MoneyStable";
            this.MoneyStable.ReadOnly = true;
            this.MoneyStable.Size = new System.Drawing.Size(157, 22);
            this.MoneyStable.TabIndex = 21;
            this.MoneyStable.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MoneyStable.TextChanged += new System.EventHandler(this.MoneyStable_TextChanged);
            // 
            // textBox21
            // 
            this.textBox21.BackColor = System.Drawing.SystemColors.MenuText;
            this.textBox21.ForeColor = System.Drawing.Color.White;
            this.textBox21.Location = new System.Drawing.Point(433, 430);
            this.textBox21.Multiline = true;
            this.textBox21.Name = "textBox21";
            this.textBox21.ReadOnly = true;
            this.textBox21.Size = new System.Drawing.Size(317, 59);
            this.textBox21.TabIndex = 30;
            this.textBox21.TabStop = false;
            this.textBox21.Text = "Includes single company stocks like AAPL, MCD, AMZN, etc. Can be small, medium, o" +
    "r large cap. Should be kept domestic.";
            this.textBox21.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox22
            // 
            this.textBox22.BackColor = System.Drawing.SystemColors.MenuText;
            this.textBox22.ForeColor = System.Drawing.Color.White;
            this.textBox22.Location = new System.Drawing.Point(433, 359);
            this.textBox22.Multiline = true;
            this.textBox22.Name = "textBox22";
            this.textBox22.ReadOnly = true;
            this.textBox22.Size = new System.Drawing.Size(317, 37);
            this.textBox22.TabIndex = 29;
            this.textBox22.TabStop = false;
            this.textBox22.Text = "Includes indices like the S&P 500, DOW JONES, and NASDAQ. Sectors are also includ" +
    "ed.";
            this.textBox22.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox22.TextChanged += new System.EventHandler(this.textBox22_TextChanged);
            // 
            // textBox23
            // 
            this.textBox23.BackColor = System.Drawing.SystemColors.MenuText;
            this.textBox23.ForeColor = System.Drawing.Color.White;
            this.textBox23.Location = new System.Drawing.Point(433, 522);
            this.textBox23.Multiline = true;
            this.textBox23.Name = "textBox23";
            this.textBox23.ReadOnly = true;
            this.textBox23.Size = new System.Drawing.Size(317, 59);
            this.textBox23.TabIndex = 28;
            this.textBox23.TabStop = false;
            this.textBox23.Text = "Includes residential, commercial, industrial, etc. real estate, as well as REITs " +
    "and similar investments.";
            this.textBox23.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox25
            // 
            this.textBox25.BackColor = System.Drawing.SystemColors.MenuText;
            this.textBox25.ForeColor = System.Drawing.Color.White;
            this.textBox25.Location = new System.Drawing.Point(433, 209);
            this.textBox25.Multiline = true;
            this.textBox25.Name = "textBox25";
            this.textBox25.ReadOnly = true;
            this.textBox25.Size = new System.Drawing.Size(317, 59);
            this.textBox25.TabIndex = 26;
            this.textBox25.TabStop = false;
            this.textBox25.Text = "More secured investments like US Treasury Bonds, CDs, Retirement Plans, Certain a" +
    "nnuities and other similar investments.";
            this.textBox25.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox10
            // 
            this.textBox10.BackColor = System.Drawing.SystemColors.MenuText;
            this.textBox10.ForeColor = System.Drawing.Color.White;
            this.textBox10.Location = new System.Drawing.Point(433, 302);
            this.textBox10.Name = "textBox10";
            this.textBox10.ReadOnly = true;
            this.textBox10.Size = new System.Drawing.Size(317, 22);
            this.textBox10.TabIndex = 38;
            this.textBox10.TabStop = false;
            this.textBox10.Text = "ETFs, Stocks & Real Estate.";
            this.textBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MoneyRisky
            // 
            this.MoneyRisky.BackColor = System.Drawing.Color.Navy;
            this.MoneyRisky.ForeColor = System.Drawing.Color.White;
            this.MoneyRisky.Location = new System.Drawing.Point(270, 302);
            this.MoneyRisky.Name = "MoneyRisky";
            this.MoneyRisky.ReadOnly = true;
            this.MoneyRisky.Size = new System.Drawing.Size(157, 22);
            this.MoneyRisky.TabIndex = 37;
            this.MoneyRisky.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MoneyRisky.TextChanged += new System.EventHandler(this.MoneyRisky_TextChanged);
            // 
            // RiskyPercent
            // 
            this.RiskyPercent.BackColor = System.Drawing.Color.Navy;
            this.RiskyPercent.ForeColor = System.Drawing.Color.White;
            this.RiskyPercent.Location = new System.Drawing.Point(185, 302);
            this.RiskyPercent.Name = "RiskyPercent";
            this.RiskyPercent.ReadOnly = true;
            this.RiskyPercent.Size = new System.Drawing.Size(74, 22);
            this.RiskyPercent.TabIndex = 36;
            this.RiskyPercent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.RiskyPercent.TextChanged += new System.EventHandler(this.RiskyPercent_TextChanged);
            // 
            // textBox24
            // 
            this.textBox24.BackColor = System.Drawing.SystemColors.MenuText;
            this.textBox24.ForeColor = System.Drawing.Color.White;
            this.textBox24.Location = new System.Drawing.Point(12, 302);
            this.textBox24.Name = "textBox24";
            this.textBox24.ReadOnly = true;
            this.textBox24.Size = new System.Drawing.Size(157, 22);
            this.textBox24.TabIndex = 35;
            this.textBox24.TabStop = false;
            this.textBox24.Text = "Risky Investment Total";
            this.textBox24.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // totalCash
            // 
            this.totalCash.BackColor = System.Drawing.Color.Navy;
            this.totalCash.ForeColor = System.Drawing.Color.White;
            this.totalCash.Location = new System.Drawing.Point(271, 599);
            this.totalCash.Name = "totalCash";
            this.totalCash.ReadOnly = true;
            this.totalCash.Size = new System.Drawing.Size(157, 22);
            this.totalCash.TabIndex = 42;
            this.totalCash.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.totalCash.TextChanged += new System.EventHandler(this.textBox7_TextChanged_1);
            // 
            // TotalPercent
            // 
            this.TotalPercent.BackColor = System.Drawing.Color.Navy;
            this.TotalPercent.ForeColor = System.Drawing.Color.White;
            this.TotalPercent.Location = new System.Drawing.Point(186, 599);
            this.TotalPercent.Name = "TotalPercent";
            this.TotalPercent.ReadOnly = true;
            this.TotalPercent.Size = new System.Drawing.Size(74, 22);
            this.TotalPercent.TabIndex = 41;
            this.TotalPercent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TotalPercent.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // Totaltxt
            // 
            this.Totaltxt.BackColor = System.Drawing.SystemColors.MenuText;
            this.Totaltxt.ForeColor = System.Drawing.Color.White;
            this.Totaltxt.Location = new System.Drawing.Point(13, 599);
            this.Totaltxt.Name = "Totaltxt";
            this.Totaltxt.ReadOnly = true;
            this.Totaltxt.Size = new System.Drawing.Size(157, 22);
            this.Totaltxt.TabIndex = 40;
            this.Totaltxt.TabStop = false;
            this.Totaltxt.Text = "Total";
            this.Totaltxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Totaltxt.TextChanged += new System.EventHandler(this.textBox11_TextChanged);
            // 
            // PortfolioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.ClientSize = new System.Drawing.Size(793, 690);
            this.Controls.Add(this.totalCash);
            this.Controls.Add(this.TotalPercent);
            this.Controls.Add(this.Totaltxt);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.MoneyRisky);
            this.Controls.Add(this.RiskyPercent);
            this.Controls.Add(this.textBox24);
            this.Controls.Add(this.textBox21);
            this.Controls.Add(this.textBox22);
            this.Controls.Add(this.textBox23);
            this.Controls.Add(this.textBox25);
            this.Controls.Add(this.MoneyStocks);
            this.Controls.Add(this.MoneyEtf);
            this.Controls.Add(this.MoneyRE);
            this.Controls.Add(this.MoneyStable);
            this.Controls.Add(this.StockPercent);
            this.Controls.Add(this.ETFPercent);
            this.Controls.Add(this.REPercent);
            this.Controls.Add(this.StablePercent);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.textBox13);
            this.Controls.Add(this.textBox15);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "PortfolioForm";
            this.Text = "PortfolioForm";
            this.Load += new System.EventHandler(this.PortfolioForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.TextBox StockPercent;
        private System.Windows.Forms.TextBox ETFPercent;
        private System.Windows.Forms.TextBox REPercent;
        private System.Windows.Forms.TextBox StablePercent;
        private System.Windows.Forms.TextBox MoneyStocks;
        private System.Windows.Forms.TextBox MoneyEtf;
        private System.Windows.Forms.TextBox MoneyRE;
        private System.Windows.Forms.TextBox MoneyStable;
        private System.Windows.Forms.TextBox textBox21;
        private System.Windows.Forms.TextBox textBox22;
        private System.Windows.Forms.TextBox textBox23;
        private System.Windows.Forms.TextBox textBox25;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox MoneyRisky;
        private System.Windows.Forms.TextBox RiskyPercent;
        private System.Windows.Forms.TextBox textBox24;
        private System.Windows.Forms.TextBox totalCash;
        private System.Windows.Forms.TextBox TotalPercent;
        private System.Windows.Forms.TextBox Totaltxt;
    }
}