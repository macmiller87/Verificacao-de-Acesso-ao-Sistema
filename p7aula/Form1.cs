using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p7aula
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAcessar_Click(object sender, EventArgs e)
        {
            string AcesPerSenha, AcesPerNome, lblNome, lblSenha;

            AcesPerSenha = "PROGRAMAÇÃO C#";
            AcesPerNome = "MACMILLER";
            lblNome = txtNome.Text;
            lblSenha = txtSenha.Text;

            if (string.Equals(lblSenha,AcesPerSenha) && string.Equals(lblNome,AcesPerNome)) {

                lblRes.Text = ("Acesso liberado Com Sucesso!");
            } else {
                lblRes.Text = ("Erro Senha Não Compativel, Acesso Negado!");
            }
        }

        private void btbLimpar_Click(object sender, EventArgs e)
        {
            txtSenha.Text = " ";
            lblRes.Text = " ";
            txtNome.Text = " ";
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
