namespace MauiAppFlix.Categorias;

public partial class Infantil : ContentPage
{
	public Infantil()
	{
		InitializeComponent();
	}

    private void bntCoraline_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new Filmes.coraline());

        }
        catch (Exception ex)
        {
            DisplayAlert("Não encontrado", ex.Message, "OK");
        }
    }

    private void bntGatoDeBotas_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new Filmes.gatodebotas());

        }
        catch (Exception ex)
        {
            DisplayAlert("Não encontrado", ex.Message, "OK");
        }
    }
}