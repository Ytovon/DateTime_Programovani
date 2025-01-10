using ConsoleApp1;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool Continue = true;

            while (Continue)
            {
                int input = TimeHelper.GetIntInRange("1 - Získej dnešní den v týdnu, 2 - Získej momentální čas, 3 - pro posun podle vámi stanoveneho počtu dní, 4 - pro rozdil mezi vámi stanoveným časem a momentálním časem, 5 - odejít");

                switch (input)
                {
                    case 1:
                        Console.WriteLine(TimeHelper.GetDayOfWeek());
                        break;
                    case 2:
                        Console.WriteLine(TimeHelper.GetCurrentTime());
                        break;
                    case 3:
                        Console.WriteLine(TimeHelper.CalculateAddDays().ToString("D"));
                        break;
                    case 4:
                        Console.WriteLine(TimeHelper.CalculateDifferenceNow());
                        break;
                    case 5:
                        Continue = false;
                        break;
                    default:
                        Console.WriteLine("Špatně zadaný vstup...");
                        break;
                }
            }
        }
    }
}
