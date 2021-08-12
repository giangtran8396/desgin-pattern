using Decorator.Interfaces;

namespace Decorator.Extensions
{
    public class ChainedMonAn : IMonAn
    {
        private IMonAn Inner { get; }
        private IMonAn Next { get; }
        public ChainedMonAn(IMonAn inner,IMonAn next)
        {
            this.Inner = inner;
            this.Next = next;
        }

        public float Tinhtien()
        {
            return this.Inner.Tinhtien() + this.Next.Tinhtien();
        }
    }
}
