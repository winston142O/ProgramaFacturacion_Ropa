using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramaFacturacion
{
    public partial class Form1 : Form
    {
        // teclas
        private char enter = Convert.ToChar(13);
        private char backspace = Convert.ToChar(8);
        private char punto = Convert.ToChar(46);
        private char tabv = Convert.ToChar(9);
        private char tabh = Convert.ToChar(11);
        private char letra_e = Convert.ToChar(101);
        private char letra_E = Convert.ToChar(69);
        char[] numeros = new char[] {
            (char)48, // 0
            (char)49, // 1
            (char)50, // 2
            (char)51, // 3
            (char)52, // 4
            (char)53, // 5
            (char)54, // 6
            (char)55, // 7
            (char)56, // 8
            (char)57 // 9
        };        
        // totales
        private double totalOrden = 0.00;
        private double PrecioNeto = 0.00;        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // asignar totales predeterminados
            txtSubtotalCamisa.Text = String.Format("${0:F2}", "0.00");
            txtSubtotalPantalon.Text = String.Format("${0:F2}", "0.00");
            txtSubtotalVestido.Text = String.Format("${0:F2}", "0.00");
            txtTasaImpuestos.Text = String.Format("${0:F2}", "18.00");
            txtTotalOrden.Text = String.Format("${0:F2}", "0.00");
            txtMontoImpuestos.Text = String.Format("${0:F2}", "0.00");
            txtPrecioNeto.Text = String.Format("${0:F2}", "0.00");            
        }

        private double CalcularSubtotal(double cantItem, double precioUnit)
        {
            double subtotal = cantItem * precioUnit;
            return subtotal;
        }

        private void AddTotal(TextBox subtotalArticulo, TextBox destino)
        {
            string valorTexto = subtotalArticulo.Text;
            valorTexto = valorTexto.Replace("$", "");
            double subtotal = Convert.ToDouble(valorTexto);
            totalOrden += subtotal;
            destino.Text = String.Format("${0:F2}", totalOrden);
        }

        private void txtPrecioCamisa_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox objTextBox = (TextBox)sender;

            // si se presiona enter
            if (e.KeyChar == enter || e.KeyChar == tabv || e.KeyChar == tabh)
            {
                e.Handled = false;
                if (objTextBox == txtPrecioCamisa)
                {
                    DialogResult resp = MessageBox.Show(String.Format("¿Deseas agregar el monto {0:F2} al total de esta orden?", txtSubtotalCamisa.Text), "Confirmar", MessageBoxButtons.YesNo);
                    if (resp == DialogResult.Yes)
                    {
                        AddTotal(txtSubtotalCamisa, txtTotalOrden);
                    }
                    else if (resp == DialogResult.No)
                    {
                        // nada
                    }
                }
                else if (objTextBox == txtPrecioPantalon)
                {
                    DialogResult resp = MessageBox.Show(String.Format("¿Deseas agregar el monto {0:F2} al total de esta orden?", txtSubtotalPantalon.Text), "Confirmar", MessageBoxButtons.YesNo);
                    if (resp == DialogResult.Yes)
                    {
                        AddTotal(txtSubtotalPantalon, txtTotalOrden);
                    }
                    else if (resp == DialogResult.No)
                    {
                        // nada
                    }
                }
                else if (objTextBox == txtPrecioVestido)
                {
                    DialogResult resp = MessageBox.Show(String.Format("¿Deseas agregar el monto {0:F2} al total de esta orden?", txtSubtotalVestido.Text), "Confirmar", MessageBoxButtons.YesNo);
                    if (resp == DialogResult.Yes)
                    {
                        AddTotal(txtSubtotalVestido, txtTotalOrden);
                    }
                    else if (resp == DialogResult.No)
                    {
                        // nada
                    }
                }                
            }
            // si se presiona una de: numeros, punto, tabulador, backspace.
            else if (numeros.Contains(e.KeyChar) || e.KeyChar == punto || e.KeyChar == tabv || e.KeyChar == tabh || e.KeyChar == backspace)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

        }                

        private void txtTotalOrden_TextChanged(object sender, EventArgs e)
        {
            double taxRate = 0.18;
            string total = txtTotalOrden.Text;
            total = total.Replace("$", "");
            double tax = taxRate * Convert.ToDouble(total);
            txtMontoImpuestos.Text = String.Format("${0:F2}", tax);
            PrecioNeto = tax + Convert.ToDouble(total);
            txtPrecioNeto.Text = String.Format("${0:F2}", PrecioNeto);
        }

        private void txtPrecioCamisa_TextChanged(object sender, EventArgs e)
        {
            TextBox objTextBox = (TextBox)sender;

            if (objTextBox == txtPrecioCamisa)
            {
                try
                {
                    double precioCamisa = Convert.ToDouble(txtPrecioCamisa.Text);
                    double subtotal = CalcularSubtotal(precioCamisa, Convert.ToDouble(CantidadCamisas.Value));
                    txtSubtotalCamisa.Text = String.Format("${0:F2}", subtotal);
                }
                catch (Exception ex)
                {

                }
            }
            else if (objTextBox == txtPrecioPantalon)
            {
                try
                {
                    double precioPantalon = Convert.ToDouble(txtPrecioPantalon.Text);
                    double subtotal = CalcularSubtotal(precioPantalon, Convert.ToDouble(CantidadPantalones.Value));
                    txtSubtotalPantalon.Text = String.Format("${0:F2}", subtotal);
                }
                catch (Exception e2)
                {

                }
            }
            else if (objTextBox == txtPrecioVestido)
            {
                try
                {
                    double precioVestido = Convert.ToDouble(txtPrecioVestido.Text);
                    double subtotal = CalcularSubtotal(precioVestido, Convert.ToDouble(CantidadVestidos.Value));
                    txtSubtotalVestido.Text = String.Format("${0:F2}", subtotal);
                }
                catch (Exception e3)
                {

                }
            }                        
        }        

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string factura = String.Format("Facturar a:\n \nNombre: {0} \nTeléfono: {1} \nDirección: {2} \nFecha: {3} \n \nART. \t\tCANT. \tPRECIO",
                                 txtNombreCliente.Text, txtNumCliente.Text, txtDireccionCliente.Text, dateTimePicker1.Value.ToString());
            if (CantidadCamisas.Value > 0)
            {
                factura += String.Format("\nCamisas: \t\t{0} \t{1}", CantidadCamisas.Value, txtSubtotalCamisa.Text);
            }
            if (CantidadPantalones.Value > 0)
            {
                factura += String.Format("\nPantalones: \t{0} \t{1}", CantidadPantalones.Value, txtSubtotalPantalon.Text);
            }
            if (CantidadVestidos.Value > 0)
            {
                factura += String.Format("\nVestidos: \t{0} \t{1}", CantidadVestidos.Value, txtSubtotalVestido.Text);
            }
            factura += "\n";
            factura += String.Format("\nTOTAL: \t{0} \n%IMP.: \t{1} \nIMP.: \t{2} \nNETO: \t{3}", txtTotalOrden.Text, txtTasaImpuestos.Text, txtMontoImpuestos.Text, txtPrecioNeto.Text);

            MessageBox.Show(factura, "Factura de la Compra");
        }
        
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult resp = MessageBox.Show("¿Desea cerrar la aplicación?", "Confirmar", MessageBoxButtons.YesNo);
            if (resp == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (resp == DialogResult.No)
            {
                // nada
            }
        }
    }
}
