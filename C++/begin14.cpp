// Muallif: Bekzhanov Rasul
// Sana: 15.05.2023

#include <iostream>
#include <cmath>
using namespace std;

int main(){
    long long l,r,s;
    cout << "Aylana uzunligin kiriting:";
    cin >> l;
    r = l/2*M_PI;
    s = M_PI*pow(r,2);
    cout << "Aylana radiusi: " << r << endl;
    cout << "Yuzasi: " << s;
    return 0;
}