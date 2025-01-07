aa = list(map(int,input().split()))
bb = list(map(int,input().split()))
s1 = 0
s2 = 0
for i in range(10):
    if aa[i]>bb[i]:
        s1+=1
    elif aa[i]==bb[i]:
        continue
    else:
        s2+=1
if s1==s2:
    print('D')
elif s1>s2:
    print('A')
else:
    print('B')