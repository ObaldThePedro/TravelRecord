﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TravelRecord
{
	public partial class MainPage : ContentPage
	{
        public MainPage()
        {
            InitializeComponent();
        }

        private void Login_Button_Clicked(object sender, EventArgs e)
        {
            bool IsEmailEmpty = string.IsNullOrEmpty(email.Text);
            bool IsPasswordEmpty = string.IsNullOrEmpty(password.Text);

            if(IsEmailEmpty || IsPasswordEmpty)
            {

            }
            else
            {
                Navigation.PushAsync(new HomePage());
            }
        }
    }
}
