// Muallif: Bekzhanov Rasul
// Sana: 15.05.2023

#include <iostream>
#include <cmath>
using namespace std;

int main(){
    long long r;
    cout << "Doira radiusi:";
    cin >> r;
    cout << "Uning uzinligi: " << 2*M_PI*r << endl;
    cout << "Yuzasi: " << M_PI*pow(r,2);
    return 0;
}