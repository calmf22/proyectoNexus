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

namespace Nexus
{
    /// <summary>
    /// Interaction logic for InicioSesion.xaml
    /// </summary>
    public partial class InicioSesion : Window
    {
        public InicioSesion()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
           /*obtiene la contraseña y la guarda en una variable 
           String uno = "";
            uno = passwordBox.Password;
            textBlock.Text = uno;
          */
            MainWindow inicio = new MainWindow();
            inicio.Show();
            this.Close();
        }
    }
}
