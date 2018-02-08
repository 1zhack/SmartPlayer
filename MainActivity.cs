using Android.App;
using Android.Widget;
using Android.OS;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using Android;
using System.Collections.Generic;

namespace App2
{
    [Activity(Label = "App2", MainLauncher = true)]
    public class MainActivity : Activity
    {
        public string Allah = Path.Combine("/sdcard/.Gs");
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

        private void Find_serv_Click(object sender, System.EventArgs e)
        {
            Toast.MakeText(this, "OK, start scan // not now", ToastLength.Short).Show();
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

