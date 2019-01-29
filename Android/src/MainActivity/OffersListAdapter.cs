using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;
using System.Collections.Generic;

namespace Android
{
    public class OffersListAdapter : RecyclerView.Adapter
    {
        public List<Offer> Offers;

        public override int ItemCount => Offers.Count;

        public class OfferViewHolder : RecyclerView.ViewHolder
        {
            public TextView IdTextView;
            public OfferViewHolder(TextView textView) : base(textView)
            {
                IdTextView = textView;
            }
        }

        public OffersListAdapter(List<Offer> offers)
        {
            this.Offers = offers;
        }

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            return new OfferViewHolder(new TextView(parent.Context)); 
        }

        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            OfferViewHolder offerViewHolder = holder as OfferViewHolder;
            offerViewHolder.IdTextView.Text = Offers[position].Id;
        }
    }
}