namespace ClientTemperatura
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
            this.TempInici_cb = new System.Windows.Forms.ComboBox();
            this.De_lbl = new System.Windows.Forms.Label();
            this.Temperatura_tb = new System.Windows.Forms.TextBox();
            this.Envia_btn = new System.Windows.Forms.Button();
            this.A_lbl = new System.Windows.Forms.Label();
            this.TempFinal_cb = new System.Windows.Forms.ComboBox();
            this.Connecta_btn = new System.Windows.Forms.Button();
            this.Desconnecta_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TempInici_cb
            // 
            this.TempInici_cb.FormattingEnabled = true;
            this.TempInici_cb.Items.AddRange(new object[] {
            "Celcius (C)",
            "Kelvin (K)",
            "Farenheit (F)",
            "Rankine (Ra)"});
            this.TempInici_cb.Location = new System.Drawing.Point(83, 182);
            this.TempInici_cb.Name = "TempInici_cb";
            this.TempInici_cb.Size = new System.Drawing.Size(121, 24);
            this.TempInici_cb.TabIndex = 0;
            this.TempInici_cb.SelectedIndexChanged += new System.EventHandler(this.TempInici_cb_SelectedIndexChanged);
            // 
            // De_lbl
            // 
            this.De_lbl.AutoSize = true;
            this.De_lbl.Location = new System.Drawing.Point(120, 147);
            this.De_lbl.Name = "De_lbl";
            this.De_lbl.Size = new System.Drawing.Size(30, 17);
            this.De_lbl.TabIndex = 1;
            this.De_lbl.Text = "De:\r\n";
            // 
            // Temperatura_tb
            // 
            this.Temperatura_tb.Location = new System.Drawing.Point(137, 87);
            this.Temperatura_tb.Name = "Temperatura_tb";
            this.Temperatura_tb.Size = new System.Drawing.Size(187, 22);
            this.Temperatura_tb.TabIndex = 2;
            // 
            // Envia_btn
            // 
            this.Envia_btn.Location = new System.Drawing.Point(197, 252);
            this.Envia_btn.Name = "Envia_btn";
            this.Envia_btn.Size = new System.Drawing.Size(75, 23);
            this.Envia_btn.TabIndex = 3;
            this.Envia_btn.Text = "Envia";
            this.Envia_btn.UseVisualStyleBackColor = true;
            this.Envia_btn.Click += new System.EventHandler(this.Envia_btn_Click);
            // 
            // A_lbl
            // 
            this.A_lbl.AutoSize = true;
            this.A_lbl.Location = new System.Drawing.Point(303, 147);
            this.A_lbl.Name = "A_lbl";
            this.A_lbl.Size = new System.Drawing.Size(21, 17);
            this.A_lbl.TabIndex = 4;
            this.A_lbl.Text = "A:\r\n";
            // 
            // TempFinal_cb
            // 
            this.TempFinal_cb.FormattingEnabled = true;
            this.TempFinal_cb.Items.AddRange(new object[] {
            "Celcius (C)",
            "Kelvin (K)",
            "Farenheit (F)",
            "Rankine (Ra)"});
            this.TempFinal_cb.Location = new System.Drawing.Point(259, 182);
            this.TempFinal_cb.Name = "TempFinal_cb";
            this.TempFinal_cb.Size = new System.Drawing.Size(121, 24);
            this.TempFinal_cb.TabIndex = 5;
            // 
            // Connecta_btn
            // 
            this.Connecta_btn.Location = new System.Drawing.Point(83, 306);
            this.Connecta_btn.Name = "Connecta_btn";
            this.Connecta_btn.Size = new System.Drawing.Size(110, 92);
            this.Connecta_btn.TabIndex = 6;
            this.Connecta_btn.Text = "Connecta";
            this.Connecta_btn.UseVisualStyleBackColor = true;
            this.Connecta_btn.Click += new System.EventHandler(this.Connecta_btn_Click);
            // 
            // Desconnecta_btn
            // 
            this.Desconnecta_btn.Location = new System.Drawing.Point(270, 306);
            this.Desconnecta_btn.Name = "Desconnecta_btn";
            this.Desconnecta_btn.Size = new System.Drawing.Size(110, 92);
            this.Desconnecta_btn.TabIndex = 7;
            this.Desconnecta_btn.Text = "Desconnecta";
            this.Desconnecta_btn.UseVisualStyleBackColor = true;
            this.Desconnecta_btn.Click += new System.EventHandler(this.Desconnecta_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 447);
            this.Controls.Add(this.Desconnecta_btn);
            this.Controls.Add(this.Connecta_btn);
            this.Controls.Add(this.TempFinal_cb);
            this.Controls.Add(this.A_lbl);
            this.Controls.Add(this.Envia_btn);
            this.Controls.Add(this.Temperatura_tb);
            this.Controls.Add(this.De_lbl);
            this.Controls.Add(this.TempInici_cb);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox TempInici_cb;
        private System.Windows.Forms.Label De_lbl;
        private System.Windows.Forms.TextBox Temperatura_tb;
        private System.Windows.Forms.Button Envia_btn;
        private System.Windows.Forms.Label A_lbl;
        private System.Windows.Forms.ComboBox TempFinal_cb;
        private System.Windows.Forms.Button Connecta_btn;
        private System.Windows.Forms.Button Desconnecta_btn;
    }
}

