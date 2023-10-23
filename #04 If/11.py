a = int(input())
b = int(input())
if a == b:
    a,b = 0,0
else:
    if a > b:
        b = a
    else:
        a = b
print(a)
print(b)