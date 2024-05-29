namespace SAE_TEST
{
    partial class FormParametrage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormParametrage));
            btnConvertir = new Button();
            btnCalculer = new Button();
            panel1 = new Panel();
            rdoIPdecimal = new RadioButton();
            lblMessageErreurIP = new Label();
            txtIP = new TextBox();
            rdoIpBinaire = new RadioButton();
            rdoIpHexadecimal = new RadioButton();
            lblAdrIP = new Label();
            panel2 = new Panel();
            lblMessageErreurMasque = new Label();
            rdoMasqueCIDR = new RadioButton();
            txtMasque = new TextBox();
            rdoMasqueBinaire = new RadioButton();
            rdoMasqueHexadecimal = new RadioButton();
            rdoMasqueDecimal = new RadioButton();
            lblMasque = new Label();
            panel3 = new Panel();
            rdoChoixBinaire = new RadioButton();
            rdoChoixHexadecimal = new RadioButton();
            redoChoixDecimal = new RadioButton();
            label1 = new Label();
            pnlConvertirIP = new Panel();
            txtIP2 = new TextBox();
            rdoIP2binaire = new RadioButton();
            rdoIP2hexadecimal = new RadioButton();
            rdoIP2decimal = new RadioButton();
            lblIP2 = new Label();
            pnlConvertirMasque = new Panel();
            rdoMasque2cidr = new RadioButton();
            txtMasque2 = new TextBox();
            lblMasque2binaire = new RadioButton();
            lblMasque2hexadecimal = new RadioButton();
            lblMasque2decimal = new RadioButton();
            lblMasque2 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            pnlConvertirIP.SuspendLayout();
            pnlConvertirMasque.SuspendLayout();
            SuspendLayout();
            // 
            // btnConvertir
            // 
            btnConvertir.Location = new Point(473, 41);
            btnConvertir.Name = "btnConvertir";
            btnConvertir.Size = new Size(75, 23);
            btnConvertir.TabIndex = 14;
            btnConvertir.Text = "Convertir";
            btnConvertir.UseVisualStyleBackColor = true;
            btnConvertir.Click += btnConvertir_Click;
            // 
            // btnCalculer
            // 
            btnCalculer.Location = new Point(334, 605);
            btnCalculer.Name = "btnCalculer";
            btnCalculer.Size = new Size(75, 23);
            btnCalculer.TabIndex = 27;
            btnCalculer.Text = "Calculer";
            btnCalculer.UseVisualStyleBackColor = true;
            btnCalculer.Click += btnCalculer_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(rdoIPdecimal);
            panel1.Controls.Add(lblMessageErreurIP);
            panel1.Controls.Add(txtIP);
            panel1.Controls.Add(rdoIpBinaire);
            panel1.Controls.Add(rdoIpHexadecimal);
            panel1.Controls.Add(lblAdrIP);
            panel1.Location = new Point(15, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(237, 192);
            panel1.TabIndex = 28;
            // 
            // rdoIPdecimal
            // 
            rdoIPdecimal.AutoSize = true;
            rdoIPdecimal.Location = new Point(25, 50);
            rdoIPdecimal.Name = "rdoIPdecimal";
            rdoIPdecimal.Size = new Size(68, 19);
            rdoIPdecimal.TabIndex = 11;
            rdoIPdecimal.TabStop = true;
            rdoIPdecimal.Text = "Décimal";
            rdoIPdecimal.UseVisualStyleBackColor = true;
            // 
            // lblMessageErreurIP
            // 
            lblMessageErreurIP.AutoSize = true;
            lblMessageErreurIP.ForeColor = Color.Red;
            lblMessageErreurIP.Location = new Point(33, 161);
            lblMessageErreurIP.Name = "lblMessageErreurIP";
            lblMessageErreurIP.Size = new Size(130, 15);
            lblMessageErreurIP.TabIndex = 10;
            lblMessageErreurIP.Text = "Erreur: format incorrect";
            lblMessageErreurIP.Visible = false;
            // 
            // txtIP
            // 
            txtIP.Enabled = false;
            txtIP.Location = new Point(25, 122);
            txtIP.Name = "txtIP";
            txtIP.Size = new Size(193, 23);
            txtIP.TabIndex = 9;
            // 
            // rdoIpBinaire
            // 
            rdoIpBinaire.AutoSize = true;
            rdoIpBinaire.Location = new Point(25, 97);
            rdoIpBinaire.Name = "rdoIpBinaire";
            rdoIpBinaire.Size = new Size(61, 19);
            rdoIpBinaire.TabIndex = 8;
            rdoIpBinaire.TabStop = true;
            rdoIpBinaire.Text = "Binaire";
            rdoIpBinaire.UseVisualStyleBackColor = true;
            // 
            // rdoIpHexadecimal
            // 
            rdoIpHexadecimal.AutoSize = true;
            rdoIpHexadecimal.Location = new Point(25, 72);
            rdoIpHexadecimal.Name = "rdoIpHexadecimal";
            rdoIpHexadecimal.Size = new Size(94, 19);
            rdoIpHexadecimal.TabIndex = 7;
            rdoIpHexadecimal.TabStop = true;
            rdoIpHexadecimal.Text = "Hexadécimal";
            rdoIpHexadecimal.UseVisualStyleBackColor = true;
            rdoIpHexadecimal.CheckedChanged += rdoIpHexadecimal_CheckedChanged;
            // 
            // lblAdrIP
            // 
            lblAdrIP.AutoSize = true;
            lblAdrIP.Location = new Point(25, 29);
            lblAdrIP.Name = "lblAdrIP";
            lblAdrIP.Size = new Size(61, 15);
            lblAdrIP.TabIndex = 5;
            lblAdrIP.Text = "Adresse IP";
            // 
            // panel2
            // 
            panel2.Controls.Add(lblMessageErreurMasque);
            panel2.Controls.Add(rdoMasqueCIDR);
            panel2.Controls.Add(txtMasque);
            panel2.Controls.Add(rdoMasqueBinaire);
            panel2.Controls.Add(rdoMasqueHexadecimal);
            panel2.Controls.Add(rdoMasqueDecimal);
            panel2.Controls.Add(lblMasque);
            panel2.Location = new Point(17, 229);
            panel2.Name = "panel2";
            panel2.Size = new Size(237, 191);
            panel2.TabIndex = 29;
            // 
            // lblMessageErreurMasque
            // 
            lblMessageErreurMasque.AutoSize = true;
            lblMessageErreurMasque.ForeColor = Color.Red;
            lblMessageErreurMasque.Location = new Point(31, 166);
            lblMessageErreurMasque.Name = "lblMessageErreurMasque";
            lblMessageErreurMasque.Size = new Size(130, 15);
            lblMessageErreurMasque.TabIndex = 11;
            lblMessageErreurMasque.Text = "Erreur: format incorrect";
            lblMessageErreurMasque.Visible = false;
            // 
            // rdoMasqueCIDR
            // 
            rdoMasqueCIDR.AutoSize = true;
            rdoMasqueCIDR.Location = new Point(22, 100);
            rdoMasqueCIDR.Name = "rdoMasqueCIDR";
            rdoMasqueCIDR.Size = new Size(51, 19);
            rdoMasqueCIDR.TabIndex = 21;
            rdoMasqueCIDR.TabStop = true;
            rdoMasqueCIDR.Text = "CIDR";
            rdoMasqueCIDR.UseVisualStyleBackColor = true;
            rdoMasqueCIDR.CheckedChanged += rdoMasqueCIDR_CheckedChanged;
            // 
            // txtMasque
            // 
            txtMasque.Enabled = false;
            txtMasque.Location = new Point(22, 125);
            txtMasque.Name = "txtMasque";
            txtMasque.Size = new Size(193, 23);
            txtMasque.TabIndex = 20;
            // 
            // rdoMasqueBinaire
            // 
            rdoMasqueBinaire.AutoSize = true;
            rdoMasqueBinaire.Location = new Point(22, 75);
            rdoMasqueBinaire.Name = "rdoMasqueBinaire";
            rdoMasqueBinaire.Size = new Size(61, 19);
            rdoMasqueBinaire.TabIndex = 19;
            rdoMasqueBinaire.TabStop = true;
            rdoMasqueBinaire.Text = "Binaire";
            rdoMasqueBinaire.UseVisualStyleBackColor = true;
            rdoMasqueBinaire.CheckedChanged += rdoMasqueBinaire_CheckedChanged_1;
            // 
            // rdoMasqueHexadecimal
            // 
            rdoMasqueHexadecimal.AutoSize = true;
            rdoMasqueHexadecimal.Location = new Point(22, 50);
            rdoMasqueHexadecimal.Name = "rdoMasqueHexadecimal";
            rdoMasqueHexadecimal.Size = new Size(94, 19);
            rdoMasqueHexadecimal.TabIndex = 18;
            rdoMasqueHexadecimal.TabStop = true;
            rdoMasqueHexadecimal.Text = "Hexadécimal";
            rdoMasqueHexadecimal.UseVisualStyleBackColor = true;
            rdoMasqueHexadecimal.CheckedChanged += rdoMasqueHexadecimal_CheckedChanged;
            // 
            // rdoMasqueDecimal
            // 
            rdoMasqueDecimal.AutoSize = true;
            rdoMasqueDecimal.Location = new Point(22, 25);
            rdoMasqueDecimal.Name = "rdoMasqueDecimal";
            rdoMasqueDecimal.Size = new Size(68, 19);
            rdoMasqueDecimal.TabIndex = 17;
            rdoMasqueDecimal.TabStop = true;
            rdoMasqueDecimal.Text = "Décimal";
            rdoMasqueDecimal.UseVisualStyleBackColor = true;
            rdoMasqueDecimal.CheckedChanged += rdoMasqueDecimal_CheckedChanged;
            // 
            // lblMasque
            // 
            lblMasque.AutoSize = true;
            lblMasque.Location = new Point(22, 7);
            lblMasque.Name = "lblMasque";
            lblMasque.Size = new Size(49, 15);
            lblMasque.TabIndex = 16;
            lblMasque.Text = "Masque";
            // 
            // panel3
            // 
            panel3.Controls.Add(rdoChoixBinaire);
            panel3.Controls.Add(rdoChoixHexadecimal);
            panel3.Controls.Add(redoChoixDecimal);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(17, 452);
            panel3.Name = "panel3";
            panel3.Size = new Size(235, 122);
            panel3.TabIndex = 30;
            // 
            // rdoChoixBinaire
            // 
            rdoChoixBinaire.AutoSize = true;
            rdoChoixBinaire.Location = new Point(11, 86);
            rdoChoixBinaire.Name = "rdoChoixBinaire";
            rdoChoixBinaire.Size = new Size(61, 19);
            rdoChoixBinaire.TabIndex = 17;
            rdoChoixBinaire.TabStop = true;
            rdoChoixBinaire.Text = "Binaire";
            rdoChoixBinaire.UseVisualStyleBackColor = true;
            // 
            // rdoChoixHexadecimal
            // 
            rdoChoixHexadecimal.AutoSize = true;
            rdoChoixHexadecimal.Location = new Point(11, 61);
            rdoChoixHexadecimal.Name = "rdoChoixHexadecimal";
            rdoChoixHexadecimal.Size = new Size(94, 19);
            rdoChoixHexadecimal.TabIndex = 16;
            rdoChoixHexadecimal.TabStop = true;
            rdoChoixHexadecimal.Text = "Hexadécimal";
            rdoChoixHexadecimal.UseVisualStyleBackColor = true;
            // 
            // redoChoixDecimal
            // 
            redoChoixDecimal.AutoSize = true;
            redoChoixDecimal.Location = new Point(11, 36);
            redoChoixDecimal.Name = "redoChoixDecimal";
            redoChoixDecimal.Size = new Size(68, 19);
            redoChoixDecimal.TabIndex = 15;
            redoChoixDecimal.TabStop = true;
            redoChoixDecimal.Text = "Décimal";
            redoChoixDecimal.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 18);
            label1.Name = "label1";
            label1.Size = new Size(212, 15);
            label1.TabIndex = 14;
            label1.Text = "Choix du type d'affichage des données";
            // 
            // pnlConvertirIP
            // 
            pnlConvertirIP.Controls.Add(txtIP2);
            pnlConvertirIP.Controls.Add(rdoIP2binaire);
            pnlConvertirIP.Controls.Add(rdoIP2hexadecimal);
            pnlConvertirIP.Controls.Add(rdoIP2decimal);
            pnlConvertirIP.Controls.Add(lblIP2);
            pnlConvertirIP.Location = new Point(435, 85);
            pnlConvertirIP.Name = "pnlConvertirIP";
            pnlConvertirIP.Size = new Size(272, 142);
            pnlConvertirIP.TabIndex = 31;
            pnlConvertirIP.Visible = false;
            // 
            // txtIP2
            // 
            txtIP2.Location = new Point(40, 106);
            txtIP2.Name = "txtIP2";
            txtIP2.Size = new Size(193, 23);
            txtIP2.TabIndex = 25;
            // 
            // rdoIP2binaire
            // 
            rdoIP2binaire.AutoSize = true;
            rdoIP2binaire.Location = new Point(40, 81);
            rdoIP2binaire.Name = "rdoIP2binaire";
            rdoIP2binaire.Size = new Size(61, 19);
            rdoIP2binaire.TabIndex = 24;
            rdoIP2binaire.TabStop = true;
            rdoIP2binaire.Text = "Binaire";
            rdoIP2binaire.UseVisualStyleBackColor = true;
            // 
            // rdoIP2hexadecimal
            // 
            rdoIP2hexadecimal.AutoSize = true;
            rdoIP2hexadecimal.Location = new Point(40, 56);
            rdoIP2hexadecimal.Name = "rdoIP2hexadecimal";
            rdoIP2hexadecimal.Size = new Size(94, 19);
            rdoIP2hexadecimal.TabIndex = 23;
            rdoIP2hexadecimal.TabStop = true;
            rdoIP2hexadecimal.Text = "Hexadécimal";
            rdoIP2hexadecimal.UseVisualStyleBackColor = true;
            // 
            // rdoIP2decimal
            // 
            rdoIP2decimal.AutoSize = true;
            rdoIP2decimal.Location = new Point(40, 31);
            rdoIP2decimal.Name = "rdoIP2decimal";
            rdoIP2decimal.Size = new Size(68, 19);
            rdoIP2decimal.TabIndex = 22;
            rdoIP2decimal.TabStop = true;
            rdoIP2decimal.Text = "Décimal";
            rdoIP2decimal.UseVisualStyleBackColor = true;
            // 
            // lblIP2
            // 
            lblIP2.AutoSize = true;
            lblIP2.Location = new Point(40, 13);
            lblIP2.Name = "lblIP2";
            lblIP2.Size = new Size(61, 15);
            lblIP2.TabIndex = 21;
            lblIP2.Text = "Adresse IP";
            // 
            // pnlConvertirMasque
            // 
            pnlConvertirMasque.Controls.Add(rdoMasque2cidr);
            pnlConvertirMasque.Controls.Add(txtMasque2);
            pnlConvertirMasque.Controls.Add(lblMasque2binaire);
            pnlConvertirMasque.Controls.Add(lblMasque2hexadecimal);
            pnlConvertirMasque.Controls.Add(lblMasque2decimal);
            pnlConvertirMasque.Controls.Add(lblMasque2);
            pnlConvertirMasque.Location = new Point(440, 257);
            pnlConvertirMasque.Name = "pnlConvertirMasque";
            pnlConvertirMasque.Size = new Size(259, 180);
            pnlConvertirMasque.TabIndex = 32;
            pnlConvertirMasque.Visible = false;
            // 
            // rdoMasque2cidr
            // 
            rdoMasque2cidr.AutoSize = true;
            rdoMasque2cidr.Location = new Point(33, 113);
            rdoMasque2cidr.Name = "rdoMasque2cidr";
            rdoMasque2cidr.Size = new Size(51, 19);
            rdoMasque2cidr.TabIndex = 32;
            rdoMasque2cidr.TabStop = true;
            rdoMasque2cidr.Text = "CIDR";
            rdoMasque2cidr.UseVisualStyleBackColor = true;
            // 
            // txtMasque2
            // 
            txtMasque2.Location = new Point(33, 138);
            txtMasque2.Name = "txtMasque2";
            txtMasque2.Size = new Size(193, 23);
            txtMasque2.TabIndex = 31;
            // 
            // lblMasque2binaire
            // 
            lblMasque2binaire.AutoSize = true;
            lblMasque2binaire.Location = new Point(33, 88);
            lblMasque2binaire.Name = "lblMasque2binaire";
            lblMasque2binaire.Size = new Size(61, 19);
            lblMasque2binaire.TabIndex = 30;
            lblMasque2binaire.TabStop = true;
            lblMasque2binaire.Text = "Binaire";
            lblMasque2binaire.UseVisualStyleBackColor = true;
            // 
            // lblMasque2hexadecimal
            // 
            lblMasque2hexadecimal.AutoSize = true;
            lblMasque2hexadecimal.Location = new Point(33, 63);
            lblMasque2hexadecimal.Name = "lblMasque2hexadecimal";
            lblMasque2hexadecimal.Size = new Size(94, 19);
            lblMasque2hexadecimal.TabIndex = 29;
            lblMasque2hexadecimal.TabStop = true;
            lblMasque2hexadecimal.Text = "Hexadécimal";
            lblMasque2hexadecimal.UseVisualStyleBackColor = true;
            // 
            // lblMasque2decimal
            // 
            lblMasque2decimal.AutoSize = true;
            lblMasque2decimal.Location = new Point(33, 38);
            lblMasque2decimal.Name = "lblMasque2decimal";
            lblMasque2decimal.Size = new Size(68, 19);
            lblMasque2decimal.TabIndex = 28;
            lblMasque2decimal.TabStop = true;
            lblMasque2decimal.Text = "Décimal";
            lblMasque2decimal.UseVisualStyleBackColor = true;
            // 
            // lblMasque2
            // 
            lblMasque2.AutoSize = true;
            lblMasque2.Location = new Point(33, 20);
            lblMasque2.Name = "lblMasque2";
            lblMasque2.Size = new Size(49, 15);
            lblMasque2.TabIndex = 27;
            lblMasque2.Text = "Masque";
            // 
            // FormParametrage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(745, 640);
            Controls.Add(pnlConvertirMasque);
            Controls.Add(pnlConvertirIP);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btnCalculer);
            Controls.Add(btnConvertir);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormParametrage";
            Text = "IP Converter";
            Load += Form2_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            pnlConvertirIP.ResumeLayout(false);
            pnlConvertirIP.PerformLayout();
            pnlConvertirMasque.ResumeLayout(false);
            pnlConvertirMasque.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btnConvertir;
        private Button btnCalculer;
        private Panel panel1;
        private Label lblMessageErreurIP;
        private TextBox txtIP;
        private RadioButton rdoIpBinaire;
        private RadioButton rdoIpHexadecimal;
        private Label lblAdrIP;
        private Panel panel2;
        private Label lblMessageErreurMasque;
        private RadioButton rdoMasqueCIDR;
        private TextBox txtMasque;
        private RadioButton rdoMasqueBinaire;
        private RadioButton rdoMasqueHexadecimal;
        private RadioButton rdoMasqueDecimal;
        private Label lblMasque;
        private Panel panel3;
        private RadioButton rdoChoixBinaire;
        private RadioButton rdoChoixHexadecimal;
        private RadioButton redoChoixDecimal;
        private Label label1;
        private Panel pnlConvertirIP;
        private TextBox txtIP2;
        private RadioButton rdoIP2binaire;
        private RadioButton rdoIP2hexadecimal;
        private RadioButton rdoIP2decimal;
        private Label lblIP2;
        private Panel pnlConvertirMasque;
        private RadioButton rdoMasque2cidr;
        private TextBox txtMasque2;
        private RadioButton lblMasque2binaire;
        private RadioButton lblMasque2hexadecimal;
        private RadioButton lblMasque2decimal;
        private Label lblMasque2;
        private RadioButton rdoIPdecimal;
    }
}