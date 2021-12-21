using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer
{
    public partial class AnswerTable
    {
        public int Id { get; set; }
        public string Answers { get; set; }
        public int? Votes { get; set; }
    }
}
