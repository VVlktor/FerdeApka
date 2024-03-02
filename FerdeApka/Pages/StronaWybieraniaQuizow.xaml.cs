using FerdeApka.Classes;

namespace FerdeApka.Pages;

public partial class StronaWybieraniaQuizow : ContentPage
{
	public StronaWybieraniaQuizow()
	{
		InitializeComponent();
        WypiszWyniki();
	}

    public void WypiszWyniki()
    {
        WynikQuizuOOdcinkach.Text = $"{Preferences.Default.Get("Quiz o odcinkach", 0)}/10";
        WynikQuizuOPostaciach.Text = $"{Preferences.Default.Get("Quiz o postaciach", 0)}/10";
        WynikQuizuOTworzeniuSerialu.Text = $"{Preferences.Default.Get("Quiz o tworzeniu serialu", 0)}/10";//zmienic aby przystosowac do wiekszej ilosci quizow(automatyzacja) (tym razem nie zapomniec)
    }

    private async void PrzejdzDoStronyzQuziemOPostaciach(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new StronaQuizu("Quiz o postaciach"));
    }

    private async void PrzejdzDoStronyzQuziemOOdcinkach(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new StronaQuizu("Quiz o odcinkach"));
    }

    private async void PrzejdzDoStronyzQuziemOTworzeniuSerialu(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new StronaQuizu("Quiz o tworzeniu serialu"));
    }
}