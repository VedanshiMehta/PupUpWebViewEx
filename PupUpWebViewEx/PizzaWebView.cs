using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Webkit;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PupUpWebViewEx
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme")]
    class PizzaWebView : Activity
    {
        WebView mywebView;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.pizzawebview);

            mywebView = FindViewById<WebView>(Resource.Id.webView1);

            var url = "https://www.wikihow.com/Make-Pizza";
            mywebView.Settings.JavaScriptEnabled = true;
            mywebView.SetWebViewClient(new PizzaWebViewClient());
            mywebView.LoadUrl(url);

        }

        public override bool OnKeyDown([GeneratedEnum] Keycode keyCode, KeyEvent e)
        {
           if(keyCode== Keycode.Back && mywebView.CanGoBack() )
            {

                mywebView.GoBack();
                return true;
            }
            return base.OnKeyDown(keyCode, e);
        }

    }
    
}