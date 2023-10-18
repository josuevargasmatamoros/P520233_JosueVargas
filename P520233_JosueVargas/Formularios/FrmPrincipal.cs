using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P520233_JosueVargas.Formularios
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void gALERIADEREPORTESToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void gestionDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(!Globales.ObjetosGlobales.MiFormularioDeGestionDeUsuarios.Visible)
{

                Globales.ObjetosGlobales.MiFormularioDeGestionDeUsuarios = new FrmUsuariosGestion();

                Globales.ObjetosGlobales.MiFormularioDeGestionDeUsuarios.Show();
            }

        }

        private void FrmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
