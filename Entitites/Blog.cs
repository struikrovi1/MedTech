﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitites
{
    public class Blog : Base
    {

        public string PhotoUrl { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string Article { get; set; }
        public string? AuthorName { get; set; }

        public DateTime? CreatedTime { get; set; }

        public int? CommentsCount { get; set; }

        public int TagId { get; set; }

        public virtual Tags Tag { get; set; }


    }
}
