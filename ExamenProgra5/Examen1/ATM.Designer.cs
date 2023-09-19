namespace Examen1
{
    partial class ATM
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ATM));
            this.Teclado = new System.Windows.Forms.PictureBox();
            this.Pantalla = new System.Windows.Forms.PictureBox();
            this.btn0 = new System.Windows.Forms.PictureBox();
            this.btn8 = new System.Windows.Forms.PictureBox();
            this.btn9 = new System.Windows.Forms.PictureBox();
            this.btn7 = new System.Windows.Forms.PictureBox();
            this.btn6 = new System.Windows.Forms.PictureBox();
            this.btn5 = new System.Windows.Forms.PictureBox();
            this.btn4 = new System.Windows.Forms.PictureBox();
            this.btn3 = new System.Windows.Forms.PictureBox();
            this.btn2 = new System.Windows.Forms.PictureBox();
            this.btn1 = new System.Windows.Forms.PictureBox();
            this.btnCancel = new System.Windows.Forms.PictureBox();
            this.btnEnter = new System.Windows.Forms.PictureBox();
            this.btnClear = new System.Windows.Forms.PictureBox();
            this.lblBienvenida = new System.Windows.Forms.Label();
            this.CajeroATM = new System.Windows.Forms.PictureBox();
            this.btnLeft1 = new System.Windows.Forms.PictureBox();
            this.btnLeft2 = new System.Windows.Forms.PictureBox();
            this.btnLeft3 = new System.Windows.Forms.PictureBox();
            this.btnRigth1 = new System.Windows.Forms.PictureBox();
            this.btnRigth2 = new System.Windows.Forms.PictureBox();
            this.btnRigth3 = new System.Windows.Forms.PictureBox();
            this.lblConsultaNro = new System.Windows.Forms.Label();
            this.lblSalir = new System.Windows.Forms.Label();
            this.lblTransferencia = new System.Windows.Forms.Label();
            this.lblRetirSaldo = new System.Windows.Forms.Label();
            this.lblConsulSaldo = new System.Windows.Forms.Label();
            this.lblConsultpts = new System.Windows.Forms.Label();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Teclado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pantalla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEnter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CajeroATM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLeft1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLeft2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLeft3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRigth1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRigth2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRigth3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Teclado
            // 
            this.Teclado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Teclado.Cursor = System.Windows.Forms.Cursors.Default;
            this.Teclado.Image = ((System.Drawing.Image)(resources.GetObject("Teclado.Image")));
            this.Teclado.Location = new System.Drawing.Point(170, 580);
            this.Teclado.Name = "Teclado";
            this.Teclado.Size = new System.Drawing.Size(264, 204);
            this.Teclado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Teclado.TabIndex = 0;
            this.Teclado.TabStop = false;
            // 
            // Pantalla
            // 
            this.Pantalla.BackColor = System.Drawing.Color.Transparent;
            this.Pantalla.Image = ((System.Drawing.Image)(resources.GetObject("Pantalla.Image")));
            this.Pantalla.Location = new System.Drawing.Point(221, 182);
            this.Pantalla.Name = "Pantalla";
            this.Pantalla.Size = new System.Drawing.Size(626, 342);
            this.Pantalla.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pantalla.TabIndex = 1;
            this.Pantalla.TabStop = false;
            this.Pantalla.Click += new System.EventHandler(this.Pantalla_Click);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.Color.Transparent;
            this.btn0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn0.Image = ((System.Drawing.Image)(resources.GetObject("btn0.Image")));
            this.btn0.Location = new System.Drawing.Point(251, 732);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(36, 28);
            this.btn0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn0.TabIndex = 2;
            this.btn0.TabStop = false;
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.Transparent;
            this.btn8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn8.Image = ((System.Drawing.Image)(resources.GetObject("btn8.Image")));
            this.btn8.Location = new System.Drawing.Point(251, 692);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(36, 28);
            this.btn8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn8.TabIndex = 3;
            this.btn8.TabStop = false;
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.Transparent;
            this.btn9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn9.Image = ((System.Drawing.Image)(resources.GetObject("btn9.Image")));
            this.btn9.Location = new System.Drawing.Point(302, 692);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(37, 28);
            this.btn9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn9.TabIndex = 4;
            this.btn9.TabStop = false;
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.Transparent;
            this.btn7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn7.Image = ((System.Drawing.Image)(resources.GetObject("btn7.Image")));
            this.btn7.Location = new System.Drawing.Point(197, 692);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(38, 28);
            this.btn7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn7.TabIndex = 5;
            this.btn7.TabStop = false;
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.Transparent;
            this.btn6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn6.Image = ((System.Drawing.Image)(resources.GetObject("btn6.Image")));
            this.btn6.Location = new System.Drawing.Point(302, 649);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(37, 28);
            this.btn6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn6.TabIndex = 6;
            this.btn6.TabStop = false;
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.Transparent;
            this.btn5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn5.Image = ((System.Drawing.Image)(resources.GetObject("btn5.Image")));
            this.btn5.Location = new System.Drawing.Point(251, 649);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(36, 28);
            this.btn5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn5.TabIndex = 7;
            this.btn5.TabStop = false;
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.Transparent;
            this.btn4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn4.Image = ((System.Drawing.Image)(resources.GetObject("btn4.Image")));
            this.btn4.Location = new System.Drawing.Point(197, 649);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(38, 28);
            this.btn4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn4.TabIndex = 8;
            this.btn4.TabStop = false;
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.Transparent;
            this.btn3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn3.Image = ((System.Drawing.Image)(resources.GetObject("btn3.Image")));
            this.btn3.Location = new System.Drawing.Point(302, 606);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(37, 28);
            this.btn3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn3.TabIndex = 9;
            this.btn3.TabStop = false;
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.Transparent;
            this.btn2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn2.Image = ((System.Drawing.Image)(resources.GetObject("btn2.Image")));
            this.btn2.Location = new System.Drawing.Point(251, 606);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(36, 28);
            this.btn2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn2.TabIndex = 10;
            this.btn2.TabStop = false;
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.Transparent;
            this.btn1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn1.Image = ((System.Drawing.Image)(resources.GetObject("btn1.Image")));
            this.btn1.Location = new System.Drawing.Point(197, 606);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(38, 28);
            this.btn1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn1.TabIndex = 11;
            this.btn1.TabStop = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Location = new System.Drawing.Point(365, 606);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(46, 28);
            this.btnCancel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCancel.TabIndex = 14;
            this.btnCancel.TabStop = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnEnter
            // 
            this.btnEnter.BackColor = System.Drawing.Color.Transparent;
            this.btnEnter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnter.Image = ((System.Drawing.Image)(resources.GetObject("btnEnter.Image")));
            this.btnEnter.Location = new System.Drawing.Point(365, 692);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(46, 28);
            this.btnEnter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnEnter.TabIndex = 15;
            this.btnEnter.TabStop = false;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Transparent;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.Image")));
            this.btnClear.Location = new System.Drawing.Point(365, 649);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(46, 28);
            this.btnClear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnClear.TabIndex = 16;
            this.btnClear.TabStop = false;
            // 
            // lblBienvenida
            // 
            this.lblBienvenida.AutoSize = true;
            this.lblBienvenida.BackColor = System.Drawing.Color.Transparent;
            this.lblBienvenida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblBienvenida.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenida.ForeColor = System.Drawing.Color.Black;
            this.lblBienvenida.Image = ((System.Drawing.Image)(resources.GetObject("lblBienvenida.Image")));
            this.lblBienvenida.Location = new System.Drawing.Point(342, 222);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(405, 19);
            this.lblBienvenida.TabIndex = 25;
            this.lblBienvenida.Text = "SELECCIONE LA TRANSACCIÓN QUE DESEA REALIZAR";
            // 
            // CajeroATM
            // 
            this.CajeroATM.Image = ((System.Drawing.Image)(resources.GetObject("CajeroATM.Image")));
            this.CajeroATM.Location = new System.Drawing.Point(-77, -40);
            this.CajeroATM.Name = "CajeroATM";
            this.CajeroATM.Size = new System.Drawing.Size(1222, 1120);
            this.CajeroATM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CajeroATM.TabIndex = 41;
            this.CajeroATM.TabStop = false;
            // 
            // btnLeft1
            // 
            this.btnLeft1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLeft1.Image = ((System.Drawing.Image)(resources.GetObject("btnLeft1.Image")));
            this.btnLeft1.Location = new System.Drawing.Point(35, 294);
            this.btnLeft1.Name = "btnLeft1";
            this.btnLeft1.Size = new System.Drawing.Size(56, 50);
            this.btnLeft1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnLeft1.TabIndex = 42;
            this.btnLeft1.TabStop = false;
            this.btnLeft1.Click += new System.EventHandler(this.btnLeft1_Click);
            // 
            // btnLeft2
            // 
            this.btnLeft2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLeft2.Image = ((System.Drawing.Image)(resources.GetObject("btnLeft2.Image")));
            this.btnLeft2.Location = new System.Drawing.Point(35, 361);
            this.btnLeft2.Name = "btnLeft2";
            this.btnLeft2.Size = new System.Drawing.Size(56, 50);
            this.btnLeft2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnLeft2.TabIndex = 43;
            this.btnLeft2.TabStop = false;
            this.btnLeft2.Click += new System.EventHandler(this.btnLeft2_Click);
            // 
            // btnLeft3
            // 
            this.btnLeft3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLeft3.Image = ((System.Drawing.Image)(resources.GetObject("btnLeft3.Image")));
            this.btnLeft3.Location = new System.Drawing.Point(35, 428);
            this.btnLeft3.Name = "btnLeft3";
            this.btnLeft3.Size = new System.Drawing.Size(56, 50);
            this.btnLeft3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnLeft3.TabIndex = 44;
            this.btnLeft3.TabStop = false;
            this.btnLeft3.Click += new System.EventHandler(this.btnLeft3_Click);
            // 
            // btnRigth1
            // 
            this.btnRigth1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRigth1.Image = ((System.Drawing.Image)(resources.GetObject("btnRigth1.Image")));
            this.btnRigth1.Location = new System.Drawing.Point(974, 294);
            this.btnRigth1.Name = "btnRigth1";
            this.btnRigth1.Size = new System.Drawing.Size(56, 50);
            this.btnRigth1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnRigth1.TabIndex = 45;
            this.btnRigth1.TabStop = false;
            this.btnRigth1.Click += new System.EventHandler(this.btnRigth1_Click);
            // 
            // btnRigth2
            // 
            this.btnRigth2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRigth2.Image = ((System.Drawing.Image)(resources.GetObject("btnRigth2.Image")));
            this.btnRigth2.Location = new System.Drawing.Point(974, 361);
            this.btnRigth2.Name = "btnRigth2";
            this.btnRigth2.Size = new System.Drawing.Size(56, 50);
            this.btnRigth2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnRigth2.TabIndex = 46;
            this.btnRigth2.TabStop = false;
            this.btnRigth2.Click += new System.EventHandler(this.btnRigth2_Click);
            // 
            // btnRigth3
            // 
            this.btnRigth3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRigth3.Image = ((System.Drawing.Image)(resources.GetObject("btnRigth3.Image")));
            this.btnRigth3.Location = new System.Drawing.Point(974, 428);
            this.btnRigth3.Name = "btnRigth3";
            this.btnRigth3.Size = new System.Drawing.Size(56, 50);
            this.btnRigth3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnRigth3.TabIndex = 47;
            this.btnRigth3.TabStop = false;
            this.btnRigth3.Click += new System.EventHandler(this.btnRigth3_Click);
            // 
            // lblConsultaNro
            // 
            this.lblConsultaNro.AutoSize = true;
            this.lblConsultaNro.BackColor = System.Drawing.Color.Aquamarine;
            this.lblConsultaNro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblConsultaNro.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsultaNro.ForeColor = System.Drawing.Color.Black;
            this.lblConsultaNro.Location = new System.Drawing.Point(682, 370);
            this.lblConsultaNro.Name = "lblConsultaNro";
            this.lblConsultaNro.Padding = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.lblConsultaNro.Size = new System.Drawing.Size(165, 37);
            this.lblConsultaNro.TabIndex = 54;
            this.lblConsultaNro.Text = "NÚMERO DE CUENTA";
            // 
            // lblSalir
            // 
            this.lblSalir.AutoSize = true;
            this.lblSalir.BackColor = System.Drawing.Color.Aquamarine;
            this.lblSalir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSalir.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalir.ForeColor = System.Drawing.Color.Black;
            this.lblSalir.Location = new System.Drawing.Point(781, 437);
            this.lblSalir.Name = "lblSalir";
            this.lblSalir.Padding = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.lblSalir.Size = new System.Drawing.Size(66, 37);
            this.lblSalir.TabIndex = 52;
            this.lblSalir.Text = "SALIR";
            // 
            // lblTransferencia
            // 
            this.lblTransferencia.AutoSize = true;
            this.lblTransferencia.BackColor = System.Drawing.Color.Aquamarine;
            this.lblTransferencia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTransferencia.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransferencia.ForeColor = System.Drawing.Color.Black;
            this.lblTransferencia.Location = new System.Drawing.Point(221, 437);
            this.lblTransferencia.Name = "lblTransferencia";
            this.lblTransferencia.Padding = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.lblTransferencia.Size = new System.Drawing.Size(138, 37);
            this.lblTransferencia.TabIndex = 51;
            this.lblTransferencia.Text = "DINERO RÁPIDO";
            // 
            // lblRetirSaldo
            // 
            this.lblRetirSaldo.AutoSize = true;
            this.lblRetirSaldo.BackColor = System.Drawing.Color.Aquamarine;
            this.lblRetirSaldo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRetirSaldo.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRetirSaldo.ForeColor = System.Drawing.Color.Black;
            this.lblRetirSaldo.Location = new System.Drawing.Point(221, 370);
            this.lblRetirSaldo.Name = "lblRetirSaldo";
            this.lblRetirSaldo.Padding = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.lblRetirSaldo.Size = new System.Drawing.Size(138, 37);
            this.lblRetirSaldo.TabIndex = 50;
            this.lblRetirSaldo.Text = "RETIRAR MONTO";
            // 
            // lblConsulSaldo
            // 
            this.lblConsulSaldo.AutoSize = true;
            this.lblConsulSaldo.BackColor = System.Drawing.Color.Aquamarine;
            this.lblConsulSaldo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblConsulSaldo.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsulSaldo.ForeColor = System.Drawing.Color.Black;
            this.lblConsulSaldo.Location = new System.Drawing.Point(221, 304);
            this.lblConsulSaldo.Name = "lblConsulSaldo";
            this.lblConsulSaldo.Padding = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.lblConsulSaldo.Size = new System.Drawing.Size(156, 37);
            this.lblConsulSaldo.TabIndex = 49;
            this.lblConsulSaldo.Text = "CONSULTAR SALDO";
            // 
            // lblConsultpts
            // 
            this.lblConsultpts.AutoSize = true;
            this.lblConsultpts.BackColor = System.Drawing.Color.Aquamarine;
            this.lblConsultpts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblConsultpts.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsultpts.ForeColor = System.Drawing.Color.Black;
            this.lblConsultpts.Location = new System.Drawing.Point(691, 304);
            this.lblConsultpts.Name = "lblConsultpts";
            this.lblConsultpts.Padding = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.lblConsultpts.Size = new System.Drawing.Size(156, 37);
            this.lblConsultpts.TabIndex = 55;
            this.lblConsultpts.Text = "DEPOSITAR MONTO";
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=DESKTOP-0J3C3IK;Initial Catalog=\"ATMDB 2.0\";Integrated Security=True";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(103, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(858, 51);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 56;
            this.pictureBox1.TabStop = false;
            // 
            // ATM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1063, 788);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblConsultpts);
            this.Controls.Add(this.lblConsultaNro);
            this.Controls.Add(this.lblSalir);
            this.Controls.Add(this.lblTransferencia);
            this.Controls.Add(this.lblRetirSaldo);
            this.Controls.Add(this.lblConsulSaldo);
            this.Controls.Add(this.btnRigth3);
            this.Controls.Add(this.btnRigth2);
            this.Controls.Add(this.btnRigth1);
            this.Controls.Add(this.btnLeft3);
            this.Controls.Add(this.btnLeft2);
            this.Controls.Add(this.btnLeft1);
            this.Controls.Add(this.lblBienvenida);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.Pantalla);
            this.Controls.Add(this.Teclado);
            this.Controls.Add(this.CajeroATM);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ATM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Teclado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pantalla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEnter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CajeroATM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLeft1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLeft2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLeft3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRigth1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRigth2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRigth3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Teclado;
        private System.Windows.Forms.PictureBox Pantalla;
        private System.Windows.Forms.PictureBox btn0;
        private System.Windows.Forms.PictureBox btn8;
        private System.Windows.Forms.PictureBox btn9;
        private System.Windows.Forms.PictureBox btn7;
        private System.Windows.Forms.PictureBox btn6;
        private System.Windows.Forms.PictureBox btn5;
        private System.Windows.Forms.PictureBox btn4;
        private System.Windows.Forms.PictureBox btn3;
        private System.Windows.Forms.PictureBox btn2;
        private System.Windows.Forms.PictureBox btn1;
        private System.Windows.Forms.PictureBox btnCancel;
        private System.Windows.Forms.PictureBox btnEnter;
        private System.Windows.Forms.PictureBox btnClear;
        private System.Windows.Forms.Label lblBienvenida;
        private System.Windows.Forms.PictureBox CajeroATM;
        private System.Windows.Forms.PictureBox btnLeft1;
        private System.Windows.Forms.PictureBox btnLeft2;
        private System.Windows.Forms.PictureBox btnLeft3;
        private System.Windows.Forms.PictureBox btnRigth1;
        private System.Windows.Forms.PictureBox btnRigth2;
        private System.Windows.Forms.PictureBox btnRigth3;
        public System.Windows.Forms.Label lblConsultaNro;
        public System.Windows.Forms.Label lblSalir;
        public System.Windows.Forms.Label lblTransferencia;
        public System.Windows.Forms.Label lblRetirSaldo;
        public System.Windows.Forms.Label lblConsulSaldo;
        public System.Windows.Forms.Label lblConsultpts;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

