using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Support.V7.Widget;
using Android.Content;
using System;
using Newtonsoft.Json;
using System.Collections.Generic;


namespace Android
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        private readonly MainViewModel _model = new MainViewModel();

        RecyclerView OffersListRecyclerView;
        OffersListAdapter OffersListAdapter;
        RecyclerView.LayoutManager OffersListLayoutManager;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_main);
            OffersListRecyclerView = (RecyclerView)FindViewById(Resource.Id.offers_recycler_view);

            OffersListRecyclerView.HasFixedSize = true;

            OffersListLayoutManager = new LinearLayoutManager(this);
            OffersListRecyclerView.SetLayoutManager(OffersListLayoutManager);

            OffersListAdapter = new OffersListAdapter(new List<Offer>(), OfferItemClicked);
            OffersListRecyclerView.SetAdapter(OffersListAdapter);

            _model.LoadOffers().ContinueWith(obj => {
                OffersListAdapter.Offers = _model.Offers;
                OffersListAdapter.NotifyItemRangeInserted(0, _model.Offers.Count);
            });

        }

        public void OfferItemClicked(int position)
        {
            Intent intent = new Intent(this, typeof(OfferInfoActivity));
            intent.PutExtra("0", JsonConvert.SerializeObject(_model.Offers[position]));
            StartActivity(intent);
        }
    }
}