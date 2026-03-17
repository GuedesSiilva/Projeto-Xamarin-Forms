using MauiApp1.Models;
using MauiApp1.Services;
using System.Collections.ObjectModel;

namespace MauiApp1;

public partial class RankingPage : ContentPage
{
    public ObservableCollection<ParticipanteViewModel> ListaRanking { get; set; } = new ObservableCollection<ParticipanteViewModel>();
    public RankingPage()
    {
        InitializeComponent();
        BindingContext = this;
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        LoadData();
    }

    private async Task LoadData()
    {
        var listaRanking = await ApiServices<ParticipanteViewModel>.getList("Ranking");

        foreach (var item in listaRanking.OrderByDescending(x => x.Pontos))
        {
            ListaRanking.Add(item);
        }
        
    }
}