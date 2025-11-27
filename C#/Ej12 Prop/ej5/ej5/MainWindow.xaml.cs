using System.Collections.Generic;
using System.Windows;

namespace ej5
{
    public class Estudiante
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public double Nota { get; set; }
        public string Curso { get; set; }
    }

    public partial class MainWindow : Window
    {
        public List<Estudiante> Estudiantes { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            CargarDatos();
            this.DataContext = this;
        }

        private void CargarDatos()
        {
            Estudiantes = new List<Estudiante>
            {
                new Estudiante { Nombre = "Ana", Edad = 20, Nota = 9, Curso = "Matemáticas" },
                new Estudiante { Nombre = "Luis", Edad = 22, Nota = 7.5, Curso = "Matemáticas" },
                new Estudiante { Nombre = "María", Edad = 21, Nota = 8.5, Curso = "Física" },
                new Estudiante { Nombre = "Pedro", Edad = 23, Nota = 6, Curso = "Física" },
                new Estudiante { Nombre = "Sofía", Edad = 20, Nota = 9.5, Curso = "Química" },
                new Estudiante { Nombre = "Carlos", Edad = 22, Nota = 7, Curso = "Química" }
            };
        }
    }
}