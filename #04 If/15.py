a = int(input())
b = int(input())
c = int(input())
if a > c and b > c:
    print(a+b)
elif a > b and c > b:
    print(a+c)
else:
     print(b+c)