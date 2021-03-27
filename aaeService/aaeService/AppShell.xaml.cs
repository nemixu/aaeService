using aaeService.ViewModels;
using aaeService.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace aaeService
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
