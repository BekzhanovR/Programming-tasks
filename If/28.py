year = int(input())
print(366 if year % 4 == 0 and (year % 100 != 0 or year % 400 == 0) else 365)