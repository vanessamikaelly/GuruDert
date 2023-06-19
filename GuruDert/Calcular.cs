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
            double servico = Convert.ToDouble(Console.ReadLine());

            string formatacao;
            string limpeza;
            string trocapeca;

            if(servico == formatacao)
            {
                 = "Formatação";

            }
            else if(servico >= 50)
            {
                limpeza = "Limpeza";
            }
            else
            {
                trocapeca = "Troca de Peça";
            }
            

        }

        private void bt_salvar_Click(object sender, EventArgs e)
        {

            double formapagam = Convert.ToDouble(Console.ReadLine());

            string dinheiro;
            string pix;
            string cartao;


            if(formapagam == )
            {
                dinehiro = 0.20;
            }
            else if(formapagam >= )


        }

        private void cbx_pagamento_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
