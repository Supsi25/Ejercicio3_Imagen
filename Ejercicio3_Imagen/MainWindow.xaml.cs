using System.Windows;
using System.Windows.Media;

namespace Ejercicio3_Imagen
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            opacidadAlta.IsChecked = true;
            relleno.IsChecked = true;
        }

        private void OpacidadAlta_Checked(object sender, RoutedEventArgs e)
        {
            imagen.Opacity = 0.9;
        }

        private void OpacidadMedia_Checked(object sender, RoutedEventArgs e)
        {
            imagen.Opacity = 0.6;
        }

        private void OpacidadBaja_Checked(object sender, RoutedEventArgs e)
        {
            imagen.Opacity = 0.3;
        }

        private void Relleno_Checked(object sender, RoutedEventArgs e)
        {
            imagen.Stretch = Stretch.Fill;
        }

        private void Uniforme_Checked(object sender, RoutedEventArgs e)
        {
            imagen.Stretch = Stretch.Uniform;
        }

        private void RellenoUniforme_Checked(object sender, RoutedEventArgs e)
        {
            imagen.Stretch = Stretch.UniformToFill;
        }

        private void SinAjuste_Checked(object sender, RoutedEventArgs e)
        {
            imagen.Stretch = Stretch.None;
        }
    }
}
