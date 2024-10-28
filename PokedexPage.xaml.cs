using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Pokemon_Antonio_Campallo_Gomez;


namespace IPO_2024_IPokemon_AntonioGeorgiNoelia
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    /// 
    public class PokemonType
    {
        public string TypeName { get; set; }
        public string Color { get; set; }

    }


    public class PokemonPokedex
    {
        public string Name { get; set; }
        public string Image { get; set; }
        public string ImagePath { get; set; }
        public string ImageName { get; set; }
        public List<PokemonType> Types { get; set; } = new List<PokemonType>();

        private static Random random = new Random();

        public string GenderIcon
        {
            get
            {
                return random.Next(2) == 0 ? "♂" : "♀";
            }
        }
    }

    public sealed partial class PokedexPage : Page
    {


        private void InfoPokemon(object sender, ItemClickEventArgs e)
        {
            if (e.ClickedItem is PokemonPokedex clickedPokemon)
            {
                fmPokedex.Navigate(typeof(DetallesPokemon), clickedPokemon);
            }
        }



        public static List<PokemonPokedex> pokemons = new List<PokemonPokedex>
        {
            new PokemonPokedex { Name = "Articuno", Image = "/Assets/ArticunoPokedex.png", ImagePath = "/Assets/Articuno.jpg", ImageName = "/Assets/ArticunoTexto.png", Types = new List<PokemonType> { new PokemonType { TypeName = "Hielo", Color = "#98D8D8" }, new PokemonType { TypeName = "Volador", Color = "#A890F0" } } },
            new PokemonPokedex { Name = "Butterfree", Image = "/Assets/ButterFreePokedex.png", Types = new List<PokemonType> { new PokemonType { TypeName = "Bicho", Color = "#A8B820" }, new PokemonType { TypeName = "Volador", Color = "#A890F0" } } },
            new PokemonPokedex { Name = "Chandelure", Image = "/Assets/ChandelurePokedex.png", ImagePath = "/Assets/Chandelure.png", ImageName = "/Assets/ChandelureTexto.png",  Types = new List<PokemonType> { new PokemonType { TypeName = "Fantasma", Color = "#705898" }, new PokemonType { TypeName = "Fuego", Color = "#F08030" } } },
            new PokemonPokedex { Name = "Charizard", Image = "/Assets/CharizardPokedex.png", Types = new List<PokemonType> { new PokemonType { TypeName = "Fuego", Color = "#F08030" }, new PokemonType { TypeName = "Volador", Color = "#A890F0" } } },
            new PokemonPokedex { Name = "Garchomp", Image = "/Assets/GarchompPokedex.png", Types = new List<PokemonType> { new PokemonType { TypeName = "Dragón", Color = "#7038F8" }, new PokemonType { TypeName = "Tierra", Color = "#E0C068" } } },
            new PokemonPokedex { Name = "Gengar", Image = "/Assets/GengarPokedex.png", Types = new List<PokemonType> { new PokemonType { TypeName = "Fantasma", Color = "#705898" }, new PokemonType { TypeName = "Veneno", Color = "#A040A0" } } },
            new PokemonPokedex { Name = "Lapras", Image = "/Assets/LaprasPokedex.png", Types = new List<PokemonType> { new PokemonType { TypeName = "Agua", Color = "#6890F0" }, new PokemonType { TypeName = "Hielo", Color = "#98D8D8" } } },
            new PokemonPokedex { Name = "Lucario", Image = "/Assets/LucarioPokedex.png", ImagePath = "/Assets/Lucario.jpg", ImageName = "/Assets/LucarioTexto.png", Types = new List<PokemonType> { new PokemonType { TypeName = "Lucha", Color = "#C03028" }, new PokemonType { TypeName = "Acero", Color = "#B8B8D0" } } },
            new PokemonPokedex { Name = "Makuhita", Image = "/Assets/MakuhitaPokedex.png", Types = new List<PokemonType> { new PokemonType { TypeName = "Lucha", Color = "#C03028" } } },
            new PokemonPokedex { Name = "Scizor", Image = "/Assets/ScizorPokedex.png", Types = new List<PokemonType> { new PokemonType { TypeName = "Bicho", Color = "#A8B820" }, new PokemonType { TypeName = "Acero", Color = "#B8B8D0" } } },
            new PokemonPokedex { Name = "Snorlax", Image = "/Assets/SnorlaxPokedex.png", Types = new List<PokemonType> { new PokemonType { TypeName = "Normal", Color = "#A8A878" } } },
            new PokemonPokedex { Name = "Toxicroak", Image="/Assets/ToxicroakPokedex.png", Types = new List<PokemonType> { new PokemonType { TypeName = "Veneno", Color = "#A040A0" }, new PokemonType { TypeName = "Lucha", Color = "#C03028" } } },
        };

        public ObservableCollection<GroupInfoCollection<PokemonPokedex>> PokemonsGrouped { get; set; }

        public PokedexPage()
        {
            this.InitializeComponent();
            GroupPokemons();
            DataContext = this;
        }

        private void GroupPokemons()
        {
            PokemonsGrouped = new ObservableCollection<GroupInfoCollection<PokemonPokedex>>(
                pokemons.GroupBy(p => p.Name[0])
                        .OrderBy(g => g.Key)
                        .Select(g => new GroupInfoCollection<PokemonPokedex>(g) { Key = g.Key }));
        }

        private void SearchBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            FilterPokemon();
        }

        private void TypeSearchBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            FilterPokemon();
        }

        private void FilterPokemon()
        {
            string searchText = NameSearchBox.Text.ToLower().Trim();
            string typeText = TypeSearchBox.Text.ToLower().Trim();

            var filteredList = pokemons.Where(p =>
                p.Name.ToLower().StartsWith(searchText) &&
                p.Types.Any(t => t.TypeName.ToLower().Contains(typeText))
            ).ToList();

            UpdatePokemonList(filteredList);
        }

        private void UpdatePokemonList(List<PokemonPokedex> filteredList)
        {
            PokemonsGrouped.Clear();
            var grouped = filteredList.GroupBy(p => p.Name[0])
                                      .OrderBy(g => g.Key)
                                      .Select(g => new GroupInfoCollection<PokemonPokedex>(g) { Key = g.Key });

            foreach (var group in grouped)
            {
                PokemonsGrouped.Add(group);
            }
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }

    public class GroupInfoCollection<T> : ObservableCollection<T>
    {
        public char Key { get; set; }
        public GroupInfoCollection(IEnumerable<T> items) : base(items) { }
    }

}




