using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Parent
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var us = ct.Usuario.FirstOrDefault(u=>u.Email == textBox1.Text && u.Senha ==textBox2.Text);
                if (us == null) 
                {
                    MessageBox.Show("Usuário ou senha iválidos!");
                    return;
                }
                new Home().Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Erro de conexão com o servidor!");
                return;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (textBox2.UseSystemPasswordChar==true) 
            {
                textBox2.UseSystemPasswordChar = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = true;

            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
                pictureBox3.Visible = false;
                pictureBox2.Visible = true;


            }
        }
    }
}
