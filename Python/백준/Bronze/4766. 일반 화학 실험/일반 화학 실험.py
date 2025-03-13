c = -999
while(True):
    n = float(input())
    if n==999:
        break
    if c!=-999:
        print(f"{n-c:.2f}")
    c=n