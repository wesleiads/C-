using System;
using servico;

namespace visual
{
    class Program
    {
      
        static void Main(string[] args)
        {
         Usuario p = new Usuario("teste","batitinha123");
         Usuario q = new Usuario("jango","batitinha123");
         Usuario r = new Usuario("jorge","batitinha123");
         Console.WriteLine(u.Serialize());
         /*Console.WriteLine("{0},{1}",u.getUsername()},{u.getHash()}");*/
         UserBase myBase = new UserBase("userbase.txt");
         myBase.Adduser(p);
         myBase.Adduser(q);
         myBase.Adduser(r);
         myBase.Save();
           
        }
    }
}    