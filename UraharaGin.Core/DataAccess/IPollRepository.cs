﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UraharaGin.Core.DBEntities;

namespace UraharaGin.Core.DataAccess
{
    public interface IPollRepository
    {
        IList<Poll> GetPolls();
    }
}
