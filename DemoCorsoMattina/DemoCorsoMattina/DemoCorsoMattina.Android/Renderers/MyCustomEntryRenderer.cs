﻿using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using DemoCorsoMattina.Controls;
using DemoCorsoMattina.Droid.Renderers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(MyCustomEntry), typeof(MyCustomEntryRenderer))]
namespace DemoCorsoMattina.Droid.Renderers
{
    public class MyCustomEntryRenderer: EntryRenderer
    {
        public MyCustomEntryRenderer(Context context): base(context)
        {

        }

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            if(Control != null){
                Control.SetBackgroundColor(Android.Graphics.Color.LightGreen);
            }
        }
    }
}