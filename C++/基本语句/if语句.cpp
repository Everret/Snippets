#include <iostream>

int main() {
    int grade = 70;
    std::string Out;
    if (grade < 60)
    {
        Out = "Failed";
    }
    else if (grade < 80)
    {
        Out = "Good";
    }
    else
    {
        Out = "Great";
    }
    return 0;
}