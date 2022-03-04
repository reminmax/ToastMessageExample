using System.Windows.Input;
using ToastMessageExample.ToastMessage;
using Xamarin.Forms;

namespace ToastMessageExample.ViewModels
{
    public class MainPageViewModel
    {
        public MainPageViewModel()
        {
            ShowLongAlertCommand = new Command(ShowLongAlert);
            ShowShortAlertCommand = new Command(ShowShortAlert);
        }
        
        public ICommand ShowLongAlertCommand { get; }
        public ICommand ShowShortAlertCommand { get; }

        private void ShowLongAlert()
        {
            DependencyService.Get<IToastMessage>().LongAlert("Long toast message");
        }
        
        private void ShowShortAlert()
        {
            DependencyService.Get<IToastMessage>().ShortAlert("Short toast message");
        }
    }


}
