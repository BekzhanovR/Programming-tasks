number = int(input())
if number > 0:
    print("musbat juft son" if number % 2 == 0 else "musbat toq son")
elif number < 0:
    print("manfiy juft son" if number % 2 == 0 else "manfiy toq son")
else:
    print("nol raqam")