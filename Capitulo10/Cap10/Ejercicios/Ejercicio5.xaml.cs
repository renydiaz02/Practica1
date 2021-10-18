using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Cap10.Ejercicios
{
    /// <summary>
    /// Interaction logic for Ejercicio5.xaml
    /// </summary>
    public partial class Ejercicio5 : Window
    {
        public Ejercicio5()
        {
            InitializeComponent();
        }

        class Poligono
        {
            public int cantidadPoligono;
            public int medidasPoligono;
            public int angulosPoligonos;
            public Poligono(int cantidad, int medida, int angulo)
            {
                cantidadPoligono = cantidad;
                medidasPoligono = medida;
                angulosPoligonos = angulo;
            }
            public Poligono()
            {
                cantidadPoligono = 0;
                medidasPoligono = 0;
                angulosPoligonos = 0;
            }
            public int Cantidad
            {
                get
                {
                    return cantidadPoligono;
                }

                set
                {
                    if (value <= 0)
                    {
                        cantidadPoligono = 1;
                    }
                    else
                    {
                        cantidadPoligono = value;
                    }
                }
            }
            public int Medidas
            {
                get
                {
                    return medidasPoligono;
                }

                set
                {
                    if (value <= 0)
                    {
                        medidasPoligono = 1;
                    }
                    else
                    {
                        medidasPoligono = value;
                    }
                }
            }
            public int Angulos
            {
                get
                {
                    return angulosPoligonos;
                }

                set
                {
                    if (value <= 0)
                    {
                        angulosPoligonos = 1;
                    }
                    else
                    {
                        angulosPoligonos = value;
                    }
                }
            }
            public override String ToString()
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat($"Cantidad de lados: {cantidadPoligono}\tMedidas de los lados: {medidasPoligono}\t Angulos: {angulosPoligonos}");
                return sb.ToString();
            }
        }


        private void IngresarButton_Click(object sender, RoutedEventArgs e)
        {
            Poligono poligono = new Poligono();
            poligono.Cantidad = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox($"Cantidad de lados: ", "Cantidad de Lados", " ", 50, 0));
            poligono.Medidas = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox($"Medidas de los lados: ", "Medidas de los Lados", " ", 50, 0));
            poligono.Angulos = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox($"Angulos: ", "Angulo", " ", 50, 0));

            ResultadoTextBlock.Text = poligono.ToString();
        }
    }
}
