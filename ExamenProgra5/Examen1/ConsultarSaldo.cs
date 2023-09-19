using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Examen1
{
    public partial class ConsultarSaldo : Form
    {
        public ConsultarSaldo()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRigth3_Click(object sender, EventArgs e)
        { 
            //Boton atras
            ATM atm = new ATM();
            atm.Show();
            this.Hide();
        }
        //Conexion con el sql
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-0J3C3IK;Initial Catalog=ATMdb;Integrated Security=True");
        private void ConsultarSaldo_Load(object sender, EventArgs e)

        {
            string clave = Login.clave;
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT monto FROM ExamenDB1 WHERE clave ='" + clave + "'", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            lblMonto.Text = "Su saldo es de: $ " +dt.Rows[0][0].ToString();
            Con.Close();
        }

        private void Pantalla_Click(object sender, EventArgs e)
        {

        }
    }
}
