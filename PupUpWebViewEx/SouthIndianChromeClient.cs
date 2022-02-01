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
    
    class SouthIndianChromeClient : WebChromeClient
    {
        
        Context context;

      

        public SouthIndianChromeClient(Context context)
        {
            this.context = context;
        }

        
        public override void OnProgressChanged(WebView view, int newProgress)
        {
            
            if (newProgress < 100)
            {
                //myprogressBar.SetProgress(newProgress);
                //activity.SetTitle(Resource.String.load);
                //activity.SetProgress(newProgress * 100);
            
            }
            if (newProgress == 100)
            {
                //myprogressBar.SetProgress(newProgress);
                //activity.SetProgress(newProgress);
            }
            base.OnProgressChanged(view, newProgress);
        }

        
    }
}