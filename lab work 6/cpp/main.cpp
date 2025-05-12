#include <iostream>
#include <windows.h>
#include "TextContainer.h"

int main() {
    SetConsoleOutputCP(CP_UTF8);
    SetConsoleCP(CP_UTF8);

    TextContainer text;
    text.AddLine(MyString("Привіт, світ"));
    text.AddLine(MyString("C++ потужний"));
    text.AddLine(MyString("Це тестовий рядок"));

    std::cout << "Рядки в тексті:" << std::endl;
    text.PrintLines();

    std::cout << "\nСередня довжина рядка: " << text.GetAverageLength() << std::endl;
    std::cout << "Відсоток голосних: " << text.GetVowelPercentage() << "%" << std::endl;

    text.RemoveLinesContaining("тест");

    std::cout << "\nПісля видалення рядків, що містять 'тест':" << std::endl;
    text.PrintLines();

    return 0;
}
