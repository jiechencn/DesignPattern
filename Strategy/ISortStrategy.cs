namespace Strategy
{
    public interface ISortStrategy
    {
        public void Sort(ref IEnumerable<int> datas);
    }

    public class AscSort : ISortStrategy
    {
        public void Sort(ref IEnumerable<int> datas)
        {
            datas = datas.OrderBy(d => d);
        }
    }

    public class DescSort : ISortStrategy
    {
        public void Sort(ref IEnumerable<int> datas)
        {
            datas = datas.OrderByDescending(d => d);
        }
    }
}