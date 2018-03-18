namespace E_FixE_mails
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var name = Console.ReadLine();

            var emailList = new Dictionary<string, string>();
            while (name != "stop")
            {
                if (!emailList.ContainsKey(name))
                {
                    emailList[name] = string.Empty;
                }

                var email = Console.ReadLine();
                if (email.Last() != 'k' && email.Last() != 's')
                {
                    emailList[name] = email;
                }
                else
                {
                    emailList.Remove(name);
                }

                name = Console.ReadLine();
            }

            foreach (var contact in emailList)
            {
                Console.WriteLine($"{contact.Key} -> {contact.Value}");
            }
        }
    }
}