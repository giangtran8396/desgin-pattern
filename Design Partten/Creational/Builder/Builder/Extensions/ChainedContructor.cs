using Builder.Interfaces;

namespace Builder.Extensions
{
    public static class ChainedContructor
    {
        public static IMonAn Them(this IMonAn inner,IMonAn next)
        {
            return new ChainedMonAn(inner, next);
        }
    }
}
