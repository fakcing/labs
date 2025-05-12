#include "MyString.h"
#include <algorithm>

MyString::MyString(const std::string& str) : value(str) {}

std::string MyString::GetValue() const {
    return value;
}

size_t MyString::Length() const {
    return value.length();
}

int MyString::CountVowels() const {
    int count = 0;
    std::string vowels = "aeiouAEIOUаеєиіїоуюяАЕЄИІЇОУЮЯ";
    for (unsigned char ch : value) {
        if ((ch & 0x80) == 0) { // ASCII
            if (vowels.find(ch) != std::string::npos) count++;
        }
        else {
            // UTF-8: не точний, бо тут краще треба libiconv або wide strings
            // Але для простоти підрахунок робимо тільки ASCII та перші байти
        }
    }
    return count;
}

bool MyString::Contains(const std::string& substring) const {
    return value.find(substring) != std::string::npos;
}
