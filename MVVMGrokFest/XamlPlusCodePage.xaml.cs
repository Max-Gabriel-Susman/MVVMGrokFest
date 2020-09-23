using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MVVMGrokFest
{
    public partial class XamlPlusCodePage : ContentPage
    {
        public XamlPlusCodePage()
        {
            InitializeComponent();
        }

        // event handlers do not need to be public
        void OnSliderValueChanged(object sender, ValueChangedEventArgs args)
        {
            valueLabel.Text = args.NewValue.ToString("F3");  
        }

        // Alternative method?
        //void OnSliderValueChanged(object sender, ValueChangedEventArgs args)
        //{
        //    valueLabel.Text = ((Slider)sender).Value.ToString("F3");
        //}

        async void OnButtonClicked(object sender, EventArgs args)
        {
            Button button = (Button)sender;
            await DisplayAlert("Clicked!",
                "The button labeled '" + button.Text + "' has been clicked",
                "OK");
        }
    }
}
