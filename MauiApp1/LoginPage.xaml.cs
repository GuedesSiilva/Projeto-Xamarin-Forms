namespace MauiApp1;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
	}

    private async void btnEntrar_Clicked(object sender, EventArgs e)
    {
		if (usuarioInput.Text == "dg" && senhaInput.Text == "123")
		{
			App.Current.MainPage = new AppShell();
        }
		else {
			await DisplayAlert("Alerta", "Usuário com senha inválida", "OK");
		}
    }
}