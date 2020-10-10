using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicHelpper
{
    public partial class Creditos : Form
    {
        public Creditos()
        {
            InitializeComponent();
            //Timer_creditos.Enabled = true;
            //Timer_creditos.Interval = 7000;
        }

        /*private void Timer_creditos_Tick(object sender, EventArgs e)
        {
            Timer_creditos.Stop();
            this.Close();
        }

        private void Creditos_FormClosing(object sender, FormClosingEventArgs e)
        {
        
           
        }
        */
        private void btn_volver_Click(object sender, EventArgs e)
        {
            Timer_creditos.Stop();
            this.DialogResult = DialogResult.OK;
            this.Close();
            LoginMedicHelppercs log = new LoginMedicHelppercs();
            log.Show();
        }
    }
}
