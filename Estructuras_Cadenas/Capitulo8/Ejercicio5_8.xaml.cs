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

namespace Estructuras_Cadenas.Capitulo8
{
    /// <summary>
    /// Interaction logic for Ejercicio5_8.xaml
    /// </summary>
    public partial class Ejercicio5_8 : Window
    {
        public Ejercicio5_8()
        {
            InitializeComponent();
        }

        private void PresentarButton_Click(object sender, RoutedEventArgs e)
        {
            string cad1 = "";
            string cad2 = "";

            cad1 = Cadena1TextBox.Text;
            cad2 = Cadena2TextBox.Text;

            string ordencadena1 = new string(cad1.OrderBy(x => x).ToArray());

            string ordencadena2 = new string(cad2.OrderBy(x => x).ToArray());

            MessageBox.Show($"La cadena 1 {cad1} ordenada alfabeticamente es: {ordencadena1}" +
                $"\nLa cadena 2 {cad2} ordenada alfabeticamente es: {ordencadena2}",
                "Ordenar", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
