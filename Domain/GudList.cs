using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp6.Domain
{
    public class GudList
    {
        public List<Gud> goods;

        public GudList()
        {
            goods = new List<Gud>();
        }

        public void AddGud(Gud gud)
        {
            goods.Add(gud);
        }

        public void RemoveGud(Gud gud)
        {
            goods.Remove(gud);
        }
        public List<Gud> SearchGoodsByName(string partialName)
        {
            partialName = partialName.ToLower();

            return goods
                .Where(g => g.Name.ToLower().Contains(partialName))
                .ToList();
        }
        public List<Gud> SortGoodsByPrice()
        {
            return goods.OrderBy(g => g.Price).ToList();
        }

        public List<Gud> SortGoodsByName()
        {
            return goods.OrderBy(g => g.Name).ToList();
        }

        public List<Gud> SortGoodsByDateAdded()
        {
            return goods.OrderByDescending(g => g.DateAdded).ToList();
        }
    }
}
