//код взят из https://github.com/extremecodetv/Html-Parser-Tutorial

using AngleSharp.Html.Dom;

namespace NET_RGR.Core
{
    interface IParser<T> where T : class
    {
        T Parse(IHtmlDocument document);
    }
}
