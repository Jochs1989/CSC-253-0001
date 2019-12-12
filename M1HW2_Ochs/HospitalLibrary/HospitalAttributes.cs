using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalLibrary
{
    public class HospitalAttributes
    {
        public static double CalcStayCharges()
        {
            Hospital output = new Hospital();

            Console.Write("\nHow many days did you spend in the hospital: > ");
            output.Days = TryParse.GetDoubleParse(Console.ReadLine());
            output.Days = output.Days * 350;

            return output.Days;
        }

        public static double CalcMiscCharges()
        {
            Hospital output = new Hospital();
            double medication;
            double surgical;
            double labFees;
            double physRehab;

            Console.Write("\nHow much did the medication cost: > ");
            medication = TryParse.GetDoubleParse(Console.ReadLine());

            Console.Write("How much did the surgical charges cost: > ");
            surgical = TryParse.GetDoubleParse(Console.ReadLine());

            Console.Write("How much did the lab fees cost: > ");
            labFees = TryParse.GetDoubleParse(Console.ReadLine());

            Console.Write("How much did the phystical rehabilitation cost: > ");
            physRehab = TryParse.GetDoubleParse(Console.ReadLine());

            output.miscCharges = medication + surgical + labFees + physRehab;

            return output.miscCharges;

        }
        
        public static void GetResults(double days, double miscCharges)
        {
            double results;

            results = days + miscCharges;

            Console.WriteLine($"\nThe total cost of your stay was: ${results}");

            Console.WriteLine("\nPress Enter to Continue!");
            Console.ReadLine();
        }
    }
}
