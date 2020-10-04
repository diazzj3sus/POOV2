namespace MedicHelpper
{
    partial class frmPadre
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCerrar = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.AddCita = new System.Windows.Forms.TabPage();
            this.lblEstado = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.btnEstado = new System.Windows.Forms.Button();
            this.btnAddCita = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.AddCita.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(637, 8);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(49, 38);
            this.btnCerrar.TabIndex = 5;
            this.btnCerrar.Text = "X";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.AddCita);
            this.tabControl1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(27, 54);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(637, 362);
            this.tabControl1.TabIndex = 6;
            // 
            // AddCita
            // 
            this.AddCita.BackColor = System.Drawing.Color.Silver;
            this.AddCita.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.AddCita.Controls.Add(this.lblEstado);
            this.AddCita.Controls.Add(this.label6);
            this.AddCita.Controls.Add(this.label5);
            this.AddCita.Controls.Add(this.label7);
            this.AddCita.Controls.Add(this.label8);
            this.AddCita.Controls.Add(this.dateTimePicker1);
            this.AddCita.Controls.Add(this.textBox1);
            this.AddCita.Controls.Add(this.textBox4);
            this.AddCita.Controls.Add(this.btnEstado);
            this.AddCita.Controls.Add(this.btnAddCita);
            this.AddCita.Location = new System.Drawing.Point(4, 29);
            this.AddCita.Margin = new System.Windows.Forms.Padding(4);
            this.AddCita.Name = "AddCita";
            this.AddCita.Padding = new System.Windows.Forms.Padding(4);
            this.AddCita.Size = new System.Drawing.Size(629, 329);
            this.AddCita.TabIndex = 1;
            this.AddCita.Text = "Citas";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(529, 193);
            this.lblEstado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(18, 20);
            this.lblEstado.TabIndex = 24;
            this.lblEstado.Text = ".";
            this.lblEstado.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(440, 192);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 20);
            this.label6.TabIndex = 23;
            this.label6.Text = "Estado:";
            this.label6.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(104, 192);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "Nº de tarjeta:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(35, 47);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 20);
            this.label7.TabIndex = 21;
            this.label7.Text = "Fecha de cita:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(86, 123);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 20);
            this.label8.TabIndex = 20;
            this.label8.Text = "Codigo de cita:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(209, 43);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(325, 24);
            this.dateTimePicker1.TabIndex = 19;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(269, 188);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 24);
            this.textBox1.TabIndex = 15;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(269, 119);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(132, 24);
            this.textBox4.TabIndex = 12;
            // 
            // btnEstado
            // 
            this.btnEstado.BackColor = System.Drawing.Color.LightGreen;
            this.btnEstado.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstado.Image = global::MedicHelpper.Properties.Resources.comprobar;
            this.btnEstado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEstado.Location = new System.Drawing.Point(444, 250);
            this.btnEstado.Margin = new System.Windows.Forms.Padding(4);
            this.btnEstado.Name = "btnEstado";
            this.btnEstado.Size = new System.Drawing.Size(119, 43);
            this.btnEstado.TabIndex = 18;
            this.btnEstado.Text = "Estado";
            this.btnEstado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEstado.UseVisualStyleBackColor = false;
            this.btnEstado.Visible = false;
            // 
            // btnAddCita
            // 
            this.btnAddCita.BackColor = System.Drawing.Color.Wheat;
            this.btnAddCita.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCita.Image = global::MedicHelpper.Properties.Resources.calendario;
            this.btnAddCita.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddCita.Location = new System.Drawing.Point(232, 250);
            this.btnAddCita.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddCita.Name = "btnAddCita";
            this.btnAddCita.Size = new System.Drawing.Size(171, 43);
            this.btnAddCita.TabIndex = 17;
            this.btnAddCita.Text = "Agendar Cita";
            this.btnAddCita.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddCita.UseVisualStyleBackColor = false;
            // 
            // frmPadre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(59)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(707, 441);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnCerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPadre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPadre";
            this.tabControl1.ResumeLayout(false);
            this.AddCita.ResumeLayout(false);
            this.AddCita.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        protected System.Windows.Forms.TabControl tabControl1;
        protected System.Windows.Forms.DateTimePicker dateTimePicker1;
        protected System.Windows.Forms.TextBox textBox1;
        protected System.Windows.Forms.TextBox textBox4;
        protected System.Windows.Forms.Button btnEstado;
        protected System.Windows.Forms.Button btnAddCita;
        protected System.Windows.Forms.Label label5;
        protected System.Windows.Forms.Label label7;
        protected System.Windows.Forms.Label label8;
        protected System.Windows.Forms.Label lblEstado;
        protected System.Windows.Forms.Label label6;
        protected System.Windows.Forms.TabPage AddCita;
        protected System.Windows.Forms.Button btnCerrar;
    }
}