// ResultadoPage.xaml.cs
using Microsoft.Maui.Controls;

namespace Calculadora__NetMaui_;

    public partial class ResultadoPage : ContentPage
    {
        public ResultadoPage(double resultado)
        {
            InitializeComponent();
            resultadoLabel.Text = $"Resultado: {resultado}";
        }
    }

