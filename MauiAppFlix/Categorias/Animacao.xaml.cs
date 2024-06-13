namespace MauiAppFlix.Categorias;

public partial class Animacao : ContentPage
{
	public Animacao()
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