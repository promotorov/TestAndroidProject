using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Content;
using Android.Widget;

namespace Android
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class OfferInfoActivity : AppCompatActivity
    {
        TextView OfferJsonTextView;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_offer_info);

            OfferJsonTextView = (TextView)FindViewById(Resource.Id.offer_json_text_view);
            OfferJsonTextView.Text = Intent.GetStringExtra("0");
        }
    }
}