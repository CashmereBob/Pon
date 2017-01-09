using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pon2._0.DataModels
{
    public class LinkDataModel
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string ImgSrc { get; set; }
        public string Description { get; set; }
        public string LinkAdress { get; set; }

        public LinkDataModel()
        {
            Id = Guid.NewGuid();
        }
    }
}