// Muallif: Bekzhanov Rasul
// Sana: 15.05.2023

#include <iostream>
#include <cmath>
using namespace std;

int main(){
    long long r1,r2,s1,s2;
    cout << "Aylanalar radiuslarin kiriting:";
    cout << r1 << r2;
    s1 = M_PI*r1;
    s2 = M_PI*r2;
    cout << "Birinshi aylananing yuzasi: " << s1 << endl;
    cout << "Ikkinshi aylananing yuzasi: " << s2 << endl;
    cout << "Ularning ayirmasi: " << M_PI*(r1-r2);
    return 0;
}