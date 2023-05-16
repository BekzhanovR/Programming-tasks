// Muallif: Bekzhanov Rasul
// Sana: 15.05.2023

#include <iostream>
using namespace std;

int main(){
    long long a,b,c;
    cout << "A sonini kiriting: ";
    cin >> a;
    cout << "B sonini kiriting: ";
    cin >> b;
    c = a;
    a = b;
    b = c;
    cout << a << " va " << b;
    return 0;
}