// Muallif: Bekzhanov Rasul
// Sana: 15.05.2023

#include <iostream>
#include <cmath>
using namespace std;

int main(){
    long long x1,y1,x2,y2,x3,y3,a,b,c,s,p;
    cout << "X1=";cin >> x1;
    cout << "Y1=";cin >> y1;
    cout << "X2=";cin >> x2;
    cout << "Y2=";cin >> y2;
    cout << "X3=";cin >> x3;
    cout << "Y3=";cin >> y3;
    a = sqrt(pow((x2-x1),2)+pow((y2-y1),2));
    b = sqrt(pow((x3-x2),2)+pow((y3-y2),2));
    c = sqrt(pow((x3-x1),2)+pow((y3-y1),2));
    p = (a+b+c)/2;
    s = sqrt(p*(p-a)*(p-b)*(p-c));
    cout << "Uchburchak yuzasi: " << s << endl;
    cout << "Uchburchak perimetri: " << p << endl;
    return 0;
}