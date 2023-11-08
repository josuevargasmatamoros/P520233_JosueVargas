﻿using System;
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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnVerContrasennia_MouseDown(object sender, MouseEventArgs e)
        {
            TxtContrasennia.UseSystemPasswordChar = false;
        }

        private void BtnVerContrasennia_MouseUp(object sender, MouseEventArgs e)
        {
            TxtContrasennia.UseSystemPasswordChar = true;
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(TxtUsuario.Text.Trim())&&
               !string.IsNullOrEmpty(TxtContrasennia.Text.Trim()))
            {
                string usuario = TxtUsuario.Text.Trim();
                string contrasennia = TxtContrasennia.Text.Trim();

                int idUsuario = Globales.ObjetosGlobales.MiUsuarioGlobal.Validar 
            }


            Globales.ObjetosGlobales.MiFormularioPrincipal.Show();
            this.Hide();
        }

        private void FrmLogin_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.Control & e.Shift & e.KeyCode == Keys.A)
                {
                BtnIngresoDirecto.Visible = true;
            }

        }

        private void BtnIngresoDirecto_Click(object sender, EventArgs e)
        {
            Globales.ObjetosGlobales.MiFormularioPrincipal.Show();
            this.Hide();
        }
    }
}
