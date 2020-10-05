using MedicHelpper.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MedicHelpper
{
    public partial class frmDoctor : MedicHelpper.frmPadre
    {
        public frmDoctor()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            MenuAdministrador frm = new MenuAdministrador("");
            frm.Visible = true;
            
        }
        private void btnMinimizar_Click(object sender, EventArgs e)
        {   
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
                if (this.WindowState == FormWindowState.Maximized)
            {
                btnRestaurar.Image = Resources.redimensionar;
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                btnRestaurar.Image = Resources.redimensionar;
                this.WindowState = FormWindowState.Maximized;
                btnRestaurar.Image = Resources.restaurar;
            }
        }

    }
}
