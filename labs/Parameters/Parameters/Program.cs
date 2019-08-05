#region using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace Parameters
{
    class Program
    {
        static void doWork()
        {
            
            int i = 0;
            Console.WriteLine(i);
            Pass.Value(ref i);  //Invokes method value which is a member of class pass
            Console.WriteLine(i);
            
            Console.WriteLine("-----------------------------------------");
            WrappedInt wi = new WrappedInt(); //"new" 
            Console.WriteLine(wi.Number);
            Pass.Reference(wi);
            Console.WriteLine(wi.Number);
        }

        static void Main(string[] args)
        {
            try
            {
                doWork();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
