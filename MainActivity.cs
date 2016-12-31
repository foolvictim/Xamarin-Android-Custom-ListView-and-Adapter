using Android.App;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;

namespace Medlow
{
    [Activity(Label = "ListAdapter", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        private List<Person> nItems;
        private ListView nListView;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.Main);
            nListView = FindViewById<ListView>(Resource.Id.myListView);
            nItems = new List<Person>();
            nItems.Add(new Person() {FirstName="Bob",LastName="Smith", Age="25",Gender="Male"});
            nItems.Add(new Person() { FirstName = "Johnny B.", LastName = "Goode", Age = "17", Gender = "Male" });
            nItems.Add(new Person() { FirstName = "Carla", LastName = "Smart", Age = "22", Gender = "Female" });
            nItems.Add(new Person() { FirstName = "Tina", LastName = "Johnson", Age = "32", Gender = "Female" });


            MyListViewAdapter adapter = new MyListViewAdapter(this,nItems);
            nListView.Adapter = adapter;
        }
    }
}

