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
            this.btn_punto1 = new System.Windows.Forms.Button();
            this.btn_punto2 = new System.Windows.Forms.Button();
            this.btn_punto3 = new System.Windows.Forms.Button();
            this.btn_punto4 = new System.Windows.Forms.Button();
            this.btn_punto5 = new System.Windows.Forms.Button();
            this.btn_punto6 = new System.Windows.Forms.Button();
            this.lbl_punto2 = new System.Windows.Forms.Label();
            this.lbl_punto3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_punto1 = new System.Windows.Forms.Label();
            this.txt_punto1 = new System.Windows.Forms.TextBox();
            this.lbl_risultato1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_punto2 = new System.Windows.Forms.TextBox();
            this.lbl_risultato2 = new System.Windows.Forms.Label();
            this.lbl_risultato3 = new System.Windows.Forms.Label();
            this.lbl__risultato4 = new System.Windows.Forms.Label();
            this.lbl_risultato5 = new System.Windows.Forms.Label();
            this.lbl_risultato6 = new System.Windows.Forms.Label();
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
            this.btn_invioDati.Click += new System.EventHandler(this.btn_invioDati_Click_1);
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
            // btn_punto1
            // 
            this.btn_punto1.Location = new System.Drawing.Point(12, 398);
            this.btn_punto1.Name = "btn_punto1";
            this.btn_punto1.Size = new System.Drawing.Size(140, 52);
            this.btn_punto1.TabIndex = 16;
            this.btn_punto1.Text = "Clicca per visualizzare nome e saldo";
            this.btn_punto1.UseVisualStyleBackColor = true;
            // 
            // btn_punto2
            // 
            this.btn_punto2.Location = new System.Drawing.Point(205, 391);
            this.btn_punto2.Name = "btn_punto2";
            this.btn_punto2.Size = new System.Drawing.Size(116, 66);
            this.btn_punto2.TabIndex = 17;
            this.btn_punto2.Text = "Clicca per visualizzare saldo e numero del conto";
            this.btn_punto2.UseVisualStyleBackColor = true;
            // 
            // btn_punto3
            // 
            this.btn_punto3.Location = new System.Drawing.Point(351, 364);
            this.btn_punto3.Name = "btn_punto3";
            this.btn_punto3.Size = new System.Drawing.Size(107, 52);
            this.btn_punto3.TabIndex = 18;
            this.btn_punto3.Text = "Clicca per visualizzare chi ha il conto in rosso";
            this.btn_punto3.UseVisualStyleBackColor = true;
            // 
            // btn_punto4
            // 
            this.btn_punto4.Location = new System.Drawing.Point(487, 364);
            this.btn_punto4.Name = "btn_punto4";
            this.btn_punto4.Size = new System.Drawing.Size(121, 72);
            this.btn_punto4.TabIndex = 19;
            this.btn_punto4.Text = "Clicca per visualizzare il contestatario del saldo massimo";
            this.btn_punto4.UseVisualStyleBackColor = true;
            // 
            // btn_punto5
            // 
            this.btn_punto5.Location = new System.Drawing.Point(626, 340);
            this.btn_punto5.Name = "btn_punto5";
            this.btn_punto5.Size = new System.Drawing.Size(114, 48);
            this.btn_punto5.TabIndex = 20;
            this.btn_punto5.Text = "Clicca per visualizzare la media dei saldi";
            this.btn_punto5.UseVisualStyleBackColor = true;
            // 
            // btn_punto6
            // 
            this.btn_punto6.Location = new System.Drawing.Point(787, 340);
            this.btn_punto6.Name = "btn_punto6";
            this.btn_punto6.Size = new System.Drawing.Size(133, 53);
            this.btn_punto6.TabIndex = 21;
            this.btn_punto6.Text = "Clicca per visualizzare i saldi in ordine crescente";
            this.btn_punto6.UseVisualStyleBackColor = true;
            // 
            // lbl_punto2
            // 
            this.lbl_punto2.AutoSize = true;
            this.lbl_punto2.Location = new System.Drawing.Point(205, 340);
            this.lbl_punto2.Name = "lbl_punto2";
            this.lbl_punto2.Size = new System.Drawing.Size(84, 13);
            this.lbl_punto2.TabIndex = 23;
            this.lbl_punto2.Text = "Inserisci il nome:";
            // 
            // lbl_punto3
            // 
            this.lbl_punto3.AutoSize = true;
            this.lbl_punto3.Location = new System.Drawing.Point(337, 340);
            this.lbl_punto3.Name = "lbl_punto3";
            this.lbl_punto3.Size = new System.Drawing.Size(0, 13);
            this.lbl_punto3.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(81, 364);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 28;
            // 
            // lbl_punto1
            // 
            this.lbl_punto1.AutoSize = true;
            this.lbl_punto1.Location = new System.Drawing.Point(12, 340);
            this.lbl_punto1.Name = "lbl_punto1";
            this.lbl_punto1.Size = new System.Drawing.Size(140, 13);
            this.lbl_punto1.TabIndex = 29;
            this.lbl_punto1.Text = "Inserisci il numero del conto:";
            // 
            // txt_punto1
            // 
            this.txt_punto1.Location = new System.Drawing.Point(15, 364);
            this.txt_punto1.Name = "txt_punto1";
            this.txt_punto1.Size = new System.Drawing.Size(100, 20);
            this.txt_punto1.TabIndex = 30;
            // 
            // lbl_risultato1
            // 
            this.lbl_risultato1.AutoSize = true;
            this.lbl_risultato1.Location = new System.Drawing.Point(18, 466);
            this.lbl_risultato1.Name = "lbl_risultato1";
            this.lbl_risultato1.Size = new System.Drawing.Size(75, 13);
            this.lbl_risultato1.TabIndex = 31;
            this.lbl_risultato1.Text = "Nome e saldo:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(186, 325);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(10, 169);
            this.label9.TabIndex = 32;
            this.label9.Text = "|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(327, 325);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(10, 169);
            this.label10.TabIndex = 33;
            this.label10.Text = "|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(471, 325);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(10, 169);
            this.label11.TabIndex = 34;
            this.label11.Text = "|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(607, 325);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(10, 169);
            this.label12.TabIndex = 35;
            this.label12.Text = "|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(751, 325);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(10, 169);
            this.label13.TabIndex = 36;
            this.label13.Text = "|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|";
            // 
            // txt_punto2
            // 
            this.txt_punto2.Location = new System.Drawing.Point(208, 365);
            this.txt_punto2.Name = "txt_punto2";
            this.txt_punto2.Size = new System.Drawing.Size(100, 20);
            this.txt_punto2.TabIndex = 37;
            // 
            // lbl_risultato2
            // 
            this.lbl_risultato2.AutoSize = true;
            this.lbl_risultato2.Location = new System.Drawing.Point(205, 466);
            this.lbl_risultato2.Name = "lbl_risultato2";
            this.lbl_risultato2.Size = new System.Drawing.Size(114, 13);
            this.lbl_risultato2.TabIndex = 42;
            this.lbl_risultato2.Text = "Numero conto e saldo:";
            // 
            // lbl_risultato3
            // 
            this.lbl_risultato3.AutoSize = true;
            this.lbl_risultato3.Location = new System.Drawing.Point(348, 437);
            this.lbl_risultato3.Name = "lbl_risultato3";
            this.lbl_risultato3.Size = new System.Drawing.Size(51, 13);
            this.lbl_risultato3.TabIndex = 43;
            this.lbl_risultato3.Text = "Risultato:";
            // 
            // lbl__risultato4
            // 
            this.lbl__risultato4.AutoSize = true;
            this.lbl__risultato4.Location = new System.Drawing.Point(487, 453);
            this.lbl__risultato4.Name = "lbl__risultato4";
            this.lbl__risultato4.Size = new System.Drawing.Size(38, 13);
            this.lbl__risultato4.TabIndex = 44;
            this.lbl__risultato4.Text = "Nome:";
            // 
            // lbl_risultato5
            // 
            this.lbl_risultato5.AutoSize = true;
            this.lbl_risultato5.Location = new System.Drawing.Point(623, 423);
            this.lbl_risultato5.Name = "lbl_risultato5";
            this.lbl_risultato5.Size = new System.Drawing.Size(63, 13);
            this.lbl_risultato5.TabIndex = 45;
            this.lbl_risultato5.Text = "Media saldi:";
            // 
            // lbl_risultato6
            // 
            this.lbl_risultato6.AutoSize = true;
            this.lbl_risultato6.Location = new System.Drawing.Point(787, 423);
            this.lbl_risultato6.Name = "lbl_risultato6";
            this.lbl_risultato6.Size = new System.Drawing.Size(132, 13);
            this.lbl_risultato6.TabIndex = 46;
            this.lbl_risultato6.Text = "Ordine crescente dei saldi:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(986, 503);
            this.Controls.Add(this.lbl_risultato6);
            this.Controls.Add(this.lbl_risultato5);
            this.Controls.Add(this.lbl__risultato4);
            this.Controls.Add(this.lbl_risultato3);
            this.Controls.Add(this.lbl_risultato2);
            this.Controls.Add(this.txt_punto2);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lbl_risultato1);
            this.Controls.Add(this.txt_punto1);
            this.Controls.Add(this.lbl_punto1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbl_punto3);
            this.Controls.Add(this.lbl_punto2);
            this.Controls.Add(this.btn_punto6);
            this.Controls.Add(this.btn_punto5);
            this.Controls.Add(this.btn_punto4);
            this.Controls.Add(this.btn_punto3);
            this.Controls.Add(this.btn_punto2);
            this.Controls.Add(this.btn_punto1);
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
        private System.Windows.Forms.Button btn_punto1;
        private System.Windows.Forms.Button btn_punto2;
        private System.Windows.Forms.Button btn_punto3;
        private System.Windows.Forms.Button btn_punto4;
        private System.Windows.Forms.Button btn_punto5;
        private System.Windows.Forms.Button btn_punto6;
        private System.Windows.Forms.Label lbl_punto2;
        private System.Windows.Forms.Label lbl_punto3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_punto1;
        private System.Windows.Forms.TextBox txt_punto1;
        private System.Windows.Forms.Label lbl_risultato1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_punto2;
        private System.Windows.Forms.Label lbl_risultato2;
        private System.Windows.Forms.Label lbl_risultato3;
        private System.Windows.Forms.Label lbl__risultato4;
        private System.Windows.Forms.Label lbl_risultato5;
        private System.Windows.Forms.Label lbl_risultato6;
    }
}

