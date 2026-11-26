namespace ContiCorrenti
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_invioDati = new System.Windows.Forms.Button();
            this.lst_nomi = new System.Windows.Forms.ListBox();
            this.lst_nConto = new System.Windows.Forms.ListBox();
            this.lst_Saldo = new System.Windows.Forms.ListBox();
            this.lbl_nomi = new System.Windows.Forms.Label();
            this.lbl_numeriConto = new System.Windows.Forms.Label();
            this.lbl_saldi = new System.Windows.Forms.Label();
            this.lbl_titolo = new System.Windows.Forms.Label();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.lbl_nConto = new System.Windows.Forms.Label();
            this.lbl_saldo = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txt_nConto = new System.Windows.Forms.TextBox();
            this.txt_saldo = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_invioDati
            // 
            this.btn_invioDati.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_invioDati.Location = new System.Drawing.Point(797, 175);
            this.btn_invioDati.Name = "btn_invioDati";
            this.btn_invioDati.Size = new System.Drawing.Size(175, 60);
            this.btn_invioDati.TabIndex = 0;
            this.btn_invioDati.Text = "INVIA DATI";
            this.btn_invioDati.UseVisualStyleBackColor = true;
            // 
            // lst_nomi
            // 
            this.lst_nomi.FormattingEnabled = true;
            this.lst_nomi.Location = new System.Drawing.Point(105, 109);
            this.lst_nomi.Name = "lst_nomi";
            this.lst_nomi.Size = new System.Drawing.Size(129, 95);
            this.lst_nomi.TabIndex = 1;
            // 
            // lst_nConto
            // 
            this.lst_nConto.FormattingEnabled = true;
            this.lst_nConto.Location = new System.Drawing.Point(358, 109);
            this.lst_nConto.Name = "lst_nConto";
            this.lst_nConto.Size = new System.Drawing.Size(134, 95);
            this.lst_nConto.TabIndex = 2;
            // 
            // lst_Saldo
            // 
            this.lst_Saldo.FormattingEnabled = true;
            this.lst_Saldo.Location = new System.Drawing.Point(626, 109);
            this.lst_Saldo.Name = "lst_Saldo";
            this.lst_Saldo.Size = new System.Drawing.Size(126, 95);
            this.lst_Saldo.TabIndex = 3;
            // 
            // lbl_nomi
            // 
            this.lbl_nomi.AutoSize = true;
            this.lbl_nomi.Font = new System.Drawing.Font("Myriad Arabic", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl_nomi.Location = new System.Drawing.Point(140, 70);
            this.lbl_nomi.Name = "lbl_nomi";
            this.lbl_nomi.Size = new System.Drawing.Size(56, 28);
            this.lbl_nomi.TabIndex = 4;
            this.lbl_nomi.Text = "NOMI[]";
            // 
            // lbl_numeriConto
            // 
            this.lbl_numeriConto.AutoSize = true;
            this.lbl_numeriConto.Font = new System.Drawing.Font("Myriad Arabic", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbl_numeriConto.Location = new System.Drawing.Point(364, 70);
            this.lbl_numeriConto.Name = "lbl_numeriConto";
            this.lbl_numeriConto.Size = new System.Drawing.Size(117, 28);
            this.lbl_numeriConto.TabIndex = 5;
            this.lbl_numeriConto.Text = "NUMERI CONTO[]";
            // 
            // lbl_saldi
            // 
            this.lbl_saldi.AutoSize = true;
            this.lbl_saldi.Font = new System.Drawing.Font("Myriad Arabic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_saldi.Location = new System.Drawing.Point(653, 70);
            this.lbl_saldi.Name = "lbl_saldi";
            this.lbl_saldi.Size = new System.Drawing.Size(64, 28);
            this.lbl_saldi.TabIndex = 6;
            this.lbl_saldi.Text = "SALDO[]";
            // 
            // lbl_titolo
            // 
            this.lbl_titolo.AutoSize = true;
            this.lbl_titolo.Font = new System.Drawing.Font("Myriad Arabic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titolo.Location = new System.Drawing.Point(349, 9);
            this.lbl_titolo.Name = "lbl_titolo";
            this.lbl_titolo.Size = new System.Drawing.Size(211, 54);
            this.lbl_titolo.TabIndex = 7;
            this.lbl_titolo.Text = "CONTI BANCARI";
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(102, 234);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(84, 13);
            this.lbl_nome.TabIndex = 8;
            this.lbl_nome.Text = "Inserisci il nome:";
            // 
            // lbl_nConto
            // 
            this.lbl_nConto.AutoSize = true;
            this.lbl_nConto.Location = new System.Drawing.Point(355, 234);
            this.lbl_nConto.Name = "lbl_nConto";
            this.lbl_nConto.Size = new System.Drawing.Size(140, 13);
            this.lbl_nConto.TabIndex = 11;
            this.lbl_nConto.Text = "Inserisci il numero del conto:";
            // 
            // lbl_saldo
            // 
            this.lbl_saldo.AutoSize = true;
            this.lbl_saldo.Location = new System.Drawing.Point(623, 234);
            this.lbl_saldo.Name = "lbl_saldo";
            this.lbl_saldo.Size = new System.Drawing.Size(83, 13);
            this.lbl_saldo.TabIndex = 12;
            this.lbl_saldo.Text = "Inserisci il saldo:";
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(105, 265);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(100, 20);
            this.txt_nome.TabIndex = 13;
            // 
            // txt_nConto
            // 
            this.txt_nConto.Location = new System.Drawing.Point(358, 265);
            this.txt_nConto.Name = "txt_nConto";
            this.txt_nConto.Size = new System.Drawing.Size(100, 20);
            this.txt_nConto.TabIndex = 14;
            // 
            // txt_saldo
            // 
            this.txt_saldo.Location = new System.Drawing.Point(626, 265);
            this.txt_saldo.Name = "txt_saldo";
            this.txt_saldo.Size = new System.Drawing.Size(100, 20);
            this.txt_saldo.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(52, 413);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(205, 413);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(336, 413);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 18;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(462, 413);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 19;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(578, 413);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 20;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(694, 413);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 21;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 365);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(226, 365);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(355, 365);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(482, 365);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(591, 365);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(717, 365);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "label6";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 503);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_saldo);
            this.Controls.Add(this.txt_nConto);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.lbl_saldo);
            this.Controls.Add(this.lbl_nConto);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.lbl_titolo);
            this.Controls.Add(this.lbl_saldi);
            this.Controls.Add(this.lbl_numeriConto);
            this.Controls.Add(this.lbl_nomi);
            this.Controls.Add(this.lst_Saldo);
            this.Controls.Add(this.lst_nConto);
            this.Controls.Add(this.lst_nomi);
            this.Controls.Add(this.btn_invioDati);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_invioDati;
        private System.Windows.Forms.ListBox lst_nomi;
        private System.Windows.Forms.ListBox lst_nConto;
        private System.Windows.Forms.ListBox lst_Saldo;
        private System.Windows.Forms.Label lbl_nomi;
        private System.Windows.Forms.Label lbl_numeriConto;
        private System.Windows.Forms.Label lbl_saldi;
        private System.Windows.Forms.Label lbl_titolo;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label lbl_nConto;
        private System.Windows.Forms.Label lbl_saldo;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.TextBox txt_nConto;
        private System.Windows.Forms.TextBox txt_saldo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

