using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebCalculator.Models
{
    public class History
    {
        public double number1 { get; set; }
        public double number2 { get; set; }
        public double total { get; set; }

        public History(double first_number, double second_number, double total_number)
        {
            number1 = first_number;
            number2 = second_number;
            total = total_number;
        }
    }
}