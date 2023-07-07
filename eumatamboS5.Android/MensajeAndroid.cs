using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using eumatamboS5.Droid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
// para emsamblar  el archivo
[assembly: Xamarin.Forms.Dependency(typeof(MensajeAndroid))]
namespace eumatamboS5.Droid
{
    internal class MensajeAndroid : Mensaje
    {
        // para  heredar  la clase previamente creada
        public void longAlert(string mensaje)
        {
            Toast.MakeText(Application.Context, mensaje, ToastLength.Long).Show();

        }

        public void shortAlert(string mensaje)
        {
            Toast.MakeText(Application.Context, mensaje, ToastLength.Short).Show();
        }
    }
}