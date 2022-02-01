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
    class ChieneseWebView : Activity
    {
        
        WebView webv;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.chienesewebview);

            webv = FindViewById<WebView>(Resource.Id.webView3);

            var url = "https://www.travelchinaguide.com/traditional-chinese-food.htm";
            webv.LoadUrl(url);
        }
    }
}