a = int(input())
b = int(input())
c = int(input())
print(f"{((a < 0) and (b > 0) and (c > 0)) or ((a > 0) and (b > 0) and (c < 0)) or ((a > 0) and (b < 0) and (c > 0))}".lower())