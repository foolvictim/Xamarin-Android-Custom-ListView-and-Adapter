using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Medlow
{
    class MyListViewAdapter : BaseAdapter<Person>
    {
        private List<Person> nItems;
        private Context nContext;
        public MyListViewAdapter(Context context, List<Person> items) {
            nItems = items;
            nContext = context;
        }
        public override int Count
        {
            get
            {
                return nItems.Count;
            }
        }
        public override long GetItemId(int position)
        {
            return position;
        }
        public override Person this[int position]
        {
            get
            {
                return nItems[position];
            }
        }
        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            View row = convertView;
            if (row == null)
            {
                row = LayoutInflater.From(nContext).Inflate(Resource.Layout.listview_row, null, false);
            }
            TextView txtName = row.FindViewById<TextView>(Resource.Id.txtName);
            txtName.Text = nItems[position].FirstName;
            TextView txtLastName = row.FindViewById<TextView>(Resource.Id.txtLastName);
            txtLastName.Text = nItems[position].LastName;
            TextView txtAge = row.FindViewById<TextView>(Resource.Id.txtAge);
            txtAge.Text = nItems[position].Age;
            TextView txtGender = row.FindViewById<TextView>(Resource.Id.txtGender);
            txtGender.Text = nItems[position].Gender;
            return row;
        }
    }
}