﻿//код взят из https://github.com/extremecodetv/Html-Parser-Tutorial

namespace NET_RGR.Core
{
    interface IParserSettings
    {
        string BaseUrl { get; set; }

        string Prefix { get; set; }

        int StartPoint { get; set; }

        int EndPoint { get; set; }
    }
}
