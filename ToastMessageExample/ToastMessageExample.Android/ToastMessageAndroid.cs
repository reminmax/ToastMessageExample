using Android.App;
using Android.Widget;
using ToastMessageExample.Droid;
using ToastMessageExample.ToastMessage;

[assembly: Xamarin.Forms.Dependency(typeof(ToastMessageAndroid))]
namespace ToastMessageExample.Droid
{
    public class ToastMessageAndroid : IToastMessage
    {
        public void ShortAlert(string message)
        {
            Toast.MakeText(Android.App.Application.Context, message, ToastLength.Short)?.Show();
        }
        public void LongAlert(string message)
        {
            Toast.MakeText(Android.App.Application.Context, message, ToastLength.Long)?.Show();
        }
    }
}