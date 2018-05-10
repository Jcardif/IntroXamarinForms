using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LearningXamarinForms
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Exerise1 : ContentPage
	{
	    private int clicks;
	    List<string> lstQuotes = new List<string>
	    {
	        "Life is like riding a bicycle, to keep your balance, you ust keep on moving",
	        "You cannot blame gravity for falling in love",
	        "Look deep into nature and then you will understand everything better"
	    };
        public Exerise1 ()
		{
			InitializeComponent ();
		    label_quotes.Text = lstQuotes[0];
		     clicks = 0;
		}

	    private void Btn_next_OnClicked(object sender, EventArgs e)
	    {

	        if (clicks >= lstQuotes.Count)
	        {
	            clicks = 0;
	            label_quotes.Text = lstQuotes[clicks];
	            clicks++;
	        }
	        else
	        {
	            label_quotes.Text = lstQuotes[clicks];
	            clicks++;
	        }
	    }
	}
}