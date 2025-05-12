#ifndef TEXTCONTAINER_H
#define TEXTCONTAINER_H

#include "MyString.h"
#include <vector>

class TextContainer {
private:
    std::vector<MyString> lines;
public:
    void AddLine(const MyString& line);
    void RemoveLinesContaining(const std::string& substring);
    void Clear();
    double GetAverageLength() const;
    double GetVowelPercentage() const;
    void PrintLines() const;
};

#endif
