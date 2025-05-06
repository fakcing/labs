#include <iostream>
#include <string>

class StringBase {
protected:
    std::string value;

public:
    StringBase(const std::string& val = "") : value(val) {}
    virtual ~StringBase() {}

    virtual size_t length() const {
        return value.length();
    }

    virtual std::string insertSymbol() const = 0;
};

class UpperCase : public StringBase {
public:
    UpperCase(const std::string& val) : StringBase(val) {}

    size_t length() const override {
        return value.length();
    }

    std::string insertSymbol() const override {
        std::string result;
        for (size_t i = 0; i < value.length(); ++i) {
            result += value[i];
            if (i != value.length() - 1) result += '/';
        }
        return result;
    }
};

class LowerCase : public StringBase {
public:
    LowerCase(const std::string& val) : StringBase(val) {}

    size_t length() const override {
        return value.length();
    }

    std::string insertSymbol() const override {
        std::string result;
        for (size_t i = 0; i < value.length(); ++i) {
            result += value[i];
            if (i != value.length() - 1) result += '\\';
        }
        return result;
    }
};

void processString(const StringBase& s) {
    std::cout << "Length: " << s.length() << std::endl;
    std::cout << "Modified: " << s.insertSymbol() << std::endl;
}

int main() {
    UpperCase upper("HELLO");
    LowerCase lower("hello");

    std::cout << "UpperCase:\n";
    processString(upper);

    std::cout << "\nLowerCase:\n";
    processString(lower);

    return 0;
}
