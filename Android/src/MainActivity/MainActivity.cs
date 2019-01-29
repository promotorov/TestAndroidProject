using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Support.V7.Widget;

namespace Android
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        RecyclerView OffersListRecyclerView;
        RecyclerView.Adapter OffersListAdapter;
        RecyclerView.LayoutManager OffersListLayoutManager;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_main);
            OffersListRecyclerView = (RecyclerView)FindViewById(Resource.Id.offers_recycler_view);

            OffersListRecyclerView.HasFixedSize = true;

            OffersListLayoutManager = new LinearLayoutManager(this);
            OffersListRecyclerView.SetLayoutManager(OffersListLayoutManager);
            
            OffersListAdapter = new OffersListAdapter(new string[] {"first", "second", "third", "forth"});
            OffersListRecyclerView.SetAdapter(OffersListAdapter);
        }
    }
}