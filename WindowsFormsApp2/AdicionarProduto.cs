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

namespace WindowsFormsApp2
{
    public partial class AdicionarProduto : Parent
    {
        MemoryStream ms = new MemoryStream();
        public AdicionarProduto()
        {
            InitializeComponent();
        }

        private void AdicionarProduto_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files |*.png;*.jpeg;*.jpg";

            //if (ofd.ShowDialog(DialogResult.OK){ }
        }
    }
}
