using System;
using Xamarin.Forms;
using Cirrious.MvvmCross.ViewModels;
using Cirrious.MvvmCross.Binding.BindingContext;

namespace MvvmCross.Forms.Platform
{
	public class MvxContentPage : ContentPage
	{
		public IMvxBindingContext BindingContext { get; set; }

		public MvxContentPage ()
		{
			BindingContext = new MvxBindingContext(this);
		}

		public object DataContext
		{
			get { return BindingContext.DataContext; }
			set { BindingContext.DataContext = value; }
		}

		public IMvxViewModel ViewModel
		{
			get { return DataContext as IMvxViewModel; }
			set
			{
				DataContext = value;
				OnViewModelSet();
			}
		}

		protected virtual void OnViewModelSet()
		{
		}
	}

	public abstract class MvxContentPage<TViewModel>
		: MvxContentPage where TViewModel : class, IMvxViewModel
	{
		public new TViewModel ViewModel
		{
			get { return (TViewModel)base.ViewModel; }
			set { base.ViewModel = value; }
		}
	}
}

