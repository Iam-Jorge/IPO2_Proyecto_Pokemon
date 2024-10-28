using Pokemon_Antonio_Campallo_Gomez;
using Microsoft.Toolkit.Uwp.Notifications;
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
    /// 

    public sealed partial class CombatePage : Page
    {
        int turno;

        public CombatePage()
        {
            this.InitializeComponent();
            articunoCombate1.verFondo(false); articunoCombate2.verFondo(false);
            articunoCombate1.verFilaVida(false); articunoCombate2.verFilaVida(false);
            articunoCombate1.verFilaEnergia(false); articunoCombate2.verFilaEnergia(false);
            articunoCombate1.verNombre(false); articunoCombate2.verNombre(false);
            articunoCombate1.Vida = 100; articunoCombate2.Vida = 100;
            articunoCombate1.Energia = 100; articunoCombate2.Energia = 100;

            chandelureCombate1.verFondo(false); chandelureCombate2.verFondo(false);
            chandelureCombate1.verFilaVida(false); chandelureCombate2.verFilaVida(false);
            chandelureCombate1.verFilaEnergia(false); chandelureCombate2.verFilaEnergia(false);
            chandelureCombate1.verNombre(false); chandelureCombate2.verNombre(false);
            chandelureCombate1.Vida = 100; chandelureCombate2.Vida = 100;
            chandelureCombate1.Energia = 100; chandelureCombate2.Energia = 100;

            ((iPokemon)lucarioCombate1).verFondo(false); ((iPokemon)lucarioCombate2).verFondo(false);
            ((iPokemon)lucarioCombate1).verFilaVida(false); ((iPokemon)lucarioCombate2).verFilaVida(false);
            ((iPokemon)lucarioCombate1).verFilaEnergia(false); ((iPokemon)lucarioCombate2).verFilaEnergia(false);
            ((iPokemon)lucarioCombate1).verNombre(false); ((iPokemon)lucarioCombate2).verNombre(false);
            ((iPokemon)lucarioCombate1).verPocionEnergia(false); ((iPokemon)lucarioCombate2).verPocionEnergia(false);
            ((iPokemon)lucarioCombate1).verPocionVida(false); ((iPokemon)lucarioCombate2).verPocionVida(false);
            ((iPokemon)lucarioCombate1).Vida = 100; ((iPokemon)lucarioCombate2).Vida = 100;
            ((iPokemon)lucarioCombate1).Energia = 100; ((iPokemon)lucarioCombate2).Energia = 100;

            butterfreeCombate1.verFondo(false); butterfreeCombate2.verFondo(false);
            butterfreeCombate1.verFilaVida(false); butterfreeCombate2.verFilaVida(false);
            butterfreeCombate1.verFilaEnergia(false); butterfreeCombate2.verFilaEnergia(false);
            butterfreeCombate1.verNombre(false); butterfreeCombate2.verNombre(false);
            butterfreeCombate1.Vida = 100; butterfreeCombate2.Vida = 100;
            butterfreeCombate1.Energia = 100; butterfreeCombate2.Energia = 100;
            butterfreeCombate1.verPocionEnergia(false); butterfreeCombate2.verPocionEnergia(false);
            butterfreeCombate1.verPocionVida(false); butterfreeCombate2.verPocionVida(false);
            
            gengarCombate1.verFondo(false); gengarCombate2.verFondo(false);
            gengarCombate1.verFilaVida(false); gengarCombate2.verFilaVida(false);
            gengarCombate1.verFilaEnergia(false); gengarCombate2.verFilaEnergia(false);
            gengarCombate1.verNombre(false); gengarCombate2.verNombre(false);
            gengarCombate1.Vida = 100; gengarCombate2.Vida = 100;
            gengarCombate1.Energia = 100; gengarCombate2.Energia = 100;
            gengarCombate1.verPocionEnergia(false); gengarCombate2.verPocionEnergia(false);
            gengarCombate1.verPocionVida(false); gengarCombate2.verPocionVida(false);

            laprasCombate1.verFondo(false); laprasCombate2.verFondo(false);
            laprasCombate1.verFilaVida(false); laprasCombate2.verFilaVida(false);
            laprasCombate1.verFilaEnergia(false); laprasCombate2.verFilaEnergia(false);
            laprasCombate1.verNombre(false); laprasCombate2.verNombre(false);
            laprasCombate1.Vida = 100; laprasCombate2.Vida = 100;
            laprasCombate1.Energia = 100; laprasCombate2.Energia = 100;

            makuhitaCombate1.verFondo(false); makuhitaCombate2.verFondo(false);
            makuhitaCombate1.verFilaVida(false); makuhitaCombate2.verFilaVida(false);
            makuhitaCombate1.verFilaEnergia(false); makuhitaCombate2.verFilaEnergia(false);
            makuhitaCombate1.verNombre(false); makuhitaCombate2.verNombre(false);
            makuhitaCombate1.Vida = 100; makuhitaCombate2.Vida = 100;
            makuhitaCombate1.Energia = 100; makuhitaCombate2.Energia = 100;
            makuhitaCombate1.verPocionEnergia(false); makuhitaCombate2.verPocionEnergia(false);
            makuhitaCombate1.verPocionVida(false); makuhitaCombate2.verPocionVida(false);

            scizorCombate1.verFondo(false); scizorCombate2.verFondo(false);
            scizorCombate1.verFilaVida(false); scizorCombate2.verFilaVida(false);
            scizorCombate1.verFilaEnergia(false); scizorCombate2.verFilaEnergia(false);
            scizorCombate1.verNombre(false); scizorCombate2.verNombre(false);
            scizorCombate1.Vida = 100; scizorCombate2.Vida = 100;
            scizorCombate1.Energia = 100; scizorCombate2.Energia = 100;
            scizorCombate1.verPocionEnergia(false); scizorCombate2.verPocionEnergia(false);
            scizorCombate1.verPocionVida(false); scizorCombate2.verPocionVida(false);

            snorlaxCombate1.verFondo(false); snorlaxCombate2.verFondo(false);
            snorlaxCombate1.verFilaVida(false); snorlaxCombate2.verFilaVida(false);
            snorlaxCombate1.verFilaEnergia(false); snorlaxCombate2.verFilaEnergia(false);
            snorlaxCombate1.verNombre(false); snorlaxCombate2.verNombre(false);
            snorlaxCombate1.Vida = 100; snorlaxCombate2.Vida = 100;
            snorlaxCombate1.Energia = 100; snorlaxCombate2.Energia = 100;
            snorlaxCombate1.verPocionEnergia(false); snorlaxCombate2.verPocionEnergia(false);
            snorlaxCombate1.verPocionVida(false); snorlaxCombate2.verPocionVida(false);

            toxicroackCombate1.verFondo(false); toxicroackCombate2.verFondo(false);
            toxicroackCombate1.verFilaVida(false); toxicroackCombate2.verFilaVida(false);
            toxicroackCombate1.verFilaEnergia(false); toxicroackCombate2.verFilaEnergia(false);
            toxicroackCombate1.verNombre(false); toxicroackCombate2.verNombre(false);
            toxicroackCombate1.Vida = 100; toxicroackCombate2.Vida = 100;
            toxicroackCombate1.Energia = 100; toxicroackCombate2.Energia = 100;
            toxicroackCombate1.verPocionEnergia(false); toxicroackCombate2.verPocionEnergia(false);
            toxicroackCombate1.verPocionVida(false); toxicroackCombate2.verPocionVida(false);

            charizardCombate1.verFondo(false); charizardCombate2.verFondo(false);
            charizardCombate1.verFilaVida(false); charizardCombate2.verFilaVida(false);
            charizardCombate1.verFilaEnergia(false); charizardCombate2.verFilaEnergia(false);
            charizardCombate1.verNombre(false); charizardCombate2.verNombre(false);
            charizardCombate1.Vida = 100; charizardCombate2.Vida = 100;
            charizardCombate1.Energia = 100; charizardCombate2.Energia = 100;
            charizardCombate1.verPocionEnergia(false); charizardCombate2.verPocionEnergia(false);
            charizardCombate1.verPocionVida(false); charizardCombate2.verPocionVida(false);

            garchompCombate1.verFondo(false); garchompCombate2.verFondo(false);
            garchompCombate1.verFilaVida(false); garchompCombate2.verFilaVida(false);
            garchompCombate1.verFilaEnergia(false); garchompCombate2.verFilaEnergia(false);
            garchompCombate1.verNombre(false); garchompCombate2.verNombre(false);
            garchompCombate1.Vida = 100; garchompCombate2.Vida = 100;
            garchompCombate1.Energia = 100; garchompCombate2.Energia = 100;




        }

        public void jugador2NoJuega()
        {
            controlesJugador2.Visibility = Visibility.Collapsed;
            controlesJugador1.Visibility = Visibility.Visible;
            textEsperar2.Text = "Es el turno del jugador 1.";
            textEsperar2.Visibility = Visibility.Visible;
            textEsperar1.Visibility = Visibility.Collapsed;
        }

        public void jugador2SiJuega()
        {
            controlesJugador1.Visibility = Visibility.Collapsed;
            controlesJugador2.Visibility = Visibility.Visible;
            textEsperar1.Text = "Es el turno del jugador 2.";
            textEsperar1.Visibility = Visibility.Visible;
            textEsperar2.Visibility = Visibility.Collapsed;
        }

        public int azarTurno()
        {
            Random rnd = new Random();
            return rnd.Next(0, 2);
        }

        private async void clickJugador1(object sender, RoutedEventArgs e)
        {
            flipJugador1.IsEnabled = false;
            btnElegirPokemon1.Visibility = Visibility.Collapsed;
            //controlesJugador1.Visibility = Visibility.Visible;
            iPokemon pokemonSeleccionado = flipJugador1.SelectedItem as iPokemon;
            pokemonSeleccionado.verFilaEnergia(true);
            pokemonSeleccionado.verFilaVida(true);
            pokemonSeleccionado.verPocionEnergia(false);
            pokemonSeleccionado.verPocionVida(false);
            if (flipJugador1.IsEnabled == false && flipJugador2.IsEnabled == false)
            {
                turno = azarTurno();
                if (turno == 1)
                {
                    jugador2NoJuega();
                }
                else
                {
                    jugador2SiJuega();
                    await Task.Delay(3000); // Espera 3 segundos
                }
            }
        }

        public int calcular_daño_fuerte()
        {
            int dañoTotal = 0;
            Random r = new Random();
            int random = r.Next(1, 100);
            if (random < 60)
            {
                dañoTotal = 20;
            }
            else if (random <= 90)
            {
                dañoTotal = (int)Math.Round((double)random / 3);
            }
            else
            {
                dañoTotal = 40;
            }
            return dañoTotal;
        }

        public int calcular_daño_flojo()
        {
            return 15;
        }

        private async void btnAtacar1_Click(object sender, RoutedEventArgs e)
        {
            if (flipJugador1.SelectedItem is iPokemon atacante && flipJugador2.SelectedItem is iPokemon defensor)
            {
                double vidaActual = defensor.Vida;
                double energiaActual = atacante.Energia;
                if (atacante.Energia > 60)
                {
                    atacante.animacionAtaqueFuerte();
                    defensor.Vida -= calcular_daño_fuerte();
                }
                else
                {
                    atacante.animacionAtaqueFlojo();
                    defensor.Vida -= calcular_daño_flojo();
                }

                if (atacante.Energia > 50)
                {
                    atacante.Energia -= 25;
                }
                else
                {
                    atacante.Energia -= 15;
                }
                controlesJugador1.Visibility = Visibility.Collapsed;
                textEsperar1.Text = "El jugador 1 ha decidido atacar.";
                textEsperar1.Visibility = Visibility.Visible;
                await Task.Delay(10000); // Espera 10 segundos

                if (atacante.Energia <= 30 && energiaActual > 30)
                {
                    atacante.animacionCansado();
                    await Task.Delay(5000); // Espera 5 segundos
                }

                if (defensor.Vida <= 0)
                {
                    defensor.animacionDerrota();
                    textEsperar2.Text = "Pokemon debilitado.";
                    await Task.Delay(5000); // Espera 5 segundos
                    imageFinalCombate.Visibility = Visibility.Visible;
                    txtMensajeVictoria.Text = "¡Ha ganado el jugador 1!";
                    txtMensajeVictoria.Visibility = Visibility.Visible;

                    //NOTIFICACION
                    new ToastContentBuilder().AddArgument("action","victoriaJugador1").AddArgument("ConversationId", 9813).AddText("¡El jugador 1 ha ganado el combate!").AddAppLogoOverride(new Uri("ms-appx:///Assets/victoria.jpg"),ToastGenericAppLogoCrop.Circle).Show();
                }
                else if (defensor.Vida > 0 && defensor.Vida <= 30 && vidaActual > 30)
                {
                    defensor.animacionHerido();
                    await Task.Delay(5000); // Espera 5 segundos
                    jugador2SiJuega();
                    await Task.Delay(10000); // Espera 10 segundos
                }
                else
                {
                    jugador2SiJuega();
                    await Task.Delay(10000); // Espera 10 segundos
                }


            }
        }

        private async void btnRendirse1_Click(object sender, RoutedEventArgs e)
        {
            controlesJugador1.Visibility = Visibility.Collapsed;
            iPokemon miPokemon = flipJugador1.SelectedItem as iPokemon;
            miPokemon.animacionDerrota();
            textEsperar1.Text = "El jugador 1 ha decidido rendirse.";
            textEsperar1.Visibility = Visibility.Visible;
            await Task.Delay(5000); // Espera 5 segundos
            imageFinalCombate.Visibility = Visibility.Visible;
            txtMensajeVictoria.Text = "¡Ha ganado el jugador 2!";
            txtMensajeVictoria.Visibility = Visibility.Visible;
            //Notificación
            new ToastContentBuilder().AddArgument("action", "victoriaJugador2").AddArgument("ConversationId", 9813).AddText("¡El jugador 2 ha ganado el combate!").AddAppLogoOverride(new Uri("ms-appx:///Assets/victoria.jpg"), ToastGenericAppLogoCrop.Circle).Show();

        }

        private async void btnCurarse1_Click(object sender, RoutedEventArgs e)
        {
            controlesJugador1.Visibility = Visibility.Collapsed;
            iPokemon pokemonSeleccionado = flipJugador1.SelectedItem as iPokemon;
            double vidaActual = pokemonSeleccionado.Vida;
            if (pokemonSeleccionado.Vida > 75)
            {
                pokemonSeleccionado.Vida = 100;
            }
            else
            {
                pokemonSeleccionado.Vida += 20;
            }

            pokemonSeleccionado.animacionDescasar();
            textEsperar1.Text = "El jugador 1 ha decidido curarse.";
            textEsperar1.Visibility = Visibility.Visible;
            await Task.Delay(5000); // Espera 5 segundos
            if (pokemonSeleccionado.Vida > 30 && vidaActual <= 30)
            {
                pokemonSeleccionado.animacionNoHerido();
                await Task.Delay(5000); // Espera 5 segundos
            }
            jugador2SiJuega();
            await Task.Delay(10000); // Espera 10 segundos
        }

        private async void btnEnergia1_Click(object sender, RoutedEventArgs e)
        {
            controlesJugador1.Visibility = Visibility.Collapsed;
            iPokemon pokemonEnergia = flipJugador1.SelectedItem as iPokemon;
            double energiaActual = pokemonEnergia.Energia;
            if (pokemonEnergia.Energia > 75)
            {
                pokemonEnergia.Energia = 100;
            }
            else
            {
                pokemonEnergia.Energia += 20;
            }
            pokemonEnergia.animacionDefensa();
            textEsperar1.Text = "El jugador 1 ha decidido subir su energía.";
            textEsperar1.Visibility = Visibility.Visible;
            await Task.Delay(8000); // Espera 8 segundos
            if (pokemonEnergia.Energia > 30 && energiaActual <= 30)
            {
                pokemonEnergia.animacionNoCansado();
                await Task.Delay(5000); // Espera 5 segundos
            }
            jugador2SiJuega();
            await Task.Delay(10000); // Espera 10 segundos
        }
        
        private async void clickJugador2(object sender, RoutedEventArgs e)
        {
            flipJugador2.IsEnabled = false;
            btnElegirPokemon2.Visibility = Visibility.Collapsed;
            iPokemon pokemonSeleccionado = flipJugador2.SelectedItem as iPokemon;
            pokemonSeleccionado.verFilaEnergia(true);
            pokemonSeleccionado.verFilaVida(true);
            pokemonSeleccionado.verPocionEnergia(false);
            pokemonSeleccionado.verPocionVida(false);
            if (flipJugador1.IsEnabled == false && flipJugador2.IsEnabled == false)
            {
                turno = azarTurno();
                if (turno == 1)
                {
                    jugador2NoJuega();
                }
                else
                {
                    jugador2SiJuega();
                    await Task.Delay(3000); // Espera 3 segundos
                }
            }
        }
        
        private async void btnAtacar2_Click(object sender, RoutedEventArgs e)
        {
            if (flipJugador2.SelectedItem is iPokemon atacante && flipJugador1.SelectedItem is iPokemon defensor)
            {
                double vidaActual = defensor.Vida;
                double energiaActual = atacante.Energia;
                if (atacante.Energia > 60)
                {
                    atacante.animacionAtaqueFuerte();
                    defensor.Vida -= calcular_daño_fuerte();
                }
                else
                {
                    atacante.animacionAtaqueFlojo();
                    defensor.Vida -= calcular_daño_flojo();
                }

                if (atacante.Energia > 50)
                {
                    atacante.Energia -= 25;
                }
                else
                {
                    atacante.Energia -= 15;
                }
                controlesJugador2.Visibility = Visibility.Collapsed;
                textEsperar2.Text = "El jugador 2 ha decidido atacar.";
                textEsperar2.Visibility = Visibility.Visible;
                await Task.Delay(10000); // Espera 10 segundos

                if (atacante.Energia <= 30 && energiaActual > 30)
                {
                    atacante.animacionCansado();
                    await Task.Delay(5000); // Espera 5 segundos
                }

                if (defensor.Vida <= 0)
                {
                    defensor.animacionDerrota();
                    textEsperar1.Text = "Pokemon debilitado.";
                    await Task.Delay(5000); // Espera 5 segundos
                    imageFinalCombate.Visibility = Visibility.Visible;
                    txtMensajeVictoria.Text = "¡Ha ganado el jugador 2!";
                    txtMensajeVictoria.Visibility = Visibility.Visible;
                    //NOTIFICACION
                    new ToastContentBuilder().AddArgument("action", "victoriaJugador2").AddArgument("ConversationId", 9813).AddText("¡El jugador 2 ha ganado el combate!").AddAppLogoOverride(new Uri("ms-appx:///Assets/victoria.jpg"), ToastGenericAppLogoCrop.Circle).Show();
                }
                else if (defensor.Vida > 0 && defensor.Vida <= 30 && vidaActual > 30)
                {
                    defensor.animacionHerido();
                    await Task.Delay(5000); // Espera 5 segundos
                    jugador2NoJuega();
                    await Task.Delay(10000); // Espera 10 segundos
                }
                else
                {
                    jugador2NoJuega();
                    await Task.Delay(10000); // Espera 10 segundos
                }


            }
        }

        private async void btnRendirse2_Click(object sender, RoutedEventArgs e)
        {
            controlesJugador2.Visibility = Visibility.Collapsed;
            iPokemon miPokemon = flipJugador2.SelectedItem as iPokemon;
            miPokemon.animacionDerrota();
            textEsperar2.Text = "El jugador 2 ha decidido rendirse.";
            textEsperar2.Visibility = Visibility.Visible;
            await Task.Delay(5000); // Espera 5 segundos
            imageFinalCombate.Visibility = Visibility.Visible;
            txtMensajeVictoria.Text = "¡Ha ganado el jugador 1!";
            txtMensajeVictoria.Visibility = Visibility.Visible;
            //Notificación
            //NOTIFICACION
            new ToastContentBuilder().AddArgument("action", "victoriaJugador1").AddArgument("ConversationId", 9813).AddText("¡El jugador 1 ha ganado el combate!").AddAppLogoOverride(new Uri("ms-appx:///Assets/victoria.jpg"), ToastGenericAppLogoCrop.Circle).Show();
        }

        private async void btnCurarse2_Click(object sender, RoutedEventArgs e)
        {
            controlesJugador2.Visibility = Visibility.Collapsed;
            iPokemon pokemonSeleccionado = flipJugador2.SelectedItem as iPokemon;
            double vidaActual = pokemonSeleccionado.Vida;
            if (pokemonSeleccionado.Vida > 75)
            {
                pokemonSeleccionado.Vida = 100;
            }
            else
            {
                pokemonSeleccionado.Vida += 20;
            }

            pokemonSeleccionado.animacionDescasar();
            textEsperar2.Text = "El jugador 2 ha decidido curarse.";
            textEsperar2.Visibility = Visibility.Visible;
            await Task.Delay(5000); // Espera 5 segundos
            if (pokemonSeleccionado.Vida > 30 && vidaActual <= 30)
            {
                pokemonSeleccionado.animacionNoHerido();
                await Task.Delay(5000); // Espera 5 segundos
            }
            jugador2NoJuega();
            await Task.Delay(10000); // Espera 10 segundos
        }

        private async void btnEnergia2_Click(object sender, RoutedEventArgs e)
        {
            controlesJugador2.Visibility = Visibility.Collapsed;
            iPokemon pokemonEnergia = flipJugador2.SelectedItem as iPokemon;
            double energiaActual = pokemonEnergia.Energia;
            if (pokemonEnergia.Energia > 75)
            {
                pokemonEnergia.Energia = 100;
            }
            else
            {
                pokemonEnergia.Energia += 20;
            }
            pokemonEnergia.animacionDefensa();
            textEsperar2.Text = "El jugador 2 ha decidido subir su energía.";
            textEsperar2.Visibility = Visibility.Visible;
            await Task.Delay(8000); // Espera 8 segundos
            if (pokemonEnergia.Energia > 30 && energiaActual <= 30)
            {
                pokemonEnergia.animacionNoCansado();
                await Task.Delay(5000); // Espera 5 segundos
            }
            jugador2NoJuega();
            await Task.Delay(10000); // Espera 10 segundos
        }
        
    }
}
