using System;

namespace TutsPlusApi.Stats.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public DateTime CreatedOn { get; set; }
        public virtual Account Account { get; set; }
    }
}