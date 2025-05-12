#include <iostream>
#include <vector>
#include "Expression.h"

int main() {
    std::vector<Expression> expressions;
    int n;
    std::cout << "Enter number of expressions: ";
    std::cin >> n;

    for (int i = 0; i < n; ++i) {
        double a, c, d;
        std::cout << "\nExpression " << i + 1 << ":\n";
        std::cout << "Enter a, c, d: ";
        std::cin >> a >> c >> d;

        Expression expr(a, c, d);
        expressions.push_back(expr);
    }

    for (size_t i = 0; i < expressions.size(); ++i) {
        try {
            double result = expressions[i].calculateExpression();
            std::cout << "Result " << i + 1 << ": " << result << std::endl;
        } catch (const std::exception& e) {
            std::cout << "Error in expression " << i + 1 << ": " << e.what() << std::endl;
        }
    }

    return 0;
}
