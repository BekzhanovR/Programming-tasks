// Muallif: Bekzhanov Rasul
// Sana: 15.05.2023

#include <iostream>
#include <cmath>
using namespace std;

int main(){
    long long a,b,c;
    cout << "Katetlarding:";
    cin >> a >> b;
    c = sqrt(pow(a,2)+pow(b,2));
    cout << "Gipotenuzasi: " << c << endl;
    cout << "Perimetri: " << a+b+c;
    return 0;
}