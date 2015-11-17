using Nexus.DB;
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

namespace Nexus.PantallasProveedores
{
    /// <summary>
    /// Interaction logic for NuevoProveedor.xaml
    /// </summary>
    public partial class NuevoProveedor : Window
    {
        public NuevoProveedor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            principal cn = new  principal();
            Proveedores pr = new Proveedores();
           

            pr.NombreProveedor = txtNombre.Text;
            pr.DireccionProveedor = txtDireccion.Text;
            pr.NumeroTelProveedor = txtNumTel.Text;
            pr.CiudadProveedor = txtCiudad.Text;
            pr.DepartamentoID = (int)cbDepartamento.SelectedValue;
            pr.PaisProveedor = txtPais.Text;
            pr.CorreoProveedor = txtCorreo.Text;
            cn.Proveedoress.Add(pr);
            cn.SaveChanges();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            principal pr =new principal();
            cbDepartamento.ItemsSource = pr.Departamentoss.ToList();
            cbDepartamento.DisplayMemberPath = "Nombre";
            cbDepartamento.SelectedValuePath = "id";
                
           
        }
    }
}
