a = int(input())
x = a // 100
y = (a % 100) // 10
z = a % 10
print(x < y < z or x > y > z)