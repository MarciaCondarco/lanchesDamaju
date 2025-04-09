using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lanchesDamaju
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCadProduto_Click(object sender, EventArgs e)
        {
            Cad_Produto form = new Cad_Produto();
            form.ShowDialog();
        }

        private void buttonCadCliente_Click(object sender, EventArgs e)
        {
            Cad_Cliente form = new Cad_Cliente();
            form.ShowDialog();
        }

        private void buttonGerenciarProduto_Click(object sender, EventArgs e)
        {
            Gerenciamento_Produto form = new Gerenciamento_Produto();
            form.ShowDialog();
        }

        private void buttonGerenciarCliente_Click(object sender, EventArgs e)
        {
            Gerenciamento_Cliente form = new Gerenciamento_Cliente();
            form.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
