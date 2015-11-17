using Microsoft.Win32;
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

namespace Nexus.PantallasProductos
{
    /// <summary>
    /// Interaction logic for NuevoProducto.xaml
    /// </summary>
    public partial class NuevoProducto : Window
    {
        public NuevoProducto()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            //Permite al usuario buscar la imagen en el disco duro
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Archivos de imágen (.jpg)|*.jpg|All Files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.Multiselect = true;
            bool? checarOK = openFileDialog1.ShowDialog();
            imagen.Source = new BitmapImage(new Uri(openFileDialog1.FileName));
            rutaimagen.Text = openFileDialog1.FileName;
        }
    }
}
