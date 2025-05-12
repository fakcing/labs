#include "TextContainer.h"
#include <iostream>
#include <numeric>
#include <algorithm>

void TextContainer::AddLine(const MyString& line) {
    lines.push_back(line);
}

void TextContainer::RemoveLinesContaining(const std::string& substring) {
    lines.erase(
        std::remove_if(lines.begin(), lines.end(),
                       [&substring](const MyString& line) {
                           return line.Contains(substring);
                       }),
        lines.end()
    );
}

void TextContainer::Clear() {
    lines.clear();
}

double TextContainer::GetAverageLength() const {
    if (lines.empty()) return 0.0;
    size_t totalLength = 0;
    for (const auto& line : lines) {
        totalLength += line.Length();
    }
    return static_cast<double>(totalLength) / lines.size();
}

double TextContainer::GetVowelPercentage() const {
    if (lines.empty()) return 0.0;
    int totalChars = 0;
    int totalVowels = 0;
    for (const auto& line : lines) {
        totalChars += line.Length();
        totalVowels += line.CountVowels();
    }
    return totalChars ? (static_cast<double>(totalVowels) / totalChars * 100) : 0.0;
}

void TextContainer::PrintLines() const {
    for (const auto& line : lines) {
        std::cout << line.GetValue() << std::endl;
    }
}
