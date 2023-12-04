namespace CurrencyConverter
{
    partial class CurrencyConverter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CurrencyConverter));
            this.FromConvertCurrency = new System.Windows.Forms.ComboBox();
            this.FromMoney = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.ToConvertCurrency = new System.Windows.Forms.ComboBox();
            this.ToMoney = new System.Windows.Forms.TextBox();
            this.from = new System.Windows.Forms.TextBox();
            this.ShuffleBtn = new System.Windows.Forms.PictureBox();
            this.ConvertBtn = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ShuffleBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // FromConvertCurrency
            // 
            this.FromConvertCurrency.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FromConvertCurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FromConvertCurrency.ForeColor = System.Drawing.Color.White;
            this.FromConvertCurrency.FormattingEnabled = true;
            this.FromConvertCurrency.Location = new System.Drawing.Point(425, 243);
            this.FromConvertCurrency.Name = "FromConvertCurrency";
            this.FromConvertCurrency.Size = new System.Drawing.Size(96, 28);
            this.FromConvertCurrency.TabIndex = 2;
            // 
            // FromMoney
            // 
            this.FromMoney.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FromMoney.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FromMoney.ForeColor = System.Drawing.Color.White;
            this.FromMoney.Location = new System.Drawing.Point(184, 243);
            this.FromMoney.Name = "FromMoney";
            this.FromMoney.Size = new System.Drawing.Size(206, 19);
            this.FromMoney.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft YaHei UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.White;
            this.textBox2.Location = new System.Drawing.Point(12, 12);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(634, 69);
            this.textBox2.TabIndex = 99;
            this.textBox2.Text = "Currency Converter";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ToConvertCurrency
            // 
            this.ToConvertCurrency.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ToConvertCurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ToConvertCurrency.ForeColor = System.Drawing.Color.White;
            this.ToConvertCurrency.FormattingEnabled = true;
            this.ToConvertCurrency.Location = new System.Drawing.Point(425, 392);
            this.ToConvertCurrency.Name = "ToConvertCurrency";
            this.ToConvertCurrency.Size = new System.Drawing.Size(96, 28);
            this.ToConvertCurrency.TabIndex = 3;
            // 
            // ToMoney
            // 
            this.ToMoney.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ToMoney.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ToMoney.ForeColor = System.Drawing.Color.White;
            this.ToMoney.Location = new System.Drawing.Point(184, 394);
            this.ToMoney.Name = "ToMoney";
            this.ToMoney.ReadOnly = true;
            this.ToMoney.Size = new System.Drawing.Size(206, 19);
            this.ToMoney.TabIndex = 99;
            // 
            // from
            // 
            this.from.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.from.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.from.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.from.ForeColor = System.Drawing.Color.White;
            this.from.Location = new System.Drawing.Point(66, 188);
            this.from.Name = "from";
            this.from.ReadOnly = true;
            this.from.Size = new System.Drawing.Size(104, 23);
            this.from.TabIndex = 99;
            this.from.Text = "From";
            // 
            // ShuffleBtn
            // 
            this.ShuffleBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ShuffleBtn.Image = ((System.Drawing.Image)(resources.GetObject("ShuffleBtn.Image")));
            this.ShuffleBtn.Location = new System.Drawing.Point(277, 297);
            this.ShuffleBtn.Name = "ShuffleBtn";
            this.ShuffleBtn.Size = new System.Drawing.Size(92, 75);
            this.ShuffleBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ShuffleBtn.TabIndex = 4;
            this.ShuffleBtn.TabStop = false;
            this.ShuffleBtn.Click += new System.EventHandler(this.ShuffleBtn_Click);
            // 
            // ConvertBtn
            // 
            this.ConvertBtn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ConvertBtn.FlatAppearance.BorderSize = 0;
            this.ConvertBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConvertBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConvertBtn.Location = new System.Drawing.Point(247, 521);
            this.ConvertBtn.Name = "ConvertBtn";
            this.ConvertBtn.Size = new System.Drawing.Size(152, 52);
            this.ConvertBtn.TabIndex = 4;
            this.ConvertBtn.Text = "Convert";
            this.ConvertBtn.UseVisualStyleBackColor = false;
            this.ConvertBtn.Click += new System.EventHandler(this.ConvertBtn_Click);
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBox6.Location = new System.Drawing.Point(-10, 649);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(679, 39);
            this.textBox6.TabIndex = 99;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox4.ForeColor = System.Drawing.Color.White;
            this.textBox4.Location = new System.Drawing.Point(66, 349);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(104, 23);
            this.textBox4.TabIndex = 99;
            this.textBox4.Text = "To";
            // 
            // CurrencyConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(658, 683);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.ConvertBtn);
            this.Controls.Add(this.ShuffleBtn);
            this.Controls.Add(this.from);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.ToMoney);
            this.Controls.Add(this.FromMoney);
            this.Controls.Add(this.ToConvertCurrency);
            this.Controls.Add(this.FromConvertCurrency);
            this.ForeColor = System.Drawing.Color.Snow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CurrencyConverter";
            this.Text = "Currency Converter";
            ((System.ComponentModel.ISupportInitialize)(this.ShuffleBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox FromConvertCurrency;
        private System.Windows.Forms.TextBox FromMoney;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox ToConvertCurrency;
        private System.Windows.Forms.TextBox ToMoney;
        private System.Windows.Forms.TextBox from;
        private System.Windows.Forms.PictureBox ShuffleBtn;
        private System.Windows.Forms.Button ConvertBtn;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox4;
    }
}

