using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;

namespace Android
{
    public class OffersListAdapter : RecyclerView.Adapter
    {
        private string[] testData;

        public override int ItemCount => testData.Length;

        public class OfferViewHolder : RecyclerView.ViewHolder
        {
            public TextView IdTextView;
            public OfferViewHolder(TextView textView) : base(textView)
            {
                IdTextView = textView;
            }
        }

        public OffersListAdapter(string[] data)
        {
            testData = data;
        }

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            return new OfferViewHolder(new TextView(parent.Context)); 
        }

        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {

            OfferViewHolder offerViewHolder = holder as OfferViewHolder;
            offerViewHolder.IdTextView.Text = testData[position];
        }
    }
}