using System;
using System.Collections.Generic;
using GpsDemoApp.ViewModels;
using GpsDemoApp.Views;
using Xamarin.Forms;

namespace GpsDemoApp
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
