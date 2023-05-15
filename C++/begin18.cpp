// Muallif: Bekzhanov Rasul
// Sana: 15.05.2023

#include <iostream>
using namespace std;

int main(){
    long long a,c,b,ac,bc;
    cout << "Koordinatalardi kiriting:";
    cin >> a >> b >> c;
    ac = abs(c - a);
    bc = abs(b - c);
    cout << "AC va BC kesmalarining kopaytmasi: " << ac*bc;
    return 0;
}