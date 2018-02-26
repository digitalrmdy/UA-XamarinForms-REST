using System.Threading.Tasks;
using Xamarin.Forms;

namespace FindMyBeer.Extensions
{
	public static class TaskExtensions
	{
		public static Task<T> SetIsLoading<T>(this Task<T> task, BaseViewModel viewModel)
		{
			viewModel.IsLoading = true;
			task.ContinueWith(t =>
			{
				Device.BeginInvokeOnMainThread(() => viewModel.IsLoading = false);
			});
			return task;
		}
		
		public static Task SetIsLoading(this Task task, BaseViewModel viewModel)
		{
			viewModel.IsLoading = true;
			task.ContinueWith(t =>
			{
				Device.BeginInvokeOnMainThread(() => viewModel.IsLoading = false);
			});
			return task;
		}
	}
}