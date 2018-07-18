using Android.App;
using Android.Widget;
using Android.OS;

using Com.Rbrooks.Indefinitepagerindicator;
using Android.Support.V7.App;

namespace App
{
    [Activity(Label = "App", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            var indicicator = FindViewById<IndefinitePagerIndicator>(Resource.Id.recyclerview_pager_indicator);
        }
    }
}