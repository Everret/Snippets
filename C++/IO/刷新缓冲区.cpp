#include <iostream>

int main() {
    std::cout << "hi!" << std::endl;//endl是输出一个换行并刷新缓冲区
    std::cout << "hi!" << std::flush;//flush是只刷新缓冲区
    std::cout << "hi!" << std::ends;//endl是输出一个空字符并刷新缓冲区
    std::cout << std::unitbuf;//unitbuf切换为立即刷新状态
    std::cout << std::nounitbuf; //nounitbuf切换为一般刷新状态
    return 0;
}