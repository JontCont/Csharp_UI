namespace FormColculator
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.htmlPanel1 = new MetroFramework.Drawing.Html.HtmlPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.mbCE = new MetroFramework.Controls.MetroButton();
            this.mbC = new MetroFramework.Controls.MetroButton();
            this.mblife = new MetroFramework.Controls.MetroButton();
            this.mbQ = new MetroFramework.Controls.MetroButton();
            this.mb07 = new MetroFramework.Controls.MetroButton();
            this.mb08 = new MetroFramework.Controls.MetroButton();
            this.mb09 = new MetroFramework.Controls.MetroButton();
            this.mbS = new MetroFramework.Controls.MetroButton();
            this.mb04 = new MetroFramework.Controls.MetroButton();
            this.mb05 = new MetroFramework.Controls.MetroButton();
            this.mb06 = new MetroFramework.Controls.MetroButton();
            this.mbN = new MetroFramework.Controls.MetroButton();
            this.mb01 = new MetroFramework.Controls.MetroButton();
            this.mb02 = new MetroFramework.Controls.MetroButton();
            this.mb03 = new MetroFramework.Controls.MetroButton();
            this.mbA = new MetroFramework.Controls.MetroButton();
            this.mbAN = new MetroFramework.Controls.MetroButton();
            this.mb0 = new MetroFramework.Controls.MetroButton();
            this.mbF = new MetroFramework.Controls.MetroButton();
            this.mbAND = new MetroFramework.Controls.MetroButton();
            this.htmlPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // htmlPanel1
            // 
            this.htmlPanel1.AutoScroll = true;
            this.htmlPanel1.AutoScrollMinSize = new System.Drawing.Size(496, 0);
            this.htmlPanel1.BackColor = System.Drawing.SystemColors.Window;
            this.htmlPanel1.Controls.Add(this.label1);
            this.htmlPanel1.Controls.Add(this.TextBox1);
            this.htmlPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.htmlPanel1.Location = new System.Drawing.Point(20, 60);
            this.htmlPanel1.Name = "htmlPanel1";
            this.htmlPanel1.Size = new System.Drawing.Size(496, 75);
            this.htmlPanel1.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(61, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 21);
            this.label1.TabIndex = 24;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TextBox1
            // 
            this.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TextBox1.Font = new System.Drawing.Font("新細明體", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TextBox1.Location = new System.Drawing.Point(55, 24);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(366, 47);
            this.TextBox1.TabIndex = 23;
            this.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // mbCE
            // 
            this.mbCE.BackColor = System.Drawing.Color.Teal;
            this.mbCE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mbCE.ForeColor = System.Drawing.Color.White;
            this.mbCE.Location = new System.Drawing.Point(75, 141);
            this.mbCE.Name = "mbCE";
            this.mbCE.Size = new System.Drawing.Size(87, 63);
            this.mbCE.TabIndex = 24;
            this.mbCE.Text = "CE";
            this.mbCE.UseCustomBackColor = true;
            this.mbCE.UseCustomForeColor = true;
            this.mbCE.UseSelectable = true;
            this.mbCE.UseStyleColors = true;
            this.mbCE.Click += new System.EventHandler(this.MbCE_Click);
            // 
            // mbC
            // 
            this.mbC.BackColor = System.Drawing.Color.Teal;
            this.mbC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mbC.ForeColor = System.Drawing.Color.White;
            this.mbC.Location = new System.Drawing.Point(168, 141);
            this.mbC.Name = "mbC";
            this.mbC.Size = new System.Drawing.Size(87, 63);
            this.mbC.TabIndex = 25;
            this.mbC.Text = "C";
            this.mbC.UseCustomBackColor = true;
            this.mbC.UseCustomForeColor = true;
            this.mbC.UseSelectable = true;
            this.mbC.UseStyleColors = true;
            this.mbC.Click += new System.EventHandler(this.MbC_Click);
            // 
            // mblife
            // 
            this.mblife.BackColor = System.Drawing.Color.Teal;
            this.mblife.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mblife.ForeColor = System.Drawing.Color.White;
            this.mblife.Location = new System.Drawing.Point(261, 141);
            this.mblife.Name = "mblife";
            this.mblife.Size = new System.Drawing.Size(87, 63);
            this.mblife.TabIndex = 26;
            this.mblife.Text = "<=";
            this.mblife.UseCustomBackColor = true;
            this.mblife.UseCustomForeColor = true;
            this.mblife.UseSelectable = true;
            this.mblife.UseStyleColors = true;
            this.mblife.Click += new System.EventHandler(this.Mblife_Click);
            // 
            // mbQ
            // 
            this.mbQ.BackColor = System.Drawing.Color.Teal;
            this.mbQ.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mbQ.ForeColor = System.Drawing.Color.White;
            this.mbQ.Location = new System.Drawing.Point(354, 141);
            this.mbQ.Name = "mbQ";
            this.mbQ.Size = new System.Drawing.Size(87, 63);
            this.mbQ.TabIndex = 27;
            this.mbQ.Text = "/";
            this.mbQ.UseCustomBackColor = true;
            this.mbQ.UseCustomForeColor = true;
            this.mbQ.UseSelectable = true;
            this.mbQ.UseStyleColors = true;
            this.mbQ.Click += new System.EventHandler(this.MbQ_Click);
            // 
            // mb07
            // 
            this.mb07.BackColor = System.Drawing.Color.Teal;
            this.mb07.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mb07.ForeColor = System.Drawing.Color.White;
            this.mb07.Location = new System.Drawing.Point(75, 210);
            this.mb07.Name = "mb07";
            this.mb07.Size = new System.Drawing.Size(87, 63);
            this.mb07.TabIndex = 28;
            this.mb07.Text = "7";
            this.mb07.UseCustomBackColor = true;
            this.mb07.UseCustomForeColor = true;
            this.mb07.UseSelectable = true;
            this.mb07.UseStyleColors = true;
            this.mb07.Click += new System.EventHandler(this.Mb07_Click);
            // 
            // mb08
            // 
            this.mb08.BackColor = System.Drawing.Color.Teal;
            this.mb08.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mb08.ForeColor = System.Drawing.Color.White;
            this.mb08.Location = new System.Drawing.Point(168, 210);
            this.mb08.Name = "mb08";
            this.mb08.Size = new System.Drawing.Size(87, 63);
            this.mb08.TabIndex = 29;
            this.mb08.Text = "8";
            this.mb08.UseCustomBackColor = true;
            this.mb08.UseCustomForeColor = true;
            this.mb08.UseSelectable = true;
            this.mb08.UseStyleColors = true;
            this.mb08.Click += new System.EventHandler(this.Mb08_Click);
            // 
            // mb09
            // 
            this.mb09.BackColor = System.Drawing.Color.Teal;
            this.mb09.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mb09.ForeColor = System.Drawing.Color.White;
            this.mb09.Location = new System.Drawing.Point(261, 210);
            this.mb09.Name = "mb09";
            this.mb09.Size = new System.Drawing.Size(87, 63);
            this.mb09.TabIndex = 30;
            this.mb09.Text = "9";
            this.mb09.UseCustomBackColor = true;
            this.mb09.UseCustomForeColor = true;
            this.mb09.UseSelectable = true;
            this.mb09.UseStyleColors = true;
            this.mb09.Click += new System.EventHandler(this.Mb09_Click);
            // 
            // mbS
            // 
            this.mbS.BackColor = System.Drawing.Color.Teal;
            this.mbS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mbS.ForeColor = System.Drawing.Color.White;
            this.mbS.Location = new System.Drawing.Point(354, 210);
            this.mbS.Name = "mbS";
            this.mbS.Size = new System.Drawing.Size(87, 63);
            this.mbS.TabIndex = 31;
            this.mbS.Text = "*";
            this.mbS.UseCustomBackColor = true;
            this.mbS.UseCustomForeColor = true;
            this.mbS.UseSelectable = true;
            this.mbS.UseStyleColors = true;
            this.mbS.Click += new System.EventHandler(this.MbS_Click);
            // 
            // mb04
            // 
            this.mb04.BackColor = System.Drawing.Color.Teal;
            this.mb04.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mb04.ForeColor = System.Drawing.Color.White;
            this.mb04.Location = new System.Drawing.Point(75, 279);
            this.mb04.Name = "mb04";
            this.mb04.Size = new System.Drawing.Size(87, 63);
            this.mb04.TabIndex = 32;
            this.mb04.Text = "4";
            this.mb04.UseCustomBackColor = true;
            this.mb04.UseCustomForeColor = true;
            this.mb04.UseSelectable = true;
            this.mb04.UseStyleColors = true;
            this.mb04.Click += new System.EventHandler(this.Mb04_Click);
            // 
            // mb05
            // 
            this.mb05.BackColor = System.Drawing.Color.Teal;
            this.mb05.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mb05.ForeColor = System.Drawing.Color.White;
            this.mb05.Location = new System.Drawing.Point(168, 279);
            this.mb05.Name = "mb05";
            this.mb05.Size = new System.Drawing.Size(87, 63);
            this.mb05.TabIndex = 33;
            this.mb05.Text = "5";
            this.mb05.UseCustomBackColor = true;
            this.mb05.UseCustomForeColor = true;
            this.mb05.UseSelectable = true;
            this.mb05.UseStyleColors = true;
            this.mb05.Click += new System.EventHandler(this.Mb05_Click);
            // 
            // mb06
            // 
            this.mb06.BackColor = System.Drawing.Color.Teal;
            this.mb06.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mb06.ForeColor = System.Drawing.Color.White;
            this.mb06.Location = new System.Drawing.Point(261, 279);
            this.mb06.Name = "mb06";
            this.mb06.Size = new System.Drawing.Size(87, 63);
            this.mb06.TabIndex = 34;
            this.mb06.Text = "6";
            this.mb06.UseCustomBackColor = true;
            this.mb06.UseCustomForeColor = true;
            this.mb06.UseSelectable = true;
            this.mb06.UseStyleColors = true;
            this.mb06.Click += new System.EventHandler(this.Mb06_Click);
            // 
            // mbN
            // 
            this.mbN.BackColor = System.Drawing.Color.Teal;
            this.mbN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mbN.ForeColor = System.Drawing.Color.White;
            this.mbN.Location = new System.Drawing.Point(354, 279);
            this.mbN.Name = "mbN";
            this.mbN.Size = new System.Drawing.Size(87, 63);
            this.mbN.TabIndex = 35;
            this.mbN.Text = "-";
            this.mbN.UseCustomBackColor = true;
            this.mbN.UseCustomForeColor = true;
            this.mbN.UseSelectable = true;
            this.mbN.UseStyleColors = true;
            this.mbN.Click += new System.EventHandler(this.MbN_Click);
            // 
            // mb01
            // 
            this.mb01.BackColor = System.Drawing.Color.Teal;
            this.mb01.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mb01.ForeColor = System.Drawing.Color.White;
            this.mb01.Location = new System.Drawing.Point(75, 348);
            this.mb01.Name = "mb01";
            this.mb01.Size = new System.Drawing.Size(87, 63);
            this.mb01.TabIndex = 36;
            this.mb01.Text = "1";
            this.mb01.UseCustomBackColor = true;
            this.mb01.UseCustomForeColor = true;
            this.mb01.UseSelectable = true;
            this.mb01.UseStyleColors = true;
            this.mb01.Click += new System.EventHandler(this.Mb01_Click);
            // 
            // mb02
            // 
            this.mb02.BackColor = System.Drawing.Color.Teal;
            this.mb02.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mb02.ForeColor = System.Drawing.Color.White;
            this.mb02.Location = new System.Drawing.Point(168, 348);
            this.mb02.Name = "mb02";
            this.mb02.Size = new System.Drawing.Size(87, 63);
            this.mb02.TabIndex = 37;
            this.mb02.Text = "2";
            this.mb02.UseCustomBackColor = true;
            this.mb02.UseCustomForeColor = true;
            this.mb02.UseSelectable = true;
            this.mb02.UseStyleColors = true;
            this.mb02.Click += new System.EventHandler(this.Mb02_Click);
            // 
            // mb03
            // 
            this.mb03.BackColor = System.Drawing.Color.Teal;
            this.mb03.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mb03.ForeColor = System.Drawing.Color.White;
            this.mb03.Location = new System.Drawing.Point(261, 348);
            this.mb03.Name = "mb03";
            this.mb03.Size = new System.Drawing.Size(87, 63);
            this.mb03.TabIndex = 38;
            this.mb03.Text = "3";
            this.mb03.UseCustomBackColor = true;
            this.mb03.UseCustomForeColor = true;
            this.mb03.UseSelectable = true;
            this.mb03.UseStyleColors = true;
            this.mb03.Click += new System.EventHandler(this.Mb03_Click);
            // 
            // mbA
            // 
            this.mbA.BackColor = System.Drawing.Color.Teal;
            this.mbA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mbA.ForeColor = System.Drawing.Color.White;
            this.mbA.Location = new System.Drawing.Point(354, 348);
            this.mbA.Name = "mbA";
            this.mbA.Size = new System.Drawing.Size(87, 63);
            this.mbA.TabIndex = 39;
            this.mbA.Text = "+";
            this.mbA.UseCustomBackColor = true;
            this.mbA.UseCustomForeColor = true;
            this.mbA.UseSelectable = true;
            this.mbA.UseStyleColors = true;
            this.mbA.Click += new System.EventHandler(this.MbA_Click);
            // 
            // mbAN
            // 
            this.mbAN.BackColor = System.Drawing.Color.Teal;
            this.mbAN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mbAN.ForeColor = System.Drawing.Color.White;
            this.mbAN.Location = new System.Drawing.Point(75, 417);
            this.mbAN.Name = "mbAN";
            this.mbAN.Size = new System.Drawing.Size(87, 63);
            this.mbAN.TabIndex = 40;
            this.mbAN.Text = "+/-";
            this.mbAN.UseCustomBackColor = true;
            this.mbAN.UseCustomForeColor = true;
            this.mbAN.UseSelectable = true;
            this.mbAN.UseStyleColors = true;
            this.mbAN.Click += new System.EventHandler(this.MbAN_Click);
            // 
            // mb0
            // 
            this.mb0.BackColor = System.Drawing.Color.Teal;
            this.mb0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mb0.ForeColor = System.Drawing.Color.White;
            this.mb0.Location = new System.Drawing.Point(168, 417);
            this.mb0.Name = "mb0";
            this.mb0.Size = new System.Drawing.Size(87, 63);
            this.mb0.TabIndex = 41;
            this.mb0.Text = "0";
            this.mb0.UseCustomBackColor = true;
            this.mb0.UseCustomForeColor = true;
            this.mb0.UseSelectable = true;
            this.mb0.UseStyleColors = true;
            this.mb0.Click += new System.EventHandler(this.Mb0_Click);
            // 
            // mbF
            // 
            this.mbF.BackColor = System.Drawing.Color.Teal;
            this.mbF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mbF.ForeColor = System.Drawing.Color.White;
            this.mbF.Location = new System.Drawing.Point(261, 417);
            this.mbF.Name = "mbF";
            this.mbF.Size = new System.Drawing.Size(87, 63);
            this.mbF.TabIndex = 42;
            this.mbF.Text = ".";
            this.mbF.UseCustomBackColor = true;
            this.mbF.UseCustomForeColor = true;
            this.mbF.UseSelectable = true;
            this.mbF.UseStyleColors = true;
            this.mbF.Click += new System.EventHandler(this.MbF_Click);
            // 
            // mbAND
            // 
            this.mbAND.BackColor = System.Drawing.Color.Teal;
            this.mbAND.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mbAND.ForeColor = System.Drawing.Color.White;
            this.mbAND.Location = new System.Drawing.Point(354, 417);
            this.mbAND.Name = "mbAND";
            this.mbAND.Size = new System.Drawing.Size(87, 63);
            this.mbAND.TabIndex = 43;
            this.mbAND.Text = "=";
            this.mbAND.UseCustomBackColor = true;
            this.mbAND.UseCustomForeColor = true;
            this.mbAND.UseSelectable = true;
            this.mbAND.UseStyleColors = true;
            this.mbAND.Click += new System.EventHandler(this.MbAND_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 510);
            this.Controls.Add(this.mbAND);
            this.Controls.Add(this.mbF);
            this.Controls.Add(this.mb0);
            this.Controls.Add(this.mbAN);
            this.Controls.Add(this.mbA);
            this.Controls.Add(this.mb03);
            this.Controls.Add(this.mb02);
            this.Controls.Add(this.mb01);
            this.Controls.Add(this.mbN);
            this.Controls.Add(this.mb06);
            this.Controls.Add(this.mb05);
            this.Controls.Add(this.mb04);
            this.Controls.Add(this.mbS);
            this.Controls.Add(this.mb09);
            this.Controls.Add(this.mb08);
            this.Controls.Add(this.mb07);
            this.Controls.Add(this.mbQ);
            this.Controls.Add(this.mblife);
            this.Controls.Add(this.mbC);
            this.Controls.Add(this.mbCE);
            this.Controls.Add(this.htmlPanel1);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.htmlPanel1.ResumeLayout(false);
            this.htmlPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Drawing.Html.HtmlPanel htmlPanel1;
        private MetroFramework.Controls.MetroButton mbCE;
        private MetroFramework.Controls.MetroButton mbC;
        private MetroFramework.Controls.MetroButton mblife;
        private MetroFramework.Controls.MetroButton mbQ;
        private MetroFramework.Controls.MetroButton mb07;
        private MetroFramework.Controls.MetroButton mb08;
        private MetroFramework.Controls.MetroButton mb09;
        private MetroFramework.Controls.MetroButton mbS;
        private MetroFramework.Controls.MetroButton mb04;
        private MetroFramework.Controls.MetroButton mb05;
        private MetroFramework.Controls.MetroButton mb06;
        private MetroFramework.Controls.MetroButton mbN;
        private MetroFramework.Controls.MetroButton mb01;
        private MetroFramework.Controls.MetroButton mb02;
        private MetroFramework.Controls.MetroButton mb03;
        private MetroFramework.Controls.MetroButton mbA;
        private MetroFramework.Controls.MetroButton mbAN;
        private MetroFramework.Controls.MetroButton mb0;
        private MetroFramework.Controls.MetroButton mbF;
        private MetroFramework.Controls.MetroButton mbAND;
        private System.Windows.Forms.TextBox TextBox1;
        private System.Windows.Forms.Label label1;
    }
}

