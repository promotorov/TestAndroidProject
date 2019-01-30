using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;
using System.Collections.Generic;
using System;

namespace Android
{
    public class OffersListAdapter : RecyclerView.Adapter
    {
        public List<Offer> Offers;
        Action<int> OfferItemClicked;

        public override int ItemCount => Offers.Count;

        public class OfferViewHolder : RecyclerView.ViewHolder
        {
            public TextView IdTextView;
            public OfferViewHolder(TextView textView) : base(textView)
            {
                IdTextView = textView;
            }
        }

        public OffersListAdapter(List<Offer> offers, Action<int> offerItemClicked)
        {
            Offers = offers;
            OfferItemClicked = offerItemClicked;
        }

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            TextView orderIdTextView = new TextView(parent.Context);
            return new OfferViewHolder(orderIdTextView); 
        }

        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            OfferViewHolder offerViewHolder = holder as OfferViewHolder;
            offerViewHolder.ItemView.Click += (sender, args) => OfferItemClicked(position);
            offerViewHolder.IdTextView.Text = Offers[position].Id;
        }
    }
}