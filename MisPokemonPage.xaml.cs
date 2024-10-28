using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace IPO_2024_IPokemon_AntonioGeorgiNoelia
{

    public sealed partial class MisPokemonPage : Page
    {

        public MisPokemonPage()
        {
            this.InitializeComponent();
            List<PokemonPokedex> misPokemons = PokedexPage.pokemons.Where(p => p.Name == "Chandelure" || p.Name == "Lucario" || p.Name == "Articuno").ToList();
            GridViewMisPokemons.ItemsSource = misPokemons;
        }

        private void MisPokemons_ItemClick(object sender, RoutedEventArgs e)
        {
            var button = (Button)sender;
            var pokemon = (PokemonPokedex)button.CommandParameter;
            fmMisPokemon.Navigate(typeof(DetallesPokemon), pokemon);
        }


    }
}
