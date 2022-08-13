using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class DataProcessor
    {
        private ISortStrategy sort;
        private IEnumerable<int> datas;

        public DataProcessor(IEnumerable<int> datas, ISortStrategy sort)
        {
            this.datas = datas;
            this.sort = sort;
        }

        public IEnumerable<int> GetTopN(int n)
        {
            sort.Sort(ref datas);
            return datas.Take(n);
        }
    }
}
