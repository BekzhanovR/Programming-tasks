a = int(input())
b = int(input())
c = int(input())
print((a == c and a != b) or (a == b and a != c) or (b == c and b != a))