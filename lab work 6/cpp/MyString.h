#ifndef MYSTRING_H
#define MYSTRING_H

#include <string>

class MyString {
private:
    std::string value;
public:
    MyString(const std::string& str);
    std::string GetValue() const;
    size_t Length() const;
    int CountVowels() const;
    bool Contains(const std::string& substring) const;
};

#endif
