using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Examen1
{
    public partial class Retirar : Form
    {
        public Retirar()
        {
            InitializeComponent();
        }

        private void BtnClear(object sender, EventArgs e)
        {
            txtRetirar.Clear();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (txtRetirar.Text.Length < 9)
            {
                txtRetirar.Text += '1';
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (txtRetirar.Text.Length < 9)
            {
                txtRetirar.Text += '2';
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (txtRetirar.Text.Length < 9)
            {
                txtRetirar.Text += '3';
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (txtRetirar.Text.Length < 9)
            {
                txtRetirar.Text += '4';
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (txtRetirar.Text.Length < 9)
            {
                txtRetirar.Text += '5';
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (txtRetirar.Text.Length < 9)
            {
                txtRetirar.Text += '6';
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (txtRetirar.Text.Length < 9)
            {
                txtRetirar.Text += '7';
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (txtRetirar.Text.Length < 9)
            {
                txtRetirar.Text += '8';
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (txtRetirar.Text.Length < 9)
            {
                txtRetirar.Text += '9';
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (txtRetirar.Text.Length < 9)
            {
                txtRetirar.Text += '0';
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
       //Variables
        string clave = Login.clave;
        decimal saldo;
        private void Retirar_Load(object sender, EventArgs e)
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT monto FROM ExamenDB1 WHERE clave ='" + clave + "'", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            saldo = Convert.ToDecimal(dt.Rows[0][0].ToString());
            Con.Close();
        }
        //Variable
        decimal montoNuevo;
        private void btnRigth2_Click(object sender, EventArgs e)
        {
            //Boton Retirar
            if (txtRetirar.Text == "")
            {
                MessageBox.Show("Debe ingresar un monto", "Mensaje Retiro", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
            else if (Convert.ToDecimal(txtRetirar.Text) <= 0)
            {
                MessageBox.Show("Ingrese un monto válido", "Mensaje Retiro", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
            else if (Convert.ToDecimal(txtRetirar.Text) > saldo)
            {
                MessageBox.Show("Fondos insuficientes", "Mensaje Retiro", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
            else
            {
                montoNuevo = saldo - Convert.ToDecimal(txtRetirar.Text);
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE ExamenDB1 SET monto = @MONTO WHERE clave ='" + clave + "'", Con);
                    cmd.Parameters.AddWithValue("@MONTO", montoNuevo);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Retiro realizado con exito!", "Mensaje Deposito", MessageBoxButtons.OK);
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

        private void txtRetirar_KeyPress(object sender, KeyPressEventArgs e)
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

        private void Pantalla_Click(object sender, EventArgs e)
        {

        }
    }
}
