﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LearningXamarinForms
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}
        private void Btn_Clicked (object  s, EventArgs e)
        {
            DisplayAlert("Title", "Message", "Ok");
        }

    }
}
