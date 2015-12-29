using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using Microsoft.Extensions.WebEncoders;
using Microsoft.AspNet.Html.Abstractions;
using CommonMark;

namespace QuickWiki.Models
{
    public class WikiPage
    {
        public int WikiPageId
        {
            get; set;
        }

        public string PageName
        {
            get; set;
        }

        public string Content
        {
            get; set;
        }

        [NotMapped]
        public IHtmlContent HtmlContent
        {
            get
            {
                return new HtmlEncodedString(ConvertedText);
            }
        }

        [NotMapped]
        public string ConvertedText
        {
            get
            {
                return CommonMarkConverter.Convert(Content);
            }
        }
    }

    class HtmlEncodedString: IHtmlContent
    {
        private string _value;
        public string Value
        {
            get
            {
                return _value;
            }
        }

        public HtmlEncodedString(string _value)
        {
            this._value = _value;
        }

        public void WriteTo(TextWriter writer, IHtmlEncoder encoder)
        {
            writer.Write(_value);
        }
    }
}
