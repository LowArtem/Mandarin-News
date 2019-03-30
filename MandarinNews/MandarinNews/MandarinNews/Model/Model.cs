using NewsAPI;
using NewsAPI.Constants;
using NewsAPI.Models;
using System;
using System.Collections.Generic;

namespace MandarinNews.Model
{
    class Model
    {
        private const string API_KEY = "87d7a28d9d46429ab88dfb9785ca55a7";

        private NewsApiClient Client;
        private ArticlesResult articlesResponse;

        public bool isStatusOk { get; private set; }

        public string Authors { get; private set; }
        public string Description { get; private set; }
        public string Title { get; private set; }
        public string NameOfSource { get; private set; }
        public string URL { get; private set; }
        public string UrlImage { get; private set; }
        public string TotalResult { get; private set; }
        public string PublishedAt { get; private set; }


        public Model()
        {
            Client = new NewsApiClient(API_KEY);
        }

        #region public void Response(...)
        /// <summary>
        /// Response to google news api
        /// </summary>
        /// <param name="sort">Sort by</param>
        /// <param name="lang">language news</param>
        /// <param name="dateTime">news in this date time</param>
        /// <param name="searchText">searching words</param>
        /// <param name="pageSize">Page counts</param>
        /// <param name="page">Page number</param>
        public void Response(SortBys sort, Languages lang, DateTime dateTime, string searchText, int pageSize, int page)
        {
            articlesResponse = Client.GetEverything(new EverythingRequest
            {
                SortBy = sort,
                Language = lang,
                From = dateTime,
                Q = searchText,
                PageSize = pageSize,
            });
            
            InformationSctructuring(page);
        }

        /// <summary>
        /// Response to google news api
        /// </summary>
        /// <param name="sort">Sort by</param>
        /// <param name="lang">Language news</param>
        /// <param name="dateTime">News in this date time</param>
        /// <param name="page">Page number</param>
        public void Response(SortBys sort, Languages lang, DateTime dateTime, int pageSize, int page)
        {
            articlesResponse = Client.GetEverything(new EverythingRequest
            {
                SortBy = sort,
                Language = lang,
                From = dateTime,
                PageSize = pageSize,
            });
            
            InformationSctructuring(page);
        }

        /// <summary>
        /// Response to google news api
        /// </summary>
        /// <param name="lang">Language news</param>
        /// <param name="dateTime">News in this date time</param>
        /// <param name="searchText">searching words</param>
        /// <param name="page">Page number</param>
        public void Response(Languages lang, DateTime dateTime, string searchText, int pageSize, int page)
        {
            articlesResponse = Client.GetEverything(new EverythingRequest
            {
                Language = lang,
                From = dateTime,
                Q = searchText,
                SortBy = SortBys.Relevancy,
                PageSize = pageSize,
            });

            InformationSctructuring(page);            
        }

        /// <summary>
        /// Response to google news api
        /// </summary>
        /// <param name="sort">Sort by</param>
        /// <param name="lang">Language news</param>
        /// <param name="searchText">searching words</param>
        /// <param name="page">Page number</param>
        public void Response(SortBys sort, Languages lang, string searchText, int pageSize, int page)
        {
            articlesResponse = Client.GetEverything(new EverythingRequest
            {
                SortBy = sort,
                Language = lang,
                Q = searchText,
                PageSize = pageSize,
            });

            InformationSctructuring(page);            
        }

        /// <summary>
        /// Response to google news api
        /// </summary>
        /// <param name="lang">Language news</param>
        /// <param name="sort">Sort by</param>
        /// <param name="page">Page number</param>
        public void Response(Languages lang, SortBys sort, int pageSize, int page)
        {
            articlesResponse = Client.GetEverything(new EverythingRequest
            {
                SortBy = sort,
                Language = lang,
                PageSize = pageSize,
            });

            InformationSctructuring(page);           
        }

        /// <summary>
        /// Response to google news api
        /// </summary>
        /// <param name="lang">Language news</param>
        /// <param name="dateTime">News in this date time</param>
        /// <param name="page">Page number</param>
        public void Response(Languages lang, DateTime dateTime, int pageSize, int page)
        {
            articlesResponse = Client.GetEverything(new EverythingRequest
            {
                From = dateTime,
                Language = lang,
                PageSize = pageSize,
            });

            InformationSctructuring(page);            
        }

        /// <summary>
        /// Response to google news api
        /// </summary>
        /// <param name="lang">Language news</param>
        /// <param name="searchText">searching words</param>
        /// <param name="page">Page number</param>
        public void Response(Languages lang, string searchText, int pageSize, int page)
        {
            articlesResponse = Client.GetEverything(new EverythingRequest
            {
                Q = searchText,
                SortBy = SortBys.Relevancy,
                Language = lang,
                PageSize = pageSize,
            });

            InformationSctructuring(page);            
        }

        /// <summary>
        /// Response to google news api
        /// </summary>
        /// <param name="lang">Language news</param>
        /// <param name="page">Page number</param>
        public void Response(Languages lang, int pageSize, int page)
        {
            articlesResponse = Client.GetEverything(new EverythingRequest
            {
                Language = lang,
                PageSize = pageSize,
            });


            InformationSctructuring(page);
        }

        /// <summary>
        /// Response to google news api
        /// </summary>
        /// <param name="sort">Sort by</param>
        /// <param name="lang">language news</param>
        /// <param name="dateTime">news in this date time</param>
        /// <param name="searchText">searching words</param>
        /// <param name="pageSize">Page counts</param>
        /// <param name="page">Page number</param>
        /// <param name="source">Information source</param>
        public void Response(SortBys sort, Languages lang, DateTime dateTime, string searchText, List<string> source, int pageSize, int page)
        {
            articlesResponse = Client.GetEverything(new EverythingRequest
            {
                SortBy = sort,
                Language = lang,
                From = dateTime,
                Q = searchText,
                PageSize = pageSize,
                Sources = source,
            });

            InformationSctructuring(page);
        }

        /// <summary>
        /// Response to google news api
        /// </summary>
        /// <param name="sort">Sort by</param>
        /// <param name="lang">Language news</param>
        /// <param name="dateTime">News in this date time</param>
        /// <param name="page">Page number</param>
        /// <param name="source">Information source</param>
        public void Response(SortBys sort, Languages lang, DateTime dateTime, List<string> source, int pageSize, int page)
        {
            articlesResponse = Client.GetEverything(new EverythingRequest
            {
                SortBy = sort,
                Language = lang,
                From = dateTime,
                PageSize = pageSize,
                Sources = source,
            });

            InformationSctructuring(page);
        }

        /// <summary>
        /// Response to google news api
        /// </summary>
        /// <param name="lang">Language news</param>
        /// <param name="dateTime">News in this date time</param>
        /// <param name="searchText">searching words</param>
        /// <param name="page">Page number</param>
        /// <param name="source">Information source</param>
        public void Response(Languages lang, DateTime dateTime, string searchText, List<string> source, int pageSize, int page)
        {
            articlesResponse = Client.GetEverything(new EverythingRequest
            {
                Language = lang,
                From = dateTime,
                Q = searchText,
                SortBy = SortBys.Relevancy,
                PageSize = pageSize,
                Sources = source,
            });

            InformationSctructuring(page);
        }

        /// <summary>
        /// Response to google news api
        /// </summary>
        /// <param name="sort">Sort by</param>
        /// <param name="lang">Language news</param>
        /// <param name="searchText">searching words</param>
        /// <param name="page">Page number</param>
        /// <param name="source">Information source</param>
        public void Response(SortBys sort, Languages lang, string searchText, List<string> source, int pageSize, int page)
        {
            articlesResponse = Client.GetEverything(new EverythingRequest
            {
                SortBy = sort,
                Language = lang,
                Q = searchText,
                PageSize = pageSize,
                Sources = source,
            });

            InformationSctructuring(page);
        }

        /// <summary>
        /// Response to google news api
        /// </summary>
        /// <param name="lang">Language news</param>
        /// <param name="sort">Sort by</param>
        /// <param name="page">Page number</param>
        /// <param name="source">Information source</param>
        public void Response(Languages lang, SortBys sort, List<string> source, int pageSize, int page)
        {
            articlesResponse = Client.GetEverything(new EverythingRequest
            {
                SortBy = sort,
                Language = lang,
                PageSize = pageSize,
                Sources = source,
            });

            InformationSctructuring(page);
        }

        /// <summary>
        /// Response to google news api
        /// </summary>
        /// <param name="lang">Language news</param>
        /// <param name="dateTime">News in this date time</param>
        /// <param name="page">Page number</param>
        /// <param name="source">Information source</param>
        public void Response(Languages lang, DateTime dateTime, List<string> source, int pageSize, int page)
        {
            articlesResponse = Client.GetEverything(new EverythingRequest
            {
                From = dateTime,
                Language = lang,
                PageSize = pageSize,
                Sources = source,
            });

            InformationSctructuring(page);
        }

        /// <summary>
        /// Response to google news api
        /// </summary>
        /// <param name="lang">Language news</param>
        /// <param name="searchText">searching words</param>
        /// <param name="page">Page number</param>
        /// <param name="source">Information source</param>
        public void Response(Languages lang, string searchText, List<string> source, int pageSize, int page)
        {
            articlesResponse = Client.GetEverything(new EverythingRequest
            {
                Q = searchText,
                SortBy = SortBys.Relevancy,
                Language = lang,
                PageSize = pageSize,
                Sources = source,
            });

            InformationSctructuring(page);
        }

        /// <summary>
        /// Response to google news api
        /// </summary>
        /// <param name="lang">Language news</param>
        /// <param name="page">Page number</param>
        /// <param name="source">Information source</param>
        public void Response(Languages lang, List<string> source, int pageSize, int page)
        {
            articlesResponse = Client.GetEverything(new EverythingRequest
            {
                Language = lang,
                PageSize = pageSize,
                Sources = source,
            });


            InformationSctructuring(page);
        }
        #endregion


        #region public void ResponseHeadlines(...)
        /// <summary>
        /// Get top headlines from google news api
        /// </summary>
        /// <param name="language">Language news</param>
        /// <param name="country">Counrty news</param>
        /// <param name="searchText">Searching words</param>
        /// <param name="category">Search category</param>
        /// <param name="pageSize">Page counts</param>
        /// <param name="page">Page number</param>
        public void ResponseHeadlines(Languages language, Countries country, string searchText, Categories category, int pageSize, int page)
        {
            articlesResponse = Client.GetTopHeadlines(new TopHeadlinesRequest
            {
                Language = language,
                Country = country,
                Q = searchText,
                Category = category,
                PageSize = pageSize,
            });

            InformationSctructuring(page);            
        }

        /// <summary>
        /// Get top headlines from google news api
        /// </summary>
        /// <param name="language">Language news</param>
        /// <param name="searchText">Searching words</param>
        /// <param name="category">Search category</param>
        /// <param name="pageSize">Page counts</param>
        /// <param name="page">Page number</param>
        public void ResponseHeadlines(Languages language, string searchText, Categories category, int pageSize, int page)
        {
            articlesResponse = Client.GetTopHeadlines(new TopHeadlinesRequest
            {
                Language = language,
                Q = searchText,
                Category = category,
                PageSize = pageSize,
            });

            InformationSctructuring(page);            
        }

        /// <summary>
        /// Get top headlines from google news api
        /// </summary>
        /// <param name="language">Language news</param>
        /// <param name="country">Counrty news</param>
        /// <param name="category">Search category</param>
        /// <param name="pageSize">Page counts</param>
        /// <param name="page">Page number</param>
        public void ResponseHeadlines(Languages language, Countries country, Categories category, int pageSize, int page)
        {
            articlesResponse = Client.GetTopHeadlines(new TopHeadlinesRequest
            {
                Language = language,
                Country = country,
                Category = category,
                PageSize = pageSize,
            });

            InformationSctructuring(page);
        }

        /// <summary>
        /// Get top headlines from google news api
        /// </summary>
        /// <param name="language">Language news</param>
        /// <param name="country">Counrty news</param>
        /// <param name="searchText">Searching words</param>
        /// <param name="pageSize">Page counts</param>
        /// <param name="page">Page number</param>
        public void ResponseHeadlines(Languages language, Countries country, string searchText, int pageSize, int page)
        {
            articlesResponse = Client.GetTopHeadlines(new TopHeadlinesRequest
            {
                Language = language,
                Country = country,
                Q = searchText,
                PageSize = pageSize,
            });

            InformationSctructuring(page);            
        }

        /// <summary>
        /// Get top headlines from google news api
        /// </summary>
        /// <param name="language">Language news</param>
        /// <param name="category">Search category</param>
        /// <param name="pageSize">Page counts</param>
        /// <param name="page">Page number</param>
        public void ResponseHeadlines(Languages language, Categories category, int pageSize, int page)
        {
            articlesResponse = Client.GetTopHeadlines(new TopHeadlinesRequest
            {
                Language = language,
                Category = category,
                PageSize = pageSize,
            });

            InformationSctructuring(page);            
        }

        /// <summary>
        /// Get top headlines from google news api
        /// </summary>
        /// <param name="language">Language news</param>
        /// <param name="country">Counrty news</param>
        /// <param name="pageSize">Page counts</param>
        /// <param name="page">Page number</param>
        public void ResponseHeadlines(Languages language, Countries country, int pageSize, int page)
        {
            articlesResponse = Client.GetTopHeadlines(new TopHeadlinesRequest
            {
                Language = language,
                Country = country,
                PageSize = pageSize,
            });

            InformationSctructuring(page);            
        }

        /// <summary>
        /// Get top headlines from google news api
        /// </summary>
        /// <param name="language">Language news</param>
        /// <param name="searchText">Searching words</param>
        /// <param name="pageSize">Page counts</param>
        /// <param name="page">Page number</param>
        public void ResponseHeadlines(Languages language, string searchText, int pageSize, int page)
        {
            articlesResponse = Client.GetTopHeadlines(new TopHeadlinesRequest
            {
                Language = language,
                Q = searchText,
                PageSize = pageSize,
            });

            InformationSctructuring(page);            
        }

        /// <summary>
        /// Get top headlines from google news api
        /// </summary>
        /// <param name="language">Language news</param>
        /// <param name="pageSize">Page counts</param>
        /// <param name="page">Page number</param>
        public void ResponseHeadlines(Languages language, int pageSize, int page)
        {
            articlesResponse = Client.GetTopHeadlines(new TopHeadlinesRequest
            {
                Language = language,
                PageSize = pageSize,
            });

            InformationSctructuring(page);            
        }

        /// <summary>
        /// Get top headlines from google news api
        /// </summary>
        /// <param name="language">Language news</param>
        /// <param name="country">Counrty news</param>
        /// <param name="searchText">Searching words</param>
        /// <param name="category">Search category</param>
        /// <param name="pageSize">Page counts</param>
        /// <param name="page">Page number</param>
        /// <param name="source">Information source</param>
        public void ResponseHeadlines(Languages language, Countries country, string searchText, List<string> source, Categories category, int pageSize, int page)
        {
            articlesResponse = Client.GetTopHeadlines(new TopHeadlinesRequest
            {
                Language = language,
                Country = country,
                Q = searchText,
                Category = category,
                PageSize = pageSize,
                Sources = source,
            });

            InformationSctructuring(page);
        }

        /// <summary>
        /// Get top headlines from google news api
        /// </summary>
        /// <param name="language">Language news</param>
        /// <param name="searchText">Searching words</param>
        /// <param name="category">Search category</param>
        /// <param name="pageSize">Page counts</param>
        /// <param name="page">Page number</param>
        /// <param name="source">Information source</param>
        public void ResponseHeadlines(Languages language, string searchText, List<string> source, Categories category, int pageSize, int page)
        {
            articlesResponse = Client.GetTopHeadlines(new TopHeadlinesRequest
            {
                Language = language,
                Q = searchText,
                Category = category,
                PageSize = pageSize,
                Sources = source,
            });

            InformationSctructuring(page);
        }

        /// <summary>
        /// Get top headlines from google news api
        /// </summary>
        /// <param name="language">Language news</param>
        /// <param name="country">Counrty news</param>
        /// <param name="category">Search category</param>
        /// <param name="pageSize">Page counts</param>
        /// <param name="page">Page number</param>
        /// <param name="source">Information source</param>
        public void ResponseHeadlines(Languages language, Countries country, List<string> source, Categories category, int pageSize, int page)
        {
            articlesResponse = Client.GetTopHeadlines(new TopHeadlinesRequest
            {
                Language = language,
                Country = country,
                Category = category,
                PageSize = pageSize,
                Sources = source,
            });

            InformationSctructuring(page);
        }

        /// <summary>
        /// Get top headlines from google news api
        /// </summary>
        /// <param name="language">Language news</param>
        /// <param name="country">Counrty news</param>
        /// <param name="searchText">Searching words</param>
        /// <param name="pageSize">Page counts</param>
        /// <param name="page">Page number</param>
        /// <param name="source">Information source</param>
        public void ResponseHeadlines(Languages language, Countries country, string searchText, List<string> source, int pageSize, int page)
        {
            articlesResponse = Client.GetTopHeadlines(new TopHeadlinesRequest
            {
                Language = language,
                Country = country,
                Q = searchText,
                PageSize = pageSize,
                Sources = source,
            });

            InformationSctructuring(page);
        }

        /// <summary>
        /// Get top headlines from google news api
        /// </summary>
        /// <param name="language">Language news</param>
        /// <param name="category">Search category</param>
        /// <param name="pageSize">Page counts</param>
        /// <param name="page">Page number</param>
        /// <param name="source">Information source</param>
        public void ResponseHeadlines(Languages language, List<string> source, Categories category, int pageSize, int page)
        {
            articlesResponse = Client.GetTopHeadlines(new TopHeadlinesRequest
            {
                Language = language,
                Category = category,
                PageSize = pageSize,
                Sources = source,
            });

            InformationSctructuring(page);
        }

        /// <summary>
        /// Get top headlines from google news api
        /// </summary>
        /// <param name="language">Language news</param>
        /// <param name="country">Counrty news</param>
        /// <param name="pageSize">Page counts</param>
        /// <param name="page">Page number</param>
        /// <param name="source">Information source</param>
        public void ResponseHeadlines(Languages language, Countries country, List<string> source, int pageSize, int page)
        {
            articlesResponse = Client.GetTopHeadlines(new TopHeadlinesRequest
            {
                Language = language,
                Country = country,
                PageSize = pageSize,
                Sources = source,
            });

            InformationSctructuring(page);
        }

        /// <summary>
        /// Get top headlines from google news api
        /// </summary>
        /// <param name="language">Language news</param>
        /// <param name="searchText">Searching words</param>
        /// <param name="pageSize">Page counts</param>
        /// <param name="page">Page number</param>
        /// <param name="source">Information source</param>
        public void ResponseHeadlines(Languages language, string searchText, List<string> source, int pageSize, int page)
        {
            articlesResponse = Client.GetTopHeadlines(new TopHeadlinesRequest
            {
                Language = language,
                Q = searchText,
                PageSize = pageSize,
                Sources = source,
            });

            InformationSctructuring(page);
        }

        /// <summary>
        /// Get top headlines from google news api
        /// </summary>
        /// <param name="language">Language news</param>
        /// <param name="pageSize">Page counts</param>
        /// <param name="page">Page number</param>
        /// <param name="source">Information source</param>
        public void ResponseHeadlines(Languages language, List<string> source, int pageSize, int page)
        {
            articlesResponse = Client.GetTopHeadlines(new TopHeadlinesRequest
            {
                Language = language,
                PageSize = pageSize,
                Sources = source,
            });

            InformationSctructuring(page);
        }
        #endregion


        #region public void ResponseOnPage(...)
        /// <summary>
        /// Response with page to google news api
        /// </summary>
        /// <param name="sort">Sort by</param>
        /// <param name="lang">language news</param>
        /// <param name="dateTime">news in this date time</param>
        /// <param name="searchText">searching words</param>
        /// <param name="pageSize">Page counts</param>
        /// <param name="page">Page number</param>
        public void ResponseOnPage(SortBys sort, Languages lang, DateTime dateTime, string searchText, int pageSize, int page)
        {
            articlesResponse = Client.GetEverything(new EverythingRequest
            {
                SortBy = sort,
                Language = lang,
                From = dateTime,
                Q = searchText,
                PageSize = pageSize,
                Page = page,
            });

            PageInformationSctructuring(page, pageSize);
        }

        /// <summary>
        /// Response with page to google news api
        /// </summary>
        /// <param name="sort">Sort by</param>
        /// <param name="lang">Language news</param>
        /// <param name="dateTime">News in this date time</param>
        /// <param name="page">Page number</param>
        public void ResponseOnPage(SortBys sort, Languages lang, DateTime dateTime, int pageSize, int page)
        {
            articlesResponse = Client.GetEverything(new EverythingRequest
            {
                SortBy = sort,
                Language = lang,
                From = dateTime,
                PageSize = pageSize,
                Page = page,
            });

            PageInformationSctructuring(page, pageSize);
        }

        /// <summary>
        /// Response with page to google news api
        /// </summary>
        /// <param name="lang">Language news</param>
        /// <param name="dateTime">News in this date time</param>
        /// <param name="searchText">searching words</param>
        /// <param name="page">Page number</param>
        public void ResponseOnPage(Languages lang, DateTime dateTime, string searchText, int pageSize, int page)
        {
            articlesResponse = Client.GetEverything(new EverythingRequest
            {
                Language = lang,
                From = dateTime,
                Q = searchText,
                SortBy = SortBys.Relevancy,
                PageSize = pageSize,
                Page = page,
            });

            PageInformationSctructuring(page, pageSize);
        }

        /// <summary>
        /// Response with page to google news api
        /// </summary>
        /// <param name="sort">Sort by</param>
        /// <param name="lang">Language news</param>
        /// <param name="searchText">searching words</param>
        /// <param name="page">Page number</param>
        public void ResponseOnPage(SortBys sort, Languages lang, string searchText, int pageSize, int page)
        {
            articlesResponse = Client.GetEverything(new EverythingRequest
            {
                SortBy = sort,
                Language = lang,
                Q = searchText,
                PageSize = pageSize,
                Page = page,
            });

            PageInformationSctructuring(page, pageSize);
        }

        /// <summary>
        /// Response with page to google news api
        /// </summary>
        /// <param name="lang">Language news</param>
        /// <param name="sort">Sort by</param>
        /// <param name="page">Page number</param>
        public void ResponseOnPage(Languages lang, SortBys sort, int pageSize, int page)
        {
            articlesResponse = Client.GetEverything(new EverythingRequest
            {
                SortBy = sort,
                Language = lang,
                PageSize = pageSize,
                Page = page,
            });

            PageInformationSctructuring(page, pageSize);
        }

        /// <summary>
        /// Response with page to google news api
        /// </summary>
        /// <param name="lang">Language news</param>
        /// <param name="dateTime">News in this date time</param>
        /// <param name="page">Page number</param>
        public void ResponseOnPage(Languages lang, DateTime dateTime, int pageSize, int page)
        {
            articlesResponse = Client.GetEverything(new EverythingRequest
            {
                From = dateTime,
                Language = lang,
                PageSize = pageSize,
                Page = page,
            });

            PageInformationSctructuring(page, pageSize);
        }

        /// <summary>
        /// Response with page to google news api
        /// </summary>
        /// <param name="lang">Language news</param>
        /// <param name="searchText">searching words</param>
        /// <param name="page">Page number</param>
        public void ResponseOnPage(Languages lang, string searchText, int pageSize, int page)
        {
            articlesResponse = Client.GetEverything(new EverythingRequest
            {
                Q = searchText,
                SortBy = SortBys.Relevancy,
                Language = lang,
                PageSize = pageSize,
                Page = page,
            });

            PageInformationSctructuring(page, pageSize);
        }

        /// <summary>
        /// Response with page to google news api
        /// </summary>
        /// <param name="lang">Language news</param>
        /// <param name="page">Page number</param>
        public void ResponseOnPage(Languages lang, int pageSize, int page)
        {
            articlesResponse = Client.GetEverything(new EverythingRequest
            {
                Language = lang,
                PageSize = pageSize,
                Page = page,
            });


            PageInformationSctructuring(page, pageSize);
        }

        /// <summary>
        /// Response with page to google news api
        /// </summary>
        /// <param name="sort">Sort by</param>
        /// <param name="lang">language news</param>
        /// <param name="dateTime">news in this date time</param>
        /// <param name="searchText">searching words</param>
        /// <param name="pageSize">Page counts</param>
        /// <param name="page">Page number</param>
        /// <param name="source">Information source</param>
        public void ResponseOnPage(SortBys sort, Languages lang, DateTime dateTime, string searchText, List<string> source, int pageSize, int page)
        {
            articlesResponse = Client.GetEverything(new EverythingRequest
            {
                SortBy = sort,
                Language = lang,
                From = dateTime,
                Q = searchText,
                PageSize = pageSize,
                Sources = source,
                Page = page,
            });

            PageInformationSctructuring(page, pageSize);
        }

        /// <summary>
        /// Response with page to google news api
        /// </summary>
        /// <param name="sort">Sort by</param>
        /// <param name="lang">Language news</param>
        /// <param name="dateTime">News in this date time</param>
        /// <param name="page">Page number</param>
        /// <param name="source">Information source</param>
        public void ResponseOnPage(SortBys sort, Languages lang, DateTime dateTime, List<string> source, int pageSize, int page)
        {
            articlesResponse = Client.GetEverything(new EverythingRequest
            {
                SortBy = sort,
                Language = lang,
                From = dateTime,
                PageSize = pageSize,
                Sources = source,
                Page = page,
            });

            PageInformationSctructuring(page, pageSize);
        }

        /// <summary>
        /// Response with page to google news api
        /// </summary>
        /// <param name="lang">Language news</param>
        /// <param name="dateTime">News in this date time</param>
        /// <param name="searchText">searching words</param>
        /// <param name="page">Page number</param>
        /// <param name="source">Information source</param>
        public void ResponseOnPage(Languages lang, DateTime dateTime, string searchText, List<string> source, int pageSize, int page)
        {
            articlesResponse = Client.GetEverything(new EverythingRequest
            {
                Language = lang,
                From = dateTime,
                Q = searchText,
                SortBy = SortBys.Relevancy,
                PageSize = pageSize,
                Sources = source,
                Page = page,
            });

            PageInformationSctructuring(page, pageSize);
        }

        /// <summary>
        /// Response with page to google news api
        /// </summary>
        /// <param name="sort">Sort by</param>
        /// <param name="lang">Language news</param>
        /// <param name="searchText">searching words</param>
        /// <param name="page">Page number</param>
        /// <param name="source">Information source</param>
        public void ResponseOnPage(SortBys sort, Languages lang, string searchText, List<string> source, int pageSize, int page)
        {
            articlesResponse = Client.GetEverything(new EverythingRequest
            {
                SortBy = sort,
                Language = lang,
                Q = searchText,
                PageSize = pageSize,
                Sources = source,
                Page = page,
            });

            PageInformationSctructuring(page, pageSize);
        }

        /// <summary>
        /// Response with page to google news api
        /// </summary>
        /// <param name="lang">Language news</param>
        /// <param name="sort">Sort by</param>
        /// <param name="page">Page number</param>
        /// <param name="source">Information source</param>
        public void ResponseOnPage(Languages lang, SortBys sort, List<string> source, int pageSize, int page)
        {
            articlesResponse = Client.GetEverything(new EverythingRequest
            {
                SortBy = sort,
                Language = lang,
                PageSize = pageSize,
                Sources = source,
                Page = page,
            });

            PageInformationSctructuring(page, pageSize);
        }

        /// <summary>
        /// Response with page to google news api
        /// </summary>
        /// <param name="lang">Language news</param>
        /// <param name="dateTime">News in this date time</param>
        /// <param name="page">Page number</param>
        /// <param name="source">Information source</param>
        public void ResponseOnPage(Languages lang, DateTime dateTime, List<string> source, int pageSize, int page)
        {
            articlesResponse = Client.GetEverything(new EverythingRequest
            {
                From = dateTime,
                Language = lang,
                PageSize = pageSize,
                Sources = source,
                Page = page,
            });

            PageInformationSctructuring(page, pageSize);
        }

        /// <summary>
        /// Response with page to google news api
        /// </summary>
        /// <param name="lang">Language news</param>
        /// <param name="searchText">searching words</param>
        /// <param name="page">Page number</param>
        /// <param name="source">Information source</param>
        public void ResponseOnPage(Languages lang, string searchText, List<string> source, int pageSize, int page)
        {
            articlesResponse = Client.GetEverything(new EverythingRequest
            {
                Q = searchText,
                SortBy = SortBys.Relevancy,
                Language = lang,
                PageSize = pageSize,
                Sources = source,
                Page = page,
            });

            PageInformationSctructuring(page, pageSize);
        }

        /// <summary>
        /// Response with page to google news api
        /// </summary>
        /// <param name="lang">Language news</param>
        /// <param name="page">Page number</param>
        /// <param name="source">Information source</param>
        public void ResponseOnPage(Languages lang, List<string> source, int pageSize, int page)
        {
            articlesResponse = Client.GetEverything(new EverythingRequest
            {
                Language = lang,
                PageSize = pageSize,
                Sources = source,
                Page = page,
            });


            PageInformationSctructuring(page, pageSize);
        }
        #endregion


        #region public void InformationSctructuring(int)
        /// <summary>
        /// Convert information from google api to string params. This method will be using after Response
        /// </summary>
        /// <param name="page">Page number</param>
        public void InformationSctructuring(int page)
        {
            if (articlesResponse != null)
            {
                int counter = 0;

                if (articlesResponse.Status == Statuses.Ok)
                {
                    isStatusOk = true;

                    TotalResult = articlesResponse.TotalResults.ToString();

                    foreach (var article in articlesResponse.Articles)
                    {
                        counter++;

                        Authors = article.Author;
                        Description = article.Description;
                        Title = article.Title;
                        NameOfSource = article.Source.Name;
                        URL = article.Url;
                        UrlImage = article.UrlToImage;
                        PublishedAt = (article.PublishedAt.Value.ToLocalTime()).ToString();

                        if (counter >= page)
                            break;
                    }
                }
                else
                {
                    isStatusOk = false;
                }
            }
            else
                isStatusOk = false;
        }
        #endregion


        #region public void PageInformationSctructuring(int, int)
        /// <summary>
        /// Convert information from google api to string params. This method will be using after ResponseOnPage
        /// </summary>
        /// <param name="page">Page number</param>
        public void PageInformationSctructuring(int page, int PAGE_SIZE)
        {
            if (articlesResponse != null)
            {
                int counter = 100;

                if (page == PAGE_SIZE || page == PAGE_SIZE + 1)
                    counter = 100;
                else
                {
                    int сoeff = page / PAGE_SIZE;

                    counter = сoeff * 100;
                }

                if (articlesResponse.Status == Statuses.Ok)
                {
                    isStatusOk = true;

                    TotalResult = articlesResponse.TotalResults.ToString();

                    foreach (var article in articlesResponse.Articles)
                    {
                        counter++;

                        Authors = article.Author;
                        Description = article.Description;
                        Title = article.Title;
                        NameOfSource = article.Source.Name;
                        URL = article.Url;
                        UrlImage = article.UrlToImage;
                        PublishedAt = (article.PublishedAt.Value.ToLocalTime()).ToString();

                        if (counter >= page)
                            break;
                    }
                }
                else
                {
                    isStatusOk = false;
                }
            }
            else
                isStatusOk = false;
        }
        #endregion
    }
}
