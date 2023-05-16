// Muallif: Bekzhanov Rasul
// Sana: 15.05.2023

#include <iostream>
#include <cmath>
using namespace std;

int main(){
    long long x1,x2,y1,y2;
    cout << "X1=";
    cin >> x1; 
    cout << "Y1=";
    cin >> y1; 
    cout << "X2=";
    cin >> x2; 
    cout << "Y2=";
    cin >> y2; 
    cout << "Orasidagi oraliq: " << sqrt(pow((x2-x1),2)+pow((y2-y1),2));
    return 0;
}