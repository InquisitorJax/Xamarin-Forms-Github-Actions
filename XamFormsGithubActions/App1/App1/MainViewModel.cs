using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace App1
{
	[ObservableObject]
	public partial class MainViewModel
	{
		[ObservableProperty]
		private string _name;

		[RelayCommand]
		public void InitName(string name)
		{
			Name = name;
		}
	}
}
