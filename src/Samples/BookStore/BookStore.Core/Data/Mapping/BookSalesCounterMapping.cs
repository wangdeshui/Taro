﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;

namespace BookStore.Data.Mapping
{
    public class BookSalesCounterMapping : ClassMapping<BookSalesCounter>
    {
        public BookSalesCounterMapping()
        {
            Id(c => c.ISBN, m => m.Generator(Generators.Assigned));

            Property(c => c.Title);
            Property(c => c.TotalSoldCount);
        }
    }
}
