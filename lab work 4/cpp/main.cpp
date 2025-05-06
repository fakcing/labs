#include <iostream>
#include <cmath>

class Line {
protected:
    double x1, y1, x2, y2;

public:
    Line() : x1(0), y1(0), x2(0), y2(0) {}
    Line(double x1, double y1, double x2, double y2)
        : x1(x1), y1(y1), x2(x2), y2(y2) {}
    Line(const Line& other)
        : x1(other.x1), y1(other.y1), x2(other.x2), y2(other.y2) {}
    virtual ~Line() {}

    double getX1() const { return x1; }
    double getY1() const { return y1; }
    double getX2() const { return x2; }
    double getY2() const { return y2; }

    double length() const {
        return std::sqrt((x2 - x1)*(x2 - x1) + (y2 - y1)*(y2 - y1));
    }
};

class Segment : public Line {
public:
    Segment(double x1, double y1, double x2, double y2)
        : Line(x1, y1, x2, y2) {}

    double angleWithOX() const {
        return std::atan2(y2 - y1, x2 - x1) * 180.0 / M_PI;
    }

    void printData() const {
        std::cout << "Start: (" << x1 << ", " << y1 << ")\n";
        std::cout << "End:   (" << x2 << ", " << y2 << ")\n";
    }
};

int main() {
    double x1, y1, x2, y2;
    std::cout << "Enter x1, y1, x2, y2: ";
    std::cin >> x1 >> y1 >> x2 >> y2;

    Segment s(x1, y1, x2, y2);

    s.printData();
    std::cout << "Length: " << s.length() << std::endl;
    std::cout << "Angle with OX: " << s.angleWithOX() << " degrees" << std::endl;

    return 0;
}
