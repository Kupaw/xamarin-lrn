using Android.App;
using System.Collections.Generic;
using Android.Widget;
using Android.OS;

namespace Kuph
{
    [Activity(Label = "Kuph", MainLauncher = true)]
    public class MainActivity : Activity
    {
        private List<string> roles;
        private ListView rolesview;
            protected override void OnCreate(Bundle savedInstanceState)
        {

            SetContentView(Resource.Layout.Main);
            base.OnCreate(savedInstanceState);

            rolesview = FindViewById<ListView>(Resource.Id.listView1);

            roles = new List<string>();
            roles.Add("Politician");
            roles.Add("Mafia Boss");
            roles.Add("Reporter");
            roles.Add("Missionary");
            roles.Add("Customs Office");

            ArrayAdapter<string> adapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleListItem1, roles);

            rolesview.Adapter = adapter;

        }
    }
}

