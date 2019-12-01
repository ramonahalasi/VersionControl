using System;
namespace UserMaintenance
{
    public class User
    {
        public Guid ID { get; set; } = Guid.NewGuid();
        public string FirstName;
        public string LastName;
        public string FullName { get; set; }
        
            
       
    }
}
