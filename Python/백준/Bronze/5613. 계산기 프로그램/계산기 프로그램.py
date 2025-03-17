n = int(input())
while(True):
    s = input()
    if s=="=":
        break
    elif s=="/":
        n = n//int(input())
    else:
        n = eval(str(n)+s+input())
print(n)