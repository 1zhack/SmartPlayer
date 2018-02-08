using Android.App;
using Android.Widget;
using Android.OS;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using Android;
using System.Collections.Generic;
using Android.Media;

namespace App2
{
    [Activity(Label = "App2", MainLauncher = true)]
    public class MainActivity : Activity
    {
        static MediaPlayer _player;
        Button start_serv;
        Button find_serv;
        //public static List<string> fls;
        public static List<string> mp3files;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            
            
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            start_serv = FindViewById<Button>(Resource.Id.start_ftp);
            find_serv = FindViewById<Button>(Resource.Id.scan_ftp);
            start_serv.Click += Start_serv_Click;
            find_serv.Click += Find_serv_Click;
            mp3files = ParseFiles();
            for (int i = 0; i <= mp3files.Count-1; i++) ToastShow(this, mp3files[i]);
            
        }
        public static void play(Android.Content.Context context, string file)
        {
            _player = MediaPlayer.Create(context, Android.Net.Uri.Parse(file));
            _player.Start();
        }

        private void Find_serv_Click(object sender, System.EventArgs e)
        {
            Toast.MakeText(this, "OK, start music // test", ToastLength.Short).Show();
            play(this, mp3files[0]);
        }

        private void Start_serv_Click(object sender, System.EventArgs e)
        {
            //ParseFiles();
            //Toast.MakeText(this, "OK, start server // not now", ToastLength.Short);
            
        }
        
        public static void ToastShow(Android.Content.Context context, string text)
        {
            Toast.MakeText(context, text, ToastLength.Short).Show();
        }

        static List<string> ParseFiles()
        {
            
            List<string> fls = new List<string>(Directory.GetFiles("storage/emulated/0/MApp/"));
            for (int i = 0; i <= fls.Count - 1; i++) {
                if (Path.GetExtension(fls[i]) != ".mp3") fls.RemoveAt(i);
            }
           
            return fls;
        }
        static void Share()
        {

        }
    }
}

