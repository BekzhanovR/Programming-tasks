a = int(input())
b = int(input())
c = int(input())
if abs(a-b) < abs(a-c):
    print(abs(a-b))
else:
    print(abs(a-c))