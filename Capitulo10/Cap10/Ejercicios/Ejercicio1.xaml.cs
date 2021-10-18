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
    /// Interaction logic for Ejercicio1.xaml
    /// </summary>
    public partial class Ejercicio1 : Window
    {
        public Ejercicio1()
        {
            InitializeComponent();
        }

        public class Inventario
        {
            public int codProducto;
            public string nomProducto;
            public string descProducto;
            public int existenciaProducto;
            public float precioProducto;

            public Inventario(int codigo, string nombreProducto, string descripcionProducto, int existencia, float precio)
            {
                codProducto = codigo;
                nomProducto = nombreProducto;
                descProducto = descripcionProducto;
                existenciaProducto = existencia;
                precioProducto = precio;
            }

            public override String ToString()
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat($"Codigo Producto: {codProducto}\nNombre Producto: {nomProducto}\nDescripcion Producto: " +
                    $"{descProducto}\nExistencia Producto: {existenciaProducto}\nPrecio Producto:{precioProducto}");
                return sb.ToString();
            }
        }

        private void IngresarButton_Click(object sender, RoutedEventArgs e)
        {

            Inventario inventario = new Inventario(Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox($"Codigo producto: ", "Codigo Producto", " ", 60, 0)),
               Microsoft.VisualBasic.Interaction.InputBox($"Nombre producto: ", "Nombre Producto", " ", 60, 0),
               Microsoft.VisualBasic.Interaction.InputBox($"Descripcion producto: ", "Descripcion Producto", " ", 60, 0),
               Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox($"Producto en Existencia ", "Producto en Existencia ", " ", 60, 0)),
               Convert.ToSingle(Microsoft.VisualBasic.Interaction.InputBox($"Precio producto: ", "Precio Producto", " ", 60, 0)));
            ResultadoTextBlock.Text = inventario.ToString();

        }
    }
}
