using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea2_UAPA
{
    public partial class CalcularNomina : Form
    {
        public CalcularNomina()
        {
            InitializeComponent();
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(textBoxSalary.ToString()))
                {
                    double salary = double.Parse(textBoxSalary.Text);
                    double SFS = double.Parse(textBoxSalary.Text) * 0.0304;
                    double AFP = double.Parse(textBoxSalary.Text) * 0.0287;
                    double salaryNoTSS = salary - SFS - AFP;
                    double ISR = 0;
                    labelSFS.Text = $"SFS: {Math.Round(SFS, 2)}";
                    labelAFP.Text = $"AFP: {Math.Round(AFP, 2)}";
                    if (salaryNoTSS * 12 <= 416220)
                    {
                        ISR = 0;
                    }
                    else if (salaryNoTSS * 12 > 416220 && salaryNoTSS * 12 <= 624329)
                    {
                        ISR = ( ( salaryNoTSS * 12 - 416220.01) * 0.15) / 12;
                    }
                    else if (salaryNoTSS * 12 > 624329 && salaryNoTSS * 12 <= 867123)
                    {
                        ISR = ( 31216 + (salaryNoTSS * 12 - 624329.01) * 0.2 ) / 12;

                    }
                    else if (salaryNoTSS * 12 > 867123)
                    {
                        ISR = (79776 + (salaryNoTSS * 12 - 867123.01) * 0.25) / 12;
                    }
                    labelISR.Text = $"ISR: {Math.Round(ISR,2)}";
                    labelTotalDeducciones.Text = $"Total deducciones: {Math.Round(SFS + AFP + ISR,2)}";
                    labelSueldoNeto.Text = $"Sueldo neto: {Math.Round(salary - SFS - AFP - ISR,2)}";
                }
                else
                {
                    MessageBox.Show(this, "No insertaste nada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show(this, "Debes agregar datos en formato numero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, $"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}


