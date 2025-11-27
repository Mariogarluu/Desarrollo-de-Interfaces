using System;
using System.Collections.Generic;
using System.Windows;

namespace ej1
{
    public class Animal
    {
        public string Nombre { get; set; }
        public string Imagen { get; set; }
    }

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            CargarDatos();
        }

        private void CargarDatos()
        {
            List<Animal> animales = new List<Animal>
            {
                new Animal { Nombre = "Perro", Imagen = "/Resources/dog.png" },
                new Animal { Nombre = "Gato", Imagen = "/Resources/cat.png" },
                new Animal { Nombre = "Pájaro", Imagen = "/Resources/bird.png" }
            };
            cmbAnimales.ItemsSource = animales;
        }

        private void CmbAnimales_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if (cmbAnimales.SelectedItem is Animal animal)
            {
                MessageBox.Show(animal.Nombre);
            }
        }
    }
}