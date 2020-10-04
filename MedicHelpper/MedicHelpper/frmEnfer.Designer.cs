namespace MedicHelpper
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
            this.addPaciente = new System.Windows.Forms.TabPage();
            this.btnAddPatient = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtnum = new System.Windows.Forms.TextBox();
            this.txtape = new System.Windows.Forms.TextBox();
            this.txtdatebirth = new System.Windows.Forms.TextBox();
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.AddCita.SuspendLayout();
            this.addPaciente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.findPaciente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.showPaciente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.addPaciente);
            this.tabControl1.Controls.Add(this.findPaciente);
            this.tabControl1.Controls.Add(this.showPaciente);
            this.tabControl1.Size = new System.Drawing.Size(659, 362);
            this.tabControl1.Controls.SetChildIndex(this.showPaciente, 0);
            this.tabControl1.Controls.SetChildIndex(this.findPaciente, 0);
            this.tabControl1.Controls.SetChildIndex(this.AddCita, 0);
            this.tabControl1.Controls.SetChildIndex(this.addPaciente, 0);
            // 
            // AddCita
            // 
            this.AddCita.Size = new System.Drawing.Size(651, 329);
            // 
            // addPaciente
            // 
            this.addPaciente.BackColor = System.Drawing.Color.Silver;
            this.addPaciente.Controls.Add(this.btnAddPatient);
            this.addPaciente.Controls.Add(this.pictureBox1);
            this.addPaciente.Controls.Add(this.txtnum);
            this.addPaciente.Controls.Add(this.txtape);
            this.addPaciente.Controls.Add(this.txtdatebirth);
            this.addPaciente.Controls.Add(this.txtnom);
            this.addPaciente.Controls.Add(this.label4);
            this.addPaciente.Controls.Add(this.label3);
            this.addPaciente.Controls.Add(this.label2);
            this.addPaciente.Controls.Add(this.label1);
            this.addPaciente.Location = new System.Drawing.Point(4, 29);
            this.addPaciente.Name = "addPaciente";
            this.addPaciente.Padding = new System.Windows.Forms.Padding(3);
            this.addPaciente.Size = new System.Drawing.Size(651, 329);
            this.addPaciente.TabIndex = 2;
            this.addPaciente.Text = "Agregar paciente";
            // 
            // btnAddPatient
            // 
            this.btnAddPatient.BackColor = System.Drawing.Color.LightGreen;
            this.btnAddPatient.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddPatient.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPatient.Image = global::MedicHelpper.Properties.Resources.agregar_usuario;
            this.btnAddPatient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddPatient.Location = new System.Drawing.Point(442, 230);
            this.btnAddPatient.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddPatient.Name = "btnAddPatient";
            this.btnAddPatient.Size = new System.Drawing.Size(127, 33);
            this.btnAddPatient.TabIndex = 19;
            this.btnAddPatient.Text = "Agregar";
            this.btnAddPatient.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddPatient.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MedicHelpper.Properties.Resources.usuarioDEF;
            this.pictureBox1.Location = new System.Drawing.Point(426, 62);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 148);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // txtnum
            // 
            this.txtnum.Location = new System.Drawing.Point(258, 265);
            this.txtnum.Margin = new System.Windows.Forms.Padding(4);
            this.txtnum.Name = "txtnum";
            this.txtnum.Size = new System.Drawing.Size(132, 24);
            this.txtnum.TabIndex = 17;
            // 
            // txtape
            // 
            this.txtape.Location = new System.Drawing.Point(258, 107);
            this.txtape.Margin = new System.Windows.Forms.Padding(4);
            this.txtape.Name = "txtape";
            this.txtape.Size = new System.Drawing.Size(132, 24);
            this.txtape.TabIndex = 16;
            // 
            // txtdatebirth
            // 
            this.txtdatebirth.Location = new System.Drawing.Point(258, 182);
            this.txtdatebirth.Margin = new System.Windows.Forms.Padding(4);
            this.txtdatebirth.Name = "txtdatebirth";
            this.txtdatebirth.Size = new System.Drawing.Size(132, 24);
            this.txtdatebirth.TabIndex = 15;
            // 
            // txtnom
            // 
            this.txtnom.Location = new System.Drawing.Point(258, 39);
            this.txtnom.Margin = new System.Windows.Forms.Padding(4);
            this.txtnom.Name = "txtnom";
            this.txtnom.Size = new System.Drawing.Size(132, 24);
            this.txtnom.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(42, 261);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Nº de tarjeta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 187);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Fecha de nacimiento:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 108);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Apellido:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
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
            this.findPaciente.Location = new System.Drawing.Point(4, 29);
            this.findPaciente.Name = "findPaciente";
            this.findPaciente.Padding = new System.Windows.Forms.Padding(3);
            this.findPaciente.Size = new System.Drawing.Size(651, 329);
            this.findPaciente.TabIndex = 3;
            this.findPaciente.Text = "Buscar Paciente";
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.LightSalmon;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEdit.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Image = global::MedicHelpper.Properties.Resources.reanudar;
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Location = new System.Drawing.Point(444, 88);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(127, 33);
            this.btnEdit.TabIndex = 32;
            this.btnEdit.Text = "Editar";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Visible = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.LightGreen;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscar.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Image = global::MedicHelpper.Properties.Resources.headhunter;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(444, 35);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(127, 33);
            this.btnBuscar.TabIndex = 31;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::MedicHelpper.Properties.Resources.usuarioDEF;
            this.pictureBox2.Location = new System.Drawing.Point(425, 150);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(160, 148);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 30;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // NTarjeta
            // 
            this.NTarjeta.Location = new System.Drawing.Point(260, 35);
            this.NTarjeta.Margin = new System.Windows.Forms.Padding(4);
            this.NTarjeta.Name = "NTarjeta";
            this.NTarjeta.Size = new System.Drawing.Size(132, 24);
            this.NTarjeta.TabIndex = 29;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(260, 180);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(4);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(132, 24);
            this.txtApellido.TabIndex = 28;
            this.txtApellido.Visible = false;
            // 
            // txtFechaBirth
            // 
            this.txtFechaBirth.Location = new System.Drawing.Point(260, 254);
            this.txtFechaBirth.Margin = new System.Windows.Forms.Padding(4);
            this.txtFechaBirth.Name = "txtFechaBirth";
            this.txtFechaBirth.Size = new System.Drawing.Size(132, 24);
            this.txtFechaBirth.TabIndex = 27;
            this.txtFechaBirth.Visible = false;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(260, 111);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(132, 24);
            this.txtNombre.TabIndex = 26;
            this.txtNombre.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(44, 30);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 20);
            this.label9.TabIndex = 25;
            this.label9.Text = "Nº de tarjeta:";
            // 
            // lblBirth
            // 
            this.lblBirth.AutoSize = true;
            this.lblBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBirth.Location = new System.Drawing.Point(44, 254);
            this.lblBirth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBirth.Name = "lblBirth";
            this.lblBirth.Size = new System.Drawing.Size(189, 20);
            this.lblBirth.TabIndex = 24;
            this.lblBirth.Text = "Fecha de nacimiento:";
            this.lblBirth.Visible = false;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(44, 180);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(82, 20);
            this.lblLastName.TabIndex = 23;
            this.lblLastName.Text = "Apellido:";
            this.lblLastName.Visible = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(44, 113);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(80, 20);
            this.lblName.TabIndex = 22;
            this.lblName.Text = "Nombre:";
            this.lblName.Visible = false;
            // 
            // showPaciente
            // 
            this.showPaciente.Controls.Add(this.button1);
            this.showPaciente.Controls.Add(this.dataGridView1);
            this.showPaciente.Location = new System.Drawing.Point(4, 29);
            this.showPaciente.Name = "showPaciente";
            this.showPaciente.Size = new System.Drawing.Size(651, 329);
            this.showPaciente.TabIndex = 4;
            this.showPaciente.Text = "Mostrar pacientes";
            this.showPaciente.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::MedicHelpper.Properties.Resources.mostrar;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(496, 278);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 30);
            this.button1.TabIndex = 3;
            this.button1.Text = "Mostrar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 16);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(615, 231);
            this.dataGridView1.TabIndex = 2;
            // 
            // frmEnfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(707, 441);
            this.Name = "frmEnfer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage addPaciente;
        private System.Windows.Forms.Button btnAddPatient;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtnum;
        private System.Windows.Forms.TextBox txtape;
        private System.Windows.Forms.TextBox txtdatebirth;
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
