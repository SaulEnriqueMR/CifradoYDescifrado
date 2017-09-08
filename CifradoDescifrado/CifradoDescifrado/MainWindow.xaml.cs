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

namespace CifradoDescifrado
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


        private void TxtBxPPOriginal_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (TxtBxPPOriginal.Text != "")
            {
                BtnCifrar.IsEnabled = true;
            }
            else
            {
                BtnCifrar.IsEnabled = false;
            }
        }

        private void TxtBxPCOriginal_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (TxtBxPCOriginal.Text != "")
            {
                BtnDescifrar.IsEnabled = true;
            }
            else
            {
                BtnDescifrar.IsEnabled = false;
            }
        }

        private void BtnCifrar_Click(object sender, RoutedEventArgs e)
        {
            var contrasenaOriginal = TxtBxPPOriginal.Text;
            var contrasenaCifrada = Cifrado.Cifrar(contrasenaOriginal);
            TxtBxPPCifrada.Text = contrasenaCifrada;
        }

        private void BtnDescifrar_Click(object sender, RoutedEventArgs e)
        {
            var contrasenaCifrada = TxtBxPCOriginal.Text;
            var contrasenaOriginal = Descifrado.Descifrar(contrasenaCifrada);
            TxtBxCPOriginal.Text = contrasenaOriginal;
        }
    }
}
