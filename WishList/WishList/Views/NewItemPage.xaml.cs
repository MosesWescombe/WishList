using System;
using System.Collections.Generic;
using System.ComponentModel;
using WishList.Models;
using WishList.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WishList.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}