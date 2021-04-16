using System;
using System.Collections.Generic;
using System.Text;

namespace Camera
{
    class MemoryCard
    {
        public int MSize { get; set; }

        public int OccupiedMSize { get; set; }


        public string MName { get; set; }


        public  MemoryCard(int mSize, int occupidMSize = 0)
        {
            this.MSize = mSize;
            this.OccupiedMSize = occupidMSize;
        }

        public override string ToString()
        {
            return "Gesamtspeicher: " + MSize +"MB" + " , verbrauchter Speicher: " + OccupiedMSize + "MB";
        }

    }
}
