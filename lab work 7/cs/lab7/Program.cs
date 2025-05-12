using System;
using ExpressionLibrary;
using System.Collections.Generic;

namespace ConsoleApp {
    class Program {
        static void Main() {
            Console.Write("Enter number of expressions: ");
            string? input = Console.ReadLine();

            // Перевірка на null або порожній рядок
            if (string.IsNullOrWhiteSpace(input)) {
                Console.WriteLine("No input provided.");
                return;
            }

            // Спроба перетворення в ціле число
            if (!int.TryParse(input, out int n)) {
                Console.WriteLine("Invalid number of expressions.");
                return;
            }

            List<Expression> expressions = new List<Expression>();

            for (int i = 0; i < n; i++) {
                Console.WriteLine($"\nExpression {i + 1}:");
                Console.Write("Enter a, c, d (separate values by space): ");
                string? expressionInput = Console.ReadLine();

                // Перевірка на null або порожній рядок для значень a, c, d
                if (string.IsNullOrWhiteSpace(expressionInput)) {
                    Console.WriteLine("Invalid input for a, c, d. Please enter valid numbers.");
                    return;
                }

                string[] inputValues = expressionInput.Split();

                // Перевірка кількості значень і їх перетворення на числа
                if (inputValues.Length != 3 || 
                    !double.TryParse(inputValues[0], out double a) ||
                    !double.TryParse(inputValues[1], out double c) ||
                    !double.TryParse(inputValues[2], out double d)) {
                    Console.WriteLine("Invalid values for a, c, d. Please enter valid numbers.");
                    return;
                }

                expressions.Add(new Expression(a, c, d));
            }

            for (int i = 0; i < expressions.Count; i++) {
                try {
                    double result = expressions[i].CalculateExpression();
                    Console.WriteLine($"Result {i + 1}: {result}");
                } catch (Exception ex) {
                    Console.WriteLine($"Error in expression {i + 1}: {ex.Message}");
                }
            }
        }
    }
}
