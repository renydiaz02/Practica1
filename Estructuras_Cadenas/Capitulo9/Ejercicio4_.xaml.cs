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

namespace Estructuras_Cadenas.Capitulo9
{
    /// <summary>
    /// Interaction logic for Ejercicio4_.xaml
    /// </summary>
    public partial class Ejercicio4_ : Window
    {
        public Ejercicio4_()
        {
            InitializeComponent();
        }
        public enum TiposNeumaticos
        {
            All_Season, Pista, Todo_Terreno, Invierno, Deportivos, Verano, Anti_Pinchazo
        }

        private void VerButton_Click(object sender, RoutedEventArgs e)
        {
            TiposNeumaticos neumaticos1 = TiposNeumaticos.All_Season;
            TiposNeumaticos neumaticos2 = TiposNeumaticos.Pista;
            TiposNeumaticos neumaticos3 = TiposNeumaticos.Todo_Terreno;
            TiposNeumaticos neumaticos4 = TiposNeumaticos.Invierno;
            TiposNeumaticos neumaticos5 = TiposNeumaticos.Deportivos;
            TiposNeumaticos neumaticos6 = TiposNeumaticos.Verano;


            string neumaticos = ""+neumaticos1.ToString()+"\n"+neumaticos2.ToString()+"\n"+neumaticos3.ToString() + "\n" + neumaticos4.ToString() + "\n" + neumaticos5.ToString() + "\n" + neumaticos6.ToString();

            ListaListBox.Items.Add(neumaticos);
        }
    }
}
