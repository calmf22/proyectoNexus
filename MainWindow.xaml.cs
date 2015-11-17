using Nexus.Compras;
using Nexus.DB;
using Nexus.PantallasProductos;
using Nexus.PantallasProveedores;
using Nexus.Salidas;
using Nexus.usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Nexus
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //Todas las pestañas estan collapsadas
            tabInicio.Visibility = Visibility.Visible;
            tabInicio.IsSelected = true;
            tabCompras.Visibility = Visibility.Collapsed;
            tabSalida.Visibility = Visibility.Collapsed;
            tabProducto.Visibility = Visibility.Collapsed;
            tabProveedores.Visibility = Visibility.Collapsed;
            tabOpciones.Visibility = Visibility.Collapsed;
        }

       

        private void button_Click(object sender, RoutedEventArgs e)
        {
            /*principal db = new principal();
            Empleado emp = new Empleado();

            emp.Nombre = txtNombre.Text;
            db.Empleados.Add(emp);
            db.SaveChanges();*/
        }

        

        private void button6_Click_1(object sender, RoutedEventArgs e)
        {
            NuevaCompra nc = new NuevaCompra();
            nc.ShowDialog();
        }

       

        private void button_Click_Inicio(object sender, RoutedEventArgs e)
        {
            //Muestra el tab seleccioado
            tabInicio.Visibility = Visibility.Visible;
            tabInicio.IsSelected = true;
            tabCompras.Visibility = Visibility.Collapsed;
            tabSalida.Visibility = Visibility.Collapsed;
            tabProducto.Visibility = Visibility.Collapsed;
            tabProveedores.Visibility = Visibility.Collapsed;
            tabOpciones.Visibility = Visibility.Collapsed;
        }

        private void button_Click_productos(object sender, RoutedEventArgs e)
        {
            //Muestra el tab seleccioado
            tabInicio.Visibility = Visibility.Collapsed;
            tabCompras.Visibility = Visibility.Collapsed;
            tabSalida.Visibility = Visibility.Collapsed;
            tabProducto.Visibility = Visibility.Visible;
            tabProducto.IsSelected = true;
            tabProveedores.Visibility = Visibility.Collapsed;
            tabOpciones.Visibility = Visibility.Collapsed;
        }

        private void button_Click_Entradas(object sender, RoutedEventArgs e)
        {
            //Muestra el tab seleccioado
            tabInicio.Visibility = Visibility.Collapsed;
            tabCompras.Visibility = Visibility.Visible;
            tabCompras.IsSelected = true;
            tabSalida.Visibility = Visibility.Collapsed;
            tabProducto.Visibility = Visibility.Collapsed;
            tabProveedores.Visibility = Visibility.Collapsed;
            tabOpciones.Visibility = Visibility.Collapsed;
        }

        private void button_Click_Salidas(object sender, RoutedEventArgs e)
        {
            //Muestra el tab seleccioado
            tabInicio.Visibility = Visibility.Collapsed;
            tabCompras.Visibility = Visibility.Collapsed;
            tabSalida.Visibility = Visibility.Visible;
            tabSalida.IsSelected = true;
            tabProducto.Visibility = Visibility.Collapsed;
            tabProveedores.Visibility = Visibility.Collapsed;
            tabOpciones.Visibility = Visibility.Collapsed;
        }

        private void button_Click_Proveedores(object sender, RoutedEventArgs e)
        {
            //Muestra el tab seleccioado
            tabInicio.Visibility = Visibility.Collapsed;
            tabCompras.Visibility = Visibility.Collapsed;
            tabSalida.Visibility = Visibility.Collapsed;
            tabProducto.Visibility = Visibility.Collapsed;
            tabProveedores.Visibility = Visibility.Visible;
            tabProveedores.IsSelected = true;
            tabOpciones.Visibility = Visibility.Collapsed;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void button13_Click(object sender, RoutedEventArgs e)
        {
            NuevoProveedor np = new NuevoProveedor();
            np.ShowDialog();
        }

        private void button8_Click(object sender, RoutedEventArgs e)
        {
            ActualizarProveedor ap = new ActualizarProveedor();
            ap.ShowDialog();
        }

        private void button9_Click(object sender, RoutedEventArgs e)
        {
            BorrarProveedor bp = new BorrarProveedor();
            bp.ShowDialog();
        }

        private void button10_Click(object sender, RoutedEventArgs e)
        {
            NuevoProducto np = new NuevoProducto();
            np.ShowDialog();
        }

        private void button11_Click(object sender, RoutedEventArgs e)
        {
            
            ActualizarProducto ap = new ActualizarProducto();
            ap.ShowDialog();
        }

        private void button12_Click(object sender, RoutedEventArgs e)
        {
            BorrarProducto bp = new BorrarProducto();
            bp.ShowDialog();
        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {
            Recibos r = new Recibos();
            r.ShowDialog();
        }

        private void button14_Click(object sender, RoutedEventArgs e)
        {
            NuevaSalida ns = new NuevaSalida();
            ns.ShowDialog();
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            InicioSesion inicio = new InicioSesion();
            this.Close();
            inicio.ShowDialog();
        }

        private void button25_Click(object sender, RoutedEventArgs e)
        {
            //Muestra el tab seleccioado
            tabInicio.Visibility = Visibility.Collapsed;
            tabCompras.Visibility = Visibility.Collapsed;
            tabSalida.Visibility = Visibility.Collapsed;
            tabProducto.Visibility = Visibility.Collapsed;
            tabProveedores.Visibility = Visibility.Collapsed;
            tabOpciones.IsSelected = true;
            tabOpciones.Visibility = Visibility.Visible;
        }

        private void button28_Click(object sender, RoutedEventArgs e)
        {
            AboutBox1 sd = new AboutBox1();
            sd.ShowDialog();
        }

        private void button26_Click(object sender, RoutedEventArgs e)
        {
            AltaUsuario au = new AltaUsuario();
            au.ShowDialog();
        }

        private void button27_Click(object sender, RoutedEventArgs e)
        {
            BajaUsuario bu = new BajaUsuario();
            bu.ShowDialog();
        }

        private void button29_Click(object sender, RoutedEventArgs e)
        {
            ActualizarUsuario au = new ActualizarUsuario();
            au.ShowDialog();
        }
    }
}
