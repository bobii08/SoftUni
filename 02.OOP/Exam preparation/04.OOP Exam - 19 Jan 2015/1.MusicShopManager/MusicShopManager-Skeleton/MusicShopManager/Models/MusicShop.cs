using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusicShopManager.Interfaces;

namespace MusicShop.Models
{
    public class MusicShop : IMusicShop
    {
        private string name;
        private readonly IList<IArticle> articles;

        public MusicShop(string name)
        {
            this.Name = name;
            this.articles = new List<IArticle>();
        }

        public string Name
        {
            get { return this.name; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("The name is required.");
                }
                this.name = value;
            }
        }

        public IList<IArticle> Articles
        {
            get { return this.articles; }
        }

        public void AddArticle(IArticle article)
        {
            this.Articles.Add(article);
        }

        public void RemoveArticle(IArticle article)
        {
            this.Articles.Remove(article);
        }

        public string ListArticles()
        {
            StringBuilder result = new StringBuilder();
            result.AppendFormat("===== {0} =====", this.Name);
            result.AppendLine();
            if (!this.Articles.Any())
            {
                result.Append("The shop is empty. Come back soon.");
                return result.ToString();
            }

            var microphones = this.Articles.Where(a => a is Microphone);
            result.Append(this.PrintArticles(microphones, "Microphones"));

            var drums = this.Articles.Where(a => a is Drums);
            result.Append(this.PrintArticles(drums, "Drums"));

            var electricGuitars = this.Articles.Where(a => a is ElectricGuitar);
            result.Append(this.PrintArticles(electricGuitars, "Electric guitars"));

            var acousticGuitars = this.Articles.Where(a => a is AcousticGuitar);
            result.Append(this.PrintArticles(acousticGuitars, "Acoustic guitars"));

            var bassGuitars = this.Articles.Where(a => a is BassGuitar);
            result.Append(this.PrintArticles(bassGuitars, "Bass guitars"));

            return result.ToString();
        }

        private string PrintArticles(IEnumerable<IArticle> articles, string title)
        {
            if (articles.Count() == 0)
            {
                return string.Empty;
            }

            StringBuilder articlesAsString = new StringBuilder();
            articles = articles.OrderBy(a => a.Make + " " + a.Model);
            articlesAsString.AppendFormat("{0} {1} {0}", new string('-', 5), title).AppendLine();
            foreach (var article in articles)
            {
                articlesAsString.AppendLine(article.ToString());
            }

            return articlesAsString.ToString();
        }
    }
}
