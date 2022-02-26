namespace Aircraft_Logistics
{
    partial class Form1
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblIndicaciones = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.nombreTxt = new System.Windows.Forms.TextBox();
            this.lblDestino = new System.Windows.Forms.Label();
            this.cmbDestinos = new System.Windows.Forms.ComboBox();
            this.lblHorarios = new System.Windows.Forms.Label();
            this.cmbHorarios = new System.Windows.Forms.ComboBox();
            this.btnCoprar = new System.Windows.Forms.Button();
            this.lblApellido = new System.Windows.Forms.Label();
            this.apellidoTxt = new System.Windows.Forms.TextBox();
            this.gbBoleto = new System.Windows.Forms.GroupBox();
            this.errorProvaider = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblClase = new System.Windows.Forms.Label();
            this.rbtnClaseP = new System.Windows.Forms.RadioButton();
            this.rbtnClaseE = new System.Windows.Forms.RadioButton();
            this.btnSalir = new System.Windows.Forms.Button();
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvaider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Perpetua Titling MT", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(240, 19);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(206, 42);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Aircraft Logistics";
            // 
            // lblIndicaciones
            // 
            this.lblIndicaciones.AutoSize = true;
            this.lblIndicaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblIndicaciones.Location = new System.Drawing.Point(52, 93);
            this.lblIndicaciones.Name = "lblIndicaciones";
            this.lblIndicaciones.Size = new System.Drawing.Size(537, 17);
            this.lblIndicaciones.TabIndex = 1;
            this.lblIndicaciones.Text = "Para comprar un boleto de avión rellene el formulario y presione el botón \"Compra" +
    "r\"";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(52, 140);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(59, 16);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre:";
            // 
            // nombreTxt
            // 
            this.nombreTxt.Location = new System.Drawing.Point(229, 134);
            this.nombreTxt.Name = "nombreTxt";
            this.nombreTxt.Size = new System.Drawing.Size(205, 22);
            this.nombreTxt.TabIndex = 3;
            this.nombreTxt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblDestino
            // 
            this.lblDestino.AutoSize = true;
            this.lblDestino.Location = new System.Drawing.Point(52, 214);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(152, 16);
            this.lblDestino.TabIndex = 4;
            this.lblDestino.Text = "Ciudad-País de Destino:";
            // 
            // cmbDestinos
            // 
            this.cmbDestinos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDestinos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbDestinos.FormattingEnabled = true;
            this.cmbDestinos.Location = new System.Drawing.Point(229, 211);
            this.cmbDestinos.Name = "cmbDestinos";
            this.cmbDestinos.Size = new System.Drawing.Size(205, 24);
            this.cmbDestinos.TabIndex = 5;
            // 
            // lblHorarios
            // 
            this.lblHorarios.AutoSize = true;
            this.lblHorarios.Location = new System.Drawing.Point(52, 254);
            this.lblHorarios.Name = "lblHorarios";
            this.lblHorarios.Size = new System.Drawing.Size(137, 16);
            this.lblHorarios.TabIndex = 8;
            this.lblHorarios.Text = "Horarios Disponibles:";
            // 
            // cmbHorarios
            // 
            this.cmbHorarios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHorarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbHorarios.FormattingEnabled = true;
            this.cmbHorarios.Location = new System.Drawing.Point(229, 254);
            this.cmbHorarios.Name = "cmbHorarios";
            this.cmbHorarios.Size = new System.Drawing.Size(205, 24);
            this.cmbHorarios.TabIndex = 9;
            // 
            // btnCoprar
            // 
            this.btnCoprar.Location = new System.Drawing.Point(177, 363);
            this.btnCoprar.Name = "btnCoprar";
            this.btnCoprar.Size = new System.Drawing.Size(104, 27);
            this.btnCoprar.TabIndex = 10;
            this.btnCoprar.Text = "Comprar";
            this.btnCoprar.UseVisualStyleBackColor = true;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(52, 178);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(60, 16);
            this.lblApellido.TabIndex = 12;
            this.lblApellido.Text = "Apellido:";
            // 
            // apellidoTxt
            // 
            this.apellidoTxt.Location = new System.Drawing.Point(229, 172);
            this.apellidoTxt.Name = "apellidoTxt";
            this.apellidoTxt.Size = new System.Drawing.Size(205, 22);
            this.apellidoTxt.TabIndex = 13;
            this.apellidoTxt.TextChanged += new System.EventHandler(this.apellidoTxt_TextChanged);
            // 
            // gbBoleto
            // 
            this.gbBoleto.Location = new System.Drawing.Point(177, 425);
            this.gbBoleto.Name = "gbBoleto";
            this.gbBoleto.Size = new System.Drawing.Size(308, 219);
            this.gbBoleto.TabIndex = 14;
            this.gbBoleto.TabStop = false;
            // 
            // errorProvaider
            // 
            this.errorProvaider.ContainerControl = this;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(378, 363);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(104, 27);
            this.btnCancelar.TabIndex = 17;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblClase
            // 
            this.lblClase.AutoSize = true;
            this.lblClase.Location = new System.Drawing.Point(52, 295);
            this.lblClase.Name = "lblClase";
            this.lblClase.Size = new System.Drawing.Size(45, 16);
            this.lblClase.TabIndex = 18;
            this.lblClase.Text = "Clase:";
            // 
            // rbtnClaseP
            // 
            this.rbtnClaseP.AutoSize = true;
            this.rbtnClaseP.Location = new System.Drawing.Point(229, 295);
            this.rbtnClaseP.Name = "rbtnClaseP";
            this.rbtnClaseP.Size = new System.Drawing.Size(111, 20);
            this.rbtnClaseP.TabIndex = 19;
            this.rbtnClaseP.TabStop = true;
            this.rbtnClaseP.Text = "Primera clase";
            this.rbtnClaseP.UseVisualStyleBackColor = true;
            // 
            // rbtnClaseE
            // 
            this.rbtnClaseE.AutoSize = true;
            this.rbtnClaseE.Location = new System.Drawing.Point(378, 295);
            this.rbtnClaseE.Name = "rbtnClaseE";
            this.rbtnClaseE.Size = new System.Drawing.Size(133, 20);
            this.rbtnClaseE.TabIndex = 20;
            this.rbtnClaseE.TabStop = true;
            this.rbtnClaseE.Text = "Clase económica";
            this.rbtnClaseE.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(529, 654);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 21;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(659, 701);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.rbtnClaseE);
            this.Controls.Add(this.rbtnClaseP);
            this.Controls.Add(this.lblClase);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.gbBoleto);
            this.Controls.Add(this.apellidoTxt);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.btnCoprar);
            this.Controls.Add(this.cmbHorarios);
            this.Controls.Add(this.lblHorarios);
            this.Controls.Add(this.cmbDestinos);
            this.Controls.Add(this.lblDestino);
            this.Controls.Add(this.nombreTxt);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblIndicaciones);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Aircraft Logistics";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvaider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblIndicaciones;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox nombreTxt;
        private System.Windows.Forms.Label lblDestino;
        private System.Windows.Forms.ComboBox cmbDestinos;
        private System.Windows.Forms.Label lblHorarios;
        private System.Windows.Forms.ComboBox cmbHorarios;
        private System.Windows.Forms.Button btnCoprar;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox apellidoTxt;
        private System.Windows.Forms.GroupBox gbBoleto;
        private System.Windows.Forms.ErrorProvider errorProvaider;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.RadioButton rbtnClaseP;
        private System.Windows.Forms.Label lblClase;
        private System.Windows.Forms.RadioButton rbtnClaseE;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}

