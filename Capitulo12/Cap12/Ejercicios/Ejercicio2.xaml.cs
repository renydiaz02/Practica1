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

namespace Cap12.Ejercicios
{
    /// <summary>
    /// Interaction logic for Ejercicio2.xaml
    /// </summary>
    public partial class Ejercicio2 : Window
    {
        public Ejercicio2()
        {
            InitializeComponent();
        }



        private void Revisar_Click(object sender, RoutedEventArgs e)
        {
            int factorial = 1;
            int num = int.Parse(NumeroTextBox.Text);
            for (int i = num; i >= 1; i--)
            {
                Console.WriteLine("Ingresado");
                factorial *= i;
                Console.WriteLine("Salio de la funcion, y resultado del Factorial es en la entrada" + i + factorial);
            }
            MessageBox.Show($"El factorial de {num} es {factorial}");
        }
    }
}
