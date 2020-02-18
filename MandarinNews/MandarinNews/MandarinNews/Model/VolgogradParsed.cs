using System;
using System.Collections.Generic;

namespace MandarinNews.Model
{
    class VolgogradParsed
    {
        public string Id { get; set; }
        public DateTimeOffset PublishDate { get; set; }
        public string DiscoverDate { get; set; }
        public string Title { get; set; }
        public string Language { get; set; }
        public string Text { get; set; }
        public string StructuredText { get; set; }
        public Uri Url { get; set; }
        public List<Element> Elements { get; set; }
        public Website Website { get; set; }
        public Metadata Metadata { get; set; }
        public string Highlight { get; set; }
        public double Score { get; set; }
    }

    public partial class Element
    {
        public string Type { get; set; }
        public bool Primary { get; set; }
        public Uri Url { get; set; }
        public object Width { get; set; }
        public object Height { get; set; }
        public object Title { get; set; }
        public object Alternative { get; set; }
    }

    public partial class Metadata
    {
        public ReadTime ReadTime { get; set; }
        public Category Category { get; set; }
    }

    public partial class Category
    {
        public string Type { get; set; }
        public string Country { get; set; }
        public string Region { get; set; }
        public string CategoryCategory { get; set; }
        public object CountryCode { get; set; }
    }

    public partial class ReadTime
    {
        public string Type { get; set; }
        public long Seconds { get; set; }
    }

    public partial class Website
    {
        public string Name { get; set; }
        public string HostName { get; set; }
        public string DomainName { get; set; }
        public Uri IconUrl { get; set; }
        public string CountryName { get; set; }
        public string CountryCode { get; set; }
        public object Region { get; set; }
    }
}