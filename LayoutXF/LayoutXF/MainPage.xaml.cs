using LayoutXF.Layouts.Absolute;
using LayoutXF.Layouts.Grid;
using LayoutXF.Layouts.Relative;
using LayoutXF.Layouts.Scroll;
using LayoutXF.Layouts.Stack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LayoutXF
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void GoPageStack(object sender, EventArgs e)
        {
            Navigation.PushAsync(new StackPage());
        }

        private void GoPageGrid(object sender, EventArgs e)
        {
            Navigation.PushAsync(new GridPage());
        }

        private void GoPageAbsolute(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AbsolutePage());
        }

        private void GoPageRelative(object sender, EventArgs e)
        {
            Navigation.PushAsync(new RelativePage());
        }

        private void GoPageScroll(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ScrollPage());
        }
    }
}