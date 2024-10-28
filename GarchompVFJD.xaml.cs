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
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Control de usuario está documentada en https://go.microsoft.com/fwlink/?LinkId=234236

namespace Pokemon_Antonio_Campallo_Gomez
{
    public sealed partial class GarchompVFJD : UserControl, iPokemon
    {

        DispatcherTimer dtTime;
        DispatcherTimer dtTime2;
        public double Vida { get => this.pbVida.Value; 
            set => this.pbVida.Value = value; }
        public double Energia { get => this.pbEnergia.Value; 
            set => this.pbEnergia.Value = value; }
        public string Nombre { get => "Garchomp"; 
            set => throw new NotImplementedException(); }
        public string Categoría { get => "Mach"; 
            set => throw new NotImplementedException(); }
        public string Tipo { get => "Dragón/Tierra"; 
            set => throw new NotImplementedException(); }
        public double Altura { get => Convert.ToDouble(1.90); 
            set => throw new NotImplementedException(); }
        public double Peso { get => Convert.ToDouble(95.0); 
            set => throw new NotImplementedException(); }
        public string Evolucion { get => "No tiene evolución"; 
            set => throw new NotImplementedException(); }
        public string Descripcion { get => "Se dice que, cuando va a velocidad máxima, sus alas crean cuchillas de viento que talan cualquier árbol."; 
            set => throw new NotImplementedException(); }

        public GarchompVFJD()
        {
            this.InitializeComponent();
            this.IsTabStop = true;
            EstadoBase = (Storyboard)this.Resources["EstadoBase"];
            EstadoBase.RepeatBehavior = RepeatBehavior.Forever;
            EstadoBase.Begin();
        }

        private void aumentoVida(object sender, PointerRoutedEventArgs e)
        {
            dtTime = new DispatcherTimer();
            dtTime.Interval = TimeSpan.FromMilliseconds(50);
            dtTime.Tick += controlincrementoVida;
            dtTime.Start();
            this.iconoVida.Opacity = 0.6;
        }

        private void controlincrementoVida(object sender, object e)
        {
            this.pbVida.Value += 0.15;
            if (pbVida.Value >= 100)
            {
                this.dtTime.Stop();
                this.iconoVida.Opacity = 1;
            }
        }

        /*private void imgPocionVida_PointerReleased(object sender, PointerRoutedEventArgs e)
        {
            Storyboard CurarVida = (Storyboard)this.Resources["AumentoVida"];
            CurarVida.Begin();

            this.aumentoVida(sender, e);
        }*/


        private void aumentarEnergia(object sender, PointerRoutedEventArgs e)
        {
            dtTime2 = new DispatcherTimer();
            dtTime2.Interval = TimeSpan.FromMilliseconds(50);
            dtTime2.Tick += controlIncrementoEnergia;
            dtTime2.Start();
            this.iconoEnergia.Opacity = 0.5;
        }

        private void controlIncrementoEnergia(object sender, object e)
        {
            this.pbEnergia.Value += 0.3;
            if (pbEnergia.Value >= 100)
            {
                this.dtTime2.Stop();
                this.iconoEnergia.Opacity = 1;
            }
        }
      /* private void imgPocionEnergia_PointerReleased(object sender, PointerRoutedEventArgs e)
        {
            Storyboard energia = (Storyboard)this.Resources["Energia"];
            energia.Begin();

            this.aumentarEnergia(sender, e);

            this.AtaqueBasico1.IsEnabled = true;
            this.AtaqueFuerte1.IsEnabled = true;
        }

        private void AtaqueBasico1_Click(object sender, RoutedEventArgs e)
        {
            Storyboard AtaqueBasico = (Storyboard)this.Resources["AtaqueBasico"];
            AtaqueBasico.Begin();

            this.pbEnergia.Value -= 20;

            if (pbEnergia.Value < 20)
            {
                this.AtaqueBasico1.IsEnabled = false;
                this.AtaqueFuerte1.IsEnabled = false;
            }
        }
      */
        private void ProgressBar_ValueChanged(object sender, RangeBaseValueChangedEventArgs e)
        {

        }

        private void ProgressBar_ValueChanged_1(object sender, RangeBaseValueChangedEventArgs e)
        {

        }

        private void ProgressBar_ValueChanged_2(object sender, RangeBaseValueChangedEventArgs e)
        {

        }

        private void pbEnergia_ValueChanged(object sender, RangeBaseValueChangedEventArgs e)
        {

        }

        private void ProgressBar_ValueChanged_3(object sender, RangeBaseValueChangedEventArgs e)
        {

        }

        private void controlDormir(object sender, object e)
        {
            this.pbVida.Value += 0.2;
            this.pbEnergia.Value += 0.2;
            if (pbVida.Value >= 100 && pbEnergia.Value >= 100)
            {
                this.dtTime.Stop();
            }
        }

        private void descansar(object sender, RoutedEventArgs e)
        {
            dtTime = new DispatcherTimer();
            dtTime.Interval = TimeSpan.FromMilliseconds(25);
            dtTime.Tick += controlDormir;
            dtTime.Start();
        }
        /*
        private void Dormir_Click(object sender, RoutedEventArgs e)
        {
            Storyboard Dormido = (Storyboard)this.Resources["Dormido"];
            Dormido.Begin();

            this.descansar(sender, e);

        }

        private void Cubrirse_Click(object sender, RoutedEventArgs e)
        {
            Storyboard Protegerse = (Storyboard)this.Resources["Protegerse"];
            Protegerse.Begin();

        }

        private void AtaqueFuerte1_Click_1(object sender, RoutedEventArgs e)
        {
            Storyboard AtaqueFuerte = (Storyboard)this.Resources["AtaqueFuerte"];
            AtaqueFuerte.Begin();

            this.pbEnergia.Value -= 20;

            if (pbEnergia.Value <= 0)
            {
                this.AtaqueBasico1.IsEnabled = false;
                this.AtaqueFuerte1.IsEnabled = false;
            }

        }*/

        private async void espera(object sender, object e)
        {
            await Task.Delay(3000); //Espera 3 segundos
        }

        private void TextBlock_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }

        /*private void Button_Click(object sender, RoutedEventArgs e)
        {
            Storyboard EstadoBase = (Storyboard)this.Resources["EstadoBase"];
            EstadoBase.Begin();

        }*/

        public void verFilaVida(bool ver)
        {
            if(!ver) this.gridPrincipal.RowDefinitions[0].Height = new GridLength(0);
            else this.gridPrincipal.RowDefinitions[0].Height = new GridLength(10, GridUnitType.Star);
        }

        public void verFilaEnergia(bool ver)
        {
            if (!ver) this.gridPrincipal.RowDefinitions[1].Height = new GridLength(0);
            else this.gridPrincipal.RowDefinitions[1].Height = new GridLength(10, GridUnitType.Star);
        }

        public void verPocionVida(bool ver)
        {
            if (!ver) this.iconoVida.Visibility = Visibility.Collapsed;
            else this.iconoVida.Visibility = Visibility.Visible;

        }

        public void verPocionEnergia(bool ver)
        {
            if (!ver) this.iconoEnergia.Visibility = Visibility.Collapsed;
            else this.iconoEnergia.Visibility = Visibility.Visible;
        }

        public void verNombre(bool ver)
        {
            if (!ver) this.gridPrincipal.RowDefinitions[3].Height = new GridLength(0);
            else this.gridPrincipal.RowDefinitions[3].Height = new GridLength(10, GridUnitType.Star);
        }

        public void activarAniIdle(bool activar)
        {
            Storyboard EstadoBase = (Storyboard)this.Resources["EstadoBase"];
            EstadoBase.Begin();
        }

        public void animacionAtaqueFlojo()
        {
            Storyboard AtaqueBasico = (Storyboard)this.Resources["AtaqueBasico"];
            AtaqueBasico.Begin();
        }

        public void animacionAtaqueFuerte()
        {
            Storyboard AtaqueFuerte = (Storyboard)this.Resources["AtaqueFuerte"];
            AtaqueFuerte.Begin();
        }

        public void animacionDefensa()
        {
            Storyboard Protegerse = (Storyboard)this.Resources["Protegerse"];
            Protegerse.Begin();
        }

        public void animacionDescasar()
        {
            Storyboard Dormido = (Storyboard)this.Resources["Dormido"];
            Dormido.Begin();
        }

        public void animacionCansado()
        {
            Storyboard Cansado = (Storyboard)this.Resources["Cansado"];
            Cansado.Begin();
        }

        public void animacionNoCansado()
        {
            //NO TIENE
        }

        public void animacionHerido()
        {
            Storyboard Herido = (Storyboard)this.Resources["Herido"];
            Herido.Begin();
        }

        public void animacionNoHerido()
        {
            //NO TIENE
        }

        public void animacionDerrota()
        {
            Storyboard Derrota = (Storyboard)this.Resources["Derrota"];
            Derrota.Begin();
        }

        public void verFondo(bool verfondo)
        {
            if (!verfondo) { this.gridPrincipal.Background.Opacity = 0; }
            else { this.gridPrincipal.Background.Opacity = 100; }
        }
    }
}

