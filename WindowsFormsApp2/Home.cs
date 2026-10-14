using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.Controls;
using WindowsFormsApp2.Models;

namespace WindowsFormsApp2
{
    public partial class Home : Parent
    {
        private List<Produto> Listaprodutos;
        public Home()
        {
            InitializeComponent();
            //panel2.BackColor = corSecundaria;
            
        }

        private void Home_Load(object sender, EventArgs e)
        {
             Listaprodutos = ct.Produto.ToList();
            ExibirProdutos(Listaprodutos);
          

        }

        public void ExibirProdutos(List<Produto> produtos)
        {
            flowLayoutPanel1.Controls.Clear();
            foreach (var p in produtos)
            {
                var card = new ProdutosControl();
                card.PreencherDados(p);
                flowLayoutPanel1.Controls.Add(card);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string pesquisa = textBox1.Text.ToLower().Trim();

            var filtrados = Listaprodutos
                .Where(p => p.Nome.ToLower().Contains(pesquisa)).ToList();
            ExibirProdutos(filtrados);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Movimentacoes().Show();
        }
    }
}
