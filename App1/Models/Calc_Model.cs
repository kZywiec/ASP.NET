using System.Diagnostics.Metrics;

namespace App1.Models
{
    public class Calc_Model
    {

        private int first_number;
        private int second_number;
        private char _operator;

        public int FirstNumber { get { return first_number; } set { first_number = value; } }
        public int SecondNumber { get { return second_number; } set { second_number = value; } }
        public char Operator { get { return _operator; } set { _operator = value; } }

        public string Addition()
            => $"{this.FirstNumber} {this.Operator} {this.SecondNumber} = {this.FirstNumber + this.SecondNumber}";
        public string Subtraction()
            => $"{this.FirstNumber} {this.Operator} {this.SecondNumber} = {this.FirstNumber - this.SecondNumber}";
        public string Multiplication()
            => $"{this.FirstNumber} {this.Operator} {this.SecondNumber} = {this.FirstNumber * this.SecondNumber}";
        public string Division()
            => $"{this.FirstNumber} {this.Operator} {this.SecondNumber} = {this.FirstNumber / this.SecondNumber}";
    }
}
