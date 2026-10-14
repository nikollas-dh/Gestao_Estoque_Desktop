using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.Models;

namespace WindowsFormsApp2
{
    public partial class Parent : Form
    {
        public readonly Color corFundo = ColorTranslator.FromHtml("#0B1930");
        public readonly Color corPainel = ColorTranslator.FromHtml("#142642");
        public readonly Color corPrimaria = ColorTranslator.FromHtml("#3B82F6");
        public readonly Color corPrimariaHover = ColorTranslator.FromHtml("#2563EB");
        public readonly Color corTexto = ColorTranslator.FromHtml("#F1F5F9");
        public readonly Color corSecundaria = ColorTranslator.FromHtml("#94A3B8");
        public readonly Color corBorda = ColorTranslator.FromHtml("#334766");
        public readonly Color corPerigo = ColorTranslator.FromHtml("#EF4444");
        public readonly Color corPerigoHover = ColorTranslator.FromHtml("#DC2626");

        public dbEstoque2Entities ct = new dbEstoque2Entities();
        public Parent()
        {
            InitializeComponent();
            panel1.BackColor = ColorTranslator.FromHtml("#0B1930");
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Parent_Load(object sender, EventArgs e)
        {
            EstilizarTela(panel1);
        }

        private void EstilizarTela(Control control)
        {
            pictureBox1.BackColor = Color.Transparent;
            foreach (Control child in control.Controls) 
            {
                if (child is Label lbl)
                {
                    if (lbl.AccessibleName == "")
                    {
                        lbl.BackColor = Color.Transparent;
                        lbl.ForeColor = corTexto;
                        lbl.Font = new Font(
                            "Segoe UI", 10f, FontStyle.Regular);
                    }
                        if (lbl.AccessibleName == "credencial")
                        {
                            lbl.Font = new Font(
                                "Segoe UI Semibold", 10f, FontStyle.Bold);
                            lbl.ForeColor = corSecundaria;
                        }
                    
                }
                if (child is LinkLabel link)
                {
                    link.Font = new Font("Segoe UI", 9.5f, FontStyle.Regular);

                    link.LinkColor = ColorTranslator.FromHtml("#60A5FA");
                    link.ActiveLinkColor = ColorTranslator.FromHtml("#93C5FD");
                    link.VisitedLinkColor = ColorTranslator.FromHtml("#A78BFA");
                    link.LinkBehavior = LinkBehavior.HoverUnderline;

                    link.BackColor = Color.Transparent;
                    link.Cursor = Cursors.Hand;

                    link.LinkArea = new LinkArea(0, link.Text.Length);
                }


                if (child is CheckBox chk)
                {
                    chk.Font = new Font("Segoe UI", 10f, FontStyle.Regular);

                    chk.ForeColor = ColorTranslator.FromHtml("#F1F5F9");
                    chk.BackColor = ColorTranslator.FromHtml("#0B1930");

                    chk.Cursor = Cursors.Hand;
                    chk.FlatStyle = FlatStyle.Flat;

                    chk.FlatAppearance.BorderColor =
                        ColorTranslator.FromHtml("#60A5FA");

                    chk.FlatAppearance.MouseOverBackColor =
                        ColorTranslator.FromHtml("#142642");

                    chk.FlatAppearance.CheckedBackColor =
                        ColorTranslator.FromHtml("#3B82F6");

                    chk.UseVisualStyleBackColor = false;
                }
                if (child is TextBox txt) 
                {
                    txt.BorderStyle = BorderStyle.FixedSingle;
                    txt.BackColor = corPainel;
                    txt.ForeColor = corTexto;
                    txt.Font = new Font(
                        "Segoe UI", 11f, FontStyle.Regular);

                    txt.Margin = new Padding(0, 5, 0, 10);
                }
                if(child is Button btn) 
                {
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;
                    btn.FlatAppearance.MouseOverBackColor =
                        corPrimariaHover;

                    btn.BackColor = corPrimaria;
                    btn.ForeColor = Color.White;
                    btn.Font = new Font(
                        "Segoe UI Semibold", 10f, FontStyle.Bold);

                    btn.Cursor = Cursors.Hand;
                    btn.Height = Math.Max(btn.Height, 38);
                    btn.Padding = new Padding(10, 4, 10, 4);
                    btn.UseVisualStyleBackColor = false;

                    if (btn.AccessibleName == "exit")
                    {
                        btn.BackColor = corPerigo;
                        btn.FlatAppearance.MouseOverBackColor =
                            corPerigoHover;
                    }
                }

                if (child.HasChildren) 
                {
                    EstilizarTela(child);
                }
            
            }
        }
    }
}
