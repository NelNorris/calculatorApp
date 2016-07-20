using System;
namespace Calculator {
    public class Program {
        public static void Main() {

            Console.WriteLine("Welcome to Calculator: Ghetto Edition. Enter a number (digits 0-9), followed by an operator (+, -, * or /), and a second number. Enter 'clear' to reset or 'exit' to end program.");

            string s;
            string empty = "";

            string plus = "+";
            string minus = "-";
            string multi = "*";
            string divi = "/";
            string reset = "clear";
            string quit = "exit";

            string operate = "";
            string input = "";
            string output = "";
                
            decimal numberOne = 0;
            decimal numberTwo = 0;
            decimal sum = 0;

            for (; ; ) {

                s = Console.ReadLine();

                if (String.Compare(s, plus) == 0) {
                    operate = plus;
                }
                if (String.Compare(s, minus) == 0) {
                    operate = minus;
                }
                if (String.Compare(s, multi) == 0) {
                    operate = multi;
                }
                if (String.Compare(s, divi) == 0) {
                    operate = divi;
                }
                if (String.Compare(s, reset) == 0) {
                    Console.WriteLine("Resetting calculator...");
                    operate = "";
                    input = "";
                    output = "";
                    numberOne = 0;
                    numberTwo = 0;
                    sum = 0;
                    Console.WriteLine("Enter number: ");
                }
                if (IsAllDigits(s)) {
                    input = s;
                    if (numberOne == 0 && numberTwo == 0) {
                        Console.WriteLine("first if statement");
                        output = input;
                    } else if (numberOne != 0 && numberTwo == 0) {
                        Console.WriteLine("second if statement " + operate);
                        numberTwo = Decimal.Parse(input);
                        if (String.Compare(operate, plus) == 0) {
                            sum = numberOne + numberTwo;
                        }
                        if (String.Compare(operate, minus) == 0) {
                            sum = numberOne - numberTwo;
                        }
                        if (String.Compare(operate, multi) == 0) {
                            sum = numberOne * numberTwo;
                        }
                        if (String.Compare(operate, divi) == 0) {
                            sum = numberOne / numberTwo;
                        }
                        output = sum.ToString();
                    } else if (numberOne != 0 && String.Compare(operate, empty) == 0) {
                        Console.WriteLine("third if statement");
                        output = input;
                    } else {
                        Console.WriteLine("final if statement");
                        numberTwo = Decimal.Parse(input);
                        if (String.Compare(operate, plus) == 0) {
                            sum = numberOne + numberTwo;
                        }
                        if (String.Compare(operate, minus) == 0) {
                            sum = numberOne - numberTwo;
                        }
                        if (String.Compare(operate, multi) == 0) {
                            sum = numberOne * numberTwo;
                        }
                        if (String.Compare(operate, divi) == 0) {
                            sum = numberOne / numberTwo;
                        }
                        output = sum.ToString();
                    }
                    Console.WriteLine("Display: " + output);
                    Console.WriteLine("Enter number or operator. Submit 'clear' to reset calculator and 'exit' will quit program.")
                    numberOne = Decimal.Parse(output);
                }
                if (String.Compare(s, quit) == 0) {
                    break;
                }
            }
            Console.WriteLine("Press Enter to terminate...");
            Console.Read();
        }
        public static bool IsAllDigits (string raw) {
            string s = raw.Trim();
            for (int index = 0; index < s.Length; index++) {
                if (s[index] == '.') {
                    continue;
                }
                if (Char.IsDigit(s[index]) == false) {
                    return false;
                }
            }
            return true;
        }
    }
}