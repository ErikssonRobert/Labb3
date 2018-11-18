using Android.App;
using Android.Widget;
using Android.OS;
using System;

namespace FirstXamarinApp
{
    [Activity(Label = "FirstXamarinApp", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity
    {
        Button button0;
        Button button1;
        Button button2;

        TextView output;
        EditText input;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            GetButtons();
            GetTextFields();
            SetButtonActions();
        }

        public void GetButtons()
        {
            // Get our buttons from the layout resource
            button0 = FindViewById<Button>(Resource.Id.button0);
            button1 = FindViewById<Button>(Resource.Id.button1);
            button2 = FindViewById<Button>(Resource.Id.button2);
        }

        public void GetTextFields()
        {
            //Get textfields from the layout resource
            output = FindViewById<TextView>(Resource.Id.textView1);
            input = FindViewById<EditText>(Resource.Id.editText1);
        }

        public void SetButtonActions()
        {
            button0.Click += delegate { Console.WriteLine("First button clicked!"); };
            button1.Click += delegate { Console.WriteLine("Second button clicked!"); };
            button2.Click += delegate 
            { 
                output.Text = input.Text;
                Console.WriteLine("Set textView.Text to {0}", input.Text);
            };
        }
    }
}

