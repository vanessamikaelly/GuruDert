using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            int formatacao = Convert.ToInt32(Console.ReadLine());
            int limpeza = Convert.ToInt32(Console.ReadLine());
            int trocadepeca = Convert.ToInt32(Console.ReadLine());

            if(formatacao == 100)
            {
                Console.WriteLine("100");

            }
            if(limpeza == 50)
            {
                Console.WriteLine("50");

            }
            else
            {
                Console.WriteLine("200");
            }

        }




        private void bt_salvar_Click(object sender, EventArgs e)
        {


        }
    }
}
