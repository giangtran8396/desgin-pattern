using Builder.Component;
using Builder.ConcreteDecorator;
using Builder.Extensions;
using Builder.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.Core
{
    class MonAnBuilder
    {
        private IMonAn comSuon;
        public MonAnBuilder CreateComSuon()
        {
            this.comSuon = new ComSuon();
            return this;
        }

        public MonAnBuilder Using(IMonAn DoAn)
        {
            this.comSuon = this.comSuon.Them(DoAn);
            return this;
        }

        public IMonAn Build()
        {
            return this.comSuon;
        }
    }
}
