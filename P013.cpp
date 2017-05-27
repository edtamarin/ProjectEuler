#include <iostream>
#include <fstream>
using namespace std;

int main(){
    fstream file;
    file.open("resources/R013.txt", ios::in);
    string str;
    int sum = 0;
    while(getline(file,str)){
        str = str.substr(0,12);
        int digits = stoi(str,nullptr);
        sum += digits;
    }
    string result = tostring(sum);
    result = result.substr(0,10);
    cout>>result;
    return 0;
}
