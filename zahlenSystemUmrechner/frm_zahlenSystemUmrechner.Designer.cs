namespace WindowsFormsApplication1
{
    partial class frm_zahlenSystemUmrechner
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_berechnung = new System.Windows.Forms.Button();
            this.rb_hex = new System.Windows.Forms.RadioButton();
            this.lbl_hex = new System.Windows.Forms.Label();
            this.tb_hex = new System.Windows.Forms.TextBox();
            this.lbl_oktal = new System.Windows.Forms.Label();
            this.rb_oktal = new System.Windows.Forms.RadioButton();
            this.rb_ternär = new System.Windows.Forms.RadioButton();
            this.rb_binär = new System.Windows.Forms.RadioButton();
            this.rb_dezimal = new System.Windows.Forms.RadioButton();
            this.lbl_ternär = new System.Windows.Forms.Label();
            this.lbl_binär = new System.Windows.Forms.Label();
            this.lbl_dezimal = new System.Windows.Forms.Label();
            this.lbl_eingabe = new System.Windows.Forms.Label();
            this.tb_eingabe = new System.Windows.Forms.TextBox();
            this.tb_oktal = new System.Windows.Forms.TextBox();
            this.tb_ternär = new System.Windows.Forms.TextBox();
            this.tb_binär = new System.Windows.Forms.TextBox();
            this.tb_dezimal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_berechnung
            // 
            this.btn_berechnung.BackColor = System.Drawing.Color.Black;
            this.btn_berechnung.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_berechnung.Location = new System.Drawing.Point(21, 220);
            this.btn_berechnung.Name = "btn_berechnung";
            this.btn_berechnung.Size = new System.Drawing.Size(331, 23);
            this.btn_berechnung.TabIndex = 63;
            this.btn_berechnung.Text = "Berechne!";
            this.btn_berechnung.UseVisualStyleBackColor = false;
            this.btn_berechnung.Click += new System.EventHandler(this.btn_berechnung_Click);
            // 
            // rb_hex
            // 
            this.rb_hex.AutoSize = true;
            this.rb_hex.ForeColor = System.Drawing.Color.White;
            this.rb_hex.Location = new System.Drawing.Point(309, 56);
            this.rb_hex.Name = "rb_hex";
            this.rb_hex.Size = new System.Drawing.Size(47, 17);
            this.rb_hex.TabIndex = 62;
            this.rb_hex.TabStop = true;
            this.rb_hex.Text = "Hex.";
            this.rb_hex.UseVisualStyleBackColor = true;
            // 
            // lbl_hex
            // 
            this.lbl_hex.AutoSize = true;
            this.lbl_hex.ForeColor = System.Drawing.Color.White;
            this.lbl_hex.Location = new System.Drawing.Point(18, 193);
            this.lbl_hex.Name = "lbl_hex";
            this.lbl_hex.Size = new System.Drawing.Size(32, 13);
            this.lbl_hex.TabIndex = 61;
            this.lbl_hex.Text = "Hex.:";
            // 
            // tb_hex
            // 
            this.tb_hex.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.tb_hex.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_hex.ForeColor = System.Drawing.Color.White;
            this.tb_hex.Location = new System.Drawing.Point(64, 193);
            this.tb_hex.Name = "tb_hex";
            this.tb_hex.ReadOnly = true;
            this.tb_hex.Size = new System.Drawing.Size(280, 13);
            this.tb_hex.TabIndex = 55;
            // 
            // lbl_oktal
            // 
            this.lbl_oktal.AutoSize = true;
            this.lbl_oktal.ForeColor = System.Drawing.Color.White;
            this.lbl_oktal.Location = new System.Drawing.Point(18, 166);
            this.lbl_oktal.Name = "lbl_oktal";
            this.lbl_oktal.Size = new System.Drawing.Size(35, 13);
            this.lbl_oktal.TabIndex = 60;
            this.lbl_oktal.Text = "Oktal:";
            // 
            // rb_oktal
            // 
            this.rb_oktal.AutoSize = true;
            this.rb_oktal.ForeColor = System.Drawing.Color.White;
            this.rb_oktal.Location = new System.Drawing.Point(256, 56);
            this.rb_oktal.Name = "rb_oktal";
            this.rb_oktal.Size = new System.Drawing.Size(50, 17);
            this.rb_oktal.TabIndex = 50;
            this.rb_oktal.Text = "Oktal";
            this.rb_oktal.UseVisualStyleBackColor = true;
            // 
            // rb_ternär
            // 
            this.rb_ternär.AutoSize = true;
            this.rb_ternär.ForeColor = System.Drawing.Color.White;
            this.rb_ternär.Location = new System.Drawing.Point(194, 56);
            this.rb_ternär.Name = "rb_ternär";
            this.rb_ternär.Size = new System.Drawing.Size(56, 17);
            this.rb_ternär.TabIndex = 49;
            this.rb_ternär.Text = "Ternär";
            this.rb_ternär.UseVisualStyleBackColor = true;
            // 
            // rb_binär
            // 
            this.rb_binär.AutoSize = true;
            this.rb_binär.ForeColor = System.Drawing.Color.White;
            this.rb_binär.Location = new System.Drawing.Point(139, 56);
            this.rb_binär.Name = "rb_binär";
            this.rb_binär.Size = new System.Drawing.Size(49, 17);
            this.rb_binär.TabIndex = 48;
            this.rb_binär.Text = "Binär";
            this.rb_binär.UseVisualStyleBackColor = true;
            // 
            // rb_dezimal
            // 
            this.rb_dezimal.AutoSize = true;
            this.rb_dezimal.Checked = true;
            this.rb_dezimal.ForeColor = System.Drawing.Color.White;
            this.rb_dezimal.Location = new System.Drawing.Point(71, 56);
            this.rb_dezimal.Name = "rb_dezimal";
            this.rb_dezimal.Size = new System.Drawing.Size(62, 17);
            this.rb_dezimal.TabIndex = 47;
            this.rb_dezimal.TabStop = true;
            this.rb_dezimal.Text = "Dezimal";
            this.rb_dezimal.UseVisualStyleBackColor = true;
            // 
            // lbl_ternär
            // 
            this.lbl_ternär.AutoSize = true;
            this.lbl_ternär.ForeColor = System.Drawing.Color.White;
            this.lbl_ternär.Location = new System.Drawing.Point(18, 140);
            this.lbl_ternär.Name = "lbl_ternär";
            this.lbl_ternär.Size = new System.Drawing.Size(41, 13);
            this.lbl_ternär.TabIndex = 59;
            this.lbl_ternär.Text = "Ternär:";
            // 
            // lbl_binär
            // 
            this.lbl_binär.AutoSize = true;
            this.lbl_binär.ForeColor = System.Drawing.Color.White;
            this.lbl_binär.Location = new System.Drawing.Point(18, 114);
            this.lbl_binär.Name = "lbl_binär";
            this.lbl_binär.Size = new System.Drawing.Size(34, 13);
            this.lbl_binär.TabIndex = 58;
            this.lbl_binär.Text = "Binär:";
            // 
            // lbl_dezimal
            // 
            this.lbl_dezimal.AutoSize = true;
            this.lbl_dezimal.ForeColor = System.Drawing.Color.White;
            this.lbl_dezimal.Location = new System.Drawing.Point(18, 88);
            this.lbl_dezimal.Name = "lbl_dezimal";
            this.lbl_dezimal.Size = new System.Drawing.Size(47, 13);
            this.lbl_dezimal.TabIndex = 57;
            this.lbl_dezimal.Text = "Dezimal:";
            // 
            // lbl_eingabe
            // 
            this.lbl_eingabe.AutoSize = true;
            this.lbl_eingabe.ForeColor = System.Drawing.Color.White;
            this.lbl_eingabe.Location = new System.Drawing.Point(18, 27);
            this.lbl_eingabe.Name = "lbl_eingabe";
            this.lbl_eingabe.Size = new System.Drawing.Size(49, 13);
            this.lbl_eingabe.TabIndex = 56;
            this.lbl_eingabe.Text = "Eingabe:";
            // 
            // tb_eingabe
            // 
            this.tb_eingabe.BackColor = System.Drawing.SystemColors.GrayText;
            this.tb_eingabe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_eingabe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.tb_eingabe.ForeColor = System.Drawing.Color.White;
            this.tb_eingabe.Location = new System.Drawing.Point(72, 24);
            this.tb_eingabe.Name = "tb_eingabe";
            this.tb_eingabe.Size = new System.Drawing.Size(280, 21);
            this.tb_eingabe.TabIndex = 46;
            this.tb_eingabe.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_eingabe_KeyDown);
            // 
            // tb_oktal
            // 
            this.tb_oktal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.tb_oktal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_oktal.ForeColor = System.Drawing.Color.White;
            this.tb_oktal.Location = new System.Drawing.Point(64, 166);
            this.tb_oktal.Name = "tb_oktal";
            this.tb_oktal.ReadOnly = true;
            this.tb_oktal.Size = new System.Drawing.Size(280, 13);
            this.tb_oktal.TabIndex = 54;
            // 
            // tb_ternär
            // 
            this.tb_ternär.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.tb_ternär.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_ternär.ForeColor = System.Drawing.Color.White;
            this.tb_ternär.Location = new System.Drawing.Point(64, 140);
            this.tb_ternär.Name = "tb_ternär";
            this.tb_ternär.ReadOnly = true;
            this.tb_ternär.Size = new System.Drawing.Size(280, 13);
            this.tb_ternär.TabIndex = 53;
            // 
            // tb_binär
            // 
            this.tb_binär.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.tb_binär.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_binär.ForeColor = System.Drawing.Color.White;
            this.tb_binär.Location = new System.Drawing.Point(64, 114);
            this.tb_binär.Name = "tb_binär";
            this.tb_binär.ReadOnly = true;
            this.tb_binär.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tb_binär.Size = new System.Drawing.Size(280, 13);
            this.tb_binär.TabIndex = 52;
            // 
            // tb_dezimal
            // 
            this.tb_dezimal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.tb_dezimal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_dezimal.ForeColor = System.Drawing.Color.White;
            this.tb_dezimal.Location = new System.Drawing.Point(64, 88);
            this.tb_dezimal.Name = "tb_dezimal";
            this.tb_dezimal.ReadOnly = true;
            this.tb_dezimal.Size = new System.Drawing.Size(280, 13);
            this.tb_dezimal.TabIndex = 51;
            // 
            // frm_zahlenSystemUmrechner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(375, 266);
            this.Controls.Add(this.btn_berechnung);
            this.Controls.Add(this.rb_hex);
            this.Controls.Add(this.lbl_hex);
            this.Controls.Add(this.tb_hex);
            this.Controls.Add(this.lbl_oktal);
            this.Controls.Add(this.rb_oktal);
            this.Controls.Add(this.rb_ternär);
            this.Controls.Add(this.rb_binär);
            this.Controls.Add(this.rb_dezimal);
            this.Controls.Add(this.lbl_ternär);
            this.Controls.Add(this.lbl_binär);
            this.Controls.Add(this.lbl_dezimal);
            this.Controls.Add(this.lbl_eingabe);
            this.Controls.Add(this.tb_eingabe);
            this.Controls.Add(this.tb_oktal);
            this.Controls.Add(this.tb_ternär);
            this.Controls.Add(this.tb_binär);
            this.Controls.Add(this.tb_dezimal);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frm_zahlenSystemUmrechner";
            this.ShowIcon = false;
            this.Text = "Umrechner";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Btn_c_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Button btn_berechnung;
        private System.Windows.Forms.RadioButton rb_hex;
        private System.Windows.Forms.Label lbl_hex;
        private System.Windows.Forms.TextBox tb_hex;
        private System.Windows.Forms.Label lbl_oktal;
        private System.Windows.Forms.RadioButton rb_oktal;
        private System.Windows.Forms.RadioButton rb_ternär;
        private System.Windows.Forms.RadioButton rb_binär;
        private System.Windows.Forms.RadioButton rb_dezimal;
        private System.Windows.Forms.Label lbl_ternär;
        private System.Windows.Forms.Label lbl_binär;
        private System.Windows.Forms.Label lbl_dezimal;
        private System.Windows.Forms.Label lbl_eingabe;
        private System.Windows.Forms.TextBox tb_eingabe;
        private System.Windows.Forms.TextBox tb_oktal;
        private System.Windows.Forms.TextBox tb_ternär;
        private System.Windows.Forms.TextBox tb_binär;
        private System.Windows.Forms.TextBox tb_dezimal;
    }
}

