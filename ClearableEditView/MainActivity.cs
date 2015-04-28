using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace ClearableEditView
{
    [Activity(Label = "ClearableEditView", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity, IListener
    {
        private ClearableEditText textEdit;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.Main);

            textEdit = FindViewById<ClearableEditText>(Resource.Id.searchText);
            textEdit.SetListener(this);
        }

        public void DidClearTextBox()
        {
            textEdit.Text = string.Empty;
        }
    }
}

