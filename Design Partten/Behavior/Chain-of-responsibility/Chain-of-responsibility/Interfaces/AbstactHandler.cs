using System;
using System.Collections.Generic;
using System.Text;

namespace Chain_of_responsibility.Interfaces
{
    public abstract class AbstactHandler : IHandler
    {
        private IHandler _nextHandler;

        public IHandler SetNext(IHandler handler)
        {
            this._nextHandler = handler;
            return this._nextHandler;
        }

        public virtual object Handle(object request)
        {
            if (this._nextHandler != null)
            {
                return this._nextHandler.Handle(request);
            }
            else
            {
                return null;
            }
        }

    }
}
