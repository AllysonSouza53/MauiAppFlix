using System.Runtime.CompilerServices;

namespace MauiAppFlix
{
    public partial class MainPage : ContentPage
    {


        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new Categorias.Acao());

            }
            catch (Exception ex)
            {
                DisplayAlert("Não encontrado", ex.Message, "OK");
            }
        }

        private void Button_Clicked_1(System.Object sender, System.EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new Categorias.Aventura());

            }
            catch (Exception ex)
            {
                DisplayAlert("Não encontrado", ex.Message, "OK");
            }
        }

        private void Button_Clicked_2(System.Object sender, System.EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new Categorias.Comedia());

            }
            catch (Exception ex)
            {
                DisplayAlert("Não encontrado", ex.Message, "OK");
            }
        }

        private void Button_Clicked_3(System.Object sender, System.EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new Categorias.Terror());

            }
            catch (Exception ex)
            {
                DisplayAlert("Não encontrado", ex.Message, "OK");
            }
        }

        private void Button_Clicked_4(System.Object sender, System.EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new Categorias.Drama());

            }
            catch (Exception ex)
            {
                DisplayAlert("Não encontrado", ex.Message, "OK");
            }
        }

        private void Button_Clicked_5(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new Categorias.Romance());

            }
            catch (Exception ex)
            {
                DisplayAlert("Não encontrado", ex.Message, "OK");
            }
        }

        private void Button_Clicked_6(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new Categorias.Infantil());

            }
            catch (Exception ex)
            {
                DisplayAlert("Não encontrado", ex.Message, "OK");
            }
        }

        private void Button_Clicked_7(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new Categorias.Animacao());

            }
            catch (Exception ex)
            {
                DisplayAlert("Não encontrado", ex.Message, "OK");
            }
        }
    }
}
