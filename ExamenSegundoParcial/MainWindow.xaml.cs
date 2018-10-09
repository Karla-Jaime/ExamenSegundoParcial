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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ExamenSegundoParcial
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void seleccion_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            InfPersonal.Visibility = Visibility.Collapsed;
            Cont.Visibility = Visibility.Collapsed;
            InfP.Visibility = Visibility.Collapsed;

            switch (seleccion.SelectedIndex)
            {
                case 0:
                    InfPersonal.Visibility = Visibility.Visible;
                    break;
                case 1:
                    Cont.Visibility = Visibility.Visible;
                    break;
                case 2:
                    InfP.Visibility = Visibility.Visible;
                    break;
                default: break;
            }
        }

        private void siguiente_Click(object sender, RoutedEventArgs e)
        {
            switch (seleccion.SelectedIndex)
            {
                case 0:
                    if (string.IsNullOrEmpty(InfPersonal.BoxN.Text)|| string.IsNullOrEmpty(InfPersonal.BoxApP.Text)||
                        string.IsNullOrEmpty(InfPersonal.BoxApM.Text) || string.IsNullOrEmpty(InfPersonal.BoxEdad.Text))
                    {

                        MessageBox.Show("Es necesario llenar todos los espacios");

                        return;

                    } 
                    break;
                case 1:
                    if (string.IsNullOrEmpty(Cont.BoxCorreo.Text) || string.IsNullOrEmpty(Cont.BoxTele.Text) || string.IsNullOrEmpty(Cont.BoxCelular.Text)
                       )
                    {

                        MessageBox.Show("Es necesario llenar todos los espacios");

                        return;

                    }
                    break;
                case 2:
                    InfP.BoxNumT.MaxLength = 16;
                  
                    
                    if(InfP.BoxNumT.Text.Length < 16)
                    {
                        MessageBox.Show("Es necesario que el numero de tarjeta sean 16 digitos");
                    }
                    break;
                default: break;
            }

        }

        
    }
}
