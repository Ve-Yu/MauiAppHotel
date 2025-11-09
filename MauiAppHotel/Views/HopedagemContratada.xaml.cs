namespace MauiAppHotel.Views;

public partial class HopedagemContratada : ContentPage
{
	public HopedagemContratada()
	{
		InitializeComponent();
	}

    private void Button_Clicked_1(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new Sobre());

        }
        catch (Exception ex)
        {
            DisplayAlert("Ops", ex.Message, "OK");
        }

        
    }
}