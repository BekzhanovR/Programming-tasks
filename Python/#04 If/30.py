number = int(input())
if 10 <= number < 100:
    print("ikki xonali juft son" if number % 2 == 0 else "ikki xonali toq son")
else:
    print("uch xonali toq son" if number % 2 == 1 else "uch xonali juft son")