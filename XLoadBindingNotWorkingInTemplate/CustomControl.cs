using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Documents;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;

// The Templated Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234235

namespace XLoadBindingNotWorkingInTemplate
{
    public sealed class CustomControl : Control, INotifyPropertyChanged
    {
        public CustomControl()
        {
            this.DefaultStyleKey = typeof(CustomControl);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public bool IsVisible { get; private set; }

        public string Greeting { get { return "Hello world"; } }
        public void MakeVisible()
        {
            IsVisible = true;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(IsVisible)));
        }
    }
}
