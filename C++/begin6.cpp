// Muallif: Bekzhanov Rasul
// Sana: 15.05.2023

#include <iostream>
using namespace std;

int main(){
    long long a,b,c;
    cout << "Paralipepidning tamonlarin kiriting:";
    cin >> a >> b >> c;
    cout << "Uning hajmi: " << a*b*c << endl;
    cout << "To'la sirt: " << 2*(a*b+b*c+a*c);
    return 0;
}