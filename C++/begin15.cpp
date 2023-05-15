// Muallif: Bekzhanov Rasul
// Sana: 15.05.2023

#include <iostream> 
#include <cmath>
using namespace std;

int main(){
    long long s,d,r;
    cout << "Ayananing yuzasin kiriting:";
    cin >> s;
    r = sqrt(s/M_PI);
    cout << "Aylananing diametri: " << r*2 << endl;
    cout << "Aylananing raduisi: " << r;
    return 0;
}