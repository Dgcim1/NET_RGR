namespace NET_RGR.Core.Ozera
{
    class OzeraSettings : IParserSettings
    {
        public OzeraSettings(int start, int end) 
        {
            StartPoint = start;
            EndPoint = end;
        }

        public string BaseUrl { get; set; } = "https://ozera.info/lakes/about/gvr/list-lakes";

        public string Prefix { get; set; } = "{CurrentId}";

        public int StartPoint { get; set; }

        public int EndPoint { get; set; }
    }
}
