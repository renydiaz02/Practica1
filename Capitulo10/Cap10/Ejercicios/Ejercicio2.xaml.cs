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
    /// Interaction logic for Ejercicio2.xaml
    /// </summary>
    public partial class Ejercicio2 : Window
    {
        public Ejercicio2()
        {
            InitializeComponent();
        }

        class Estudiantes
        {
            public int matriculaEstudiante;
            public string nombreEstudiante;
            public int edadEstudiante;
            public string gradoEstudiante;
            public string seccionEstudiante;
            public Estudiantes(int matricula, string nombre, int edad, string grado, string seccion)
            {
                matriculaEstudiante = matricula;
                nombreEstudiante = nombre;
                edadEstudiante = edad;
                gradoEstudiante = grado;
                seccionEstudiante = seccion;
            }

            public override String ToString()
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat($"Matricula Estudiante: {matriculaEstudiante}\nNombre Estudiante: " +
                    $"{nombreEstudiante}\nEdad Estudiante: {edadEstudiante}\nGrado del Estudiante: {gradoEstudiante}\nSeccion del Estudiante: {seccionEstudiante}");
                return sb.ToString();
            }
        }


        private void IngresarButton_Click(object sender, RoutedEventArgs e)
        {
            Estudiantes estudiantes = new Estudiantes(Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox($"Codigo Estudiante: ", "Codigo", " ", 60, 0)),
               Microsoft.VisualBasic.Interaction.InputBox($"Nombre Estudiante: ", "Nombre Estudiante", " ", 60, 0),
               int.Parse(Microsoft.VisualBasic.Interaction.InputBox($"Edad Estudiante: ", "Edad Estudiante", " ", 60, 0)),
               Microsoft.VisualBasic.Interaction.InputBox($"Grado del Estudiante: ", "Grado del Estudiante", " ", 60, 0),
               Microsoft.VisualBasic.Interaction.InputBox($"Seccion del Estudiante: ", "Seccion del Estudiante", " ", 60, 0));
            ResultadoTextBlock.Text = estudiantes.ToString();
        }
    }
}
