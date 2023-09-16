n = int(input())
digit1 = n // 1000
digit2 = (n // 100)%10
digit3 = (n // 10)%10
digit4 = n%10
print(digit1 == digit4 and digit3 == digit2)