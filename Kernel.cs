using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using Sys = Cosmos.System;
using Cosmos.System.Graphics;
using System.Drawing;
using Animal;
using System.IO;
using System.Linq;
using DOGE.Security;
using DOGE.Decoration;

namespace DOGE
{
    /// <summary>
    /// DOGEDos kernel
    /// </summary>
    public class Kernel : Sys.Kernel
    {
        public readonly String[] doge = { "such operationg system", "wow","very doge", "much commands", "many doges" };
        String user;
        /// <summary>
        /// Runs before the run() function runs
        /// </summary>
        #region before
        protected override void BeforeRun()
        {
            #region IOHelper_Before
            var fs = new Sys.FileSystem.CosmosVFS();
            Sys.FileSystem.VFS.VFSManager.RegisterVFS(fs);
            #endregion
            loadingscreen.loadScreen();
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Cred.authentication();
            Console.WriteLine("Welcome To DogeDOS 1.0");
            user = ReadText("creduser");
        }
        #endregion
        #region IOHelper_Functions
        /// <summary>
        /// Reads All lines of the specified text file
        /// </summary>
        /// <param name="path">the path</param>
        /// <returns>A string array</returns>
        public static string[] ReadLines(string path)
        {
            string[] f;
            f = File.ReadAllLines(path);
            return f;
        }
        /// <summary>
        /// Reads the text of the specified file
        /// </summary>
        /// <param name="path">the path</param>
        /// <returns>A string</returns>
        public static string ReadText(string path)
        {
            string c = "";
            c = File.ReadAllText(path);
            return c;
        }
        /// <summary>
        /// Reads all of the bytes of a file
        /// </summary>
        /// <param name="path">the path</param>
        /// <returns>A byte array</returns>
        public static byte[] ReadByte(string path)
        {
            byte[] c;
            c = File.ReadAllBytes(path);
            return c;
        }
        /// <summary>
        /// Return all of the file names in the specified directory
        /// </summary>
        /// <param name="addr">the path</param>
        /// <returns>A string array of all of the files in the specified folder</returns>
        public static string[] GetFilsFrmAddr(string addr)
        {
            string[] files = new string[256];
            if (Directory.GetFiles(addr).Length > 0)
                files = Directory.GetFiles(addr);
            else
                files[0] = "No Files Found";
            return files;
        }
        /// <summary>
        /// Return all of the folder names in the specified directory
        /// </summary>
        /// <param name="addr"></param>
        /// <returns>A string array of all of the folders in the specified folder</returns>
        public static string[] GetDirsFrmAddr(string addr)
        {
            var dirs = Directory.GetDirectories(addr);
            return dirs;
        }
        #endregion
        #region func
        /// <summary>
        /// Returns bool saying if the number matches the count of items in a list
        /// </summary>
        /// <param name="co">The Array</param>
        /// <param name="i">The Integer</param>
        /// <returns>A bool saying if the number matches the count of items in a list</returns>
        private bool CheckIflast(List<string> co, int i)
        {
            if (i == co.Count)
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// Returns the number the user entered
        /// </summary>
        /// <param name="start">Lowest number you can enter</param>
        /// <param name="end">Higest number you can enter</param>
        /// <param name="Default">If the number is not in between start and end it will be turned into this</param>
        /// <returns>The number entered by the user(if it isn't in between start and end default will be returned)</returns>
        public static uint ReadNumber(uint start, uint end, uint Default)
        {
            uint a;
            string userinput;
            userinput = Console.ReadLine();
            for (a = start; a <= end; a++)
            {
                if (a.ToString() == userinput)
                {
                    return a;
                }
            }
            return Default;
        }
        #endregion
        #region commands
        /// <summary>
        /// Runs in a loop after the OS Starts
        /// </summary>
        protected override void Run()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("DogeDos:"+ user +":"+Path.GetFullPath(Directory.GetCurrentDirectory())+ ">");
            var input = Console.ReadLine();
            string c = input.ToString();
            if (c == "help")
            {
                Console.WriteLine("help: shows this list");
                Console.WriteLine("dogeart: makes doge art");
                Console.WriteLine("echo: echos");
                Console.WriteLine("clear: removes command dialog");
                Console.WriteLine("reboot: reboots the system");
                Console.WriteLine("shutdown: shuts down the system");
                Console.WriteLine("resetcolor: resets the console color");
                Console.WriteLine("date: shows the date");
                Console.WriteLine("howisthedoge: shows how the doge is feeling");
                Console.WriteLine("dogescript: starts the dogecript ide(pretty bad)");
                Console.WriteLine("catscript: starts the catscript ide(pretty bad)");
                Console.WriteLine("replace: replaces all matching chars with the char to replace");
                Console.WriteLine("root: gets all files in the current directory");
                Console.WriteLine("curdir: gets the current directory");
                Console.WriteLine("mkdir: makes a directory");
                Console.WriteLine("dogetouch: creates a file");
                Console.WriteLine("cat: gets all text in a file");
                Console.WriteLine("gohome: goes to the father directory");
                Console.WriteLine("mv: moves a directory");
                Console.WriteLine("math: does math");
                Console.WriteLine("del: deletes a file or directory");
                Console.WriteLine("cred: changes your credentials");
                Console.WriteLine("doge: prints some doge text");
                Console.WriteLine("cd: goes up a directory");
                Console.WriteLine("drives: lists all drives");
            }
            else if (c == "dogeart")
            {
                Console.WriteLine("                   =              =");
                Console.WriteLine("                  |-|           ==-|");
                Console.WriteLine("                  |--|        ==---|");
                Console.WriteLine("                 |==--========-----|");
                Console.WriteLine("               ===-----------|--=|-|");
                Console.WriteLine("             ==---------------=||=-|");
                Console.WriteLine("            |---==--------------==--|");
                Console.WriteLine("            |--||=-----==|=-------|-|");
                Console.WriteLine("           |-----------|||=--------==|");
                Console.WriteLine("           |--=||=-------------------|");
                Console.WriteLine("          |-=|=|=||=-=---------------|");
                Console.WriteLine("          |--|=|=--==-=---------------|");
                Console.WriteLine("          |---====---=---------------|");
                Console.WriteLine("           |------===----------------|");
                Console.WriteLine("           |---------------------=--|");
                Console.WriteLine("            ==-----------------=----|");
                Console.WriteLine("              ==----------====----==");
                Console.WriteLine("                ==========-----===");
                Console.WriteLine("                   ----------==");
            }
            else if (c.StartsWith("echo"))
            {
                Console.WriteLine("Doge Says: " + c.Remove(0, 5));
            }
            else if (c == "reboot")
            {
                Sys.Power.Reboot();
            }
            else if (c == "shutdown")
            {
                Sys.Power.Shutdown();
            }
            else if (c == "clear")
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
            }
            else if (c == "date")
            {
                Console.WriteLine(DateTime.Now.ToString());
            }
            else if (c == "howisthedoge")
            {
                List<string> s = new List<string>();
                Random r = new Random();
                s.Add("dogie");
                s.Add("sad");
                s.Add("happy");
                s.Add("sick");
                s.Add("like dos is his life");
                Console.WriteLine("Doge is feeling " + s[r.Next(0, 4)]);


            }
            else if (c == "catscript")
            {
                string cinput;
                bool l = true;
                Cat cat = null;
                while (l)
                {
                    List<string> s = new List<string>();
                    cinput = Console.ReadLine();
                    if (cinput == "exit")
                        l = false;
                    else if (cinput.StartsWith("cat"))
                    {
                        Console.WriteLine("Enter the age and if the cat is persian(use true or false)");
                        cat = new Cat(cinput.Remove(0, 4), Convert.ToInt32(Console.ReadLine()), Convert.ToBoolean(Console.ReadLine()));
                        s.Add(cinput);
                    }
                    else if (cinput == "info")
                    {
                        cat.Overview();
                        s.Add(cinput);
                    } else if (cinput == "compile")
                    {
                        Console.Write("Enter the File Name With No Extension");
                        string name = Console.ReadLine();
                        string path = name + ".cts";
                        File.Create(path);
                        File.WriteAllText(path, c.ToString());
                    }
                }

            }
            else if (c == "dogescript")
            {
                List<string> d = new List<string>();
                string dinput;
                bool s = true;
                Doge doge = null;
                while (s)
                {
                    dinput = Console.ReadLine();
                    if (dinput == "exit")
                        s = false;
                    else if (dinput.StartsWith("doge"))
                    {
                        Console.WriteLine("Enter the age and if it is a golden retriever(use true or false)");
                        doge = new Doge(dinput.Remove(0, 4), Convert.ToInt32(Console.ReadLine()), Convert.ToBoolean(Console.ReadLine()));
                        d.Add(dinput);
                    }
                    else if (dinput == "info")
                    {
                        doge.Overview();
                        d.Add(dinput);
                    }
                    else if (dinput == "compile")
                    {
                        Console.Write("Enter the File Name With No Extension");
                        string name = Console.ReadLine();
                        string path = name + ".dgs";
                        File.Create(path);
                        File.WriteAllText(path, d.ToString());
                    }
                }
            }
            else if (c == "replace")
            {
                Console.WriteLine("Enter the input string");
                string toreplace = Console.ReadLine();
                Console.WriteLine("Enter the char to replace");
                char filter = Convert.ToChar(Console.ReadLine());
                Console.WriteLine("Enter the char that the other char will be replaced with");
                char replacement = Convert.ToChar(Console.ReadLine());
                Console.WriteLine(toreplace.Replace(filter, replacement));
            }
            else if (c == "root")
            {
                try
                {
                    string[] fls = GetFilsFrmAddr(Directory.GetCurrentDirectory());
                    string[] dirs = GetDirsFrmAddr(Directory.GetCurrentDirectory());
                    foreach (string file in fls)
                    {
                        Console.WriteLine("Current directory contains file " + file);
                    }
                    foreach (string dir in dirs)
                    {
                        Console.WriteLine("Current directory contains directory " + dir);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            else if (c == "curdir")
            {
                Console.WriteLine(Directory.GetCurrentDirectory());
            }
            else if (c.StartsWith("mkdir"))
            {
                Directory.CreateDirectory(c.Remove(0, 6));
            }
            else if (c.StartsWith("dogetouch"))
            {
                File.Create(c.Remove(0, 10));
            }
            else if (c.StartsWith("cat"))
            {
                try
                {
                    Console.WriteLine(ReadText(c.Remove(0, 4)));
                }
                catch { }
            }
            else if (c.StartsWith("gohome"))
            {
                    Directory.SetCurrentDirectory(@"0:\");
            }
            else if (c == "mv")
            {
                
                Console.WriteLine("Enter the directory you would like to move");
                string dirfl = Console.ReadLine();
                Console.WriteLine("Enter the directory you would like to move the other directory to");
                string dst = Console.ReadLine();
                if (Directory.Exists(dirfl) && Directory.Exists(dst))
                    Directory.Move(dirfl, dst);
                else
                    Console.WriteLine("One Of the directories does not exist");
            }
            #region dtxt
            // Dtext W.I.P.
            /* else if (c == "dtxt")
             {
                 Console.WriteLine(@"Enter a file to edit. If it does not exist it will be created");
                 string path = Console.ReadLine();
                 if (!File.Exists(path))
                 {
                     File.Create(path);
                 }
                 string[] lines = ReadLines(path);
                 List<string> co = new List<string>();
                 foreach (string line in lines)
                 {
                     Console.WriteLine(line);
                     co.Add(line);
                 }
                 string entry;
                 bool s = true;
                 int cou = 0;
                 while (s)
                 {
                     entry = Console.ReadLine();
                     cou++;
                     co.Add(entry);
                     ConsoleKeyInfo pressed_key = Console.ReadKey(); // read keystroke

                     switch (pressed_key.Key)
                     {
                         case ConsoleKey.UpArrow: //Move cursor up
                             Console.CursorTop = Console.CursorTop - 1;
                             cou--;
                             break;

                         case ConsoleKey.DownArrow: //Move cursor down
                             Console.CursorTop = Console.CursorTop + 1;
                             cou++;
                             break;

                         case ConsoleKey.LeftArrow: //Move cursor left
                             Console.CursorLeft = Console.CursorLeft - 1;
                             break;

                         case ConsoleKey.RightArrow: //Move cursor right
                             Console.CursorLeft = Console.CursorLeft + 1;
                             break;

                         case ConsoleKey.Backspace: //Remove characters
                             if (Console.CursorLeft > 1)
                             {
                                 co[cou].Remove(Console.CursorLeft - 1, 1);
                                 Console.CursorLeft = Console.CursorLeft - 1;
                                 Console.Write(" ");
                                 Console.CursorLeft = Console.CursorLeft - 1;

                             }
                             else
                                 Console.CursorTop = Console.CursorTop + 1;

                             break;
                         case ConsoleKey.Delete:
                             s = false;
                             break;
                     }



                 }
                 bool first = true;
                 int i = 0;
                 foreach (string line in co)
                 {
                     if (first)
                     {
                         File.WriteAllText(path, line + "\n");
                         first = false;
                         i++;
                     }
                     else if (CheckIflast(co, i))
                     {
                         File.AppendAllText(path, line);
                     }
                     else
                     {
                         File.AppendAllText(path, line + "\n");
                         i++;
                     }
                     Sys.Kernel.PrintDebug(i.ToString());
                 }
             } 
             */
            #endregion
            else if (c == "math")
            {
                Console.WriteLine("Enter the operation you woud like to use + - * /");
                string operation = Console.ReadLine();
                uint n1, n2;
                Console.Write("Enter the first number: ");
                n1 = ReadNumber(UInt32.MinValue, UInt32.MaxValue, 100);
                Console.Write("Enter the second number: ");
                n2 = ReadNumber(UInt32.MinValue, UInt32.MaxValue, 100);
                if (operation == "+")
                {
                    Console.WriteLine((n1 + n2).ToString());
                }
                else if (operation == "-")
                {
                    Console.WriteLine((n1 - n2).ToString());
                }
                else if (operation == "*")
                {
                    Console.WriteLine((n1 * n2).ToString());
                }
                else if (operation == "/")
                {
                    Console.WriteLine((n1 / n2).ToString());
                }
            }
            else if (c.StartsWith("del"))
            {
                string path = c.Remove(0, 4);
                if (path != "creduser" && path != "credpass")
                {
                    if (File.Exists(path))
                    {


                        try
                        {
                            File.Delete(path);
                            Console.WriteLine(path + " has been deleted");
                        }
                        catch { }
                    }
                    else if (Directory.Exists(path))
                    {
                        try
                        {
                            Directory.Delete(path);
                            Console.WriteLine(path + " has been deleted");
                        }
                        catch { }
                    }
                    else
                        Console.WriteLine("File/Folder " + path + " Does Not Exist");

                }
                else
                    Console.WriteLine("Access Is Denied To Delete File " + path);
            } else if (c == "cred")
            {
                bool a = true;
                string ct;
                while (a)
                {
                    Console.WriteLine(@"p to change password, u to change username, e to exit");
                    ct = Console.ReadLine();
                    if (ct.ToUpper() == "P")
                    {
                        a = false;
                        Console.WriteLine("Enter A New Password");
                        string newpassword = Console.ReadLine();
                        File.WriteAllText(@"credpass", newpassword);
                    }
                    else if (ct.ToUpper() == "U")
                    {
                        a = false;
                        Console.WriteLine("Enter A New Username");
                        string newusername = Console.ReadLine();
                        File.WriteAllText(@"creduser", newusername);
                    }
                    else if (ct.ToUpper() == "E")
                        a = false;
                }
            } else if (c == "") {   
            } else if (c == "doge")
            {
                Random rrr = new Random();
                int a = rrr.Next(2, 5);
                int b = 0;
                Random rrrr = new Random();
                while (b < a)
                {
                    int dd = rrrr.Next(0, 4);
                    Console.WriteLine(doge[dd]);
                    b++;
                }
            } else if(c.StartsWith("cd"))
            {
                string cddirectory = c.Remove(0, 3);
                if(Directory.Exists(cddirectory))
                {
                    Directory.SetCurrentDirectory(cddirectory);
                } else
                {
                    Console.WriteLine("Directory "+cddirectory+" does not exist!");
                }
            } else if(c=="drives")
            {
                foreach(DriveInfo drive in DriveInfo.GetDrives())
                {
                    Console.WriteLine("Computer contains drive " + drive.Name + " and contains " + drive.AvailableFreeSpace + " bytes of free space");
                }
            }
            else
            {
                Console.WriteLine("Dogedos does not have a command or service named " + c);
            }

        }


            #endregion

        }
    }