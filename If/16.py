a = int(input())
b = int(input())
c = int(input())
if a > b > c:
    a,b,c = 2*a, 2*b, 2*c
else:
    a,b,c = -1*a, -1*b, -1*c
print(a)
print(b)
print(c)