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
    class SouthIndianWebView : Activity
    {
        WebView _mywebview;
        protected override void OnCreate(Bundle savedInstanceState)
        {
           
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.southindianwebview);

            _mywebview = FindViewById<WebView>(Resource.Id.webView2);

            var url = "https://www.vegrecipesofindia.com/recipes/south-indian-recipes/";
            _mywebview.Settings.JavaScriptEnabled = true;
            _mywebview.SetWebChromeClient(new SouthIndianChromeClient(this));
            _mywebview.LoadUrl(url);

        }
    }
}