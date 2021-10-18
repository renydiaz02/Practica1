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
    /// Interaction logic for Ejercicio3.xaml
    /// </summary>
    public partial class Ejercicio3 : Window
    {
        public Ejercicio3()
        {
            InitializeComponent();
        }

        class Poligono
        {
            public int cantidadPoligono;
            public int medidasPoligono;
            public int angulosPoligonos;
            public Poligono(int cantidad, int medidas, int angulos)
            {
                cantidadPoligono = cantidad;
                medidasPoligono = medidas;
                angulosPoligonos = angulos;
            }
            public override String ToString()
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat($"Cantidad de lados: {cantidadPoligono}\nMedidas de los lados: {medidasPoligono}\n Angulos: {angulosPoligonos}");
                return sb.ToString();
            }
        }


        private void IngresarButton_Click(object sender, RoutedEventArgs e)
        {
            Poligono poligono = new Poligono(Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox($"Cantidad de lados: ", "Cantidad de Lados", " ", 50, 0)),
               Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox($"Medidas de llos lados: ", "Medidas de los Lados", " ", 50, 0)),
               Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox($"Angulos: ", "Angulo", " ", 50, 0)));
            ResultadoTextBlock.Text = poligono.ToString();
        }
    }
}
