using NewsMaui.Mobile.Models;

namespace NewsMaui.Mobile.Services
{
	public interface INewsService
	{
		public Task<NewsResult> GetNews(NewsScope scope);
	}
}
