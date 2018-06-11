using Android.App;
using Android.Widget;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Support.V7.App;

namespace AnimationHarma
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_main);
        }

        public override void OnWindowFocusChanged(bool hasFocus)
        {
            if (hasFocus)
            {
                ImageView imageView = FindViewById<ImageView>(Resource.Id.imageView1);
                AnimationDrawable animation = (AnimationDrawable)imageView.Drawable;
                animation.Start();
            }
        }
    }
}

