using System;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace Android
{
    class Service
    {
        private readonly Uri _baseUri;
        public static readonly Service Shared = new Service();

        private Service()
        {
            _baseUri = new Uri("https://yastatic.net/market-export/_/partner/help/YML.xml");
        }

        public async Task<List<Offer>> GetOffers()
        {
            return await Task.Run(() => {
                XmlDocument document = new XmlDocument();
                document.Load(_baseUri.ToString());

                XmlNode node = document.DocumentElement.SelectSingleNode("/yml_catalog/shop/offers");

                List<Offer> offers = new List<Offer>();
                foreach (XmlNode xnode in node.ChildNodes)
                {
                    Offer offer = new Offer();
                    offer.Id = xnode.Attributes["id"]?.Value;
                    offer.Bid = xnode.Attributes["bid"]?.Value;
                    offer.Type = xnode.Attributes["type"]?.Value;
                    offer.IsAvailable = xnode.Attributes["available"]?.Value;
                    offer.Url = xnode["url"]?.InnerText;
                    offer.Price = xnode["price"]?.InnerText;
                    offer.CurrencyId = xnode["currencyId"]?.InnerText;
                    offer.CategoryId = xnode["categoryId"]?.InnerText;
                    offer.PictureUrl = xnode["picture"]?.InnerText;
                    offer.Delivery = xnode["delivery"]?.InnerText;
                    offer.LocalDeliveryCost = xnode["local_delivery_cost"]?.InnerText;
                    offer.TypePrefix = xnode["typePrefix"]?.InnerText;
                    offer.Vendor = xnode["vendor"]?.InnerText;
                    offer.VendorCode = xnode["vendorCode"]?.InnerText;
                    offer.Model = xnode["model"]?.InnerText;
                    offers.Add(offer);
                }
                return offers;
            });
        }
    }
}