#include "Expression.h"
#include <cmath>

Expression::Expression(double a, double c, double d) : a(a), c(c), d(d) {}

void Expression::setValues(double aVal, double cVal, double dVal) {
    a = aVal;
    c = cVal;
    d = dVal;
}

double Expression::getA() const { return a; }
double Expression::getC() const { return c; }
double Expression::getD() const { return d; }

double Expression::calculateLog(double x) const {
    if (x <= 0.0) {
        throw std::invalid_argument("Logarithm argument must be > 0");
    }
    return std::log(x);
}

double Expression::calculateExpression() const {
    double numerator = 2 * c - d / 23.0;
    double denominator = calculateLog(1 - a / 4.0);

    if (denominator == 0.0) {
        throw std::runtime_error("Division by zero in expression");
    }

    return numerator / denominator;
}
