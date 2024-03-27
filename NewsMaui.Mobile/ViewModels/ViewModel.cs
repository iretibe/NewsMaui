using CommunityToolkit.Mvvm.ComponentModel;

namespace NewsMaui.Mobile.ViewModels
{
	[ObservableObject]
	public abstract partial class ViewModel
	{
		// To be able to access Navigator, we must extend the ViewModel base class,
		// making it available to all ViewModels. Proceed as follows:
		public INavigate Navigation { get; init; }
		internal ViewModel(INavigate navigation) => Navigation = navigation;
	}
}
