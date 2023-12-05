yil = int(input())
if yil % 4 == 0 and yil % 100 != 0 or yil % 400 == 0:
    print(366)
else:
    print(365)