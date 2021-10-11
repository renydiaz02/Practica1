using System;
using System.Collections;
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

namespace Capitulo_7.Ejercicio
{
    /// <summary>
    /// Interaction logic for Ejercicio_2.xaml
    /// </summary>
    public partial class Ejercicio_2 : Window
    {
        Hashtable diccionarioPalabra = new Hashtable();
        public Ejercicio_2()
        {
            InitializeComponent();
            PalabrasListView.Items.Add("arreglo\nalgoritmo\nsistema\nsoftware\nhardware");
        }

        private void BuscarButton_Click(object sender, RoutedEventArgs e)
        {
            diccionarioPalabra.Add("arreglo", "En programación, Un arreglo puede definirse como un grupo o una colección finita, homogénea y ordenada de elementos.");
            diccionarioPalabra.Add("algoritmo", "Es una secuencia de pasos lógicos y ordenados que permiten solucionar un problema.");
            diccionarioPalabra.Add("sistema", "Es un conjunto de partes o elementos organizados y relacionados que interactúan entre sí para lograr un objetivo.");
            diccionarioPalabra.Add("hardware", "Se conoce como hardware al total de los elementos materiales, tangibles, que forman al sistema informático de una computadora u ordenador.");
            diccionarioPalabra.Add("software", "Es un conjunto de programas, instrucciones y reglas informáticas que permiten ejecutar distintas tareas en una computadora.");

            DescripcionTextBox.Text = (String)diccionarioPalabra[PalabraTextBox.Text.ToLower()];
        }
    }
}
