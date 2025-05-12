using System;

namespace ExpressionLibrary {
    public class Expression {
        public double A { get; private set; }
        public double C { get; private set; }
        public double D { get; private set; }

        public Expression(double a, double c, double d) {
            A = a;
            C = c;
            D = d;
        }

        public void SetValues(double a, double c, double d) {
            A = a;
            C = c;
            D = d;
        }

        private double CalculateLog(double x) {
            if (x <= 0.0)
                throw new ArgumentException("Logarithm argument must be > 0");
            return Math.Log(x);
        }

        public double CalculateExpression() {
            double numerator = 2 * C - D / 23.0;
            double denominator = CalculateLog(1 - A / 4.0);

            if (denominator == 0.0)
                throw new DivideByZeroException("Division by zero in expression");

            return numerator / denominator;
        }
    }
}
