a = int(input())
b = int(input())
c = int(input())
if a > b > c or b > a > c:
    print(a+b)
elif a > c > b or c > a > b:
    print(a+c)
else:
    print(c+b)