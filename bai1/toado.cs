using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai1
{
    public class toado

    {
        private int x;
        private int y;
        private string name;

        public toado()
        {
            x = 0;
            y = 0;
            name = "";
        }
        public toado(int x, int y, string name)
        {
            this.x = x;
            this.y = y;
            this.name = name;
        }
        public void SetX(int x)
        {
            this.x = x;
        }

        public void SetY(int y)
        {
            this.y = y;
        }

        public void SetName(string name)
        {
            this.name = name;
        }
        public int GetX()
        {
            return x;
        }

        public int GetY()
        {
            return y;
        }

        public string GetName()
        {
            return name;
        }
        public override string ToString()
        {
            return name + " (" + x + ", " + y + ")";
        }
    }
}
