using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    class Fly
    {
        Airplane plane = new Airplane();
        bool is1000 = false;
        public void Flight()
        {
            ConsoleKeyInfo keyInfo;
            if(plane.ld.Count < 2)
            {
                while (plane.ld.Count < 2)
                {
                    Console.WriteLine("Enter name of dispatcher");
                    Dispatcher D = new Dispatcher(Console.ReadLine());
                    plane.ld.Add(D);
                }
               
            }
            bool fall = false;

            do
            {
                 
                Show();

                keyInfo = Console.ReadKey();
                Console.Clear();



                if (keyInfo.Modifiers == ConsoleModifiers.Shift && keyInfo.Key == ConsoleKey.UpArrow && plane.Speed >= 50)
                {
                    plane.High += 500;
                }
                else if (keyInfo.Key == ConsoleKey.UpArrow && plane.Speed >= 50)
                {
                    plane.High += 250;
                }


                else if (keyInfo.Modifiers == ConsoleModifiers.Shift && keyInfo.Key == ConsoleKey.DownArrow && plane.High >= 500)
                {
                    plane.High -= 500;
                }
                else if (keyInfo.Key == ConsoleKey.DownArrow && plane.High >= 250)
                {
                    plane.High -= 250;
                    
                }


                else if (keyInfo.Modifiers == ConsoleModifiers.Shift && keyInfo.Key == ConsoleKey.RightArrow && plane.Speed <= 1000)
                {
                    plane.Speed += 150;
                    if (plane.Speed >= 1000)
                        Console.WriteLine("Goal achieved");
                }
                else if (keyInfo.Key == ConsoleKey.RightArrow && plane.Speed <= 1000)
                {
                    plane.Speed += 50;
                    if (plane.Speed >= 1000)
                        Console.WriteLine("Goal achieved");
                }



                else if (keyInfo.Modifiers == ConsoleModifiers.Shift && keyInfo.Key == ConsoleKey.LeftArrow && plane.Speed >= 150)
                {
                    
                    plane.Speed -= 150;

                }
                else if (keyInfo.Key == ConsoleKey.LeftArrow && plane.Speed >= 50)
                {
                    plane.Speed -= 50;
                }

                else if (keyInfo.Key == ConsoleKey.Spacebar)
                {

                    Console.Clear();
                    string s;
                    Console.WriteLine("\tMenu\n1 - Add dispatcher\n2 - Delete dispather\n3 - Show");
                    s = Console.ReadLine();

                    if (s == "1")
                    {
                        Console.WriteLine("Enter name");
                        Dispatcher D = new Dispatcher(Console.ReadLine());
                        plane.ld.Add(D);
                    }
                    else if (s == "2")
                    {
                        if (plane.ld.Count <= 2)
                        {
                            Console.WriteLine("Error");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Enter number of dispatcher");
                            plane.ld.RemoveAt(int.Parse(Console.ReadLine()));
                        }
                    }
                    else if (s == "3")
                    {
                        foreach (var item in plane.ld)
                        {
                            item.Show();
                        }
                    }
                }
                if (plane.High <= 0 && plane.Speed <= 0)
                {
                    throw new IndexOutOfRangeException();
                    fall = true;
                }
            } while (keyInfo.Key != ConsoleKey.Escape && plane.Speed >= 50 && fall == false );
            EndOfFlight();
        }
        int EndOfFlight()
        {
            Console.WriteLine($"Penalty points {plane.Penalty}");
            return 0;
        }

        public void Show()
        {

            Console.WriteLine($"{plane.Speed}km/h\n{plane.High}m\nSpace - menu\n\nEsc - exit\n");
            if (plane.Speed >= 50)
            foreach (var item in plane.ld)
            {
                    item.RecHigh(plane);
            }
        }
    }
    }

