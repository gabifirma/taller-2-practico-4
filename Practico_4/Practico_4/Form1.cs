using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Practico_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BGenerador_Click(object sender, EventArgs e)
        {
            Boolean valorDesde = int.TryParse(TDesde.Text, out int desde);
            Boolean valorHasta = int.TryParse(THasta.Text, out int hasta);

            if(valorDesde && valorHasta)
            {
                for(int i = desde; i < hasta+1; i++)
                {
                    LBMostrar.Items.Add( i.ToString());

                    // Limpio datos anteriores
                    CGrafico.Series[0].Points.Clear();

                    // Cargo los números desde el ListBox
                    foreach (var item in LBMostrar.Items)
                    {
                        int numero = Convert.ToInt32(item);
                        CGrafico.Series[0].Points.AddY(numero);
                    }
                }
            }
            else
            {
                MessageBox.Show("Ingrese valores numéricos enteros",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void BEliminar_Click(object sender, EventArgs e)
        {
            TDesde.Clear();
            THasta.Clear();
            LBMostrar.Items.Clear();
            CGrafico.Series[0].Points.Clear();
        }

        private void BSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BPares_Click(object sender, EventArgs e)
        {
            Boolean valorDesde = int.TryParse(TDesde.Text, out int desde);
            Boolean valorHasta = int.TryParse(THasta.Text, out int hasta);

            if (valorDesde && valorHasta)
            {
                for (int i = desde; i < hasta + 1; i++)
                {
                    if((i % 2) == 0)
                    {
                        LBMostrar.Items.Add(i.ToString());

                        // Limpio datos anteriores
                        CGrafico.Series[0].Points.Clear();

                        // Cargo los números desde el ListBox
                        foreach (var item in LBMostrar.Items)
                        {
                            int numero = Convert.ToInt32(item);
                            CGrafico.Series[0].Points.AddY(numero);
                        }
                    }                    
                }
            }
            else
            {
                MessageBox.Show("Ingrese valores numéricos enteros",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void BImpares_Click(object sender, EventArgs e)
        {
            Boolean valorDesde = int.TryParse(TDesde.Text, out int desde);
            Boolean valorHasta = int.TryParse(THasta.Text, out int hasta);

            if (valorDesde && valorHasta)
            {
                for (int i = desde; i < hasta + 1; i++)
                {
                    if ((i % 2) == 1)
                    {
                        LBMostrar.Items.Add(i.ToString());

                        // Limpio datos anteriores
                        CGrafico.Series[0].Points.Clear();

                        // Cargo los números desde el ListBox
                        foreach (var item in LBMostrar.Items)
                        {
                            int numero = Convert.ToInt32(item);
                            CGrafico.Series[0].Points.AddY(numero);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Ingrese valores numéricos enteros",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void BPrimos_Click(object sender, EventArgs e)
        {
            Boolean valorDesde = int.TryParse(TDesde.Text, out int desde);
            Boolean valorHasta = int.TryParse(THasta.Text, out int hasta);

            if (valorDesde && valorHasta && hasta > 0 && desde > 0)
            {
                while (desde <= hasta)
                {
                    Boolean esPrimo = true;

                    if (desde == 1)
                    {
                        esPrimo = false;
                    }
                    else
                    {
                        for (int i = 2; i <= Math.Sqrt(desde); i++)
                        {
                            if (desde % i == 0)
                            {
                                esPrimo = false;
                                break;
                            }
                        }
                    }

                    if (esPrimo)
                    {
                        LBMostrar.Items.Add(desde.ToString());

                        // Limpio datos anteriores
                        CGrafico.Series[0].Points.Clear();

                        // Cargo los números desde el ListBox
                        foreach (var item in LBMostrar.Items)
                        {
                            int numero = Convert.ToInt32(item);
                            CGrafico.Series[0].Points.AddY(numero);
                        }
                    }
                    desde++;
                }
            }
            else
            {
                MessageBox.Show("Ingrese numéros enteros mayores a cero",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
