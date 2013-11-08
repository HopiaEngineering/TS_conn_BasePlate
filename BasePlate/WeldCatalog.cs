using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BasePlate
{
    class WeldCatalog
    {
        List<int> welds;

        public WeldCatalog()
        {
            welds = new List<int>
            {
                0, 10, 4
            };
        }

        public int GetWeld(int selectedIndex)
        {
            return welds[selectedIndex];
        }
    }
}
