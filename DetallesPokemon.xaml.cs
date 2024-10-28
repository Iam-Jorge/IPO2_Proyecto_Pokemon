using Pokemon_Antonio_Campallo_Gomez;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace IPO_2024_IPokemon_AntonioGeorgiNoelia
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class DetallesPokemon : Page
    {
        private iPokemon currentPokemon;

        public DetallesPokemon()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            PokemonPokedex id = e.Parameter as PokemonPokedex;

            switch (id.Name)
            {
                case "Articuno":
                    articuno.Visibility = Visibility.Visible;
                    articuno.verFilaEnergia(false);
                    articuno.verFilaVida(false);
                    currentPokemon = articuno;
                    break;
                case "Butterfree":
                    butterfree.Visibility = Visibility.Visible;
                    butterfree.verFilaEnergia(false);
                    butterfree.verFilaVida(false);
                    butterfree.verPocionEnergia(false);
                    butterfree.verPocionVida(false);
                    currentPokemon = butterfree;
                    break;
                case "Chandelure":
                    chandelure.Visibility = Visibility.Visible;
                    chandelure.verFilaEnergia(false);
                    chandelure.verFilaVida(false);
                    currentPokemon = chandelure;
                    break;
                case "Charizard":
                    charizard.Visibility = Visibility.Visible;
                    charizard.verFilaEnergia(false);
                    charizard.verFilaVida(false);
                    charizard.verPocionEnergia(false);
                    charizard.verPocionVida(false);
                    currentPokemon = charizard;
                    break;
                case "Garchomp":
                    garchomp.Visibility = Visibility.Visible;
                    garchomp.verFilaEnergia(false);
                    garchomp.verFilaVida(false);
                    garchomp.verPocionEnergia(false);
                    garchomp.verPocionVida(false);
                    currentPokemon = garchomp;
                    break;
                case "Gengar":
                    gengar.Visibility = Visibility.Visible;
                    gengar.verFilaEnergia(false);
                    gengar.verFilaVida(false);
                    gengar.verPocionEnergia(false);
                    gengar.verPocionVida(false);
                    currentPokemon = gengar;
                    break;
                case "Lapras":
                    lapras.Visibility = Visibility.Visible;
                    lapras.verFilaEnergia(false);
                    lapras.verFilaVida(false);
                    lapras.verPocionEnergia(false);
                    lapras.verPocionVida(false);
                    currentPokemon = lapras;
                    break;
                case "Lucario":
                    lucario.Visibility = Visibility.Visible;
                    currentPokemon = lucario;
                    ((iPokemon)lucario).verFilaEnergia(false);
                    ((iPokemon)lucario).verFilaVida(false);
                    ((iPokemon)lucario).verPocionEnergia(false);
                    ((iPokemon)lucario).verPocionVida(false);
                    break;
                case "Makuhita":
                    makuhita.Visibility = Visibility.Visible;
                    makuhita.verFilaEnergia(false);
                    makuhita.verFilaVida(false);
                    makuhita.verPocionEnergia(false);
                    makuhita.verPocionVida(false);
                    currentPokemon = makuhita;
                    break;
                case "Scizor":
                    scizor.Visibility = Visibility.Visible;
                    scizor.verFilaEnergia(false);
                    scizor.verFilaVida(false);
                    scizor.verPocionEnergia(false);
                    scizor.verPocionVida(false);
                    currentPokemon = scizor;
                    break;
                case "Snorlax":
                    snorlax.Visibility = Visibility.Visible;
                    snorlax.verFilaEnergia(false);
                    snorlax.verFilaVida(false);
                    snorlax.verPocionEnergia(false);
                    snorlax.verPocionVida(false);
                    currentPokemon = snorlax;
                    break;
                case "Toxicroak":
                    toxicroak.Visibility = Visibility.Visible;
                    toxicroak.verFilaEnergia(false);
                    toxicroak.verFilaVida(false);
                    toxicroak.verPocionEnergia(false);
                    toxicroak.verPocionVida(false);
                    currentPokemon = toxicroak;
                    break;
                default:
                    currentPokemon = articuno;
                    break;

            }

            tbNombrePokedex.Text = "Nombre: " + currentPokemon.Nombre;
            tbCategoriaPokedex.Text = "Categoría: " + currentPokemon.Categoría;
            tbDescripcionPokedex.Text = "Descripción: " + currentPokemon.Descripcion;
            tbAlturaPokedex.Text = "Altura (m): " + currentPokemon.Altura;
            tbPesoPokedex.Text = "Peso (kg): " + currentPokemon.Peso;
            tbEvolucionPokedex.Text = "Evolución: " + currentPokemon.Evolucion;
            tbTipoPokedex.ItemsSource = id.Types;
            pokemonImagenPokedex.Source = new BitmapImage(new Uri("ms-appx://" + id.Image));
        }

        private void todosFalse()
        {
            this.btnAtaqueDebil.IsEnabled = false;
            this.btnAtaqueFuerte.IsEnabled = false;
            this.btnDefensa.IsEnabled = false;
            this.btnHerido.IsEnabled = false;
            this.btnCansado.IsEnabled = false;
            this.btnDescasar.IsEnabled = false;
        }

        private void todosTrue()
        {
            this.btnAtaqueDebil.IsEnabled = true;
            this.btnAtaqueFuerte.IsEnabled = true;
            this.btnDefensa.IsEnabled = true;
            this.btnHerido.IsEnabled = true;
            this.btnCansado.IsEnabled = true;
            this.btnDescasar.IsEnabled = true;
        }

        private async void btnAtaqueFuerte_Click(object sender, RoutedEventArgs e)
        {
            todosFalse();
            currentPokemon.animacionAtaqueFuerte();
            await Task.Delay(8000);
            todosTrue();
          
        }

        private  async void btnAtaqueDebil_Click(object sender, RoutedEventArgs e)
        {
            todosFalse();
            currentPokemon.animacionAtaqueFlojo();
            await Task.Delay(8000);
            todosTrue();
        }

        private async void btnHerido_Click(object sender, RoutedEventArgs e)
        {
            todosFalse();
            currentPokemon.animacionHerido();
            await Task.Delay(3000);
            currentPokemon.animacionNoHerido();
            await Task.Delay(5000);
            todosTrue();
        }

        private async void btnCansado_Click(object sender, RoutedEventArgs e)
        {
            todosFalse();
            currentPokemon.animacionCansado();
            await Task.Delay(3000);
            currentPokemon.animacionNoCansado();
            await Task.Delay(5000);
            todosTrue();
        }

        private async void btnDefensa_Click(object sender, RoutedEventArgs e)
        {
            todosFalse();
            currentPokemon.animacionDefensa();
            await Task.Delay(8000);
            todosTrue();
        }



        private async void btnDescansar_Click(object sender, RoutedEventArgs e)
        {
            todosFalse();
            currentPokemon.animacionDescasar();
            await Task.Delay(8000);
            todosTrue();
        }




    }
}
