using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tela_de_login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
          
        }

        private void buttom_Click(object sender, EventArgs e)
        {
            string login = txtlogin.Text;
            string senha = txtsenha.Text;
            if (login == "admin" && senha == "ds@etefmc")
            {
                MessageBox.Show("Cadastro Concluido!");
            }
        }

        private void textboxlogin_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
