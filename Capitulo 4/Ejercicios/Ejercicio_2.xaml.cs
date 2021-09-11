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

namespace Capitulo_4
{
    /// <summary>
    /// Interaction logic for Ejercicio_2.xaml
    /// </summary>
    public partial class Ejercicio_2 : Window
    {
        public static int num_int=0, potencia_int=0; 
        public Ejercicio_2()
        {
            InitializeComponent();
        }

        private void CalcularButton_Click(object sender, RoutedEventArgs e)
        {
            int result = 1, container = 1;
            String numero;
            String potencia;
            potencia = this.PotenciaTextBox.Text;
            numero = this.NumeroTextBox.Text;
            int.TryParse(numero, out num_int);
            int.TryParse(potencia, out potencia_int);

            for (int i = 0; i < potencia_int;i++)
            {
                container = result;
                result = num_int * container;

            }

            if (NumeroTextBox.Text != "" && PotenciaTextBox.Text != "")
            {
                MessageBox.Show($"{result}", "Resultado",
                   MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Por Favor Digite un numero...", "ALERTA",
                    MessageBoxButton.OK, MessageBoxImage.Error);
                NumeroTextBox.Focus();
            }
            this.PotenciaTextBox.Clear();
            this.NumeroTextBox.Clear();
        }
    }
}
