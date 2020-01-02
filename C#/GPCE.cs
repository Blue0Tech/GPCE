/*GPCE (General Purpose Command Executor - a command line program which can be used for many purposes.*/
/*Copyright © 2019 Pruthvi Shrikaanth "Blue0Tech"*/
using System;
using System.Net;
using System.IO;
using System.IO.Compression;

namespace GPCE
{
    class Program
    {
        static void Main(string[] args)
        {
        	string logfilename = "GPCElog.txt";
            if (File.Exists(logfilename))
            {
                File.Delete(logfilename);
            }
            const string ProgramName = "General Purpose Command Executor", ExitMsg = "Terminating... Press any key to exit, Copyright 2019 Pruthvi Shrikaanth";
            string input, filecontent2;
            var osver = System.Environment.OSVersion;
            decimal num1, num2, ans;
            var currentdir = "C:\\";
            string filename1;
            string filecontent1;
            string url;
            WebClient fdl;
            string fdlname;
            string fdlcontent;
            string tc, privacy, license;
            string extractfilename, extractdir;
            string compressfolder, compressfilename;
            var logtext = "Program successfully launched\n";
            File.AppendAllText(logfilename, logtext);
            Console.WriteLine("Welcome to {0}, type help for a list of commands, Copyright 2019 Pruthvi Shrikaanth", ProgramName);
        /*Main activity*/
        MainActivity:
            do
            {
                Console.Write("GPCE >");
                input = Console.ReadLine();
                switch (input)
                {
                	case "":
                	{
                		/*Do nothing*/
                	}
                	break;
                    case "help":
                        {
                            logtext = input + " command entered\n";
                            File.AppendAllText(logfilename, logtext);
                            Console.WriteLine("help: Displays a list of commands and how to use them");
                            Console.WriteLine("now: Displays the time and date");
                            Console.WriteLine("exit: Exits {0}", ProgramName);
                            Console.WriteLine("clear: Clears the screen");
                            Console.WriteLine("pcname: Gets your computer name");
                            Console.WriteLine("osver: Returns the operating system version that you are running");
                            Console.WriteLine("sum: Gets the sum of two numbers, input one at a time.");
                            Console.WriteLine("diff: Gets the difference of two numbers, input one at a time.");
                            Console.WriteLine("prod: Gets the product of two numbers, input one at a time.");
                            Console.WriteLine("div: Gets the quotient of one number divided by another, input one at a time.");
                            Console.WriteLine("rem: Gets the remainder of one number divided by another, input one at a time.");
                            Console.WriteLine("fwrite: Writes to a file. Type \\n for a new line, \\t for a tabspace, and \\\\ for a backslash. If the file doesn't exist, error is thrown.");
                            Console.WriteLine("fdel: Deletes a file.");
                            Console.WriteLine("fopen: Opens a file with the default program (only on Windows).");
                            Console.WriteLine("ftype: Types the contents of a file.");
                            Console.WriteLine("dir: Displays the path of the current directory that GPCE is running from.");
                            Console.WriteLine("fdl: Downloads a file from the Web to a local file.");
                            Console.WriteLine("contact: Shows contact details to contact me.");
                            Console.WriteLine("tc: Displays the terms and conditions");
                            Console.WriteLine("privacy: Displays the privacy policy");
                            Console.WriteLine("license: Displays the license");
                            Console.WriteLine("extract: Extract a zip to a directory");
                            Console.WriteLine("compress: Compress a directory to a zip archive");
                            logtext = input + " command successfully executed\n";
                            File.AppendAllText(logfilename, logtext);
                        }
                        break;
                    case "now":
                        {
                            logtext = input + " command entered\n";
                            File.AppendAllText(logfilename, logtext);
                            var now = DateTime.Now;
                            Console.WriteLine("Now, it is {0}", now);
                            logtext = input + " command successfully executed\n";
                            File.AppendAllText(logfilename, logtext);
                        }
                        break;
                    case "exit":
                        {
                            logtext = input + " command entered\n";
                            File.AppendAllText(logfilename, logtext);
                            Console.WriteLine(ExitMsg);
                            logtext = input + " command successfully executed\n";
                            File.AppendAllText(logfilename, logtext);
                        }
                        break;
                    case "clear":
                        {
                            logtext = input + " command entered\n";
                            File.AppendAllText(logfilename, logtext);
                            Console.Clear();
                            Console.WriteLine("Welcome to {0}, type help for a list of commands", ProgramName);
                            logtext = input + " command successfully executed\n";
                            File.AppendAllText(logfilename, logtext);
                        }
                        break;
                    case "osver":
                        {
                            logtext = input + " command entered\n";
                            File.AppendAllText(logfilename, logtext);
                            Console.WriteLine("You are running {0}", osver);
                            logtext = input + " command successfully executed\n";
                            File.AppendAllText(logfilename, logtext);
                        }
                        break;
                    case "pcname":
                        {
                            logtext = input + " command entered\n";
                            File.AppendAllText(logfilename, logtext);
                            try
                            {
                                var pcname = Dns.GetHostName();
                                Console.WriteLine("Your computer name is {0}", pcname);
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("Unknown error.");
                                Console.WriteLine("Press Y to see the error.");
                                if (Console.ReadKey().Key == ConsoleKey.Y)
                                {
                                    Console.WriteLine(e.Message);
                                }
                                logtext = e.Message + "\n";
                                File.AppendAllText(logfilename, logtext);
                                goto MainActivity;
                            }
                            logtext = input + " command successfully executed\n";
                            File.AppendAllText(logfilename, logtext);
                        }
                        break;
                    case "sum":
                        {
                            logtext = input + " command entered\n";
                            File.AppendAllText(logfilename, logtext);
                            Console.WriteLine("First number? ");
                            try
                            {
                                num1 = Convert.ToDecimal(Console.ReadLine());
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("You must enter a decimal number or integer.");
                                Console.WriteLine("Press Y to see the error.");
                                if (Console.ReadKey().Key == ConsoleKey.Y)
                                {
                                    Console.WriteLine(e.Message);
                                }
                                logtext = e.Message + "\n";
                                File.AppendAllText(logfilename, logtext);
                                goto MainActivity;
                            }
                            Console.WriteLine("Second number? ");
                            try
                            {
                                num2 = Convert.ToDecimal(Console.ReadLine());
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("You must enter a decimal number or integer.");
                                Console.WriteLine("Press Y to see the error.");
                                if (Console.ReadKey().Key == ConsoleKey.Y)
                                {
                                    Console.WriteLine(e.Message);
                                }
                                logtext = e.Message + "\n";
                                File.AppendAllText(logfilename, logtext);
                                goto MainActivity;
                            }
                            ans = num1 + num2;
                            Console.WriteLine("The sum of {0} and {1} is {2}", num1, num2, ans);
                            logtext = input + " command successfully executed\n";
                            File.AppendAllText(logfilename, logtext);
                        }
                        break;
                    case "diff":
                        {
                            logtext = input + " command entered\n";
                            File.AppendAllText(logfilename, logtext);
                            Console.WriteLine("First number? ");
                            try
                            {
                                num1 = Convert.ToDecimal(Console.ReadLine());
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("You must enter a decimal number or integer.");
                                Console.WriteLine("Press Y to see the error.");
                                if (Console.ReadKey().Key == ConsoleKey.Y)
                                {
                                    Console.WriteLine(e.Message);
                                }
                                logtext = e.Message + "\n";
                                File.AppendAllText(logfilename, logtext);
                                goto MainActivity;
                            }
                            Console.WriteLine("Second number? ");
                            try
                            {
                                num2 = Convert.ToDecimal(Console.ReadLine());
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("You must enter a decimal number or integer.");
                                Console.WriteLine("Press Y to see the error.");
                                if (Console.ReadKey().Key == ConsoleKey.Y)
                                {
                                    Console.WriteLine(e.Message);
                                }
                                logtext = e.Message + "\n";
                                File.AppendAllText(logfilename, logtext);
                                goto MainActivity;
                            }
                            ans = num1 - num2;
                            Console.WriteLine("The difference of {0} and {1} is {2}", num1, num2, ans);
                            logtext = input + " command successfully executed\n";
                            File.AppendAllText(logfilename, logtext);
                        }
                        break;
                    case "prod":
                        {
                            logtext = input + " command entered\n";
                            File.AppendAllText(logfilename, logtext);
                            Console.WriteLine("First number? ");
                            try
                            {
                                num1 = Convert.ToDecimal(Console.ReadLine());
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("You must enter a decimal number or integer.");
                                Console.WriteLine("Press Y to see the error.");
                                if (Console.ReadKey().Key == ConsoleKey.Y)
                                {
                                    Console.WriteLine(e.Message);
                                }
                                logtext = e.Message + "\n";
                                File.AppendAllText(logfilename, logtext);
                                goto MainActivity;
                            }
                            Console.WriteLine("Second number? ");
                            try
                            {
                                num2 = Convert.ToDecimal(Console.ReadLine());
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("You must enter a decimal number or integer.");
                                Console.WriteLine("Press Y to see the error.");
                                if (Console.ReadKey().Key == ConsoleKey.Y)
                                {
                                    Console.WriteLine(e.Message);
                                }
                                logtext = e.Message + "\n";
                                File.AppendAllText(logfilename, logtext);
                                goto MainActivity;
                            }
                            ans = num1 * num2;
                            Console.WriteLine("The product of {0} and {1} is {2}", num1, num2, ans);
                            logtext = input + " command successfully executed\n";
                            File.AppendAllText(logfilename, logtext);
                        }
                        break;
                    case "div":
                        {
                            logtext = input + " command entered\n";
                            File.AppendAllText(logfilename, logtext);
                            Console.WriteLine("First number? ");
                            try
                            {
                                num1 = Convert.ToDecimal(Console.ReadLine());
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("You must enter a decimal number or integer.");
                                Console.WriteLine("Press Y to see the error.");
                                if(Console.ReadKey().Key == ConsoleKey.Y)
                                {
                                    Console.WriteLine(e.Message);
                                }
                                logtext = e.Message + "\n";
                                File.AppendAllText(logfilename, logtext);
                                goto MainActivity;
                            }
                            Console.WriteLine("Second number? ");
                            try
                            {
                                num2 = Convert.ToDecimal(Console.ReadLine());
                                ans = num1 / num2;
                            }
                            catch (DivideByZeroException e)
                            {
                                Console.WriteLine("You cannot divide by zero.");
                                Console.WriteLine("Press Y to see the error.");
                                if (Console.ReadKey().Key == ConsoleKey.Y)
                                {
                                    Console.WriteLine(e.Message);
                                }
                                logtext = e.Message + "\n";
                                File.AppendAllText(logfilename, logtext);
                                goto MainActivity;
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("You must enter a decimal number or integer.");
                                Console.WriteLine("Press Y to see the error.");
                                if (Console.ReadKey().Key == ConsoleKey.Y)
                                {
                                    Console.WriteLine(e.Message);
                                }
                                logtext = e.Message + "\n";
                                File.AppendAllText(logfilename, logtext);
                                goto MainActivity;
                            }
                            Console.WriteLine("The quotient of {0} divided by {1} is {2}", num1, num2, ans);
                            logtext = input + " command successfully executed\n";
                            File.AppendAllText(logfilename, logtext);
                        }
                        break;
                    case "rem":
                        {
                            logtext = input + " command entered\n";
                            File.AppendAllText(logfilename, logtext);
                            Console.WriteLine("First number? ");
                            try
                            {
                                num1 = Convert.ToDecimal(Console.ReadLine());
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("You must enter a decimal number or integer.");
                                Console.WriteLine("Press Y to see the error.");
                                if (Console.ReadKey().Key == ConsoleKey.Y)
                                {
                                    Console.WriteLine(e.Message);
                                }
                                logtext = e.Message + "\n";
                                File.AppendAllText(logfilename, logtext);
                                goto MainActivity;
                            }
                            Console.WriteLine("Second number? ");
                            try
                            {
                                num2 = Convert.ToDecimal(Console.ReadLine());
                            }
                            catch (DivideByZeroException e)
                            {
                                Console.WriteLine("You cannot divide by zero.");
                                Console.WriteLine("Press Y to see the error.");
                                if (Console.ReadKey().Key == ConsoleKey.Y)
                                {
                                    Console.WriteLine(e.Message);
                                }
                                logtext = e.Message + "\n";
                                File.AppendAllText(logfilename, logtext);
                                goto MainActivity;
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("You must enter a decimal number or integer.");
                                Console.WriteLine("Press Y to see the error.");
                                if (Console.ReadKey().Key == ConsoleKey.Y)
                                {
                                    Console.WriteLine(e.Message);
                                }
                                logtext = e.Message + "\n";
                                File.AppendAllText(logfilename, logtext);
                                goto MainActivity;
                            }
                            ans = num1 % num2;
                            Console.WriteLine("The remainder of {0} divided by {1} is {2}", num1, num2, ans);
                            logtext = input + " command successfully executed\n";
                            File.AppendAllText(logfilename, logtext);
                        }
                        break;
                    case "fwrite":
                        {
                            logtext = input + " command entered\n";
                            File.AppendAllText(logfilename, logtext);
                            Console.WriteLine("File name? ");
                            filename1 = Console.ReadLine();
                            try
                            {
                                filecontent2 = File.ReadAllText(filename1); /*To not allow the user to continue the program without checking for a valid file path*/
                            }
                            catch (DirectoryNotFoundException e)
                            {
                                Console.WriteLine("You must enter a valid file name and path.");
                                Console.WriteLine("Press Y to see the error.");
                                if (Console.ReadKey().Key == ConsoleKey.Y)
                                {
                                    Console.WriteLine(e.Message);
                                }
                                logtext = e.Message + "\n";
                                File.AppendAllText(logfilename, logtext);
                                goto MainActivity;
                            }
                            catch (FileNotFoundException e)
                            {
                                Console.WriteLine("You must enter a valid file name and path.");
                                Console.WriteLine("Press Y to see the error.");
                                if (Console.ReadKey().Key == ConsoleKey.Y)
                                {
                                    Console.WriteLine(e.Message);
                                }
                                logtext = e.Message + "\n";
                                File.AppendAllText(logfilename, logtext);
                                goto MainActivity;
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("Unknown error.");
                                Console.WriteLine("Press Y to see the error.");
                                if (Console.ReadKey().Key == ConsoleKey.Y)
                                {
                                    Console.WriteLine(e.Message);
                                }
                                logtext = e.Message + "\n";
                                File.AppendAllText(logfilename, logtext);
                                goto MainActivity;
                            }
                            Console.WriteLine("File content? ");
                            filecontent1 = Console.ReadLine();
                            filecontent1 = filecontent1.Replace("\\\\", "\\");
                            filecontent1 = filecontent1.Replace("\\n", "\n");
                            filecontent1 = filecontent1.Replace("\\t", "\t");
                            Console.WriteLine("Overwrite or append? O for overwrite ");
                            try {
		                        if (Console.ReadKey().Key == ConsoleKey.O)
		                        {
		                            File.WriteAllText(filename1, filecontent1);
		                        }
		                        else
		                        {
		                            File.AppendAllText(filename1, filecontent1);
		                        }
		                    }
		                    catch (Exception e)
		                    {
		                    	Console.WriteLine("Unknown error.");
		                    	Console.WriteLine("Press Y to see the error.");
		                    	if (Console.ReadKey().Key == ConsoleKey.Y)
		                    	{
		                    		Console.WriteLine(e.Message);
		                    	}
		                    	logtext = e.Message + "\n";
                                File.AppendAllText(logfilename, logtext);
                                goto MainActivity;
                            }
                            logtext = input + " command successfully executed\n";
                            File.AppendAllText(logfilename, logtext);
                        }
                        break;
                    case "fdel":
                        {
                            logtext = input + " command entered\n";
                            File.AppendAllText(logfilename, logtext);
                            Console.WriteLine("File name? ");
                            filename1 = Console.ReadLine();
                            try
                            {
                                File.Delete(filename1);
                            }
                            catch (DirectoryNotFoundException e)
                            {
                                Console.WriteLine("You must enter a valid file name and path.");
                                Console.WriteLine("Press Y to see the error.");
                                if (Console.ReadKey().Key == ConsoleKey.Y)
                                {
                                    Console.WriteLine(e.Message);
                                }
                                logtext = e.Message + "\n";
                                File.AppendAllText(logfilename, logtext);
                                goto MainActivity;
                            }
                            catch (FileNotFoundException e)
                            {
                                Console.WriteLine("You must enter a valid file name and path.");
                                Console.WriteLine("Press Y to see the error.");
                                if (Console.ReadKey().Key == ConsoleKey.Y)
                                {
                                    Console.WriteLine(e.Message);
                                }
                                logtext = e.Message + "\n";
                                File.AppendAllText(logfilename, logtext);
                                goto MainActivity;
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("Unknown error");
                                Console.WriteLine("Press Y to see the error.");
                                if (Console.ReadKey().Key == ConsoleKey.Y)
                                {
                                    Console.WriteLine(e.Message);
                                }
                                logtext = e.Message + "\n";
                                File.AppendAllText(logfilename, logtext);
                                goto MainActivity;
                            }
                            logtext = input + " command successfully executed\n";
                            File.AppendAllText(logfilename, logtext);
                        }
                        break;
                    case "fopen":
                        {
                            logtext = input + " command entered\n";
                            File.AppendAllText(logfilename, logtext);
                            Console.WriteLine("File name? ");
                            filename1 = Console.ReadLine();
                            try
                            {
                                System.Diagnostics.Process.Start(filename1);
                            }
                            catch (DirectoryNotFoundException e)
                            {
                                Console.WriteLine("You must enter a valid file name and path.");
                                Console.WriteLine("Press Y to see the error.");
                                if (Console.ReadKey().Key == ConsoleKey.Y)
                                {
                                    Console.WriteLine(e.Message);
                                }
                                logtext = e.Message + "\n";
                                File.AppendAllText(logfilename, logtext);
                                goto MainActivity;
                            }
                            catch (FileNotFoundException e)
                            {
                                Console.WriteLine("You must enter a valid file name and path.");
                                Console.WriteLine("Press Y to see the error.");
                                if (Console.ReadKey().Key == ConsoleKey.Y)
                                {
                                    Console.WriteLine(e.Message);
                                }
                                logtext = e.Message + "\n";
                                File.AppendAllText(logfilename, logtext);
                                goto MainActivity;
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("Unknown error.");
                                Console.WriteLine("Press Y to see the error.");
                                if (Console.ReadKey().Key == ConsoleKey.Y)
                                {
                                    Console.WriteLine(e.Message);
                                }
                                logtext = e.Message + "\n";
                                File.AppendAllText(logfilename, logtext);
                                goto MainActivity;
                            }
                            logtext = input + " command successfully executed\n";
                            File.AppendAllText(logfilename, logtext);
                        }
                        break;
                    case "ftype":
                        {
                            logtext = input + " command entered\n";
                            File.AppendAllText(logfilename, logtext);
                            Console.WriteLine("File name? ");
                            filename1 = Console.ReadLine();
                            try
                            {
                                filecontent1 = File.ReadAllText(filename1);
                            }
                            catch (DirectoryNotFoundException e)
                            {
                                Console.WriteLine("You must enter a valid file name and path.");
                                Console.WriteLine("Press Y to see the error.");
                                if (Console.ReadKey().Key == ConsoleKey.Y)
                                {
                                    Console.WriteLine(e.Message);
                                }
                                logtext = e.Message + "\n";
                                File.AppendAllText(logfilename, logtext);
                                goto MainActivity;
                            }
                            catch (FileNotFoundException e)
                            {
                                Console.WriteLine("You must enter a valid file name and path.");
                                Console.WriteLine("Press Y to see the error.");
                                if (Console.ReadKey().Key == ConsoleKey.Y)
                                {
                                    Console.WriteLine(e.Message);
                                }
                                logtext = e.Message + "\n";
                                File.AppendAllText(logfilename, logtext);
                                goto MainActivity;
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("Unknown error.");
                                Console.WriteLine("Press Y to see the error.");
                                if (Console.ReadKey().Key == ConsoleKey.Y)
                                {
                                    Console.WriteLine(e.Message);
                                }
                                logtext = e.Message + "\n";
                                File.AppendAllText(logfilename, logtext);
                                goto MainActivity;
                            }
                            Console.Write("{0}\n", filecontent1);
                            logtext = input + " command successfully executed\n";
                            File.AppendAllText(logfilename, logtext);
                        }
                        break;
                    case "fcreate":
                        {
                            logtext = input + " command entered\n";
                            File.AppendAllText(logfilename, logtext);
                            Console.WriteLine("File name and path? ");
                            filename1 = Console.ReadLine();
                            try
                            {
                                if (File.Exists(filename1))
                                {
                                    Console.WriteLine("File already exists. Replace it? Y for yes ");
                                    if (Console.ReadKey().Key == ConsoleKey.Y)
                                    {
                                        File.Delete(filename1);
                                    }
                                    else
                                    {
                                        Console.WriteLine("Aborted.");
                                        goto MainActivity;
                                    }
                                }
                                File.Create(filename1).Dispose();
                                Console.WriteLine("File created.");
                            }
                            catch(Exception e)
                            {
                                Console.WriteLine("Error. ");
                                Console.WriteLine("Press Y to see the error.");
                                if (Console.ReadKey().Key == ConsoleKey.Y)
                                {
                                    Console.WriteLine(e.Message);
                                }
                                logtext = e.Message + "\n";
                                File.AppendAllText(logfilename, logtext);
                                goto MainActivity;
                            }
                            logtext = input + " command successfully executed\n";
                            File.AppendAllText(logfilename, logtext);
                        }
                        break;
                    case "dir":
                        {
                            logtext = input + " command entered\n";
                            File.AppendAllText(logfilename, logtext);
                            try
                            {
                                currentdir = Directory.GetCurrentDirectory();
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("Unknown error.");
                                Console.WriteLine("Press Y to see the error.");
                                if (Console.ReadKey().Key == ConsoleKey.Y)
                                {
                                    Console.WriteLine(e.Message);
                                }
                                logtext = e.Message + "\n";
                                File.AppendAllText(logfilename, logtext);
                                goto MainActivity;
                            }
                            Console.WriteLine("{0}", currentdir);
                            logtext = input + " command successfully executed\n";
                            File.AppendAllText(logfilename, logtext);
                        }
                        break;
                    case "contact":
                        {
                            logtext = input + " command entered\n";
                            File.AppendAllText(logfilename, logtext);
                            Console.WriteLine("Email: shrikaanthpruthvispareemail@gmail.com\nPhone: +447712343856\nWebsite: http://blue0tech.unaux.com/");
                            logtext = input + " command successfully executed\n";
                            File.AppendAllText(logfilename, logtext);
                        }
                        break;
                    case "fdl":
                        {
                            logtext = input + " command entered\n";
                            File.AppendAllText(logfilename, logtext);
                            try
                            {
                                Console.WriteLine("Enter URL? ");
                                url = Console.ReadLine();
                                fdl = new WebClient();
                                fdlcontent = fdl.DownloadString(url);
                                Console.WriteLine("Enter filename? ");
                                fdlname = Console.ReadLine();
                                File.WriteAllText(fdlname, fdlcontent);
                            }
                            catch (HttpListenerException e)
                            {
                                Console.WriteLine("Could not connect to the Internet. Please check your connection and the url entered was correct.");
                                Console.WriteLine("Press Y to see the error.");
                                if (Console.ReadKey().Key == ConsoleKey.Y)
                                {
                                    Console.WriteLine(e.Message);
                                }
                                logtext = e.Message + "\n";
                                File.AppendAllText(logfilename, logtext);
                                goto MainActivity;
                            }
                            catch (FileNotFoundException e)
                            {
                                Console.WriteLine("Please check the file name and path.");
                                Console.WriteLine("Press Y to see the error.");
                                if (Console.ReadKey().Key == ConsoleKey.Y)
                                {
                                    Console.WriteLine(e.Message);
                                }
                                logtext = e.Message + "\n";
                                File.AppendAllText(logfilename, logtext);
                                goto MainActivity;
                            }
                            catch (DirectoryNotFoundException e)
                            {
                                Console.WriteLine("Please check the file name and path.");
                                Console.WriteLine("Press Y to see the error.");
                                if (Console.ReadKey().Key == ConsoleKey.Y)
                                {
                                    Console.WriteLine(e.Message);
                                }
                                logtext = e.Message + "\n";
                                File.AppendAllText(logfilename, logtext);
                                goto MainActivity;
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("Unknown error.");
                                Console.WriteLine("Press Y to see the error.");
                                if (Console.ReadKey().Key == ConsoleKey.Y)
                                {
                                    Console.WriteLine(e.Message);
                                }
                                logtext = e.Message + "\n";
                                File.AppendAllText(logfilename, logtext);
                                goto MainActivity;
                            }
                            logtext = input + " command successfully executed\n";
                            File.AppendAllText(logfilename, logtext);
                        }
                        break;
                    case "tc":
                        {
                            logtext = input + " command entered\n";
                            File.AppendAllText(logfilename, logtext);
                            try
                            {
                                tc = File.ReadAllText("tc.txt");
                                Console.WriteLine(tc);
                            } 
                            catch(Exception e)
                            {
                                Console.WriteLine("Critical error. Please make sure that you have installed the program correctly and from trusted sources.");
                                Console.WriteLine("Press Y to see the error.");
                                if (Console.ReadKey().Key == ConsoleKey.Y)
                                {
                                    Console.WriteLine(e.Message);
                                }
                                logtext = e.Message + "\n";
                                File.AppendAllText(logfilename, logtext);
                                goto MainActivity;
                            }
                            logtext = input + " command successfully executed\n";
                            File.AppendAllText(logfilename, logtext);
                        }
                        break;
                    case "privacy":
                        {
                            logtext = input + " command entered\n";
                            File.AppendAllText(logfilename, logtext);
                            try
                            {
                                privacy = File.ReadAllText("privacy.txt");
                                Console.WriteLine(privacy);
                            } 
                            catch(Exception e)
                            {
                                Console.WriteLine("Critical error. Please make sure that you have installed the program correctly and from trusted sources.");
                                Console.WriteLine("Press Y to see the error.");
                                if (Console.ReadKey().Key == ConsoleKey.Y)
                                {
                                    Console.WriteLine(e.Message);
                                }
                                logtext = e.Message + "\n";
                                File.AppendAllText(logfilename, logtext);
                                goto MainActivity;
                            }
                            logtext = input + " command successfully executed\n";
                            File.AppendAllText(logfilename, logtext);
                        }
                        break;
                    case "license":
                        {
                            logtext = input + " command entered\n";
                            File.AppendAllText(logfilename, logtext);
                            try
                            {
                                license = File.ReadAllText("license.txt");
                                Console.WriteLine(license);
                            } 
                            catch(Exception e)
                            {
                                Console.WriteLine("Critical error. Please make sure that you have installed the program correctly and from trusted sources.");
                                Console.WriteLine("Press Y to see the error.");
                                if (Console.ReadKey().Key == ConsoleKey.Y)
                                {
                                    Console.WriteLine(e.Message);
                                }
                                logtext = e.Message + "\n";
                                File.AppendAllText(logfilename, logtext);
                                goto MainActivity;
                            }
                            logtext = input + " command successfully executed\n";
                            File.AppendAllText(logfilename, logtext);
                        }
                        break;
                        case "extract":
                        {
                            logtext = input + " command entered\n";
                            File.AppendAllText(logfilename, logtext);
                            Console.WriteLine("Archive file name? ");
                    		extractfilename = Console.ReadLine();
                    		Console.WriteLine("Archive extraction destination directory? ");
                    		extractdir = Console.ReadLine();
                    		try {
                    			ZipFile.ExtractToDirectory(extractfilename,extractdir);
                    		} catch(Exception e) {
                    			Console.WriteLine("Unknown error.");
                    			Console.WriteLine("Press Y to see the error.");
                    			if(Console.ReadKey().Key == ConsoleKey.Y) {
                    				Console.WriteLine(e.Message);
                    			}
                    			logtext = e.Message + "\n";
                                File.AppendAllText(logfilename, logtext);
                                goto MainActivity;
                            }
                            logtext = input + " command successfully executed\n";
                            File.AppendAllText(logfilename, logtext);
                        }
                        break;
                    case "compress":
                        {
                            logtext = input + " command entered\n";
                            File.AppendAllText(logfilename, logtext);
                            Console.WriteLine("Directory to compress? ");
                            compressfolder = Console.ReadLine();
                            Console.WriteLine("Archive file name? ");
                            compressfilename = Console.ReadLine();
                            try
                            {
                                ZipFile.CreateFromDirectory(compressfolder, compressfilename);
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("Unknown error.");
                                Console.WriteLine("Press Y to see the error.");
                                if (Console.ReadKey().Key == ConsoleKey.Y)
                                {
                                    Console.WriteLine(e.Message);
                                }
                                logtext = e.Message + "\n";
                                File.AppendAllText(logfilename, logtext);
                                goto MainActivity;
                            }
                            logtext = input + " command successfully executed\n";
                            File.AppendAllText(logfilename, logtext);
                        }
                        break;
                    default:
                        {
                            Console.WriteLine("{0} is not a valid command", input);
                        }
                        break;
                }
            } while (input != "exit");
            /*before closing the window*/
            Console.ReadKey(true);
            logtext = "Program successfully terminated";
            File.AppendAllText(logfilename, logtext);
        }
    }
}
