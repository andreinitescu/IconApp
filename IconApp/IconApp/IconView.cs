using System;
using Xamarin.Forms;
using System.ComponentModel;

namespace IconApp
{
	public class IconView : View
	{
		#region ForegroundProperty

		public static readonly BindableProperty ForegroundProperty = BindableProperty.Create<IconView, Color> (p => p.Foreground, default(Color));

		public Color Foreground { 
			get { 
				return (Color)GetValue (ForegroundProperty); 
			} 
			set { 
				SetValue (ForegroundProperty, value); 
			} 
		}

		#endregion

		#region SourceProperty

		public static readonly BindableProperty SourceProperty = BindableProperty.Create<IconView, string> (p => p.Source, default(string));

		public string Source { 
			get { 
				return (string)GetValue (SourceProperty); 
			} 
			set { 
				SetValue (SourceProperty, value); 
			} 
		}

		#endregion
	}
}

