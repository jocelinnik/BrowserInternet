using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BrowserInternet
{
    public partial class frmBrowser : Form
    {
        public frmBrowser()
        {
            InitializeComponent();
        }

        private void voltar_Click(object sender, EventArgs e)
        {
            Browser.GoBack();
        }

        private void avancar_Click(object sender, EventArgs e)
        {
            Browser.GoForward();
        }

        private void home_Click(object sender, EventArgs e)
        {
            Browser.GoHome();
        }

        private void pesquisar_Click(object sender, EventArgs e)
        {
            Browser.GoSearch();
        }

        private void parar_Click(object sender, EventArgs e)
        {
            Browser.Stop();
        }

        private void atualizar_Click(object sender, EventArgs e)
        {
            Browser.Refresh();
        }

        private void ir_Click(object sender, EventArgs e)
        {
            Browser.Navigate(txtUrl.Text);
        }
    }
}
