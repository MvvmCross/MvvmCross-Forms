using Cirrious.MvvmCross.ViewModels;

namespace Example.ViewModels
{
    public class FirstViewModel 
		: MvxViewModel
    {
		private string _yourNickname = "???";
        public string YourNickname
		{ 
			get { return _yourNickname; }
			set { _yourNickname = value; RaisePropertyChanged(() => YourNickname); RaisePropertyChanged(() => Hello); }
		}

        public string Hello
        {
            get { return "Hello " + YourNickname; }
        }
    }
}
