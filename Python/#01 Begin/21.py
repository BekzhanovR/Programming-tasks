x1 = int(input())
y1 = int(input())
x2 = int(input())
y2 = int(input())
x3 = int(input())
y3 = int(input())
a = ((x2-x1)**2+(y2-y1)**2)**(1/2)
b = ((x3-x2)**2+(y3-y2)**2)**(1/2)
c = ((x3-x1)**2+(y3-y1)**2)**(1/2)
p = a+b+c
p2 = p/2
s = (p2*(p2-a)*(p2-b)*(p2-c))**(1/2)
print(int(p))
print(int(s))
