using EjercicioPrestamo.Entidades;
using EjercicioPrestamo.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioPrestamo.GUI
{
    public partial class FormPrestamos : Form
    {
        PrestamoNegocio _prestamoNegocio;
        public FormPrestamos()
        {
            this._prestamoNegocio = new PrestamoNegocio();
            InitializeComponent();
        }

        private void FormPrestamos_Load(object sender, EventArgs e)
        {
            CargarTiposPrestamos();
            CargarPrestamos();
        }

        private void CargarPrestamos()
        {
            try
            {
                Operador operador = this._prestamoNegocio.Traer();

                lstPrestamos.DataSource = null;
                lstPrestamos.DataSource = operador.Prestamos;

                txtComisionTotal.Text = operador.Comision.ToString("0.00");
            }
            catch (Exception exe)
            {
                MessageBox.Show(exe.Message);
            }
        }

        private void CargarTiposPrestamos()
        {
            try
            {
                lstTipoPrestamos.DataSource = null;
                lstTipoPrestamos.DataSource = this._prestamoNegocio.TraerTiposPrestamo();
                LimpiarCampos();
            }
            catch (Exception exe)
            {
                MessageBox.Show(exe.Message);
            }
        }

        private void LimpiarCampos()
        {
            txtCuotaTotal.Text = string.Empty;
            txtCuotaCapital.Text = string.Empty;
            txtCuotaInteres.Text = string.Empty;
            txtLinea.Text = string.Empty;
            txtMonto.Text = string.Empty;
            txtPLazo.Text = string.Empty;
            txtTNA.Text = string.Empty;
        }

        private void btnSimular_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstTipoPrestamos.SelectedItem == null)
                    throw new Exception("Debe seleccionar tipo de préstamo");

                Validar();

                TipoPrestamo tipoSeleccionado = (TipoPrestamo)lstTipoPrestamos.SelectedItem;
                Prestamo simulacion = new Prestamo();
                simulacion.TNA = tipoSeleccionado.TNA;
                simulacion.Plazo = int.Parse(txtPLazo.Text);
                simulacion.Monto = double.Parse(txtMonto.Text);

                txtCuotaCapital.Text = simulacion.CuotaCapital.ToString("0.00");
                txtCuotaInteres.Text = simulacion.CuotaInteres.ToString("0.00");
                txtCuotaTotal.Text = simulacion.Cuota.ToString("0.00");

            }
            catch (Exception exe)
            {
                MessageBox.Show(exe.Message);
            }
        }

        private void Validar()
        {
            if(!int.TryParse(txtPLazo.Text, out int plazo))
                throw new Exception("Plazo: Debe ingresar un número");

            if (!double.TryParse(txtMonto.Text, out double monto))
                throw new Exception("Monto: Debe ingresar un número");
        }

        private void lstTipoPrestamos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstTipoPrestamos.DataSource != null)
            {
                TipoPrestamo tipoSeleccionado = (TipoPrestamo)lstTipoPrestamos.SelectedItem;
                txtLinea.Text = tipoSeleccionado.Linea;
                txtTNA.Text = tipoSeleccionado.TNA.ToString("0.00");
                LimpiarCampos();
            }
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstTipoPrestamos.SelectedItem == null)
                    throw new Exception("Debe seleccionar tipo de préstamo");

                Validar();

                TipoPrestamo tipoSeleccionado = (TipoPrestamo)lstTipoPrestamos.SelectedItem;
                Prestamo prestamo = new Prestamo();

                prestamo.Linea = tipoSeleccionado.Linea;
                prestamo.Plazo = int.Parse(txtPLazo.Text);
                prestamo.Monto = double.Parse(txtMonto.Text);
                ResultadoTransaccion resultado = this._prestamoNegocio.Agregar(prestamo);

                MessageBox.Show(resultado.ToString());
                CargarPrestamos();
                LimpiarCampos();

            }
            catch (Exception exe)
            {
                MessageBox.Show(exe.Message);
            }

        }
    }
}
