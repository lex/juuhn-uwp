using Firebase.Database;
using Firebase.Database.Query;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace juuhn_uwp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public StoryViewModel ViewModel { get; set; }
        private const int MAX_STORIES = 5;
        private const string FIREBASE_URL = "https://hacker-news.firebaseio.com/v0/";
        private FirebaseClient firebaseClient;

        public MainPage()
        {
            this.InitializeComponent();
            this.ViewModel = new StoryViewModel();
            this.firebaseClient = new FirebaseClient(FIREBASE_URL);

            GetStories();
        }

        private async void GetStories()
        {
            IEnumerable<int> topStories = await firebaseClient
                .Child("topstories")
                .OnceSingleAsync<List<int>>();

            topStories = topStories.Take(MAX_STORIES);

            foreach (var story in topStories)
            {
                ViewModel.Stories.Add(await GetStory(story));
            }
        }

        private async Task<Story> GetStory(int id)
        {
            return await firebaseClient
                .Child("item")
                .Child("" + id)
                .OnceSingleAsync<Story>();
        }
    }
}
