using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClovaTest.Control
{
    public enum PageName { Main }
    class GotoPage
    {
        public GotoPage(PageName pageName)
        {
            PageName = pageName;
        }

        public GotoPage(PageName pageName, object param) : this(pageName)
        {
            Param = param;
        }

        public PageName PageName { get; private set; }
        public object Param { get; private set; }
    }
}
