using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Examen1
{
    public partial class Depositar : Form
    {
        public Depositar()
        {
            InitializeComponent();
        }

        private void BtnClear(object sender, EventArgs e)
        {
            txtDepositar.Clear();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (txtDepositar.Text.Length < 9)
            {
                txtDepositar.Text += '1';
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (txtDepositar.Text.Length < 9)
            {
                txtDepositar.Text += '2';
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (txtDepositar.Text.Length < 9)
            {
                txtDepositar.Text += '3';
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (txtDepositar.Text.Length < 9)
            {
                txtDepositar.Text += '4';
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (txtDepositar.Text.Length < 9)
            {
                txtDepositar.Text += '5';
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (txtDepositar.Text.Length < 9)
            {
                txtDepositar.Text += '6';
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (txtDepositar.Text.Length < 9)
            {
                txtDepositar.Text += '7';
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (txtDepositar.Text.Length < 9)
            {
                txtDepositar.Text += '8';
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (txtDepositar.Text.Length < 9)
            {
                txtDepositar.Text += '9';
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (txtDepositar.Text.Length < 9)
            {
                txtDepositar.Text += '0';
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRigth3_Click(object sender, EventArgs e)
        {
            ATM atm = new ATM();
            atm.Show();
            this.Hide();
        }
        //Conexion con el sql
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-0J3C3IK;Initial Catalog=ATMdb;Integrated Security=True");
        string clave = Login.clave;
        private void btnRigth2_Click(object sender, EventArgs e)
        {
            if (txtDepositar.Text == "")
            {
                MessageBox.Show("Debe ingresar un monto", "Mensaje Deposito", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
            else if (Convert.ToDecimal(txtDepositar.Text) <= 0)
            {
                MessageBox.Show("Debe ingresar un monto válido", "Mensaje Deposito", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
            else
            {
                montoNuevo = montoAnterior + Convert.ToDecimal(txtDepositar.Text);
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE ExamenDB1 SET monto = @MONTO WHERE clave ='" + clave + "'", Con);
                    cmd.Parameters.AddWithValue("@MONTO", montoNuevo);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Deposito realizado con exito!", "Mensaje Deposito", MessageBoxButtons.OK);
                    Con.Close();

                    ATM atm = new ATM();
                    atm.Show();
                    this.Hide();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        private void txtDepositar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        decimal montoAnterior, montoNuevo;

        private void Pantalla_Click(object sender, EventArgs e)
        {

        }

        private void Depositar_Load(object sender, EventArgs e)
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT monto FROM ExamenDB1 WHERE clave ='" + clave + "'", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            montoAnterior = Convert.ToDecimal(dt.Rows[0][0].ToString());
            Con.Close();
        }
    }
}
