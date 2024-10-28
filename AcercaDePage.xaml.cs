using Microsoft.Toolkit.Uwp.Notifications;
using System;
using System.Collections.Generic;
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

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace IPO_2024_IPokemon_AntonioGeorgiNoelia
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class AcercaDePage : Page
    {
        public AcercaDePage()
        {
            this.InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            new ToastContentBuilder().AddArgument("action", "recibirInformacion").AddArgument("ConversationId", 9813).AddText("Muchas gracias por utilizar nuestra aplicación. Opina sobre nuestro proyecto :D", hintMaxLines: 2).AddInlineImage(new Uri("ms-appx:///Assets/flecha.png")).AddInputTextBox("opinionInput", "Escribe tu opinión").AddButton(new ToastButton().SetContent("Enviar").AddArgument("action", "submitOpinion")).Show();

        }
    }
}
