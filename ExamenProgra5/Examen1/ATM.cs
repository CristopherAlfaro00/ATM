using System;
using System.Windows.Forms;

namespace Examen1
{
    public partial class ATM : Form
    {
        public ATM()
        {
            InitializeComponent();
        }

        private void btnRigth3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login form1 = new Login();
            form1.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLeft1_Click(object sender, EventArgs e)
        {
            ConsultarSaldo cSaldo = new ConsultarSaldo();
            cSaldo.Show();
            this.Hide();
        }

        private void btnRigth1_Click(object sender, EventArgs e)
        {
            Depositar cDeposito = new Depositar();
            cDeposito.Show();
            this.Hide();
        }

        private void btnLeft2_Click(object sender, EventArgs e)
        {
            Retirar cRetirar = new Retirar();
            cRetirar.Show();
            this.Hide();
        }

        private void btnLeft3_Click(object sender, EventArgs e)
        {
            dineroRapido cdineroRapido = new dineroRapido();
            cdineroRapido.Show();
            this.Hide();
        }

        private void btnRigth2_Click(object sender, EventArgs e)
        {
            ConsultarNumeroCuenta cNumcuenta = new ConsultarNumeroCuenta();
            cNumcuenta.Show();
            this.Hide();
        }

        private void Pantalla_Click(object sender, EventArgs e)
        {

        }
    }
}
