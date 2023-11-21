using News_App.Models;
using News_App.Services;

namespace News_App.Pages;

public partial class NewsListPage : ContentPage
{
	public List<Article> ArticlesList;
	public NewsListPage(string categoryNeme)
	{
        InitializeComponent();
        Title = categoryNeme;
		GetNews(categoryNeme);
		ArticlesList = new List<Article>();
	}

	private async void GetNews(string categoryNeme)
	{
		var apiService = new ApiService();
		var newsResult = await apiService.GetNews(categoryNeme);
		foreach (var item in newsResult.Articles)
		{
			ArticlesList.Add(item);
		}
        CvNews.ItemsSource = ArticlesList;
	}

    private void CvNews_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        var selectedItem = e.CurrentSelection.FirstOrDefault() as Article;
        if (selectedItem == null) return;
        Navigation.PushAsync(new NewsDetailPage(selectedItem));
        ((CollectionView)sender).SelectedItem = null;
    }
}