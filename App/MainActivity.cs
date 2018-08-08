using System;
using System.Collections.Generic;
using Android.App;
using Android.Content;
using Android.Widget;
using Android.OS;
using Android.Runtime;
using Android.Support.V4.View;
using Com.Rbrooks.Indefinitepagerindicator;
using Android.Support.V7.App;
using Android.Views;
using Com.Bumptech.Glide;
using Java.Text;

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

            var viewPager = FindViewById<ViewPager>(Resource.Id.viewPager);
            var indicicator = FindViewById<IndefinitePagerIndicator>(Resource.Id.indicator);

            indicicator.AttachToViewPager(viewPager);

            var list = new List<string>();
            for (var i = 0; i < 25; ++i)
            {
                list.Add(CreateRandomImageUrl());
            }

            viewPager.Adapter = new FancyAdapter(this, list);
        }

        private static string CreateRandomImageUrl() => MessageFormat.Format("https://lorempixel.com/{0}/{1}/", new Random().Next(400) + 200, new Random().Next(200) + 400);
    }

    internal class FancyAdapter : PagerAdapter
    {
        private List<string> Uris { get; }
        private WeakReference<Context> Context { get; }

        public FancyAdapter(Context context, List<string> uris)
        {
            Context = new WeakReference<Context>(context);
            Uris = uris;
        }

        public override int Count => Uris?.Count ?? 0;

        public override bool IsViewFromObject(View view, Java.Lang.Object obj) => view == obj;

        [Obsolete("deprecated")]
        public override Java.Lang.Object InstantiateItem(View container, int position)
        {
            Context.TryGetTarget(out var context);
            var imageView = new ImageView(context);

            var viewPager = container.JavaCast<ViewPager>();
            viewPager.AddView(imageView);
            Glide.With(context).Load(Uris[position]).Into(imageView);
            return imageView;
        }

        [Obsolete("deprecated")]
        public override void DestroyItem(View container, int position, Java.Lang.Object view)
        {
            var viewPager = container.JavaCast<ViewPager>();
            viewPager.RemoveView(view as View);
        }
    }
}