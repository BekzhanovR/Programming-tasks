a = int(input())
b = int(input())
c = int(input())
if a > c and b > c:
    print(c)
elif a > b and c > b:
    print(b)
else:
    print(a)