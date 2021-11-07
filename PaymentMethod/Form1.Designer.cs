
namespace PaymentMethod
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.creditCardBox1 = new PaymentMethod.UserControls.CreditCardBox();
            this.lstTaksitler = new System.Windows.Forms.ListBox();
            this.btnOdemeYap = new System.Windows.Forms.Button();
            this.cmbSecim = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // creditCardBox1
            // 
            this.creditCardBox1.AdSoyad = "";
            this.creditCardBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.creditCardBox1.CardNo = "               ";
            this.creditCardBox1.Cvv = "";
            this.creditCardBox1.Location = new System.Drawing.Point(12, 100);
            this.creditCardBox1.Name = "creditCardBox1";
            this.creditCardBox1.Size = new System.Drawing.Size(361, 169);
            this.creditCardBox1.TabIndex = 0;
            this.creditCardBox1.AdSoyadHata += new PaymentMethod.UserControls.AdSoyadHataEvent(this.creditCardBox1_AdSoyadHata);
            // 
            // lstTaksitler
            // 
            this.lstTaksitler.FormattingEnabled = true;
            this.lstTaksitler.ItemHeight = 25;
            this.lstTaksitler.Location = new System.Drawing.Point(394, 32);
            this.lstTaksitler.Name = "lstTaksitler";
            this.lstTaksitler.Size = new System.Drawing.Size(322, 329);
            this.lstTaksitler.TabIndex = 1;
            // 
            // btnOdemeYap
            // 
            this.btnOdemeYap.Location = new System.Drawing.Point(12, 291);
            this.btnOdemeYap.Name = "btnOdemeYap";
            this.btnOdemeYap.Size = new System.Drawing.Size(361, 70);
            this.btnOdemeYap.TabIndex = 2;
            this.btnOdemeYap.Text = "Ödeme Yap";
            this.btnOdemeYap.UseVisualStyleBackColor = true;
            this.btnOdemeYap.Click += new System.EventHandler(this.btnOdemeYap_Click);
            // 
            // cmbSecim
            // 
            this.cmbSecim.FormattingEnabled = true;
            this.cmbSecim.Location = new System.Drawing.Point(129, 34);
            this.cmbSecim.Name = "cmbSecim";
            this.cmbSecim.Size = new System.Drawing.Size(244, 33);
            this.cmbSecim.TabIndex = 3;
            this.cmbSecim.SelectedIndexChanged += new System.EventHandler(this.cmbSecim_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kart Seçiniz";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 421);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbSecim);
            this.Controls.Add(this.btnOdemeYap);
            this.Controls.Add(this.lstTaksitler);
            this.Controls.Add(this.creditCardBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.CreditCardBox creditCardBox1;
        private System.Windows.Forms.ListBox lstTaksitler;
        private System.Windows.Forms.Button btnOdemeYap;
        private System.Windows.Forms.ComboBox cmbSecim;
        private System.Windows.Forms.Label label1;
    }
}

