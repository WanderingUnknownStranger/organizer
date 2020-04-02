using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace organizer
{

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<Memo> memo_list = new List<Memo>();
                while (true)
                {
                    Console.WriteLine("What you want to do?\nA - show all memo\nE - Exit");
                    String str = Console.ReadLine();
                    if(str == "Exit")
                    {
                        break;
                    }
                    else if(str == "Edit")  
                    {
                        Console.WriteLine("Enter number element for edit:");
                        int temp = Convert.ToInt32(Console.ReadLine()) - 1;
                        Console.WriteLine(memo_list[temp].GetMemo());
                        memo_list[temp].Edit(Console.ReadLine());
                    }
                    else if (str == "A")
                    {
                        for (int i = 0; i < memo_list.Count; i++)
                        {
                            Console.WriteLine(memo_list[i].GetMemo());
                        }
                    }
                    else
                    {
                        if (char.IsDigit(str[0]))
                        {
                            if(memo_list.Count >= Convert.ToInt32(str))
                                Console.WriteLine(memo_list[Convert.ToInt32(str) - 1].GetMemo());
                        }
                        else
                        {
                            memo_list.Add(new Memo(str));
                        }
                    }
                    
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
