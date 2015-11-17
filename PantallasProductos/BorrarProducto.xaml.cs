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
    /// Interaction logic for BorrarProducto.xaml
    /// </summary>
    public partial class BorrarProducto : Window
    {
        public BorrarProducto()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            //obtiene la ruta de la imagen  y la muestra en el imagebox
           String rutaimagen = "C:\\Users\\AlbertoR\\Downloads\\merca\\samsung-logo1.jpg";
            imagen.Source = new BitmapImage(new Uri(rutaimagen));
        }
    }
}
