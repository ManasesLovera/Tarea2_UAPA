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
    public partial class CalcularNota : Form
    {
        public CalcularNota()
        {
            InitializeComponent();
        }
        class claUapa
        {
            static public int calcularNota(string examen,string plataforma, string actitudesYValores, string trabajoFinal)
            {
                try
                {
                    int resultado = 0;
                    if (!String.IsNullOrEmpty(examen) && !String.IsNullOrEmpty(plataforma) && !String.IsNullOrEmpty(actitudesYValores) && !String.IsNullOrEmpty(trabajoFinal) )
                    {
                        int Examen = Convert.ToInt32(examen);
                        int Plataforma = Convert.ToInt32(plataforma);
                        int ActitudesYValores = Convert.ToInt32(actitudesYValores);
                        int TrabajoFinal = Convert.ToInt32(trabajoFinal);
                        resultado = Examen + Plataforma + ActitudesYValores + TrabajoFinal;
                    } else
                    {
                        MessageBox.Show("Uno o varios textBox estan vacios, debes completarlos todos con numeros");
                    }
                    return resultado;
                }
                catch (FormatException fex)
                {
                    MessageBox.Show($"Debes insertar solo numeros: {fex.Message}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return 0;
            }
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int resultado = claUapa.calcularNota(textBoxExamen.Text,textBoxPlataforma.Text,textBoxActitudesYValores.Text,textBoxTrabajoFinal.Text);
            if(resultado > 0 && resultado <= 100)
            {
                labelNota.Text = $"Nota: {resultado}";
                labelResultado.Text = resultado >= 70 ? $"Resultado: Aprobado!" : $"Resultado: Reprobado!";
                if (resultado >= 90)
                    labelLiteral.Text = $"Literal: A";
                else if (resultado >= 80)
                    labelLiteral.Text = $"Literal: B";
                else if (resultado >= 70)
                    labelLiteral.Text = $"Literal: C";
                else if (resultado >= 60)
                    labelLiteral.Text = $"Literal: D";
                else
                    labelLiteral.Text = $"Literal: F";
            } else
            {
                MessageBox.Show(this, "Los valores insertados deben dar igual a un valor mayor a cero y ser igual o menor a 100","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }
    }
}
