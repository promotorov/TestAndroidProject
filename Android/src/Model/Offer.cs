using System.Xml.Serialization;
using System.Collections.Generic;

namespace Android
{
    public class Offer
    {
        public string Id;
        public string Type;
        public string Bid;
        public string IsAvailable;
        public string Url;
        public string Price;
        public string CurrencyId;
        public string CategoryId;
        public string PictureUrl;
        public string Delivery;
        public string LocalDeliveryCost;
        public string TypePrefix;
        public string Vendor;
        public string VendorCode;
        public string Model;
    }

    public class OffersList
    {
        public List<Offer> offers;
    }
}