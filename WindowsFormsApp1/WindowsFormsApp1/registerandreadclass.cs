using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WindowsFormsApp1
{
    public class registerandreadclass
    {
        Surf_country s; 
        //save method
        public static void Save (List<Surf_country>  SavelistBox)
            {
            StreamWriter outputfile;
            outputfile = File.AppendText("country saved");

            foreach (Surf_country s in SavelistBox)
            {
                outputfile.WriteLine(s.Country);
                outputfile.WriteLine(s.Temperature);
                outputfile.WriteLine(s.Price);
            }
            outputfile.Close();
        }

        //view method
        public static  List<Surf_country> Read()
        {
            Surf_country s;
         
            StreamReader inputfile;
            List<Surf_country> SavelistBox= new List<Surf_country>();
            inputfile = File.OpenText("country saved");

            try
            {
                while (!inputfile.EndOfStream)
                {
                    s = new Surf_country();

                    s.Country = inputfile.ReadLine ();
                    s.Temperature = Convert.ToDouble(Console.ReadLine());
                    s.Price = Convert.ToDecimal(Console.ReadLine());

                    SavelistBox.Add(s);
                }
                inputfile.Close();

                return SavelistBox;

            }
            catch
            {
                return SavelistBox;
            }

        }
        
    }
}
