a = int(input())
x = a // 1000
y = (a // 100) % 10
z = (a // 10) % 10
v = a % 10
print(y == x and z == v)