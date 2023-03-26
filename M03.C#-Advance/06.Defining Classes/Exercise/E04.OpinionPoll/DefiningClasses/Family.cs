using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClasses
{
    public class Family
    {
        private List<Person> familyMembers;

        public Family()
        {
            this.familyMembers = new List<Person>();
        }

        public void AddMember(Person member)
        {
            this.familyMembers.Add(member);
        }

        public List<Person> GetOverThirty()
        {
            List<Person> members = this.familyMembers.Where(m => m.Age > 30).OrderBy(m => m.Name).ToList();
            return members; 
        
        }
    }
}
