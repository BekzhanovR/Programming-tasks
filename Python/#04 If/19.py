a = int(input())
b = int(input())
c = int(input())
d = int(input())
if a == b and b == c:
    print(4)
elif a == b and b == d:
    print(c)
elif a == c and c == d:
    print(2)
else:
    print(1)