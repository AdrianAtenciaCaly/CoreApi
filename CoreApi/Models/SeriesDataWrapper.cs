namespace CoreApi.Models
{
    using System;
    using System.Collections.Generic;

    public class SeriesDataWrapper
    {
        public int? Code { get; set; }
        public string Status { get; set; }
        public string Copyright { get; set; }
        public string AttributionText { get; set; }
        public string AttributionHTML { get; set; }
        public SeriesDataContainer Data { get; set; }
        public string Etag { get; set; }
    }

    public class SeriesDataContainer
    {
        public int? Offset { get; set; }
        public int? Limit { get; set; }
        public int? Total { get; set; }
        public int? Count { get; set; }
        public List<Series> Results { get; set; }
    }

    public class Series
    {
        public int? Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ResourceURI { get; set; }
        public List<Url> Urls { get; set; }
        public int? StartYear { get; set; }
        public int? EndYear { get; set; }
        public string Rating { get; set; }
        public string? Modified { get; set; }
        public Image Thumbnail { get; set; }
        public ComicList Comics { get; set; }
        public StoryList Stories { get; set; }
        public EventList Events { get; set; }
        public CharacterList Characters { get; set; }
        public CreatorList Creators { get; set; }
        public SeriesSummary Next { get; set; }
        public SeriesSummary Previous { get; set; }
    }

    public class Url
    {
        public string Type { get; set; }
        public string UrlValue { get; set; }
    }

    public class Image
    {
        public string Path { get; set; }
        public string Extension { get; set; }
    }

    public class ComicList
    {
        public int? Available { get; set; }
        public int? Returned { get; set; }
        public string CollectionURI { get; set; }
        public List<ComicSummary> Items { get; set; }
    }

    public class ComicSummary
    {
        public string ResourceURI { get; set; }
        public string Name { get; set; }
    }

    public class StoryList
    {
        public int? Available { get; set; }
        public int? Returned { get; set; }
        public string CollectionURI { get; set; }
        public List<StorySummary> Items { get; set; }
    }

    public class StorySummary
    {
        public string ResourceURI { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
    }

    public class EventList
    {
        public int? Available { get; set; }
        public int? Returned { get; set; }
        public string CollectionURI { get; set; }
        public List<EventSummary> Items { get; set; }
    }

    public class EventSummary
    {
        public string ResourceURI { get; set; }
        public string Name { get; set; }
    }

    public class CharacterList
    {
        public int? Available { get; set; }
        public int? Returned { get; set; }
        public string CollectionURI { get; set; }
        public List<CharacterSummary> Items { get; set; }
    }

    public class CharacterSummary
    {
        public string ResourceURI { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }
    }

    public class CreatorList
    {
        public int? Available { get; set; }
        public int? Returned { get; set; }
        public string CollectionURI { get; set; }
        public List<CreatorSummary> Items { get; set; }
    }

    public class CreatorSummary
    {
        public string ResourceURI { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }
    }

    public class SeriesSummary
    {
        public string ResourceURI { get; set; }
        public string Name { get; set; }
    }

}
