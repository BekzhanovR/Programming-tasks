n = int(input())
digit1 = n // 100
digit2 = (n // 10) % 10
digit3 = n % 10
print(digit1 < digit2 < digit3 or digit1 > digit2 > digit3)