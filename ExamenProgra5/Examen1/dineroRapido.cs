using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Examen1
{
    public partial class dineroRapido : Form
    {
        public dineroRapido()
        {
            InitializeComponent();
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
        //conexion
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-0J3C3IK;Initial Catalog=ATMdb;Integrated Security=True");
       
        string clave = Login.clave;
        decimal saldo;

        private void dineroRapido_Load_1(object sender, EventArgs e)
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT monto FROM ExamenDB1 WHERE clave ='" + clave + "'", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            saldo = Convert.ToDecimal(dt.Rows[0][0].ToString());
            Con.Close();


            timer1.Start();
        }

        //Validaciones*********************************************************
        private void btnLeft1_Click(object sender, EventArgs e)
        {
            //Validaciones dinero rapido
            if (saldo < 50)
            {
                MessageBox.Show("Fondos insuficientes", "Mensaje Retiro", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
            else
            {
                decimal montoNuevo = saldo - 50;
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE ExamenDB1 SET monto = @MONTO WHERE clave ='" + clave + "'", Con);
                    cmd.Parameters.AddWithValue("@MONTO", montoNuevo);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Retiro realizado con exito!", "Mensaje Retiro", MessageBoxButtons.OK);
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

        private void btnLeft2_Click(object sender, EventArgs e)
        {
            //Validaciones dinero rapido
            if (saldo < 100)
            {
                MessageBox.Show("Fondos insuficientes", "Mensaje Retiro", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
            else
            {
                decimal montoNuevo = saldo - 100;
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE ExamenDB1 SET monto = @MONTO WHERE clave ='" + clave + "'", Con);
                    cmd.Parameters.AddWithValue("@MONTO", montoNuevo);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Retiro realizado con exito!", "Mensaje Retiro", MessageBoxButtons.OK);
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

        private void btnLeft3_Click(object sender, EventArgs e)
        {
            //Validaciones dinero rapido
            if (saldo < 500)
            {
                MessageBox.Show("Fondos insuficientes", "Mensaje Retiro", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
            else
            {
                decimal montoNuevo = saldo - 500;
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE ExamenDB1 SET monto = @MONTO WHERE clave ='" + clave + "'", Con);
                    cmd.Parameters.AddWithValue("@MONTO", montoNuevo);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Retiro realizado con exito!", "Mensaje Retiro", MessageBoxButtons.OK);
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

        private void btnRigth1_Click(object sender, EventArgs e)
        {
            //Validaciones dinero rapido
            if (saldo < 800)
            {
                MessageBox.Show("Fondos insuficientes", "Mensaje Retiro", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
            else
            {
                decimal montoNuevo = saldo - 800;
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE ExamenDB1 SET monto = @MONTO WHERE clave ='" + clave + "'", Con);
                    cmd.Parameters.AddWithValue("@MONTO", montoNuevo);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Retiro realizado con exito!", "Mensaje Retiro", MessageBoxButtons.OK);
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

        //Validaciones*********************************************************
        private void btnRigth2_Click(object sender, EventArgs e)
        {
            //Validaciones dinero rapido
            if (saldo < 1000)
            {
                MessageBox.Show("Fondos insuficientes", "Mensaje Retiro", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
            else
            {
                decimal montoNuevo = saldo - 1000;
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE ExamenDB1 SET monto = @MONTO WHERE clave ='" + clave + "'", Con);
                    cmd.Parameters.AddWithValue("@MONTO", montoNuevo);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Retiro realizado con exito!", "Mensaje Retiro", MessageBoxButtons.OK);
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Movimiento de los lbl
         
            int a = lbl50.Location.X;
            int b = lbl100.Location.X;
            int c = lbl500.Location.X;
            int d = lbl800.Location.X;
            int f = lbl1000.Location.X;

            if (a <= 228 && b <= 228 && c <= 228 && d >= 228 && f >= 228)
            {
                a += 1;
                b += 1;
                c += 1;
                d += -1;
                f += -1;

                lbl50.Location = new Point(a, lbl50.Location.Y);
                lbl100.Location = new Point(b, lbl100.Location.Y);
                lbl500.Location = new Point(c, lbl500.Location.Y);
                lbl800.Location = new Point(d, lbl800.Location.Y);
                lbl1000.Location = new Point(f, lbl1000.Location.Y);
            }
            else
            {
                timer1.Stop();
            }
        }

        private void Pantalla_Click(object sender, EventArgs e)
        {

         } 
    }
}
