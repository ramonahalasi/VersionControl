using System;

namespace UserMaintenance
{
    internal class User
    {
        public Guid ID { get; set; } = Guid.NewGuid();
        public string FirstName;
        public string LastName;
        public string FullName { get; set; }
        
    }
}