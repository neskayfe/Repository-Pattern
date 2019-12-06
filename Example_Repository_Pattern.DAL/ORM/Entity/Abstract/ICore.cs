﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_Repository_Pattern.DAL.ORM.Entity.Abstract
{
    public enum Status
    {
        None=0,
        Active=1,
        Delete=2,
        Passive=3
    }
   public interface ICore
    {
        Guid ID { get; set; }
        DateTime AddDate { get; set; }
        DateTime? UpdateDate { get; set; }
        DateTime DeleteDate { get; set; }
        Status Status { get; set; }
    }
}