// Muallif: Bekzhanov Rasul
// Sana: 15.05.2023

#include <iostream>
using namespace std;

int main(){
    long long a,b,c,temp;
    cout << "A sonini kiriting: ";cin >> a;
    cout << "B sonini kiriting: ";cin >> b;
    cout << "C sonini kiriting: ";cin >> c;
    temp = a;
    a = b;
    b = c;
    c = temp;
    cout << "A=" << a << endl;
    cout << "B=" << b << endl;
    cout << "C=" << c << endl;
    return 0;
}