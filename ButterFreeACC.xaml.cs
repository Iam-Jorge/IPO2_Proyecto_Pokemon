using Pokemon_Antonio_Campallo_Gomez;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Media.Core;
using Windows.Media.Playback;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Control de usuario está documentada en https://go.microsoft.com/fwlink/?LinkId=234236

namespace Pokemon_Antonio_Campallo_Gomez
{
    public sealed partial class ButterFreeACC : UserControl, iPokemon
    {
        DispatcherTimer dtTime;
        private Storyboard sbaux;

        public ButterFreeACC()
        {
            this.InitializeComponent();
            this.IsTabStop = true; // hacer interactivo el pokemon
        }

        private string nombre = "Butterfree";
        private string categoria = "Mariposa";
        private double altura = 1.10;
        private double peso = 32.0;
        private string evolucion = "No tiene.";
        private string descripcion = "Adora el néctar de las flores. Una pequeña cantidad de polen le basta para localizar prados floridos.";

        public double Energia { get { return this.barra_energia.Value; } set { this.barra_energia.Value = value; } }
        public string Nombre { get { return this.nombre; } set { this.nombre = value; } }
        public string Categoría { get { return this.categoria; } set { this.categoria = value; } }
        public string Tipo { get { return this.Tipo; } set { this.Tipo = value; } }
        public double Altura { get { return this.altura; } set { this.altura = value; } }
        public double Peso { get { return this.peso; } set { this.peso = value; } }
        public string Evolucion { get { return this.evolucion; } set { this.evolucion = value; } }
        public string Descripcion { get { return this.descripcion; } set { this.descripcion = value; } }
        public double Vida { get => this.barra_vida.Value; set => this.barra_vida.Value = value; }

        // Apartado de pocimas -------------------------------------------------------------------------------

        private void pocima_vida_PointerReleased(object sender, PointerRoutedEventArgs e) // para aumentar la vida
        {
            dtTime = new DispatcherTimer();
            dtTime.Interval = TimeSpan.FromMilliseconds(100);
            dtTime.Tick += subeVida;
            dtTime.Start();
            this.pocima_vida.Opacity = 0.5;

        }

        private void subeVida(object sender, object e)
        {
            this.barra_vida.Value += 0.2;
            if (barra_vida.Value >= 100)
            {
                this.dtTime.Stop();
                this.pocima_vida.Visibility = Visibility.Collapsed;
            }
        }
        private void pocima_energia_PointerReleased(object sender, PointerRoutedEventArgs e) // para aumentar energia
        {
            dtTime = new DispatcherTimer();
            dtTime.Interval = TimeSpan.FromMilliseconds(100);
            dtTime.Tick += subeEnergia;
            dtTime.Start();
            this.pocima_energia.Opacity = 0.5;
        }

        private void subeEnergia(object sender, object e)
        {
            this.barra_energia.Value += 0.2;
            if (barra_energia.Value >= 100)
            {
                this.dtTime.Stop();
                this.pocima_energia.Visibility = Visibility.Collapsed;
            }

        }

        // Lanzar animaciones -----------------------------------------------------------------------------------------------
        
        public void activarAniIdle(bool activar)
        {
            sbaux = (Storyboard)this.Resources["AniAleteo"];
            sbaux.Begin();
        }

        public void animacionAtaqueFlojo()
        {
            sbaux = (Storyboard)this.Resources["Ataque_debil"];
            sbaux.Begin();
        }
        public void animacionAtaqueFuerte()
        {
            sbaux = (Storyboard)this.Resources["Ataque_fuerte"];
            sbaux.Begin();
            MediaPlayer mpTornado = new MediaPlayer();
            mpTornado.Source = MediaSource.CreateFromUri(new Uri("ms-appx:///Assets/tornado.mp3"));
            mpTornado.Play();
        }
        public void animacionDefensa()
        {
            sbaux = (Storyboard)this.Resources["AniEscudo"];
            sbaux.Begin();
            MediaPlayer mpEscudo = new MediaPlayer();
            mpEscudo.Source = MediaSource.CreateFromUri(new Uri("ms-appx:///Assets/escudo.mp3"));
            mpEscudo.Play();
        }
        public void animacionDescasar()
        {

            sbaux = (Storyboard)this.Resources["AniDescanso"];
            sbaux.Begin();
        }

        public void animacionCansado()
        {
            sbaux = (Storyboard)this.Resources["AniAleteo"]; // para el alaeteo normal para iniciar el aleteo suave
            sbaux.Stop();

            sbaux = (Storyboard)this.Resources["AniCansado"];
            sbaux.Begin();
        }
        public void animacionNoCansado()
        {
            sbaux = (Storyboard)this.Resources["AniCansado"]; // para el aleteo suave e inicia el normal
            sbaux.Stop();

            sbaux = (Storyboard)this.Resources["AniAleteo"];
            sbaux.Begin();
        }
        public void animacionHerido()
        {
            sbaux = (Storyboard)this.Resources["Herido"];
            sbaux.Begin();
        }
        public void animacionNoHerido()
        {
            sbaux = (Storyboard)this.Resources["NoHerido"];
            sbaux.Begin();
        }
        public void animacionDerrota()
        {
            sbaux = (Storyboard)this.Resources["AniMuerte"];
            sbaux.Begin();
            MediaPlayer mpMuerte = new MediaPlayer();
            mpMuerte.Source = MediaSource.CreateFromUri(new Uri("ms-appx:///Assets/muerte.mp3"));
            mpMuerte.Play();
        }

        public void verFilaEnergia(bool ver)
        {
            if(ver == true)
            {
                this.barra_energia.Visibility = Visibility.Visible;
                this.energia.Visibility = Visibility.Visible;
            }
            else
            {
                this.barra_energia.Visibility= Visibility.Collapsed;
                this.energia.Visibility = Visibility.Collapsed;
            }
        }

        public void verPocionVida(bool ver)
        {
            if(ver== true)
            {
                this.pocima_vida.Visibility = Visibility.Visible;
            }
            else
            {
                this.pocima_vida.Visibility=Visibility.Collapsed;
            }
        }

        public void verPocionEnergia(bool ver)
        {
            if( ver == true)
            {
                this.pocima_energia.Visibility = Visibility.Visible;
            }
            else
            {
                this.pocima_energia.Visibility=Visibility.Collapsed;
            }
        }


        public void verNombre(bool ver)
        {
            if (ver == true)
            {
                this.NombrePokemon.Visibility = Visibility.Visible;
            }
            else
            {
                this.NombrePokemon.Visibility=Visibility.Collapsed;
            }
        }

        public void verFondo(bool ver)
        {
            if (ver == true)
            {
                this.gridButterfree.Background.Opacity = 100;
            }
            else
            {
                this.gridButterfree.Background.Opacity = 0;
            }
        }

        public void verFilaVida(bool ver)
        {
            if (ver == true)
            {
                this.barra_vida.Visibility = Visibility.Visible;
                this.vida.Visibility = Visibility.Visible;
            }
            else
            {
                this.barra_vida.Visibility = Visibility.Collapsed;
                this.vida.Visibility = Visibility.Collapsed;
            }
        }
    }
}
