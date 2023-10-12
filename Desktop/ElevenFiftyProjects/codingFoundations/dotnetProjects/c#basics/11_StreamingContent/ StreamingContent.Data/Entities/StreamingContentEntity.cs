using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StreamingContent.Data.Entities
{
    public class StreamingContentEntity
    {
        public StreamingContentEntity(){}
        public String Title { get; set; }
        public String Description { get; set; }
        public String StarRating { get; set; }
    }
}