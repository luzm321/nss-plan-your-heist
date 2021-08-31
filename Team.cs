using System;
using System.Collections.Generic;
// using System.Linq;

namespace BankHeist
{
    public class Team
    {
        public List<Member> wholeTeam { get; set; }
        public Team(List<Member> memberList)
        {
            Console.WriteLine("---------Team Members----------");
            Console.WriteLine($"There are {memberList.Count} members in the team!");
            foreach (var member in memberList)
            {
                Console.WriteLine("---------Member-------");
                Console.WriteLine($"Member name: {member.Name}");
                Console.WriteLine($"Member skill level: {member.SkillLevel}");
                Console.WriteLine($"Member courage factor: {member.CourageFactor}");
            }
        }
    }
}