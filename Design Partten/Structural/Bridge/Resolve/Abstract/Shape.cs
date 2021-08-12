namespace Resolve.Abstract
{
    public abstract class Shape
    {
        protected IColor _color;

        protected Shape(IColor color)
        {
            this._color = color;
        }

        public abstract void Draw();
    }
}
