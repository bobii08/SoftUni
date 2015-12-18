using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusicShopManager.Interfaces;
using MusicShopManager.Models;

namespace MusicShop.Models
{
    public class AcousticGuitar : Guitar, IAcousticGuitar
    {
        public AcousticGuitar(string make, string model, decimal price, string color, 
            string bodyWood, string fingerboardWood, bool caseIncluded, StringMaterial stringMaterial)
            : base(make, model, price, color, false, bodyWood, fingerboardWood, Constants.AcousticAndElectricGuitarsNumberOfStrings)
        {
            this.CaseIncluded = caseIncluded;
            this.StringMaterial = stringMaterial;
        }

        public bool CaseIncluded { get; private set; }

        public StringMaterial StringMaterial { get; private set; }

        public override string ToString()
        {
            return base.ToString() + string.Format("\nCase included: {0}\nString material: {1}", 
                (this.CaseIncluded ? "yes" : "no"), this.StringMaterial);
        }
    }
}
