﻿using System;
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

namespace Capitulo_6.Ejercicios
{
    /// <summary>
    /// Interaction logic for Ejercicio_2.xaml
    /// </summary>
    public partial class Ejercicio_2 : Window
    {
        int cantidad;
        int salondeclases = 0;
        float[][] calificaciones;


        public static float suma = 0.0f;
        public static float promedioCalificaciones = 0.0f;
        public static int count = 0;
        public static float menor = 2147483648, aux = 0.0f;
        public Ejercicio_2()
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
            salondeclases = ToInt(CursosTextBox.Text);
            calificaciones = new float[salondeclases][];

            for (int i = 0; i < salondeclases; i++)
            {
                cantidad = ToInt(Microsoft.VisualBasic.Interaction.InputBox($"Ingrese la cantidad de estudiantes de salon de clase: {i + 1}", " Cantidad de estudiantes ", " ", 50, 0));
                calificaciones[i] = new float[cantidad];
                //contador += cantidad;
                //cantidad += cantidad;
            }

            CursosTextBox.Text = "";
        }
        private void AregarCalificaionesButton_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < salondeclases; i++)
            {
                for (int j = 0; j < calificaciones[i].GetLength(0); j++)
                {
                    calificaciones[i][j] = Convert.ToSingle(Microsoft.VisualBasic.Interaction.InputBox($"Ingrese la calificación del estudiante {j + 1} del salon de clase {i + 1}", "Calificaciones los estudiantes"));

                    suma += calificaciones[i][j];
                    count++;
                    if (calificaciones[i][j] < menor)
                    {
                        menor = calificaciones[i][j];
                    }
                }
            }
            for (int n = 0; n < salondeclases; n++)
            {
                CalificacionesListView.Items.Add($"Salón de clases {n + 1}");

                for (int m = 0; m < calificaciones[n].GetLength(0); m++)
                {
                    CalificacionesListView.Items.Add($"El estudiante {m + 1} tiene {calificaciones[n][m]}");
                }
            }

        }

        private void ResultadoButton_Click(object sender, RoutedEventArgs e)
        {
            promedioCalificaciones = suma / count;
            ResultadosListView.Items.Add("Promedio: ");
            ResultadosListView.Items.Add(promedioCalificaciones);

            ResultadosListView.Items.Add("Calificacion menor ");
            ResultadosListView.Items.Add(menor);
        }
    }
}
