namespace UraharaGin.Core.DBEntitys
{
    using System;
    using System.Collections.Generic;

    class Poll
    {
        public Guid Id { get; set; }

        public string Question { get; set; }

        public virtual IList<Answer> Answers { get; set; }
    }
}
