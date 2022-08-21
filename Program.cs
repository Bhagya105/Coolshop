using System;
using System.Collections.Generic;
using System.Text;



namespace abc
{

    class Program
    {
        static void Main (string[] args)
        {
            Console.WriteLine (string.Join(",",readRecord("Alberto","sample.csv",3)));
            Console.ReadLine();
        }
        
            public static string[] readRecord (string searchkey , string filepath, int postionofsearchkey)
            {
                postionofsearchkey--;
                string[] recordnotfound = {"Record Not Found"};
                try
                {
                    string[] lines = System.IO.File.ReadAllLines (@filepath);
                    for (int i=0;i<lines.Length;i++)
                    {
                        string[] fields = lines[i].Split(',');
                        if(recordMatches(searchkey,fields,postionofsearchkey))
                        {
                            Console.WriteLine("Record Found");
                            return fields;
                        }
                    }
                    return recordnotfound;
                }
                catch (Exception ex)
                {
                    Console.WriteLine ("This program throws an error");
                    return recordnotfound;
                    throw new ApplicationException ("This program throws an error:",ex);
                }

            }
            public static bool recordMatches (string searchkey,string[] record, int postionofsearchkey)
            {
              if(record[postionofsearchkey].Equals(searchkey))
              {
                return true;
              }
              return false;
            }
        }
}
