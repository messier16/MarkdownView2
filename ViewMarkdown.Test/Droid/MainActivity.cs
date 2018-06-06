using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;
using ViewMarkdown.Forms.Plugin.Droid;

namespace ViewMarkdown.Test.Droid
{
	[Activity(Label = "ViewMarkdown.Test.Droid", Icon = "@mipmap/ic_launcher", Theme = "@style/MyTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
	{
		protected override void OnCreate(Bundle bundle)
		{
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

			global::Xamarin.Forms.Forms.Init(this, bundle);
            MarkdownViewRenderer.Init();

            LoadApplication(new App());
        }
	}
}

