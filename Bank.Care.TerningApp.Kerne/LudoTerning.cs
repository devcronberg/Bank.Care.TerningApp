using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Care.TerningApp.Kerne
{
    public class LudoTerning : Terning
    {
        public bool ErStjerne() {
            return this.Værdi == 3;
        }

        public bool ErGlobus()
        {
            return this.Værdi == 5;
        }

        public LudoTerning() : base()
        {

        }

        public override string ToString()
        {
            if (ErStjerne())
                return "[ S ]";
            if (ErGlobus())
                return "[ G ]";
            return base.ToString();
        }


    }
}
