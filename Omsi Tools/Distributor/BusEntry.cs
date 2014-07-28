using System;
using System.Linq;

namespace OmsiTools.Distributor
{
    public class BusEntry
    {
        public string Name { get; internal set; }
        public string Path { get; internal set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
