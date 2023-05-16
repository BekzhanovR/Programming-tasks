// Muallif: Bekzhanov Rasul
// Sana: 15.05.2023

#include <iostream>
using namespace std;

int main(){
    long long a,b,c,temp;
    cout << "A sonin kiriting: ";
    cin >> a;
    cout << "B sonin kiriting: ";
    cin >> b;
    cout << "C sonin kiriting: ";
    cin >> c;
    temp = a;
    a = c;
    c = b;
    b = temp;
    cout << "A=" << a << endl;
    cout << "B=" << b << endl;
    cout << "C=" << c << endl;
    return 0;
}