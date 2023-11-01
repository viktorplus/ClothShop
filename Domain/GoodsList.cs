using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp6.Domain
{
    public class GoodsList
    {
        public List<Goods> goods;
        public Goods? selectedGud = null;
        public GoodsList()
        {
            goods = new List<Goods>();
        }

        public List<Goods> DistinctGoods()
        {
            return goods.GroupBy(x => x.ItemId).Select(g => g.First()).ToList();
        }

        public List<Goods> DistinctColoredGoodsByID(int id)
        {
            return goods.Where(x => x.ItemId == id).GroupBy(x => x.Color.ToLower()).Select(x => x.First()).ToList();
        }

        public List<Goods> DistinctSizedGoodsByID(int id)
        {
            return goods.Where(x => x.ItemId == id).GroupBy(x => x.Size.ToLower()).Select(x => x.First()).ToList();
        }

        public void AddGud(Goods gud)
        {
            goods.Add(gud);
        }

        public void RemoveGud(Goods gud)
        {
            goods.Remove(gud);
        }
        public List<Goods> SearchGoodsByName(string partialName)
        {
            partialName = partialName.ToLower();

            return goods
                .Where(g => g.Name.ToLower().Contains(partialName))
                .ToList();
        }
        public List<Goods> SortGoodsByPrice()
        {
            return goods.OrderBy(g => g.Price).ToList();
        }

        public List<Goods> SortGoodsByName()
        {
            return goods.OrderBy(g => g.Name).ToList();
        }

        public List<Goods> SortGoodsByDateAdded()
        {
            return goods.OrderByDescending(g => g.DateAdded).ToList();
        }
    }
}
