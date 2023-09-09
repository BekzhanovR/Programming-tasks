A = int(input())
B = int(input())
C = int(input())
print(f"{((A>0) and (B<=0) and (C<=0)) or ((A<=0) and (B>0) and (C<=0)) or((A<=0) and (B<=0) and (C>0))}".lower())