using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AndroidX.AppCompat.App;

namespace PupUpWebViewEx
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity, PopupMenu.IOnMenuItemClickListener
    {
        Button mybutton;
        PopupMenu mymenu;

       

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            mybutton = FindViewById<Button>(Resource.Id.button1);
            mybutton.Click += Mybutton_Click;
        }

        private void Mybutton_Click(object sender, System.EventArgs e)
        {
            mymenu = new PopupMenu(this, mybutton);
            mymenu.MenuInflater.Inflate(Resource.Menu.menu, mymenu.Menu);
            mymenu.SetOnMenuItemClickListener(this);
            mymenu.Show(); 
        }

        public bool OnMenuItemClick(IMenuItem item)
        {
            switch (item.ItemId)
            {

                case Resource.Id.item1:
                    Intent i = new Intent(Application.Context, typeof(PizzaWebView));
                    StartActivity(i);
                    //Toast.MakeText(this, Resource.String.item1, ToastLength.Short).Show();
                    return true;

                case Resource.Id.item2:
                    Intent j = new Intent(Application.Context, typeof(SouthIndianWebView));
                    StartActivity(j) ;
                    //Toast.MakeText(this, Resource.String.item2, ToastLength.Short).Show();
                    return true;

                case Resource.Id.item3:
                    Intent k = new Intent(Application.Context, typeof(ChieneseWebView));
                    StartActivity(k);
                    //Toast.MakeText(this, Resource.String.item3, ToastLength.Short).Show();
                    return true;

                default:
                    return false;

            }

            
        }


    }
}