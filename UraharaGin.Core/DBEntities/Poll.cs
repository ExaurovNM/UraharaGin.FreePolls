﻿using System;
using System.Collections.Generic;

namespace UraharaGin.Core.DBEntities
{
    public class Poll
    {
        public Guid Id { get; set; }

        public string Question { get; set; }

        public virtual IList<Answer> Answers { get; set; }
    }
}
