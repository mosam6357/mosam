aa = list(map(int,input().split()))
for i in range(3):
    if aa.count(aa[i])==1:
        print(chr(i+65))
        break
    if i==2:
        print('*')