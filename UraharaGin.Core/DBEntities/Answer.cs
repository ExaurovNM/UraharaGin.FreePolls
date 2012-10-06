

using System;

namespace UraharaGin.Core.DBEntities
{
    public class Answer
    {
        public Guid Id { get; set; }

        public Guid PollId { get; set; }

        public string AnswerName { get; set; }

        public int Votes { get; set; }
    }
}