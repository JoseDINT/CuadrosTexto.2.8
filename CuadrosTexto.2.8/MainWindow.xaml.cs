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

namespace CuadrosTexto._2._8
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            NombreTextBox.Tag = HintNombreTextBlock;
            ApellidosTextBox.Tag = HintApellidosTextBlock;
        }

        private void TeclaF1_KeyUp(object sender, KeyEventArgs e)
        {
            TextBox texto = (TextBox)sender;

            TextBlock pista = (TextBlock)texto.Tag;


            if (e.Key == Key.F1 && pista.Visibility == Visibility.Visible)
            { 
                pista.Visibility = Visibility.Hidden; 
            }
            else { 
                pista.Visibility = Visibility.Visible; 
            }
        }

        private void TeclaF2_KeyUp(object sender, KeyEventArgs e)
        {
            bool esNumero = int.TryParse(EdadTextBox.Text, out _);
            // out _ descartar salida

            if (e.Key == Key.F2)
            {
                if (esNumero)
                    HintEdadTexBlock.Visibility = Visibility.Hidden;
                else
                    HintEdadTexBlock.Visibility = Visibility.Visible;
            }
        }

    }
}
