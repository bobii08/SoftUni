using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class TheBetterMusicProducer
{
    private static decimal EstimateIncomeFromFirstProducer(int albumsInEurope, decimal priceInEurope, 
        int albumsInNorthAmerica, decimal priceInNorthAmerica, int albumsInSouthAmerica, decimal priceInSouthAmerica)
    {
        decimal totalPrice = 0;
        totalPrice += ((albumsInEurope * priceInEurope) * (decimal)1.94) +
                      ((albumsInNorthAmerica * priceInNorthAmerica) * (decimal)1.72) +
                      ((albumsInSouthAmerica * priceInSouthAmerica) / (decimal)332.74);

        decimal totalPriceForTheBand = (decimal)0.65 * totalPrice;
        decimal result = (decimal)0.8 * totalPriceForTheBand;

        return result;
    }

    static void Main()
    {
        int albumsInEurope = int.Parse(Console.ReadLine());
        decimal priceInEurope = decimal.Parse(Console.ReadLine());
        int albumsInNorthAmerica = int.Parse(Console.ReadLine());
        decimal priceInNorthAmerica = decimal.Parse(Console.ReadLine());
        int albumsInSouthAmerica = int.Parse(Console.ReadLine());
        decimal priceInSouthAmerica = decimal.Parse(Console.ReadLine());

        decimal profitAlbums = EstimateIncomeFromFirstProducer(albumsInEurope, priceInEurope,
            albumsInNorthAmerica, priceInNorthAmerica, albumsInSouthAmerica, priceInSouthAmerica);
        int numberOfConcerts = int.Parse(Console.ReadLine());
        decimal profitFromASingleConcertInEuro = decimal.Parse(Console.ReadLine());
        decimal profitConcertsInEuro = numberOfConcerts * profitFromASingleConcertInEuro;
        decimal profitConcerts = profitConcertsInEuro * (decimal)1.94;
        if (profitConcerts > 100000)
        {
            profitConcerts = (decimal)0.85 * profitConcerts;
        }

        if (profitAlbums > profitConcerts)
        {
            Console.WriteLine(@"Let's record some songs! They'll bring us {0:0.00}lv.", profitAlbums);
        }
        else
        {
            Console.WriteLine(@"On the road again! We'll see the world and earn {0:0.00}lv.", profitConcerts);
        }
    }
}

