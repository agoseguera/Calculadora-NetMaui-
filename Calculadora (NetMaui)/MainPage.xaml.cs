using System;
using Microsoft.Maui.Controls;

namespace Calculadora__NetMaui_
   {
    public partial class MainPage : ContentPage
    {
        private MathOperations _mathOperations = new MathOperations();

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnSumaClicked(object sender, EventArgs e)
        {
            if (double.TryParse(num1Entry.Text, out double num1) &&
                double.TryParse(num2Entry.Text, out double num2))
            {
                double resultado = _mathOperations.Suma(num1, num2);
                await Navigation.PushAsync(new ResultadoPage(resultado));
            }
            else
            {
                await DisplayAlert("Error", "Por favor ingresa números válidos", "OK");
            }
        }

        private async void OnRestaClicked(object sender, EventArgs e)
        {
            if (double.TryParse(num1Entry.Text, out double num1) &&
                double.TryParse(num2Entry.Text, out double num2))
            {
                double resultado = _mathOperations.Resta(num1, num2);
                await Navigation.PushAsync(new ResultadoPage(resultado));
            }
            else
            {
                await DisplayAlert("Error", "Por favor ingresa números válidos", "OK");
            }
        }

        private async void OnMultiplicacionClicked(object sender, EventArgs e)
        {
            if (double.TryParse(num1Entry.Text, out double num1) &&
                double.TryParse(num2Entry.Text, out double num2))
            {
                double resultado = _mathOperations.Multiplicacion(num1, num2);
                await Navigation.PushAsync(new ResultadoPage(resultado));
            }
            else
            {
                await DisplayAlert("Error", "Por favor ingresa números válidos", "OK");
            }
        }

        private async void OnDivisionClicked(object sender, EventArgs e)
        {
            if (double.TryParse(num1Entry.Text, out double num1) &&
                double.TryParse(num2Entry.Text, out double num2))
            {
                try
                {
                    double resultado = _mathOperations.Division(num1, num2);
                    await Navigation.PushAsync(new ResultadoPage(resultado));
                }
                catch (DivideByZeroException ex)
                {
                    await DisplayAlert("Error", ex.Message, "OK");
                }
            }
            else
            {
                await DisplayAlert("Error", "Por favor ingresa números válidos", "OK");
            }
        }
    }
}