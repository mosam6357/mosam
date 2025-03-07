a = int(input())
while(True):
    n = int(input())
    if n==0:
        break
    if n%a==0:
        print(f"{n} is a multiple of {a}.")
    else:
        print(f"{n} is NOT a multiple of {a}.")