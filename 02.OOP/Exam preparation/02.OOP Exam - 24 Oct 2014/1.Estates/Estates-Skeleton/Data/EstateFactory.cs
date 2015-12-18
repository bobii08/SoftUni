using Estates.Engine;
using Estates.Interfaces;
using System;

namespace Estates.Data
{
    public class EstateFactory
    {
        public static IEstateEngine CreateEstateEngine()
        {
            return new AdvancedEstateEngine();
        }

        public static IEstate CreateEstate(EstateType type)
        {
            switch (type)
            {
                case EstateType.Apartment:
                    return new Apartment();
                case EstateType.Garage:
                    return new Garage();
                case EstateType.House:
                    return new House();
                case EstateType.Office:
                    return new Office();
                default:
                    throw new ArgumentException("There is no such estate type!");
            }
        }

        public static IOffer CreateOffer(OfferType type)
        {
            string offer = type.ToString();
            switch (offer)
            {
                case "Sale":
                    return new SaleOffer(type);
                case "Rent":
                    return new RentOffer(type);
                default: throw new ArgumentException("Ivalid offer type");
            }
        }
    }
}
