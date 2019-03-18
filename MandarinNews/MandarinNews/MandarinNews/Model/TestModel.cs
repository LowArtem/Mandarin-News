using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NewsAPI;
using NewsAPI.Models;
using NewsAPI.Constants;
using System.Threading.Tasks;

namespace MandarinNews.Model
{
    class TestModel
    {
        private const string API_KEY = "87d7a28d9d46429ab88dfb9785ca55a7";

        public string totalResult;
        public string title;
        public string authors;
        public string description;
        public string url;
        public string urlImage;
        public string nameOfSource;

        public bool isStatusOk { get; private set; }



        public void GetResponce()
        {
            NewsApiClient newsApiClient = new NewsApiClient(API_KEY);

            ArticlesResult articlesResponse = newsApiClient.GetEverything(new EverythingRequest
            {
                SortBy = SortBys.PublishedAt,
                Language = Languages.RU,
                PageSize = 1,
            });


            if (articlesResponse.Status == Statuses.Ok)
            {
                totalResult = articlesResponse.TotalResults.ToString();

                foreach (var article in articlesResponse.Articles)
                {
                    title = article.Title;
                    authors = article.Author;
                    description = article.Description;
                    url = article.Url;
                    urlImage = article.UrlToImage;
                    nameOfSource = article.Source.Name;
                }
            }
            else
            {
                totalResult = "Error!";
            }

            newsApiClient = null;
        }

        public void GetResponce(string serachText)
        {
            NewsApiClient newsApiClient = new NewsApiClient(API_KEY);

            ArticlesResult articlesResponse = newsApiClient.GetEverything(new EverythingRequest
            {
                Q = serachText,
                SortBy = SortBys.PublishedAt,
                Language = Languages.RU,
                PageSize = 1,
            });


            if (articlesResponse.Status == Statuses.Ok)
            {
                totalResult = articlesResponse.TotalResults.ToString();

                foreach (var article in articlesResponse.Articles)
                {
                    title = article.Title;
                    authors = article.Author;
                    description =  article.Description;
                    url = article.Url;
                    urlImage = article.UrlToImage;
                    nameOfSource = article.Source.Name;
                }
            }
            else
            {
                totalResult = "Error!";
            }

            newsApiClient = null;
        }
    }
}
