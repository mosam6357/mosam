t = int(input())
s = 0 #필요한 돈
for i in range(t):
    a,b,c = map(int,input().split()) #가진 재료 수, 필요 재료 수, 재료비(1개당)
    if(a>=b):
        continue
    else:
        s+=(b-a)*c
print(s)