// Muallif: Bekzhanov Rasul
// Sana: 15.05.2023

#include <iostream>
using namespace std;

int main(){
    long long a,b,c,ac,bc;
    cout << "Kesmalar uzinligin kiriting:";
    cin >> a >> b >> c;
    ac = abs(c - a);
    bc = abs(c - b);
    cout << "AC kesmasining uzunligi: " << ac << endl;
    cout << "BC kesmasining uzunligi: " << bc << endl;
    cout << "Kesmalar uzunligining yig'indisi: " << ac+bc;
    return 0;
}