#ifndef EXPRESSION_H
#define EXPRESSION_H

#include <stdexcept>

class Expression {
private:
    double a, c, d;

public:
    Expression(double a, double c, double d);

    void setValues(double a, double c, double d);
    double getA() const;
    double getC() const;
    double getD() const;

    double calculateExpression() const;

private:
    double calculateLog(double x) const;
};

#endif
