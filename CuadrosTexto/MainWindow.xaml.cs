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

namespace CuadrosTexto
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

        private void TextBox_KeyUp(object sender, KeyEventArgs e)
        {
            TextBox informacion = (TextBox)sender;
            string[] informacionString = informacion.Tag.ToString().Split('|');
            TextBlock mostrarInformacion = (TextBlock)FindName(informacionString[1]);
            if(e.Key==Key.F1)
            {
                try
                {
                    mostrarInformacion.Text = mostrarInformacion.Text == "" ? informacionString[0] : "";
                    mostrarInformacion.Foreground = Brushes.Gray;
                }catch(NullReferenceException exN)
                {
                    Console.WriteLine(exN.Message);
                }
            
            }
         
        }

        private void EdadTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.Key==Key.F2)
            {
                TextBox edad = (TextBox)sender;
                int numero;
                bool esNumero = Int32.TryParse(EdadTextBox.Text, out numero);
                if(!esNumero)
                {
                    EdadTextBlock.Text = edad.Tag.ToString();
                    EdadTextBlock.FontWeight = FontWeights.Bold;
                    EdadTextBlock.Foreground = Brushes.Red;
                }
                else
                {
                    EdadTextBlock.Text = "";
                }

            }
        }
    }
}
