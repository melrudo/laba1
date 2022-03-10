using System;

namespace _1
{
    class programm
    {
        void Main(string []args)
        {
            reka a = new reka();
        }
    }
    
    class reka
    {
        private string name = "none";
        private double ploshad = 0;
        private double protyazh = 0;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public double Ploshad
        {
            get { return ploshad; }
            set { ploshad = value; }
        }
        public double Protyazh
        {
            get { return protyazh; }
            set { protyazh = value; }
        }
    }
}
