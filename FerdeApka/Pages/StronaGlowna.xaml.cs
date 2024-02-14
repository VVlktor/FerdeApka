using CommunityToolkit.Maui.Views;
using FerdeApka.Pages.Popuppages;

namespace FerdeApka.Pages;

public partial class StronaGlowna : ContentPage
{
	public StronaGlowna()
	{
        InitializeComponent();   
    }

    public StronaGlowna(string doKad)
    {
        InitializeComponent();
        if (doKad == "StronaWybieraniaQuizow")
        {
            PrzejdzmyDoStronyQuizow();
        }
    }

    public async void PrzejdzmyDoStronyQuizow()
    {
        await Navigation.PushAsync(new StronaWybieraniaQuizow());
    }

    private async void PrzejdzDoStronySoundbarow(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new SoundbarMenu());
    }

    private void PokazPopupOAplikacji(object sender, EventArgs e)
    {
        this.ShowPopup(new PopupInfoOAplikacji());
    }

    private void LogoFerdkaKlikniete(object sender, EventArgs e)
    {
        if (DzwiekNaGlownymEkranie.CurrentState == CommunityToolkit.Maui.Core.Primitives.MediaElementState.Paused || DzwiekNaGlownymEkranie.CurrentState == CommunityToolkit.Maui.Core.Primitives.MediaElementState.Stopped)
        {
            DzwiekNaGlownymEkranie.SeekTo(TimeSpan.Zero);
            DzwiekNaGlownymEkranie.Play();
        }
    }

    private async void PrzejdzDoStronyQuizow(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new StronaWybieraniaQuizow());
    }

    private async void PrzejdzDoStronyMemow(object sender, EventArgs e)
    {
        NetworkAccess czyJestNet = Connectivity.Current.NetworkAccess;

        if (czyJestNet == NetworkAccess.Internet)
        {
            await Navigation.PushAsync(new StronaMemow());
        }
        else
        {
            this.ShowPopup(new PopupPotrzebnyInternet());
        }
        
    }

    private async void PrzejdzDoStronyDaily(object sender, EventArgs e)
    {
        NetworkAccess czyJestNet = Connectivity.Current.NetworkAccess;

        if (czyJestNet == NetworkAccess.Internet)
        {
            await Navigation.PushAsync(new StronaDaily());
        }
        else
        {
            this.ShowPopup(new PopupPotrzebnyInternet());
        }
    }

    private async void PrzejdzDoStronyClicker(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new StronaClicker());
    }
}