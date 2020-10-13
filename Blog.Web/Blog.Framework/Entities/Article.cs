﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Framework.Entities
{
    public class Article : IEntity
    {
        public virtual int Id { get; set; }

        public virtual string Title { get; set; }

        public virtual string Description { get; set; }

        public virtual DateTime PostedOn { get; set; }

        public virtual Category Category { get; set; }
        //public virtual int Category_Id { get; set; }
    }
}
