namespace pryPracticaPromocional
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
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblDNI = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.gpbDatosPersonales = new System.Windows.Forms.GroupBox();
            this.lblTituloDatosp = new System.Windows.Forms.Label();
            this.lblTipoServicio = new System.Windows.Forms.Label();
            this.rdbDomicilio = new System.Windows.Forms.RadioButton();
            this.rdbVehiculo = new System.Windows.Forms.RadioButton();
            this.gpbTipoServicio = new System.Windows.Forms.GroupBox();
            this.lblDatosVehiculo = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblPatente = new System.Windows.Forms.Label();
            this.lblFechaVehiculo = new System.Windows.Forms.Label();
            this.cmbMarca = new System.Windows.Forms.ComboBox();
            this.txtPatente = new System.Windows.Forms.TextBox();
            this.dtpFechaVehiculo = new System.Windows.Forms.DateTimePicker();
            this.gpbVehiculo = new System.Windows.Forms.GroupBox();
            this.lblDatosDomicilio = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblTipoVivienda = new System.Windows.Forms.Label();
            this.lblFechaDomicilio = new System.Windows.Forms.Label();
            this.dtpFechaDomicilio = new System.Windows.Forms.DateTimePicker();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.cmbTipoVivienda = new System.Windows.Forms.ComboBox();
            this.gpbDatosDomicilio = new System.Windows.Forms.GroupBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.lstUsuariosRegistrados = new System.Windows.Forms.ListBox();
            this.lblUsuariosRegistrados = new System.Windows.Forms.Label();
            this.gpbUsuariosRegistrados = new System.Windows.Forms.GroupBox();
            this.gpbDatosPersonales.SuspendLayout();
            this.gpbTipoServicio.SuspendLayout();
            this.gpbVehiculo.SuspendLayout();
            this.gpbDatosDomicilio.SuspendLayout();
            this.gpbUsuariosRegistrados.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(11, 69);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(60, 16);
            this.lblApellido.TabIndex = 0;
            this.lblApellido.Text = "Apellido:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(11, 43);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(59, 16);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(12, 25);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(345, 18);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Servicio de Alarmas - Vehículos y Domicilios";
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Location = new System.Drawing.Point(11, 98);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(33, 16);
            this.lblDNI.TabIndex = 3;
            this.lblDNI.Text = "DNI:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(86, 43);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 22);
            this.txtNombre.TabIndex = 4;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(86, 69);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 22);
            this.txtApellido.TabIndex = 5;
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(86, 98);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(100, 22);
            this.txtDNI.TabIndex = 6;
            // 
            // gpbDatosPersonales
            // 
            this.gpbDatosPersonales.Controls.Add(this.lblTituloDatosp);
            this.gpbDatosPersonales.Controls.Add(this.txtDNI);
            this.gpbDatosPersonales.Controls.Add(this.txtApellido);
            this.gpbDatosPersonales.Controls.Add(this.txtNombre);
            this.gpbDatosPersonales.Controls.Add(this.lblDNI);
            this.gpbDatosPersonales.Controls.Add(this.lblNombre);
            this.gpbDatosPersonales.Controls.Add(this.lblApellido);
            this.gpbDatosPersonales.Location = new System.Drawing.Point(20, 69);
            this.gpbDatosPersonales.Name = "gpbDatosPersonales";
            this.gpbDatosPersonales.Size = new System.Drawing.Size(212, 135);
            this.gpbDatosPersonales.TabIndex = 7;
            this.gpbDatosPersonales.TabStop = false;
            // 
            // lblTituloDatosp
            // 
            this.lblTituloDatosp.AutoSize = true;
            this.lblTituloDatosp.Location = new System.Drawing.Point(11, 18);
            this.lblTituloDatosp.Name = "lblTituloDatosp";
            this.lblTituloDatosp.Size = new System.Drawing.Size(118, 16);
            this.lblTituloDatosp.TabIndex = 7;
            this.lblTituloDatosp.Text = "Datos Personales:";
            // 
            // lblTipoServicio
            // 
            this.lblTipoServicio.AutoSize = true;
            this.lblTipoServicio.Location = new System.Drawing.Point(10, 18);
            this.lblTipoServicio.Name = "lblTipoServicio";
            this.lblTipoServicio.Size = new System.Drawing.Size(173, 16);
            this.lblTipoServicio.TabIndex = 8;
            this.lblTipoServicio.Text = "Tipo de servicio a contratar:";
            // 
            // rdbDomicilio
            // 
            this.rdbDomicilio.AutoSize = true;
            this.rdbDomicilio.Location = new System.Drawing.Point(13, 44);
            this.rdbDomicilio.Name = "rdbDomicilio";
            this.rdbDomicilio.Size = new System.Drawing.Size(99, 20);
            this.rdbDomicilio.TabIndex = 9;
            this.rdbDomicilio.TabStop = true;
            this.rdbDomicilio.Text = "Domiciliario";
            this.rdbDomicilio.UseVisualStyleBackColor = true;
            this.rdbDomicilio.CheckedChanged += new System.EventHandler(this.rdbDomicilio_CheckedChanged);
            // 
            // rdbVehiculo
            // 
            this.rdbVehiculo.AutoSize = true;
            this.rdbVehiculo.Location = new System.Drawing.Point(118, 44);
            this.rdbVehiculo.Name = "rdbVehiculo";
            this.rdbVehiculo.Size = new System.Drawing.Size(84, 20);
            this.rdbVehiculo.TabIndex = 10;
            this.rdbVehiculo.TabStop = true;
            this.rdbVehiculo.Text = "Vehicular";
            this.rdbVehiculo.UseVisualStyleBackColor = true;
            this.rdbVehiculo.CheckedChanged += new System.EventHandler(this.rdbVehiculo_CheckedChanged);
            // 
            // gpbTipoServicio
            // 
            this.gpbTipoServicio.Controls.Add(this.rdbVehiculo);
            this.gpbTipoServicio.Controls.Add(this.lblTipoServicio);
            this.gpbTipoServicio.Controls.Add(this.rdbDomicilio);
            this.gpbTipoServicio.Location = new System.Drawing.Point(21, 224);
            this.gpbTipoServicio.Name = "gpbTipoServicio";
            this.gpbTipoServicio.Size = new System.Drawing.Size(211, 82);
            this.gpbTipoServicio.TabIndex = 11;
            this.gpbTipoServicio.TabStop = false;
            // 
            // lblDatosVehiculo
            // 
            this.lblDatosVehiculo.AutoSize = true;
            this.lblDatosVehiculo.Location = new System.Drawing.Point(19, 15);
            this.lblDatosVehiculo.Name = "lblDatosVehiculo";
            this.lblDatosVehiculo.Size = new System.Drawing.Size(101, 16);
            this.lblDatosVehiculo.TabIndex = 8;
            this.lblDatosVehiculo.Text = "Datos Vehiculo:";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(19, 39);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(123, 16);
            this.lblMarca.TabIndex = 12;
            this.lblMarca.Text = "Marca del vehículo:";
            // 
            // lblPatente
            // 
            this.lblPatente.AutoSize = true;
            this.lblPatente.Location = new System.Drawing.Point(19, 66);
            this.lblPatente.Name = "lblPatente";
            this.lblPatente.Size = new System.Drawing.Size(56, 16);
            this.lblPatente.TabIndex = 13;
            this.lblPatente.Text = "Patente:";
            this.lblPatente.Click += new System.EventHandler(this.lblPatente_Click);
            // 
            // lblFechaVehiculo
            // 
            this.lblFechaVehiculo.AutoSize = true;
            this.lblFechaVehiculo.Location = new System.Drawing.Point(19, 94);
            this.lblFechaVehiculo.Name = "lblFechaVehiculo";
            this.lblFechaVehiculo.Size = new System.Drawing.Size(134, 16);
            this.lblFechaVehiculo.TabIndex = 14;
            this.lblFechaVehiculo.Text = "Fecha de instalación:";
            // 
            // cmbMarca
            // 
            this.cmbMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMarca.FormattingEnabled = true;
            this.cmbMarca.Location = new System.Drawing.Point(164, 36);
            this.cmbMarca.Name = "cmbMarca";
            this.cmbMarca.Size = new System.Drawing.Size(100, 24);
            this.cmbMarca.TabIndex = 15;
            // 
            // txtPatente
            // 
            this.txtPatente.Location = new System.Drawing.Point(164, 66);
            this.txtPatente.MaxLength = 7;
            this.txtPatente.Name = "txtPatente";
            this.txtPatente.Size = new System.Drawing.Size(100, 22);
            this.txtPatente.TabIndex = 8;
            // 
            // dtpFechaVehiculo
            // 
            this.dtpFechaVehiculo.Location = new System.Drawing.Point(164, 94);
            this.dtpFechaVehiculo.Name = "dtpFechaVehiculo";
            this.dtpFechaVehiculo.Size = new System.Drawing.Size(100, 22);
            this.dtpFechaVehiculo.TabIndex = 16;
            // 
            // gpbVehiculo
            // 
            this.gpbVehiculo.Controls.Add(this.dtpFechaVehiculo);
            this.gpbVehiculo.Controls.Add(this.lblDatosVehiculo);
            this.gpbVehiculo.Controls.Add(this.txtPatente);
            this.gpbVehiculo.Controls.Add(this.cmbMarca);
            this.gpbVehiculo.Controls.Add(this.lblFechaVehiculo);
            this.gpbVehiculo.Controls.Add(this.lblPatente);
            this.gpbVehiculo.Controls.Add(this.lblMarca);
            this.gpbVehiculo.Location = new System.Drawing.Point(12, 331);
            this.gpbVehiculo.Name = "gpbVehiculo";
            this.gpbVehiculo.Size = new System.Drawing.Size(284, 134);
            this.gpbVehiculo.TabIndex = 17;
            this.gpbVehiculo.TabStop = false;
            // 
            // lblDatosDomicilio
            // 
            this.lblDatosDomicilio.AutoSize = true;
            this.lblDatosDomicilio.Location = new System.Drawing.Point(10, 18);
            this.lblDatosDomicilio.Name = "lblDatosDomicilio";
            this.lblDatosDomicilio.Size = new System.Drawing.Size(105, 16);
            this.lblDatosDomicilio.TabIndex = 17;
            this.lblDatosDomicilio.Text = "Datos Domicilio:";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(4, 44);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(67, 16);
            this.lblDireccion.TabIndex = 17;
            this.lblDireccion.Text = "Dirección:";
            // 
            // lblTipoVivienda
            // 
            this.lblTipoVivienda.AutoSize = true;
            this.lblTipoVivienda.Location = new System.Drawing.Point(4, 70);
            this.lblTipoVivienda.Name = "lblTipoVivienda";
            this.lblTipoVivienda.Size = new System.Drawing.Size(111, 16);
            this.lblTipoVivienda.TabIndex = 18;
            this.lblTipoVivienda.Text = "Tipo de vivienda:";
            // 
            // lblFechaDomicilio
            // 
            this.lblFechaDomicilio.AutoSize = true;
            this.lblFechaDomicilio.Location = new System.Drawing.Point(4, 101);
            this.lblFechaDomicilio.Name = "lblFechaDomicilio";
            this.lblFechaDomicilio.Size = new System.Drawing.Size(134, 16);
            this.lblFechaDomicilio.TabIndex = 17;
            this.lblFechaDomicilio.Text = "Fecha de instalación:";
            // 
            // dtpFechaDomicilio
            // 
            this.dtpFechaDomicilio.Location = new System.Drawing.Point(149, 101);
            this.dtpFechaDomicilio.Name = "dtpFechaDomicilio";
            this.dtpFechaDomicilio.Size = new System.Drawing.Size(100, 22);
            this.dtpFechaDomicilio.TabIndex = 17;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(149, 38);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(100, 22);
            this.txtDireccion.TabIndex = 19;
            // 
            // cmbTipoVivienda
            // 
            this.cmbTipoVivienda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoVivienda.FormattingEnabled = true;
            this.cmbTipoVivienda.Location = new System.Drawing.Point(149, 71);
            this.cmbTipoVivienda.Name = "cmbTipoVivienda";
            this.cmbTipoVivienda.Size = new System.Drawing.Size(100, 24);
            this.cmbTipoVivienda.TabIndex = 17;
            this.cmbTipoVivienda.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // gpbDatosDomicilio
            // 
            this.gpbDatosDomicilio.Controls.Add(this.cmbTipoVivienda);
            this.gpbDatosDomicilio.Controls.Add(this.lblDatosDomicilio);
            this.gpbDatosDomicilio.Controls.Add(this.txtDireccion);
            this.gpbDatosDomicilio.Controls.Add(this.dtpFechaDomicilio);
            this.gpbDatosDomicilio.Controls.Add(this.lblFechaDomicilio);
            this.gpbDatosDomicilio.Controls.Add(this.lblTipoVivienda);
            this.gpbDatosDomicilio.Controls.Add(this.lblDireccion);
            this.gpbDatosDomicilio.Location = new System.Drawing.Point(20, 492);
            this.gpbDatosDomicilio.Name = "gpbDatosDomicilio";
            this.gpbDatosDomicilio.Size = new System.Drawing.Size(275, 148);
            this.gpbDatosDomicilio.TabIndex = 20;
            this.gpbDatosDomicilio.TabStop = false;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(152, 655);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(124, 52);
            this.btnLimpiar.TabIndex = 21;
            this.btnLimpiar.Text = "LIMPIAR";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(20, 655);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(124, 52);
            this.btnRegistrar.TabIndex = 22;
            this.btnRegistrar.Text = "REGISTRAR";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // lstUsuariosRegistrados
            // 
            this.lstUsuariosRegistrados.FormattingEnabled = true;
            this.lstUsuariosRegistrados.ItemHeight = 16;
            this.lstUsuariosRegistrados.Location = new System.Drawing.Point(6, 31);
            this.lstUsuariosRegistrados.Name = "lstUsuariosRegistrados";
            this.lstUsuariosRegistrados.Size = new System.Drawing.Size(318, 100);
            this.lstUsuariosRegistrados.TabIndex = 23;
            // 
            // lblUsuariosRegistrados
            // 
            this.lblUsuariosRegistrados.AutoSize = true;
            this.lblUsuariosRegistrados.Location = new System.Drawing.Point(15, 12);
            this.lblUsuariosRegistrados.Name = "lblUsuariosRegistrados";
            this.lblUsuariosRegistrados.Size = new System.Drawing.Size(135, 16);
            this.lblUsuariosRegistrados.TabIndex = 17;
            this.lblUsuariosRegistrados.Text = "Usuarios registrados:";
            // 
            // gpbUsuariosRegistrados
            // 
            this.gpbUsuariosRegistrados.Controls.Add(this.lstUsuariosRegistrados);
            this.gpbUsuariosRegistrados.Controls.Add(this.lblUsuariosRegistrados);
            this.gpbUsuariosRegistrados.Location = new System.Drawing.Point(291, 73);
            this.gpbUsuariosRegistrados.Name = "gpbUsuariosRegistrados";
            this.gpbUsuariosRegistrados.Size = new System.Drawing.Size(330, 149);
            this.gpbUsuariosRegistrados.TabIndex = 24;
            this.gpbUsuariosRegistrados.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 735);
            this.Controls.Add(this.gpbUsuariosRegistrados);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.gpbDatosDomicilio);
            this.Controls.Add(this.gpbVehiculo);
            this.Controls.Add(this.gpbTipoServicio);
            this.Controls.Add(this.gpbDatosPersonales);
            this.Controls.Add(this.lblTitulo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Alarmas - Domicilio y Vehículos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gpbDatosPersonales.ResumeLayout(false);
            this.gpbDatosPersonales.PerformLayout();
            this.gpbTipoServicio.ResumeLayout(false);
            this.gpbTipoServicio.PerformLayout();
            this.gpbVehiculo.ResumeLayout(false);
            this.gpbVehiculo.PerformLayout();
            this.gpbDatosDomicilio.ResumeLayout(false);
            this.gpbDatosDomicilio.PerformLayout();
            this.gpbUsuariosRegistrados.ResumeLayout(false);
            this.gpbUsuariosRegistrados.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.GroupBox gpbDatosPersonales;
        private System.Windows.Forms.Label lblTituloDatosp;
        private System.Windows.Forms.Label lblTipoServicio;
        private System.Windows.Forms.RadioButton rdbDomicilio;
        private System.Windows.Forms.RadioButton rdbVehiculo;
        private System.Windows.Forms.GroupBox gpbTipoServicio;
        private System.Windows.Forms.Label lblDatosVehiculo;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblPatente;
        private System.Windows.Forms.Label lblFechaVehiculo;
        private System.Windows.Forms.ComboBox cmbMarca;
        private System.Windows.Forms.TextBox txtPatente;
        private System.Windows.Forms.DateTimePicker dtpFechaVehiculo;
        private System.Windows.Forms.GroupBox gpbVehiculo;
        private System.Windows.Forms.Label lblDatosDomicilio;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblTipoVivienda;
        private System.Windows.Forms.Label lblFechaDomicilio;
        private System.Windows.Forms.DateTimePicker dtpFechaDomicilio;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.ComboBox cmbTipoVivienda;
        private System.Windows.Forms.GroupBox gpbDatosDomicilio;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.ListBox lstUsuariosRegistrados;
        private System.Windows.Forms.Label lblUsuariosRegistrados;
        private System.Windows.Forms.GroupBox gpbUsuariosRegistrados;
    }
}

