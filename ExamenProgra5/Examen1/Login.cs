using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Examen1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void BtnClear(object sender, EventArgs e)
        {
            if (txtClave.Text.Length > 0)
            {
                String borrarCampos = txtClave.Text.Substring(0, txtClave.Text.Length - 1);
                txtClave.Text = borrarCampos;
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (txtClave.Text.Length < 4)
            {
                txtClave.Text += '1';
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (txtClave.Text.Length < 4)
            {
                txtClave.Text += '2';
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (txtClave.Text.Length < 4)
            {
                txtClave.Text += '3';
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (txtClave.Text.Length < 4)
            {
                txtClave.Text += '4';
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (txtClave.Text.Length < 4)
            {
                txtClave.Text += '5';
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (txtClave.Text.Length < 4)
            {
                txtClave.Text += '6';
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (txtClave.Text.Length < 4)
            {
                txtClave.Text += '7';
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (txtClave.Text.Length < 4)
            {
                txtClave.Text += '8';
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (txtClave.Text.Length < 4)
            {
                txtClave.Text += '9';
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (txtClave.Text.Length < 4)
            {
                txtClave.Text += '0';
            }
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            Consultar_Acceso();
        }

        public static String clave; //Variable estatica para el load
        private void Consultar_Acceso()
        {
            try
            {
                sqlConnection1.Open();

                SqlCommand ComandoAcceso = new SqlCommand("SP_CONEXION", sqlConnection1);

                ComandoAcceso.CommandType = CommandType.StoredProcedure;
                ComandoAcceso.Parameters.AddWithValue("@CLAVE", txtClave.Text.Trim());

                SqlDataReader AccesoUsuario = ComandoAcceso.ExecuteReader();

                if (txtClave.Text != "")
                {
                    if (AccesoUsuario.Read())
                    {
                        clave = txtClave.Text; //Se reemplaza
                        ATM atm = new ATM();
                        atm.Show();
                        this.Hide();
                        txtClave.Clear();

                        sqlConnection1.Close();
                    }
                    else
                    {
                        MessageBox.Show("Clave Incorrecta, por favor vuelva a intentar", "Mensaje Usuario", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                        sqlConnection1.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Clave en blanco, debe digitar 4 números", "Mensaje Usuario", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                    sqlConnection1.Close();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtClave_KeyPress(object sender, KeyPressEventArgs e)
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
