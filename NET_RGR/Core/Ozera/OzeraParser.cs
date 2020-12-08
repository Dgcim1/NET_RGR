using AngleSharp.Html.Dom;
using System.Collections.Generic;
using System.Linq;

namespace NET_RGR.Core.Ozera
{
    class OzeraParser : IParser<Lake[]>
    {
        public Lake[] Parse(IHtmlDocument document) 
        {
            var list = new List<Lake>();
            var rows = document.QuerySelectorAll("tr").Where(item => item.ClassName != null && item.ClassName.Contains("table-row"));
            foreach (var row in rows)
            {
                var cells = row.QuerySelectorAll("td");
                var lake = new Lake();
                lake.Name = cells[0].TextContent.Trim();
                lake.Location = cells[1].TextContent.Trim();
                lake.BasinDistrinct = cells[2].TextContent.Trim();
                lake.RiverBasin = cells[3].TextContent.Trim();
                lake.Square = cells[4].TextContent.Trim();
                list.Add(lake);
            }
            return list.ToArray();
        }
    }
}
