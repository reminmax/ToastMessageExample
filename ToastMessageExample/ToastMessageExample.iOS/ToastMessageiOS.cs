using Foundation;
using ToastMessageExample.iOS;
using ToastMessageExample.ToastMessage;
using UIKit;

[assembly: Xamarin.Forms.Dependency(typeof(ToastMessageiOS))]
namespace ToastMessageExample.iOS
{
    public class ToastMessageiOS : IToastMessage
    {
        private const double _long_delay = 3.5;
        private const double _short_delay = 2.0;

        public void LongAlert(string message)
        {
            ShowAlert(message, _long_delay);
        }

        public void ShortAlert(string message)
        {
            ShowAlert(message, _short_delay);
        }

        void ShowAlert(string message, double seconds)
        {
            var alert = UIAlertController.Create(null, message, UIAlertControllerStyle.Alert);

            var alertDelay = NSTimer.CreateScheduledTimer(seconds, obj =>
            {
                DismissMessage(alert, obj);
            });

            if (UIApplication.SharedApplication.KeyWindow.RootViewController != null)
                UIApplication.SharedApplication.KeyWindow.RootViewController.PresentViewController(alert, true, null);
        }

        void DismissMessage(UIAlertController alert, NSTimer alertDelay)
        {
            if (alert != null)
            {
                alert.DismissViewController(true, null);
            }

            if (alertDelay != null)
            {
                alertDelay.Dispose();
            }
        }
    }
}