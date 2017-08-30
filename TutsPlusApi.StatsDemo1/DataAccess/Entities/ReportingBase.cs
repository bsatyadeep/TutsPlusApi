using System;

namespace TutsPlusApi.StatsDemo1.DataAccess.Entities
{
    public abstract class ReportingBase
    {
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
    }
}