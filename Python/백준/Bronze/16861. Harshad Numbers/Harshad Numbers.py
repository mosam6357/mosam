a = int(input())
while(True):
    s = str(a)
    n = 0
    for i in s:
        n+=int(i)
    if a%n==0:
        break
    a+=1
print(a)