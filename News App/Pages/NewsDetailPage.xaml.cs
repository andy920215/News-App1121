using News_App.Models;

namespace News_App.Pages;

public partial class NewsDetailPage : ContentPage
{
	public NewsDetailPage(Article article)
	{
		InitializeComponent();
		ImgNews.Source = article.Image;
		LblTitle.Text = article.Title;
		LblContent.Text = article.Content;
	}
}