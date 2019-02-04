using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace RestAPI
{
    public partial class MainPage : ContentPage
    {
        const string Url = "https://jsonplaceholder.typicode.com/posts";
        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            GetPosts();
        }

        async void GetPosts()
        {
            List<Post> _posts;
            HttpClient _client = new HttpClient();

            var content = await _client.GetStringAsync(Url);
            _posts = JsonConvert.DeserializeObject<List<Post>>(content);

            postsListView.ItemsSource = _posts;
        }

        private void PostsListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Post post = e.SelectedItem as Post;
            Navigation.PushAsync(new PostDetails(post));
        }
    }
}
