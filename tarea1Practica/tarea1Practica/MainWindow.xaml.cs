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

namespace tarea1Practica
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Valor1TextBox.PreviewTextInput += Valor1TextBox_PreviewTextInput;
            Valor2TextBox.PreviewTextInput += Valor2TextBox_PreviewTextInput;
            AceptarButton.Click += AceptarButton_Click;
            ReiniciarButton.Click += ReiniciarButton_Click;
        }

        private void Valor1TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            int result;
            if (!int.TryParse(e.TextComposition.Text, out result))
            {
                e.Handled = true;
            }
        }
        private void Valor2TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            int result;
            if (!int.TryParse(e.TextComposition.Text, out result))
            {
                e.Handled = true;
            }
        }

        private void AceptarButton_Click(object sender, RoutedEventArgs e)
        {
            int valor1;
            int valor2;
            if(int.TryParse(Valor1TextBox.Text, out valor1) && int.TryParse(Valor2TextBox.Text, out valor2))
            {
                int resultado = valor1 * valor2;
                ResultadoTextBox.Text = resultado.ToString();
            }
        }

        private void ReiniciarButton_Click(object sender, RoutedEventArgs e)
        {
            Valor1TextBox.Text = "";
            Valor2TextBox.Text = "";
            ResultadoTextBox.Text = "";
        }
    }
}