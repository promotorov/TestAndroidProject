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
using System.Threading.Tasks;

namespace Android
{
    class MainViewModel
    {
        private OffersList _offersList = new OffersList();
        public List<Offer> Offers
        {
            get => _offersList.offers;
        }

        public async Task LoadOffers()
        {
            _offersList.offers = await Service.Shared.GetOffers();
        }
    }
}