using Android.App;
using Android.Widget;
using Android.OS;

namespace GUI
{
    [Activity(Label = "GUI", MainLauncher = true, Theme = "@style/theme.AppCombat.Light.NoActionBar")]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Main);

            var BottomNavigaton = FindViewById<BottomNavigationView>(Resource.Id.bottom_Navigation);

            BottomNavigaton.NavigationItemSelected += (s, e) =>
            {

            }  ;
                }
    }
}

