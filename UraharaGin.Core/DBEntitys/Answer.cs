

namespace UraharaGin.Core.DBEntitys
{
    using System;

    public class Answer
    {
        public Guid Id { get; set; }

        public Guid PollId { get; set; }

        public string AnswerName { get; set; }

        public int Votes { get; set; }
    }
}