using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.Models;

namespace WindowsFormsApp2.Controls
{
    public partial class ProdutosControl : UserControl
    {
        public string NomeProduto { get; set; }
        public ProdutosControl()
        {
            InitializeComponent();
            this.BackColor = ColorTranslator.FromHtml("#142642");
            
        }

        public void PreencherDados(Produto produto) 
        {
            lblNome.Text = produto.Nome;
            lblQuantidade.Text = produto.Quantidade.ToString();
            lblValorUnitario.Text = "R$"+produto.Valor_Unitario.ToString();
            NomeProduto = produto.Nome;

            var caminhoRelativo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, $"..\\..\\Images\\{produto.Nome}.png");
            var caminhoAbsoluto = Path.GetFullPath( caminhoRelativo );

            pictureBox1.Image = Image.FromFile(caminhoAbsoluto);

            button1.BackColor = ColorTranslator.FromHtml("#3B82F6");
            button1.ForeColor = Color.White;
            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 0;
            button1.Font = new Font(
                "Segoe UI Semibold", 10f, FontStyle.Bold);
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
