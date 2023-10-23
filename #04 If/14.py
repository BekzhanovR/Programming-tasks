a = int(input())
b = int(input())
c = int(input())

if a < b and a < c:
    print(a)
    if b > c:
        print(b)
    else: 
        print(c)
elif b < a and b < c:
    print(b)
    if a > c:
        print(a)
    else:
        print(c)
else:
    print(c)
    if a > b:
        print(a)
    else:
        print(b)