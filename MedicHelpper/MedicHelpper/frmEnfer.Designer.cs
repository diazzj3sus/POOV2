﻿namespace MedicHelpper
{
    partial class frmEnfer
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEnfer));
            this.addPaciente = new System.Windows.Forms.TabPage();
            this.dtFechadeNacimiento = new System.Windows.Forms.DateTimePicker();
            this.btnAddPatient = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtnum = new System.Windows.Forms.TextBox();
            this.txtape = new System.Windows.Forms.TextBox();
            this.txtnom = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.findPaciente = new System.Windows.Forms.TabPage();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.NTarjeta = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtFechaBirth = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lblBirth = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.showPaciente = new System.Windows.Forms.TabPage();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.dgvPacientes = new System.Windows.Forms.DataGridView();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnRestaurar = new System.Windows.Forms.PictureBox();
            this.errorCodigoCita = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorCodigoTarjeta = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorNombreAgg = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorFechadeNacimientoAgg = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorNTarjetaFind = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorFecha = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorApellidoAgg = new System.Windows.Forms.ErrorProvider(this.components);
            this.pctAtras = new System.Windows.Forms.PictureBox();
            this.tipVerificar = new System.Windows.Forms.ToolTip(this.components);
            this.errorFechaNacimiento = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorNTarjeta = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorNtarjetaPaciente = new System.Windows.Forms.ErrorProvider(this.components);
            this.tipAgregar = new System.Windows.Forms.ToolTip(this.components);
            this.tabControl1.SuspendLayout();
            this.AddCita.SuspendLayout();
            this.addPaciente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.findPaciente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.showPaciente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCodigoCita)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCodigoTarjeta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNombreAgg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorFechadeNacimientoAgg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNTarjetaFind)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorFecha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorApellidoAgg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctAtras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorFechaNacimiento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNTarjeta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNtarjetaPaciente)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.addPaciente);
            this.tabControl1.Controls.Add(this.findPaciente);
            this.tabControl1.Controls.Add(this.showPaciente);
            this.tabControl1.Location = new System.Drawing.Point(20, 51);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Size = new System.Drawing.Size(548, 294);
            this.tabControl1.Controls.SetChildIndex(this.showPaciente, 0);
            this.tabControl1.Controls.SetChildIndex(this.findPaciente, 0);
            this.tabControl1.Controls.SetChildIndex(this.AddCita, 0);
            this.tabControl1.Controls.SetChildIndex(this.addPaciente, 0);
            // 
            // dtpCita
            // 
            this.dtpCita.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpCita.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCita.Location = new System.Drawing.Point(218, 33);
            this.dtpCita.Size = new System.Drawing.Size(240, 26);
            this.dtpCita.ValueChanged += new System.EventHandler(this.dtpCita_ValueChanged);
            // 
            // txtTarjeta
            // 
            this.txtTarjeta.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTarjeta.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTarjeta.Location = new System.Drawing.Point(223, 87);
            this.txtTarjeta.Margin = new System.Windows.Forms.Padding(2);
            this.txtTarjeta.Size = new System.Drawing.Size(100, 26);
            this.txtTarjeta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // btnAddCita
            // 
            this.btnAddCita.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAddCita.Location = new System.Drawing.Point(265, 206);
            this.btnAddCita.Click += new System.EventHandler(this.btnAddCita_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(74, 87);
            this.label5.Size = new System.Drawing.Size(101, 20);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(69, 37);
            this.label7.Size = new System.Drawing.Size(109, 20);
            // 
            // lblEstado
            // 
            this.lblEstado.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(141, 192);
            this.lblEstado.Size = new System.Drawing.Size(13, 20);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(74, 191);
            this.label6.Size = new System.Drawing.Size(64, 20);
            // 
            // AddCita
            // 
            this.AddCita.Margin = new System.Windows.Forms.Padding(2);
            this.AddCita.Padding = new System.Windows.Forms.Padding(2);
            this.AddCita.Size = new System.Drawing.Size(540, 265);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Location = new System.Drawing.Point(536, 3);
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(72, 142);
            this.label8.Size = new System.Drawing.Size(82, 20);
            // 
            // txtCita
            // 
            this.txtCita.Enabled = false;
            this.txtCita.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCita.Location = new System.Drawing.Point(223, 142);
            this.txtCita.Size = new System.Drawing.Size(100, 26);
            this.txtCita.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox4_KeyPress);
            // 
            // addPaciente
            // 
            this.addPaciente.BackColor = System.Drawing.Color.Silver;
            this.addPaciente.Controls.Add(this.dtFechadeNacimiento);
            this.addPaciente.Controls.Add(this.btnAddPatient);
            this.addPaciente.Controls.Add(this.pictureBox1);
            this.addPaciente.Controls.Add(this.txtnum);
            this.addPaciente.Controls.Add(this.txtape);
            this.addPaciente.Controls.Add(this.txtnom);
            this.addPaciente.Controls.Add(this.label4);
            this.addPaciente.Controls.Add(this.label3);
            this.addPaciente.Controls.Add(this.label2);
            this.addPaciente.Controls.Add(this.label1);
            this.addPaciente.Location = new System.Drawing.Point(4, 25);
            this.addPaciente.Margin = new System.Windows.Forms.Padding(2);
            this.addPaciente.Name = "addPaciente";
            this.addPaciente.Padding = new System.Windows.Forms.Padding(2);
            this.addPaciente.Size = new System.Drawing.Size(540, 265);
            this.addPaciente.TabIndex = 2;
            this.addPaciente.Text = "Agregar paciente";
            // 
            // dtFechadeNacimiento
            // 
            this.dtFechadeNacimiento.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtFechadeNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechadeNacimiento.Location = new System.Drawing.Point(185, 149);
            this.dtFechadeNacimiento.Margin = new System.Windows.Forms.Padding(2);
            this.dtFechadeNacimiento.Name = "dtFechadeNacimiento";
            this.dtFechadeNacimiento.Size = new System.Drawing.Size(100, 20);
            this.dtFechadeNacimiento.TabIndex = 20;
            this.dtFechadeNacimiento.ValueChanged += new System.EventHandler(this.dtFechadeNacimiento_ValueChanged);
            // 
            // btnAddPatient
            // 
            this.btnAddPatient.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAddPatient.BackColor = System.Drawing.Color.LightGreen;
            this.btnAddPatient.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddPatient.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPatient.Image = global::MedicHelpper.Properties.Resources.agregar_usuario;
            this.btnAddPatient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddPatient.Location = new System.Drawing.Point(339, 184);
            this.btnAddPatient.Name = "btnAddPatient";
            this.btnAddPatient.Size = new System.Drawing.Size(95, 27);
            this.btnAddPatient.TabIndex = 19;
            this.btnAddPatient.Text = "Agregar";
            this.btnAddPatient.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddPatient.UseVisualStyleBackColor = true;
            this.btnAddPatient.Click += new System.EventHandler(this.btnAddPatient_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = global::MedicHelpper.Properties.Resources.usuarioDEF;
            this.pictureBox1.Location = new System.Drawing.Point(325, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // txtnum
            // 
            this.txtnum.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtnum.Location = new System.Drawing.Point(185, 212);
            this.txtnum.Name = "txtnum";
            this.txtnum.Size = new System.Drawing.Size(100, 20);
            this.txtnum.TabIndex = 17;
            // 
            // txtape
            // 
            this.txtape.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtape.Location = new System.Drawing.Point(185, 84);
            this.txtape.Name = "txtape";
            this.txtape.Size = new System.Drawing.Size(100, 20);
            this.txtape.TabIndex = 16;
            this.txtape.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtape_KeyPress);
            // 
            // txtnom
            // 
            this.txtnom.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtnom.Location = new System.Drawing.Point(183, 29);
            this.txtnom.Name = "txtnom";
            this.txtnom.Size = new System.Drawing.Size(100, 20);
            this.txtnom.TabIndex = 14;
            this.txtnom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnom_KeyPress);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Nº de tarjeta:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Fecha de nacimiento:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Apellido:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nombre:";
            // 
            // findPaciente
            // 
            this.findPaciente.BackColor = System.Drawing.Color.Silver;
            this.findPaciente.Controls.Add(this.btnEdit);
            this.findPaciente.Controls.Add(this.btnBuscar);
            this.findPaciente.Controls.Add(this.pictureBox2);
            this.findPaciente.Controls.Add(this.NTarjeta);
            this.findPaciente.Controls.Add(this.txtApellido);
            this.findPaciente.Controls.Add(this.txtFechaBirth);
            this.findPaciente.Controls.Add(this.txtNombre);
            this.findPaciente.Controls.Add(this.label9);
            this.findPaciente.Controls.Add(this.lblBirth);
            this.findPaciente.Controls.Add(this.lblLastName);
            this.findPaciente.Controls.Add(this.lblName);
            this.findPaciente.Location = new System.Drawing.Point(4, 25);
            this.findPaciente.Margin = new System.Windows.Forms.Padding(2);
            this.findPaciente.Name = "findPaciente";
            this.findPaciente.Padding = new System.Windows.Forms.Padding(2);
            this.findPaciente.Size = new System.Drawing.Size(540, 265);
            this.findPaciente.TabIndex = 3;
            this.findPaciente.Text = "Buscar Paciente";
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.BackColor = System.Drawing.Color.LightSalmon;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEdit.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Image = global::MedicHelpper.Properties.Resources.reanudar;
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Location = new System.Drawing.Point(376, 85);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(95, 27);
            this.btnEdit.TabIndex = 32;
            this.btnEdit.Text = "Editar";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Visible = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.BackColor = System.Drawing.Color.LightGreen;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscar.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Image = global::MedicHelpper.Properties.Resources.headhunter;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(376, 30);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(95, 27);
            this.btnBuscar.TabIndex = 31;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox2.Image = global::MedicHelpper.Properties.Resources.usuarioDEF;
            this.pictureBox2.Location = new System.Drawing.Point(381, 128);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(120, 120);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 30;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // NTarjeta
            // 
            this.NTarjeta.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.NTarjeta.Location = new System.Drawing.Point(205, 30);
            this.NTarjeta.Name = "NTarjeta";
            this.NTarjeta.Size = new System.Drawing.Size(100, 20);
            this.NTarjeta.TabIndex = 29;
            // 
            // txtApellido
            // 
            this.txtApellido.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtApellido.Location = new System.Drawing.Point(205, 148);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 28;
            this.txtApellido.Visible = false;
            // 
            // txtFechaBirth
            // 
            this.txtFechaBirth.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtFechaBirth.Location = new System.Drawing.Point(205, 208);
            this.txtFechaBirth.Name = "txtFechaBirth";
            this.txtFechaBirth.Size = new System.Drawing.Size(100, 20);
            this.txtFechaBirth.TabIndex = 27;
            this.txtFechaBirth.Visible = false;
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNombre.Location = new System.Drawing.Point(205, 92);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 26;
            this.txtNombre.Visible = false;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(51, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 16);
            this.label9.TabIndex = 25;
            this.label9.Text = "Nº de tarjeta:";
            // 
            // lblBirth
            // 
            this.lblBirth.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblBirth.AutoSize = true;
            this.lblBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBirth.Location = new System.Drawing.Point(51, 208);
            this.lblBirth.Name = "lblBirth";
            this.lblBirth.Size = new System.Drawing.Size(156, 16);
            this.lblBirth.TabIndex = 24;
            this.lblBirth.Text = "Fecha de nacimiento:";
            this.lblBirth.Visible = false;
            // 
            // lblLastName
            // 
            this.lblLastName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(51, 143);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(70, 16);
            this.lblLastName.TabIndex = 23;
            this.lblLastName.Text = "Apellido:";
            this.lblLastName.Visible = false;
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(51, 89);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(67, 16);
            this.lblName.TabIndex = 22;
            this.lblName.Text = "Nombre:";
            this.lblName.Visible = false;
            // 
            // showPaciente
            // 
            this.showPaciente.Controls.Add(this.btnMostrar);
            this.showPaciente.Controls.Add(this.dgvPacientes);
            this.showPaciente.Location = new System.Drawing.Point(4, 25);
            this.showPaciente.Margin = new System.Windows.Forms.Padding(2);
            this.showPaciente.Name = "showPaciente";
            this.showPaciente.Size = new System.Drawing.Size(540, 265);
            this.showPaciente.TabIndex = 4;
            this.showPaciente.Text = "Mostrar pacientes";
            this.showPaciente.UseVisualStyleBackColor = true;
            // 
            // btnMostrar
            // 
            this.btnMostrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMostrar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnMostrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMostrar.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrar.Image = global::MedicHelpper.Properties.Resources.mostrar;
            this.btnMostrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMostrar.Location = new System.Drawing.Point(406, 222);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(103, 24);
            this.btnMostrar.TabIndex = 3;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMostrar.UseVisualStyleBackColor = false;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // dgvPacientes
            // 
            this.dgvPacientes.AllowUserToAddRows = false;
            this.dgvPacientes.AllowUserToDeleteRows = false;
            this.dgvPacientes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPacientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPacientes.Location = new System.Drawing.Point(33, 16);
            this.dgvPacientes.Name = "dgvPacientes";
            this.dgvPacientes.ReadOnly = true;
            this.dgvPacientes.RowHeadersVisible = false;
            this.dgvPacientes.RowHeadersWidth = 51;
            this.dgvPacientes.Size = new System.Drawing.Size(488, 200);
            this.dgvPacientes.TabIndex = 2;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.Image = global::MedicHelpper.Properties.Resources.minimizar2;
            this.btnMinimizar.Location = new System.Drawing.Point(456, 7);
            this.btnMinimizar.Margin = new System.Windows.Forms.Padding(2);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(40, 28);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 14;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaurar.Image = global::MedicHelpper.Properties.Resources.redimensionar;
            this.btnRestaurar.Location = new System.Drawing.Point(491, 6);
            this.btnRestaurar.Margin = new System.Windows.Forms.Padding(2);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(37, 28);
            this.btnRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRestaurar.TabIndex = 13;
            this.btnRestaurar.TabStop = false;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // errorCodigoCita
            // 
            this.errorCodigoCita.ContainerControl = this;
            // 
            // errorCodigoTarjeta
            // 
            this.errorCodigoTarjeta.ContainerControl = this;
            // 
            // errorNombreAgg
            // 
            this.errorNombreAgg.ContainerControl = this;
            // 
            // errorFechadeNacimientoAgg
            // 
            this.errorFechadeNacimientoAgg.ContainerControl = this;
            // 
            // errorNTarjetaFind
            // 
            this.errorNTarjetaFind.ContainerControl = this;
            // 
            // errorFecha
            // 
            this.errorFecha.ContainerControl = this;
            // 
            // errorApellidoAgg
            // 
            this.errorApellidoAgg.ContainerControl = this;
            // 
            // pctAtras
            // 
            this.pctAtras.Image = global::MedicHelpper.Properties.Resources.Atras;
            this.pctAtras.Location = new System.Drawing.Point(20, 7);
            this.pctAtras.Margin = new System.Windows.Forms.Padding(2);
            this.pctAtras.Name = "pctAtras";
            this.pctAtras.Size = new System.Drawing.Size(38, 31);
            this.pctAtras.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctAtras.TabIndex = 15;
            this.pctAtras.TabStop = false;
            this.pctAtras.Click += new System.EventHandler(this.pctAtras_Click);
            // 
            // errorFechaNacimiento
            // 
            this.errorFechaNacimiento.ContainerControl = this;
            // 
            // errorNTarjeta
            // 
            this.errorNTarjeta.ContainerControl = this;
            // 
            // errorNtarjetaPaciente
            // 
            this.errorNtarjetaPaciente.ContainerControl = this;
            // 
            // frmEnfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(584, 376);
            this.Controls.Add(this.pctAtras);
            this.Controls.Add(this.btnMinimizar);
            this.Controls.Add(this.btnRestaurar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3);
            this.Name = "frmEnfer";
            this.Controls.SetChildIndex(this.btnRestaurar, 0);
            this.Controls.SetChildIndex(this.btnMinimizar, 0);
            this.Controls.SetChildIndex(this.pctAtras, 0);
            this.Controls.SetChildIndex(this.btnCerrar, 0);
            this.Controls.SetChildIndex(this.tabControl1, 0);
            this.tabControl1.ResumeLayout(false);
            this.AddCita.ResumeLayout(false);
            this.AddCita.PerformLayout();
            this.addPaciente.ResumeLayout(false);
            this.addPaciente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.findPaciente.ResumeLayout(false);
            this.findPaciente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.showPaciente.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCodigoCita)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCodigoTarjeta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNombreAgg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorFechadeNacimientoAgg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNTarjetaFind)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorFecha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorApellidoAgg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctAtras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorFechaNacimiento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNTarjeta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNtarjetaPaciente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage addPaciente;
        private System.Windows.Forms.Button btnAddPatient;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtnum;
        private System.Windows.Forms.TextBox txtape;
        private System.Windows.Forms.TextBox txtnom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage findPaciente;
        protected System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox NTarjeta;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtFechaBirth;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblBirth;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TabPage showPaciente;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.DataGridView dgvPacientes;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnRestaurar;
        private System.Windows.Forms.ErrorProvider errorCodigoCita;
        private System.Windows.Forms.DateTimePicker dtFechadeNacimiento;
        private System.Windows.Forms.ErrorProvider errorCodigoTarjeta;
        private System.Windows.Forms.ErrorProvider errorNombreAgg;
        private System.Windows.Forms.ErrorProvider errorFechadeNacimientoAgg;
        private System.Windows.Forms.ErrorProvider errorNTarjetaFind;
        private System.Windows.Forms.ErrorProvider errorFecha;
        private System.Windows.Forms.ErrorProvider errorApellidoAgg;
        private System.Windows.Forms.PictureBox pctAtras;
        private System.Windows.Forms.ToolTip tipVerificar;
        private System.Windows.Forms.ErrorProvider errorFechaNacimiento;
        private System.Windows.Forms.ErrorProvider errorNTarjeta;
        private System.Windows.Forms.ErrorProvider errorNtarjetaPaciente;
        private System.Windows.Forms.ToolTip tipAgregar;
    }
}
