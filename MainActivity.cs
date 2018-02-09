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
<<<<<<< HEAD
using TagLib;
=======
<<<<<<< HEAD
using TagLib;
=======
>>>>>>> c8d29f8ba51e7622142adc7e2ac24296e81178fb
>>>>>>> 93f4c1827103d346e1c0e559eeb40cbe530c19cd

namespace App2
{
    [Activity(Label = "App2", MainLauncher = true)]
    public class MainActivity : Activity
    {
<<<<<<< HEAD
        static int now = 0;
        static MediaPlayer _player = new MediaPlayer();
        Button start_serv;
        Button find_serv;
        Button next;
        TextView nowplay;
        TextView lib;
=======
<<<<<<< HEAD
        static int now = 0;
        static MediaPlayer _player = new MediaPlayer();
=======
        static MediaPlayer _player;
>>>>>>> c8d29f8ba51e7622142adc7e2ac24296e81178fb
        Button start_serv;
        Button find_serv;
        Button next;
>>>>>>> 93f4c1827103d346e1c0e559eeb40cbe530c19cd
        //public static List<string> fls;
        public static List<string> mp3files;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            
            
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            start_serv = FindViewById<Button>(Resource.Id.start_ftp);
            find_serv = FindViewById<Button>(Resource.Id.scan_ftp);
            next = FindViewById<Button>(Resource.Id.next);
<<<<<<< HEAD
           // nowplay = FindViewById<TextView>(Resource.Id.Now);
            lib = FindViewById<TextView>(Resource.Id.lib);
=======
>>>>>>> 93f4c1827103d346e1c0e559eeb40cbe530c19cd
            start_serv.Click += Start_serv_Click;
            find_serv.Click += Find_serv_Click;
            next.Click += Next_Click;
            mp3files = ParseFiles();
            //for (int i = 0; i <= mp3files.Count-1; i++) ToastShow(this, mp3files[i]);


            for (int i = 0; i <= mp3files.Count - 1; i++)
            {
                var File = TagLib.File.Create(mp3files[i]);
                string text = File.Tag.Title + " - " + File.Tag.Performers[0];
                lib.Append(text);
            }
           // Now_Playing();
        }
        public void Now_Playing()
        {
            var File = TagLib.File.Create(mp3files[now]);
            nowplay.Text += File.Tag.Title + " - " + File.Tag.Performers;
            string text = null;
            if (File.Tag.Performers != null) text = "Сейчас играет: " + File.Tag.Title + " - " + File.Tag.Performers[0];
            else text = "Сейчас играет: " + File.Tag.Title + " - неизв.";
            ToastShow(this, text);
        }
        private void Next_Click(object sender, System.EventArgs e)
        {
            if (_player.IsPlaying)
            {
                _player.Stop();
                if(now == mp3files.Count - 1)
                {
                    now = 0;
                    Play(this, mp3files[now]);
                    Now_Playing();
                }
                else
                {
                    Play(this, mp3files[now + 1]);
                    now++;
                    Now_Playing();
                }
                
            }
            else
            {
                Play(this, mp3files[now + 1]);
                now++;
                Now_Playing();
            }
        }

        public static void Play(Android.Content.Context context, string file)
        {
            _player = MediaPlayer.Create(context, Android.Net.Uri.Parse(file));
            _player.Start();
        }
        public static void play(Android.Content.Context context, string file)
        {
            _player = MediaPlayer.Create(context, Android.Net.Uri.Parse(file));
            _player.Start();
        }

        private void Next_Click(object sender, System.EventArgs e)
        {
            if (_player.IsPlaying)
            {
                _player.Stop();
                if(now == mp3files.Count - 1)
                {
                    now = 0;
                    Play(this, mp3files[now]);
                }
                else
                {
                    Play(this, mp3files[now + 1]);
                    now++;
                }
                
            }
            else
            {
                Play(this, mp3files[now + 1]);
                now++;
            }
        }

        public static void Play(Android.Content.Context context, string file)
        {
            _player = MediaPlayer.Create(context, Android.Net.Uri.Parse(file));
            _player.Start();
        }

        private void Find_serv_Click(object sender, System.EventArgs e)
        {
            Toast.MakeText(this, "OK, start music // test", ToastLength.Short).Show();
<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> 93f4c1827103d346e1c0e559eeb40cbe530c19cd
            if (_player.IsPlaying == false) Play(this, mp3files[now]);
            else
            {
                _player.Reset();
                Play(this, mp3files[0]);
            }
<<<<<<< HEAD
=======
=======
            play(this, mp3files[0]);
>>>>>>> c8d29f8ba51e7622142adc7e2ac24296e81178fb
>>>>>>> 93f4c1827103d346e1c0e559eeb40cbe530c19cd
        }

        private void Start_serv_Click(object sender, System.EventArgs e)
        {
            if (_player.IsPlaying)
            {
                _player.Pause();
                Toast.MakeText(this, "Pause", ToastLength.Short);
            }
            else _player.Start();
        }
        
        public static void ToastShow(Android.Content.Context context, string text)
        {
            Toast.MakeText(context, text, ToastLength.Short).Show();
        }

        static List<string> ParseFiles()
        {
            
            List<string> fls = new List<string>(Directory.GetFiles("sdcard/MApp/"));
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

