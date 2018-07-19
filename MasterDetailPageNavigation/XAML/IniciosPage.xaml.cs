using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MasterDetailPageNavigation
{
    public partial class IniciosPage : ContentPage
    {
        public IniciosPage()
        {
            InitializeComponent();
            image.Source = ImageSource.FromResource("MasterDetailPageNavigation.Resources.AutoMecanixLogo.png");
            imageActivar.Source = ImageSource.FromResource("MasterDetailPageNavigation.Resources.Activar.png");
            imageAt3Tire.Source = ImageSource.FromResource("MasterDetailPageNavigation.Resources.AT3.jpg");
            imageAt3WTire.Source = ImageSource.FromResource("MasterDetailPageNavigation.Resources.AT3W.png");
            imageBktTireTire.Source = ImageSource.FromResource("MasterDetailPageNavigation.Resources.BKTMP567.jpg");
            imageAceite.Source = ImageSource.FromResource("MasterDetailPageNavigation.Resources.Aceite10w30.jpg");

        }
    }
}
