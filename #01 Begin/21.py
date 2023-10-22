from math import *
x1 = int(input())
y1 = int(input())
x2 = int(input())
y2 = int(input())
x3 = int(input())
y3 = int(input())
a = sqrt(pow(x2-x1,2)+pow(y2-y1,2))
b = sqrt(pow(x3-x1,2)+pow(y3-y1,2))
c = sqrt(pow(x3-x2,2)+pow(y3-y2,2))
p = a+b+c
pp = p/2
s = (pp*(pp-a)*(pp-b)*(pp-c))**(1/2)
print(p)
print(s)
