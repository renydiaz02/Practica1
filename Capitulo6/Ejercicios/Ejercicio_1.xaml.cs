using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Capitulo_6.Ejercicios
{
    /// <summary>
    /// Interaction logic for Ejercicio_1.xaml
    /// </summary>
    public partial class Ejercicio_1 : Window
    {
        int cantidad; 
        int salondeClases = 0;
        static float[][] calificaciones; 


        public static float suma = 0.0f;
        public static float promedioCalificaciones = 0.0f;
        public static int count = 0;
        public Ejercicio_1()
        {
            InitializeComponent();
        }

        public static int ToInt(string valor)
        {
            int retorno = 0;

            int.TryParse(valor, out retorno);

            return retorno;
        }
        private void AgregarCursoButton_Click(object sender, RoutedEventArgs e)
        {
            salondeClases = ToInt(CursosTextBox.Text);
            calificaciones = new float[salondeClases][];

            for (int i = 0; i < salondeClases; i++)
            {
                cantidad = ToInt(Microsoft.VisualBasic.Interaction.InputBox($"Ingrese la cantidad de estudiantes del salon de clase: {i + 1}", " Cantidad de Estudiantes ", " ", 50, 0));
                calificaciones[i] = new float[cantidad];
                count += cantidad;
                cantidad += cantidad;

            }

            CursosTextBox.Text = "";
        }
        private void AregarCalificaionesButton_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < salondeClases; i++)
            {
                for (int j = 0; j < calificaciones[i].GetLength(0); j++)
                {
                    calificaciones[i][j] = ToInt(Microsoft.VisualBasic.Interaction.InputBox($"Ingrese la calificación del estudiante {j + 1}  del salon de clase {i + 1}", "Calificaciones de los estudiantes", " ", 50, 0));
                    suma += calificaciones[i][j];
                }
            }

        }

        private void ResultadoButton_Click(object sender, RoutedEventArgs e)
        {
            promedioCalificaciones = suma / count;
            ResultadosListView.Items.Add("Promedio: ");
            ResultadosListView.Items.Add(promedioCalificaciones);
        }
    }
}
