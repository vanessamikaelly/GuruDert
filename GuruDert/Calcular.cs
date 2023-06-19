using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace GuruDert
{
    public partial class Calcular : Form
    {
        public Calcular()
        {
            InitializeComponent();
        }

        private void cbx_servico_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine("Digite uma opcao: ");

            Console.WriteLine("1 - formatação ");
            Console.WriteLine("2 - Limpeza");
            Console.WriteLine("3 - Troca de peça");

            int opcao = Convert.ToInt32(Console.ReadLine());

            if(opcao == 1)
            {
                Console.WriteLine();
            }
            

        }

        private void bt_salvar_Click(object sender, EventArgs e)
        {

          /*  double formapagam = Convert.ToDouble(Console.ReadLine());

            string dinheiro = "";
            string pix = "";
            string cartao = "";


            if(formapagam == )
            {
                dinehiro = 0.20;
            }
            else if(formapagam >= )
            {

            } */


        }

        private void cbx_pagamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            bt_salvar.Enabled = true;

        }

        private void bt_cancelar_Click(object sender, EventArgs e)
        {

        }
    }
}
