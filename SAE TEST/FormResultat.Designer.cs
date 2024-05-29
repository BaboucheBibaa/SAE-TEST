namespace SAE_TEST
{
    partial class FormResultat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormResultat));
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            lblAdresseIP = new Label();
            lblMasque = new Label();
            lblClasseIP = new Label();
            lblAdrNet = new Label();
            lblAdrBroad = new Label();
            lblPremIP = new Label();
            lblDernIP = new Label();
            lblNbIP = new Label();
            lblNbMachines = new Label();
            txtClassIP = new TextBox();
            txtAdrNet = new TextBox();
            txtAdrBroad = new TextBox();
            txtPremIP = new TextBox();
            txtDernIP = new TextBox();
            txtNbIP = new TextBox();
            txtNbMachines = new TextBox();
            btnConvertir = new Button();
            rdoDecimal = new RadioButton();
            rdoHexa = new RadioButton();
            rdoBinaire = new RadioButton();
            btnRetour = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Control;
            textBox1.Location = new Point(111, 47);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(193, 23);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.Control;
            textBox2.Location = new Point(112, 87);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(192, 23);
            textBox2.TabIndex = 1;
            // 
            // lblAdresseIP
            // 
            lblAdresseIP.AutoSize = true;
            lblAdresseIP.BackColor = SystemColors.Control;
            lblAdresseIP.Font = new Font("Microsoft PhagsPa", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAdresseIP.Location = new Point(33, 49);
            lblAdresseIP.Name = "lblAdresseIP";
            lblAdresseIP.Size = new Size(61, 16);
            lblAdresseIP.TabIndex = 2;
            lblAdresseIP.Text = "Adresse IP";
            lblAdresseIP.Click += label1_Click;
            // 
            // lblMasque
            // 
            lblMasque.AutoSize = true;
            lblMasque.BackColor = SystemColors.Control;
            lblMasque.Location = new Point(45, 90);
            lblMasque.Name = "lblMasque";
            lblMasque.Size = new Size(49, 15);
            lblMasque.TabIndex = 3;
            lblMasque.Text = "Masque";
            lblMasque.Click += label2_Click;
            // 
            // lblClasseIP
            // 
            lblClasseIP.AutoSize = true;
            lblClasseIP.BackColor = SystemColors.Control;
            lblClasseIP.Location = new Point(45, 159);
            lblClasseIP.Name = "lblClasseIP";
            lblClasseIP.Size = new Size(63, 15);
            lblClasseIP.TabIndex = 4;
            lblClasseIP.Text = "Classe d'IP";
            // 
            // lblAdrNet
            // 
            lblAdrNet.AutoSize = true;
            lblAdrNet.BackColor = SystemColors.Control;
            lblAdrNet.Location = new Point(45, 197);
            lblAdrNet.Name = "lblAdrNet";
            lblAdrNet.Size = new Size(70, 15);
            lblAdrNet.TabIndex = 5;
            lblAdrNet.Text = "Adresse Net";
            // 
            // lblAdrBroad
            // 
            lblAdrBroad.AutoSize = true;
            lblAdrBroad.BackColor = SystemColors.Control;
            lblAdrBroad.Location = new Point(45, 235);
            lblAdrBroad.Name = "lblAdrBroad";
            lblAdrBroad.Size = new Size(103, 15);
            lblAdrBroad.TabIndex = 6;
            lblAdrBroad.Text = "Adresse Broadcast";
            lblAdrBroad.Click += label3_Click;
            // 
            // lblPremIP
            // 
            lblPremIP.AutoSize = true;
            lblPremIP.BackColor = SystemColors.Control;
            lblPremIP.Location = new Point(45, 273);
            lblPremIP.Name = "lblPremIP";
            lblPremIP.Size = new Size(117, 15);
            lblPremIP.TabIndex = 7;
            lblPremIP.Text = "Première IP utilisable";
            lblPremIP.Click += label4_Click;
            // 
            // lblDernIP
            // 
            lblDernIP.AutoSize = true;
            lblDernIP.BackColor = SystemColors.Control;
            lblDernIP.Location = new Point(45, 311);
            lblDernIP.Name = "lblDernIP";
            lblDernIP.Size = new Size(114, 15);
            lblDernIP.TabIndex = 8;
            lblDernIP.Text = "Dernière IP utilisable";
            lblDernIP.Click += label5_Click;
            // 
            // lblNbIP
            // 
            lblNbIP.AutoSize = true;
            lblNbIP.BackColor = SystemColors.Control;
            lblNbIP.Location = new Point(45, 349);
            lblNbIP.Name = "lblNbIP";
            lblNbIP.Size = new Size(129, 15);
            lblNbIP.TabIndex = 9;
            lblNbIP.Text = "Nombre d'IP utilisables";
            // 
            // lblNbMachines
            // 
            lblNbMachines.AutoSize = true;
            lblNbMachines.BackColor = SystemColors.Control;
            lblNbMachines.Location = new Point(45, 387);
            lblNbMachines.Name = "lblNbMachines";
            lblNbMachines.Size = new Size(176, 15);
            lblNbMachines.TabIndex = 10;
            lblNbMachines.Text = "Nombre de machines utilisables";
            lblNbMachines.Click += lblNbMachines_Click;
            // 
            // txtClassIP
            // 
            txtClassIP.BackColor = SystemColors.Control;
            txtClassIP.Location = new Point(238, 151);
            txtClassIP.Name = "txtClassIP";
            txtClassIP.Size = new Size(192, 23);
            txtClassIP.TabIndex = 11;
            // 
            // txtAdrNet
            // 
            txtAdrNet.BackColor = SystemColors.Control;
            txtAdrNet.Location = new Point(238, 194);
            txtAdrNet.Name = "txtAdrNet";
            txtAdrNet.Size = new Size(192, 23);
            txtAdrNet.TabIndex = 12;
            txtAdrNet.TextChanged += txtAdrNet_TextChanged;
            // 
            // txtAdrBroad
            // 
            txtAdrBroad.BackColor = SystemColors.Control;
            txtAdrBroad.Location = new Point(238, 235);
            txtAdrBroad.Name = "txtAdrBroad";
            txtAdrBroad.Size = new Size(192, 23);
            txtAdrBroad.TabIndex = 13;
            // 
            // txtPremIP
            // 
            txtPremIP.BackColor = SystemColors.Control;
            txtPremIP.Location = new Point(238, 273);
            txtPremIP.Name = "txtPremIP";
            txtPremIP.Size = new Size(192, 23);
            txtPremIP.TabIndex = 14;
            // 
            // txtDernIP
            // 
            txtDernIP.BackColor = SystemColors.Control;
            txtDernIP.Location = new Point(238, 311);
            txtDernIP.Name = "txtDernIP";
            txtDernIP.Size = new Size(192, 23);
            txtDernIP.TabIndex = 15;
            // 
            // txtNbIP
            // 
            txtNbIP.BackColor = SystemColors.Control;
            txtNbIP.Location = new Point(238, 346);
            txtNbIP.Name = "txtNbIP";
            txtNbIP.Size = new Size(192, 23);
            txtNbIP.TabIndex = 16;
            // 
            // txtNbMachines
            // 
            txtNbMachines.BackColor = SystemColors.Control;
            txtNbMachines.Location = new Point(238, 384);
            txtNbMachines.Name = "txtNbMachines";
            txtNbMachines.Size = new Size(192, 23);
            txtNbMachines.TabIndex = 17;
            // 
            // btnConvertir
            // 
            btnConvertir.BackColor = SystemColors.Control;
            btnConvertir.Location = new Point(551, 90);
            btnConvertir.Name = "btnConvertir";
            btnConvertir.Size = new Size(75, 23);
            btnConvertir.TabIndex = 18;
            btnConvertir.Text = "Convertir";
            btnConvertir.UseVisualStyleBackColor = false;
            // 
            // rdoDecimal
            // 
            rdoDecimal.AutoSize = true;
            rdoDecimal.BackColor = SystemColors.Control;
            rdoDecimal.Location = new Point(551, 134);
            rdoDecimal.Name = "rdoDecimal";
            rdoDecimal.Size = new Size(68, 19);
            rdoDecimal.TabIndex = 19;
            rdoDecimal.Text = "Décimal";
            rdoDecimal.UseVisualStyleBackColor = false;
            // 
            // rdoHexa
            // 
            rdoHexa.AutoSize = true;
            rdoHexa.BackColor = SystemColors.Control;
            rdoHexa.Location = new Point(649, 134);
            rdoHexa.Name = "rdoHexa";
            rdoHexa.Size = new Size(94, 19);
            rdoHexa.TabIndex = 20;
            rdoHexa.Text = "Hexadécimal";
            rdoHexa.UseVisualStyleBackColor = false;
            rdoHexa.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // rdoBinaire
            // 
            rdoBinaire.AutoSize = true;
            rdoBinaire.BackColor = SystemColors.Control;
            rdoBinaire.Location = new Point(769, 134);
            rdoBinaire.Name = "rdoBinaire";
            rdoBinaire.Size = new Size(61, 19);
            rdoBinaire.TabIndex = 21;
            rdoBinaire.Text = "Binaire";
            rdoBinaire.UseVisualStyleBackColor = false;
            // 
            // btnRetour
            // 
            btnRetour.Location = new Point(745, 411);
            btnRetour.Name = "btnRetour";
            btnRetour.Size = new Size(140, 23);
            btnRetour.TabIndex = 22;
            btnRetour.Text = "Retour au paramètrage";
            btnRetour.UseVisualStyleBackColor = true;
            btnRetour.Click += btnRetour_Click;
            // 
            // FormResultat
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(897, 446);
            Controls.Add(btnRetour);
            Controls.Add(rdoBinaire);
            Controls.Add(rdoHexa);
            Controls.Add(rdoDecimal);
            Controls.Add(btnConvertir);
            Controls.Add(txtNbMachines);
            Controls.Add(txtNbIP);
            Controls.Add(txtDernIP);
            Controls.Add(txtPremIP);
            Controls.Add(txtAdrBroad);
            Controls.Add(txtAdrNet);
            Controls.Add(txtClassIP);
            Controls.Add(lblNbMachines);
            Controls.Add(lblNbIP);
            Controls.Add(lblDernIP);
            Controls.Add(lblPremIP);
            Controls.Add(lblAdrBroad);
            Controls.Add(lblAdrNet);
            Controls.Add(lblClasseIP);
            Controls.Add(lblMasque);
            Controls.Add(lblAdresseIP);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormResultat";
            Text = "IP Converter";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Label lblAdresseIP;
        private Label lblMasque;
        private Label lblClasseIP;
        private Label lblAdrNet;
        private Label lblAdrBroad;
        private Label lblPremIP;
        private Label lblDernIP;
        private Label lblNbIP;
        private Label lblNbMachines;
        private TextBox txtClassIP;
        private TextBox txtAdrNet;
        private TextBox txtAdrBroad;
        private TextBox txtPremIP;
        private TextBox txtDernIP;
        private TextBox txtNbIP;
        private TextBox txtNbMachines;
        private Button btnConvertir;
        private RadioButton rdoDecimal;
        private RadioButton rdoHexa;
        private RadioButton rdoBinaire;
        private Button btnRetour;
    }
}
