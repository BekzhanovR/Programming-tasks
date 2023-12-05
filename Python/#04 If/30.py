n = int(input())
if 1 <= n < 10:
    print("bir xonali juft son") if n % 2 == 0 else print("bir xonali toq son")
elif 10 <= n < 100:
    print("ikki xonali juft son") if n % 2 == 0 else print("ikki xonali toq son")
else:
    print("uch xonali toq son") if n % 2 == 1 else print("uch xonali juft son")