from math import sqrt
x1 = int(input())
y1 = int(input())
x2 = int(input())
y2 = int(input())
x3 = int(input())
y3 = int(input())
a = sqrt(pow(x1-x2,2)+pow(y1-y2,2))
b = sqrt(pow(x2-x3,2)+pow(y2-y3,2))
c = sqrt(pow(x3-x1,2)+pow(y3-y1,2))
p = a+b+c
p_2 = p/2
s = sqrt(p_2*(p_2-a)*(p_2-b)*(p_2-c))
print(int(p))
print(int(s))