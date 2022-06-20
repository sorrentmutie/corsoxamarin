using DemoCorsoMattina.Controls;
using DemoCorsoMattina.iOS.Renderers;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(MyCustomEntry), typeof(MyCustomEntryRenderer))]
namespace DemoCorsoMattina.iOS.Renderers
{
    public class MyCustomEntryRenderer: EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            if(Control != null)
            {
                Control.BackgroundColor = UIColor.Red;
                Control.BorderStyle = UITextBorderStyle.RoundedRect;
            }
        }
    }
}