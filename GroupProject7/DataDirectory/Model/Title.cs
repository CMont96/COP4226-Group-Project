using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupProject7.Model
{
    public class Title
    {
        // Properties matching the SQL table columns
        public string TitleId { get; set; } // Assuming 'tid' maps to an integer or similar type
        public string TitleName { get; set; } = string.Empty;
        public string Type { get; set; } = "UNDECIDED";
        public string PubId { get; set; } = null ;// Nullable foreign key
        public string Price { get; set; } = null;// MONEY maps to decimal in C#
        public string Advance { get; set; } = null;
        public string Royalty { get; set; } = null;
        public string YtdSales { get; set; } = null;
        public string Notes { get; set; } = "";
        public string PubDate { get; set; } = null;

        // Default constructor
        public Title() { }

        // Optional parameterized constructor for initialization
        public Title(
            string titleId,
            string titleName,
            string type = "UNDECIDED",
            string pubId = null,
            string price = null,
            string advance = null,
            string royalty = null,
            string ytdSales = null,
            string notes = "",
            string pubDate = null)
        {
            TitleId = titleId;
            TitleName = titleName;
            Type = type;
            PubId = pubId;
            Price = price;
            Advance = advance;
            Royalty = royalty;
            YtdSales = ytdSales;
            Notes = notes;
            PubDate = pubDate;
        }
    }
}
