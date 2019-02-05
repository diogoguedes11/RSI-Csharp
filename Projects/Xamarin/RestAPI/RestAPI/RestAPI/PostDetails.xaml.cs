using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RestAPI
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PostDetails : ContentPage
	{
		public PostDetails (Post post)
		{
			InitializeComponent ();
            BindingContext = post;
		}
	}
}