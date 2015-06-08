using System;
using System.Collections.Generic;

using Xamarin.Forms;
using System.Threading.Tasks;
using System.Diagnostics;
using System.ComponentModel;

namespace IconApp
{
	public partial class MyPage : ContentPage
	{
		static readonly Color[] Colors = new Color[] { Color.Red, Color.Aqua, Color.Yellow, Color.Green };

		public MyPage ()
		{
			InitializeComponent ();
			ChangeColor ();
		}

		async void ChangeColor()
		{
            int i = 0;
			do {
                if(i > 3)
                {
                    i = 0;
                }
				IconView.Foreground =  Colors[i++];
				await Task.Delay (TimeSpan.FromMilliseconds (700));
			} while(true);
		}
	}
}

