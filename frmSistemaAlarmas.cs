using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryPracticaPromocional
{
    struct Cliente
    {
        public string nombre;
        public string apellido;
        public string DNI;
        public string TipoServicio;
        public DateTime FechaInstalacion;
        public string Patente;
        public string Marca;
        public string Direccion;
        public string TipoVivienda;




    }
    public partial class Form1 : Form
    {
        Cliente[] clientes = new Cliente[20];
        int contador = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            // Agregar Marcas de autos al comboBox
            cmbMarca.Items.Add("Peugeot");
            cmbMarca.Items.Add("Fiat");
            cmbMarca.Items.Add("Renault");
            cmbMarca.Items.Add("Ford");
            cmbMarca.Items.Add("Toyota");
            cmbMarca.Items.Add("Jeep");
            cmbMarca.Items.Add("Chevrolet");
            cmbMarca.Items.Add("Nissan");

            // Agregar tipos de vivienda al comboBox
            cmbTipoVivienda.Items.Add("Casa");
            cmbTipoVivienda.Items.Add("Departamento");
            cmbTipoVivienda.Items.Add("Residencia");
            cmbTipoVivienda.Items.Add("Cabaña");
            cmbTipoVivienda.Items.Add("Local");
        }

        private void lblPatente_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Validar que no se supere el límite de clientes
            if (contador >= clientes.Length)
            {
                MessageBox.Show("Se ha alcanzado el límite de clientes registrados.");
                return;
            }

            // Validar que los campos de texto no estén vacíos

            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Campo de Nombre vacío, intentelo nuevamente.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                MessageBox.Show("Campo de Apellido vacio, intentelo nuevamente.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtDNI.Text))
            {
                MessageBox.Show("Campo de DNI vacio, intentelo nuevamente");
                return;
            }

            clientes[contador].nombre = txtNombre.Text;
            clientes[contador].apellido = txtApellido.Text;
            clientes[contador].DNI = txtDNI.Text;

            // Validar que se haya seleccionado un tipo de servicio
            if (!rdbVehiculo.Checked && !rdbDomicilio.Checked)
            {
                MessageBox.Show("Debe seleccionar un tipo de servicio, intentelo de nuevo.");
                return;
            }

            // Guardar el tipo de servicio seleccionado
            if (rdbVehiculo.Checked)
            {
                clientes[contador].TipoServicio = "Vehículo";
            }
            else
            {
                clientes[contador].TipoServicio = "Domicilio";
            }

            // Fecha de instalación
            if (rdbVehiculo.Checked)
            {
                if (cmbMarca.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe seleccionar una marca, vuelva a intentarlo");
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtPatente.Text))
                {
                    MessageBox.Show("Debe ingresar la patente, intentelo de nuevo");
                    return;
                }

                clientes[contador].FechaInstalacion = dtpFechaVehiculo.Value;
                clientes[contador].Marca = cmbMarca.Text;
                clientes[contador].Patente = txtPatente.Text;
            }
            else
            {
                if (string.IsNullOrWhiteSpace(txtDireccion.Text))
                {
                    MessageBox.Show("Debe ingresar una direccion, intentelo de nuevo");
                    return;
                }
                
                if (cmbTipoVivienda.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe seleccionar un tipo de vivienda, intentelo de nuevo");
                    return;
                }
                clientes[contador].Direccion = txtDireccion.Text;
                clientes[contador].TipoVivienda = cmbTipoVivienda.Text;
                clientes[contador].FechaInstalacion = dtpFechaDomicilio.Value;
                }

            contador++;

            // Se pone -1 porque el contador se incrementa antes de agregar el cliente al ListBox
            // Basicamente, compensa al incremento que se hace en la variable contador antes de agregar el cliente al ListBox

            lstUsuariosRegistrados.Items.Add(
                clientes[contador - 1].nombre + " " +
                clientes[contador - 1].apellido + " " +
                clientes[contador - 1].DNI + " " +
                clientes[contador - 1].TipoServicio + " " +
                clientes[contador - 1].FechaInstalacion.ToShortDateString()
            );

            // Limpiar los campos de texto después de registrar al cliente

            txtNombre.Clear();
            txtApellido.Clear();
            txtDNI.Clear();
            txtPatente.Clear();
            txtDireccion.Clear();

            cmbMarca.SelectedIndex = -1;
            cmbTipoVivienda.SelectedIndex = -1;

            rdbDomicilio.Checked = false;
            rdbVehiculo.Checked = false;

        }

        private void rdbVehiculo_CheckedChanged(object sender, EventArgs e)
        {
            // Deshabilitar el grupo de datos de domicilio cuando se selecciona el servicio vehicular
            gpbDatosDomicilio.Enabled = !rdbVehiculo.Checked;
        }

        private void rdbDomicilio_CheckedChanged(object sender, EventArgs e)
        {
            // Deshabilitar el grupo de datos de vehiculo cuando se selecciona el servicio domiciliario
            gpbVehiculo.Enabled = !rdbDomicilio.Checked;
        }
    }
}
