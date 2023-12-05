a = int(input())
b = int(input())
if a != b:
    if a < b:
        a,b = b,b
    a,b = a,a
else:
    a,b = 0,0
print(a)
print(b)