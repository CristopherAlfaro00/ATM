using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Examen1
{
    public partial class ConsultarNumeroCuenta : Form
    {
        public ConsultarNumeroCuenta()
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
        //Conexion con el sql
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-0J3C3IK;Initial Catalog=""ATMDB 2.0"";Integrated Security=True");
        private void ConsultarSaldo_Load(object sender, EventArgs e)
        {
            string clave = Login.clave;
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT numcuenta, nombre, cuenta FROM ExamenDB1 WHERE clave ='" + clave + "'", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            lblCuenta.Text = "Número de cuenta: " +dt.Rows[0][0].ToString();
            lblnombre.Text = "Nombre: " +dt.Rows[0][1].ToString();
            lblCuentaB.Text = "Cuenta: " + dt.Rows[0][2].ToString();
            Con.Close();
        }
    }
}
