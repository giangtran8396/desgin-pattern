using Strategy.Interfaces;

namespace Strategy.Strategies
{
    public class SortHelper
    {
        private ISortStrategy _sortStrategy;

        public SortHelper()
        {

        }

        public void SetStrategy(ISortStrategy sortStrategy)
        {
            this._sortStrategy = sortStrategy;
        }

        public void Execute() {
            this._sortStrategy.Execute();
        }
    }
}
