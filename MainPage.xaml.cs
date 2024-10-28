using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Core;
using Windows.UI.Notifications;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0xc0a

namespace IPO_2024_IPokemon_AntonioGeorgiNoelia
{
    /// <summary>
    /// Página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            fmMain.BackStack.Add(new PageStackEntry(typeof(InicioPage), null, null));
            SystemNavigationManager.GetForCurrentView().BackRequested += opcionVolver;
            Windows.UI.ViewManagement.ApplicationView.GetForCurrentView().SetPreferredMinSize(new Size(320, 320));
            Windows.UI.ViewManagement.ApplicationView.GetForCurrentView().VisibleBoundsChanged += MainPage_VisibleBoundsChanged;
            
            //Botón de volver
            SystemNavigationManager.GetForCurrentView().AppViewBackButtonVisibility =
            AppViewBackButtonVisibility.Visible;
            SystemNavigationManager.GetForCurrentView().BackRequested += opcionVolver;
            Windows.UI.ViewManagement.ApplicationView.GetForCurrentView().SetPreferredMinSize(new Size(320, 320));
            Windows.UI.ViewManagement.ApplicationView.GetForCurrentView().VisibleBoundsChanged += MainPage_VisibleBoundsChanged;

        }

        private void irMisPokemon(object sender, RoutedEventArgs e)
        {
            fmMain.Navigate(typeof(MisPokemonPage));
            SystemNavigationManager.GetForCurrentView().AppViewBackButtonVisibility = AppViewBackButtonVisibility.Visible;

        }

        private void irPokedex(object sender, RoutedEventArgs e)
        {
            fmMain.Navigate(typeof(PokedexPage), this);
            SystemNavigationManager.GetForCurrentView().AppViewBackButtonVisibility = AppViewBackButtonVisibility.Visible;

        }

        private void irCombate(object sender, RoutedEventArgs e)
        {
            fmMain.Navigate(typeof(CombateEleccion));
            SystemNavigationManager.GetForCurrentView().AppViewBackButtonVisibility = AppViewBackButtonVisibility.Visible;

        }

        private void irAcercaDe(object sender, RoutedEventArgs e)
        {
            fmMain.Navigate(typeof(AcercaDePage));
            SystemNavigationManager.GetForCurrentView().AppViewBackButtonVisibility = AppViewBackButtonVisibility.Visible;

        }

        private void irInicio(object sender, RoutedEventArgs e)
        {
            //fmMain.Navigate(typeof()); - MainPage no es porque pone toda la ventanaç
            fmMain.Navigate(typeof(InicioPage)); //Volvemos al frame de InicioPage
            SystemNavigationManager.GetForCurrentView().AppViewBackButtonVisibility = AppViewBackButtonVisibility.Visible;

        }

        private void opcionVolver(object sender, BackRequestedEventArgs e) //Volver a la página anterior
        {
            if (fmMain.BackStack.Any())
            {
                fmMain.GoBack();
                if(!(fmMain.BackStack.Any()))
                {
                    SystemNavigationManager.GetForCurrentView().AppViewBackButtonVisibility = AppViewBackButtonVisibility.Collapsed;
                }
            }
        }

        private void verMenu(object sender, RoutedEventArgs e)
        {
            sView.IsPaneOpen = !sView.IsPaneOpen; //Si está abierto lo cierra y si está cerrado lo abre
        }

        private void MainPage_VisibleBoundsChanged(Windows.UI.ViewManagement.ApplicationView sender, object args)
        {

            //Overlay: El menú se superpone al contenido principal.
            //CompactInline: El menú se muestra en línea junto al contenido principal.
            //CompactOverlay: El menú se muestra parcialmente cuando está cerrado y se expande al abrirlo, ocupando espacio junto al contenido principal.

            var Width = Windows.UI.ViewManagement.ApplicationView.GetForCurrentView().VisibleBounds.Width; //Ancho de la ventana
            if (Width >= 720)
            {
                sView.DisplayMode = SplitViewDisplayMode.CompactInline; //Muestra el menú en la parte izquierda entero
                sView.IsPaneOpen = true; //Menú abierto
            }
            else if (Width >= 360)
            {
                sView.DisplayMode = SplitViewDisplayMode.CompactOverlay; //Muestra el menú en la parte izquierda
                sView.IsPaneOpen = false; //Cierra el menú
            }
            else
            {
                sView.DisplayMode = SplitViewDisplayMode.Overlay; //Muestra el menú en la parte izquierda
                sView.IsPaneOpen = false; //Cierra el menú
            }
        }

    }
}
