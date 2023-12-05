a = int(input())
b = int(input())
if a != b:
    a,b = a+b,a+b
else:
    a,b = 0,0
print(a)
print(b)