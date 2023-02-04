namespace Nomina
{
    partial class Nomina
    {
        private const string V = "Nomina";

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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Nominadgtv = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtSM = new System.Windows.Forms.TextBox();
            this.txtDT = new System.Windows.Forms.TextBox();
            this.txtHE = new System.Windows.Forms.TextBox();
            this.btnRegistro = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBasico = new System.Windows.Forms.TextBox();
            this.txtINSS = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEliminarTodo = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmpleo = new System.Windows.Forms.TextBox();
            this.Cedulatxt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sueldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Horas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Basico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Devengado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.txtToT = new System.Windows.Forms.TextBox();
            this.txtToty = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Nominadgtv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Identificacion";
            // 
            // Nominadgtv
            // 
            this.Nominadgtv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Nominadgtv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cedulatxt,
            this.Name,
            this.Cargo,
            this.Sueldo,
            this.Dias,
            this.Horas,
            this.Basico,
            this.Devengado});
            this.Nominadgtv.Location = new System.Drawing.Point(30, 225);
            this.Nominadgtv.Name = "Nominadgtv";
            this.Nominadgtv.Size = new System.Drawing.Size(605, 155);
            this.Nominadgtv.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Sueldo mensual";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Horas Extras";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(135, 24);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(219, 20);
            this.txtID.TabIndex = 8;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(135, 61);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(219, 20);
            this.txtNom.TabIndex = 9;
            // 
            // txtSM
            // 
            this.txtSM.Location = new System.Drawing.Point(135, 127);
            this.txtSM.Name = "txtSM";
            this.txtSM.Size = new System.Drawing.Size(219, 20);
            this.txtSM.TabIndex = 10;
            // 
            // txtDT
            // 
            this.txtDT.Location = new System.Drawing.Point(135, 155);
            this.txtDT.Name = "txtDT";
            this.txtDT.Size = new System.Drawing.Size(219, 20);
            this.txtDT.TabIndex = 11;
            // 
            // txtHE
            // 
            this.txtHE.Location = new System.Drawing.Point(135, 191);
            this.txtHE.Name = "txtHE";
            this.txtHE.Size = new System.Drawing.Size(219, 20);
            this.txtHE.TabIndex = 12;
            // 
            // btnRegistro
            // 
            this.btnRegistro.Location = new System.Drawing.Point(678, 17);
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.Size = new System.Drawing.Size(96, 33);
            this.btnRegistro.TabIndex = 13;
            this.btnRegistro.Text = "Registrar";
            this.btnRegistro.UseVisualStyleBackColor = true;
            this.btnRegistro.Click += new System.EventHandler(this.btnRegistro_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(678, 61);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(96, 36);
            this.btnBuscar.TabIndex = 14;
            this.btnBuscar.Text = "Buscar Empleado";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(678, 105);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(96, 35);
            this.btnSalir.TabIndex = 15;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(476, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Salario Basico";
            // 
            // txtBasico
            // 
            this.txtBasico.Location = new System.Drawing.Point(412, 49);
            this.txtBasico.Name = "txtBasico";
            this.txtBasico.Size = new System.Drawing.Size(223, 20);
            this.txtBasico.TabIndex = 17;
            // 
            // txtINSS
            // 
            this.txtINSS.Location = new System.Drawing.Point(413, 120);
            this.txtINSS.Name = "txtINSS";
            this.txtINSS.Size = new System.Drawing.Size(222, 20);
            this.txtINSS.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(476, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "INNS Laboral";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(678, 155);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(96, 33);
            this.btnEliminar.TabIndex = 20;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEliminarTodo
            // 
            this.btnEliminarTodo.Location = new System.Drawing.Point(678, 198);
            this.btnEliminarTodo.Name = "btnEliminarTodo";
            this.btnEliminarTodo.Size = new System.Drawing.Size(96, 33);
            this.btnEliminarTodo.TabIndex = 21;
            this.btnEliminarTodo.Text = "Eliminar Todo";
            this.btnEliminarTodo.UseVisualStyleBackColor = true;
            this.btnEliminarTodo.Click += new System.EventHandler(this.btnEliminarTodo_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 162);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Dias Trabajados";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Empleo";
            // 
            // txtEmpleo
            // 
            this.txtEmpleo.Location = new System.Drawing.Point(135, 91);
            this.txtEmpleo.Name = "txtEmpleo";
            this.txtEmpleo.Size = new System.Drawing.Size(219, 20);
            this.txtEmpleo.TabIndex = 24;
            // 
            // Cedulatxt
            // 
            this.Cedulatxt.HeaderText = "Identificacion";
            this.Cedulatxt.Name = "Cedulatxt";
            // 
            // Name
            // 
            this.Name.HeaderText = "Nombre";
            this.Name.Name = "Name";
            // 
            // Cargo
            // 
            this.Cargo.HeaderText = "Empleo";
            this.Cargo.Name = "Cargo";
            // 
            // Sueldo
            // 
            this.Sueldo.HeaderText = "Sueldo Mensual";
            this.Sueldo.Name = "Sueldo";
            // 
            // Dias
            // 
            this.Dias.HeaderText = "Dias Trabajados";
            this.Dias.Name = "Dias";
            // 
            // Horas
            // 
            this.Horas.HeaderText = "Horas Extras";
            this.Horas.Name = "Horas";
            // 
            // Basico
            // 
            this.Basico.HeaderText = "Salario Basico";
            this.Basico.Name = "Basico";
            // 
            // Devengado
            // 
            this.Devengado.HeaderText = "INSS Laboral";
            this.Devengado.Name = "Devengado";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(678, 254);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 38);
            this.button1.TabIndex = 25;
            this.button1.Text = "Total Salario";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtToT
            // 
            this.txtToT.Location = new System.Drawing.Point(412, 162);
            this.txtToT.Name = "txtToT";
            this.txtToT.Size = new System.Drawing.Size(223, 20);
            this.txtToT.TabIndex = 26;
            // 
            // txtToty
            // 
            this.txtToty.Location = new System.Drawing.Point(412, 195);
            this.txtToty.Name = "txtToty";
            this.txtToty.Size = new System.Drawing.Size(223, 20);
            this.txtToty.TabIndex = 27;
            // 
            // Nomina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 417);
            this.Controls.Add(this.txtToty);
            this.Controls.Add(this.txtToT);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtEmpleo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnEliminarTodo);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtINSS);
            this.Controls.Add(this.txtBasico);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnRegistro);
            this.Controls.Add(this.txtHE);
            this.Controls.Add(this.txtDT);
            this.Controls.Add(this.txtSM);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Nominadgtv);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Text = "Nomina";
            this.Text = "Nomina";
            this.Load += new System.EventHandler(this.Nomina_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Nominadgtv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView Nominadgtv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtSM;
        private System.Windows.Forms.TextBox txtDT;
        private System.Windows.Forms.TextBox txtHE;
        private System.Windows.Forms.Button btnRegistro;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBasico;
        private System.Windows.Forms.TextBox txtINSS;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEliminarTodo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmpleo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cedulatxt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sueldo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dias;
        private System.Windows.Forms.DataGridViewTextBoxColumn Horas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Basico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Devengado;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtToT;
        private System.Windows.Forms.TextBox txtToty;
    }
}