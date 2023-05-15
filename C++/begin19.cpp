// Muallif: Bekzhanov Rasul
// Sana: 15.05.2023

#include <iostream>
using namespace std;

int main(){
    long long x1,x2,y1,y2,p,s;
    cout << "X1=";
    cin >> x1;
    cout << "Y1=";
    cin >> y1;
    cout << "X2=";
    cin >> x2;
    cout << "Y2=";
    cin >> y2;
    p = 2*(abs(x1-x2)+abs(y1-y2));
    s = (abs(x1-x2)*abs(y1-y2));
    cout << "Perimetri: " << p << endl;
    cout << "Yuzasi: " << s;
    return 0;
}