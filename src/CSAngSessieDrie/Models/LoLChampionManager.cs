using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSAngSessieDrie.Models
{
    public class LoLChampionManager
    {
        readonly List<LoLChampion> champions = new List<LoLChampion>()
        {
            new LoLChampion { ID = 1, Name = "Zed", Role="Assassin" },
            new LoLChampion { ID = 2, Name = "Caitlynn", Role="AD Carry" },
            new LoLChampion { ID = 3, Name = "Sona", Role="Support" },
            new LoLChampion { ID = 4, Name = "Trundle", Role="Top" },
            new LoLChampion { ID = 5, Name = "Shaco", Role="Jungler" }
        };

        public IEnumerable<LoLChampion> GetAll { get { return champions; } }

        public List<LoLChampion> GetChampionsByType(string type)
        {
            return champions.Where(champion => champion.Role.ToLower().Equals(type.ToLower())).ToList();
        }

        public LoLChampion GetChamionByID(int id)
        {
            return champions.Find(champion => champion.ID == id);
        }
    }
}
