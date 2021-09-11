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

namespace Capitulo_4.Ejercicios
{
    /// <summary>
    /// Interaction logic for Ejercicio_5.xaml
    /// </summary>
    public partial class ProblemaNum_5 : Window
    {
        public static int minimum = 1, maximum = 1, age = 1;
        public static int cont = 0;
        public static float promedio = 0, SumaAcumulada = 0;

        //Botones
        private void ResultadoButton_Click(object sender, RoutedEventArgs e)
        {
            promedio = (SumaAcumulada / cont);

            ResultadoListView.Items.Add("La Edad Promedio es: ");
            ResultadoListView.Items.Add(promedio);

            ResultadoListView.Items.Add("La Edad Minima es: ");
            ResultadoListView.Items.Add(minimum);

            ResultadoListView.Items.Add("La Edad Maxima es: ");
            ResultadoListView.Items.Add(maximum);

        }
        public ProblemaNum_5()
        {
            InitializeComponent();
        }
        private void AgregarButton_Click(object sender, RoutedEventArgs e)
        {
            int numero = 0;
            //If, para agregar los datos que ingresan y se muestran en el list view
            if (EdadTextBox.Text != "")
            {
                string str = EdadTextBox.Text;
                int.TryParse(str, out numero);
               
                this.EdadListView.Items.Add(numero);
                EdadTextBox.Text = "";
                cont++;
                SumaAcumulada += numero;
                EdadTextBox.Focus();

            }
            else
            {
                MessageBox.Show("El Campo no puedes estar vacio, debe de contener un Valor...", "ALERTA",
                    MessageBoxButton.OK, MessageBoxImage.Error);
                EdadTextBox.Focus();
            }

            //Igualamos el minimo y el maximo a la edad, para poder compararlas
            age = numero;
            minimum = maximum = age;

            //Ciclo For, para comparar la edad maxima y minima

            for (int x = 0; x < EdadListView.Items.Count; x++)
            {

                if (maximum < Convert.ToInt32(EdadListView.Items[x]))
                {
                    maximum = Convert.ToInt32(EdadListView.Items[x]);

                }
                else if (minimum > Convert.ToInt32(EdadListView.Items[x]))
                {
                    minimum = Convert.ToInt32(EdadListView.Items[x]);
                }
            }
        }
    }
}
