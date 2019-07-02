using System;

namespace DoFactory.GangOfFour.Adapter.RealWorld
{
    /// <summary>

    /// MainApp startup class for Real-World 

    /// Adapter Design Pattern.

    /// </summary>

    class MainApp

    {
        /// <summary>

        /// Entry point into console application.

        /// </summary>

        static void Main()
        {
            // Non-adapted chemical compound

            Compound unknown = new Compound("Unknown");
            unknown.Display();

            // Adapted chemical compounds

            Compound water = new RichCompound("Water");
            water.Display();

            Compound benzene = new RichCompound("Benzene");
            benzene.Display();

            Compound ethanol = new RichCompound("Ethanol");
            ethanol.Display();

            // Wait for user

            Console.ReadKey();
        }
    }

    /// <summary>

    /// The 'Target' class

    /// </summary>

    class Compound

    {
        protected string _chemical;
        protected float _boilingPoint;
        protected float _meltingPoint;
        protected double _molecularWeight;
        protected string _molecularFormula;

        // Constructor

        public Compound(string chemical)
        {
            this._chemical = chemical;
        }

        public virtual void Display()
        {
            Console.WriteLine("\nCompound: {0} ------ ", _chemical);
        }
    }

    /// <summary>

    /// The 'Adapter' class

    /// </summary>

    

    /// <summary>

    /// The 'Adaptee' class

    /// </summary>

    class ChemicalDatabank

    {
        // The databank 'legacy API'

        public float GetCriticalPoint(string compound, string point)
        {
            // Melting Point

            if (point == "M")
            {
                switch (compound.ToLower())
                {
                    case "water": return 0.0f;
                    case "benzene": return 5.5f;
                    case "ethanol": return -114.1f;
                    default: return 0f;
                }
            }
            // Boiling Point

            else

            {
                switch (compound.ToLower())
                {
                    case "water": return 100.0f;
                    case "benzene": return 80.1f;
                    case "ethanol": return 78.3f;
                    default: return 0f;
                }
            }
        }

        public string GetMolecularStructure(string compound)
        {
            switch (compound.ToLower())
            {
                case "water": return "H20";
                case "benzene": return "C6H6";
                case "ethanol": return "C2H5OH";
                default: return "";
            }
        }

        public double GetMolecularWeight(string compound)
        {
            switch (compound.ToLower())
            {
                case "water": return 18.015;
                case "benzene": return 78.1134;
                case "ethanol": return 46.0688;
                default: return 0d;
            }
        }
    }
}



