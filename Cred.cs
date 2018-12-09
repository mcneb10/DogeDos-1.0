using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace DOGE.Security
{
    public static class Cred
    {
        static ConsoleColor defaultcolor = Console.ForegroundColor;
        public static void authentication()
        {

                if (!File.Exists("creduser") && !File.Exists("credpass"))
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    // just to be safe
                    Console.WriteLine(@"Please Enter Some Credentials, And please write them down");
                    Console.Write("Your new username: ");
                    string usern = Console.ReadLine();
                    Console.Write("Your new password: ");
                    Console.ForegroundColor = ConsoleColor.Black;
                    string passw = Console.ReadLine();
                    Console.ForegroundColor = defaultcolor;
                    File.Create("creduser");
                    File.Create("credpass");
                    File.WriteAllText("creduser", usern);
                    File.WriteAllText("credpass", passw);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    bool unlocked = false;
                    while (!unlocked)
                    {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Clear();
                        Console.WriteLine("Login Please");
                        Console.Write("Username: ");
                        string user = Console.ReadLine();
                        Console.Write("Password: ");
                        Console.ForegroundColor = ConsoleColor.Black;
                        string pass = Console.ReadLine();
                        
                        if ((user == File.ReadAllText("creduser") && pass == File.ReadAllText("credpass")))
                        {
                            unlocked = true;
                            Console.Clear();
                        }
                    }
                }
            }
        }
    
}
namespace DOGE.Decoration
{
    public class loadingscreen
    {
        /// <summary>
        /// Creates A Loading Screen
        /// </summary>
        public static void loadScreen()
        {
            Console.WriteLine("Loading...");
            Console.Write("[#                    ]");
            Console.Write("[##                   ]");
            Console.Write("[###                  ]");
            Console.Write("[####                 ]");
            Console.Write("[#####                ]");
            Console.Write("[######               ]");
            Console.Write("[#######              ]");
            Console.Write("[########             ]");
            Console.Write("[#########            ]");
            Console.Write("[##########           ]");
            Console.Write("[###########          ]");
            Console.Write("[############         ]");
            Console.Write("[#############        ]");
            Console.Write("[##############       ]");
            Console.Write("[###############      ]");
            Console.Write("[################     ]");
            Console.Write("[#################    ]");
            Console.Write("[##################   ]");
            Console.Write("[###################  ]");
            Console.Write("[#################### ]");
            Console.Write("[#####################]");
            Console.Clear();
        }
    }
}
