using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContiCorrenti
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] arrayNomi = new string[10];
        int[] arraySaldo = new int[10];
        int[] arrayNumeroConto = new int[10];

        private void btn_invioDati_Click_1(object sender, EventArgs e)
        {
            string nome = txt_nome.Text;
            int numeroConto = Convert.ToInt32(txt_nConto.Text);
            int saldo = Convert.ToInt32(txt_saldo.Text);
            int contatore = 0;

            arrayNomi[contatore] = nome;
            arraySaldo[contatore] = saldo;
            arrayNumeroConto[contatore] = numeroConto;

            lst_nomi.Items.Add(nome);
            lst_nConto.Items.Add(numeroConto);
            lst_Saldo.Items.Add(saldo);

            txt_nConto.Clear();
            txt_saldo.Clear();
            txt_nome.Clear();

            contatore++;
        }
    }
}
