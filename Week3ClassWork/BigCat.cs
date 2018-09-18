using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3ClassWork
{
    class BigCat
    {
        public string Type { get; set; }
        public int Height { get; set; }
        public int Length { get; set; }
        public int Weight { get; set; }
        public double Speed { get; set; }

        public void OutputToFile()
        {

            List<string> lines = new List<string>();
            lines.Add(Type);
            lines.Add(Height + "");
            lines.Add(Length + "");
            lines.Add(Weight + "");
            lines.Add(Speed + "");
            

            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(@"C:\Users\Public\Documents\WriteLines2.txt"))
            {
                foreach (string line in lines)
                {
                    file.WriteLine(line);
                }
            }
        }

    }

}
