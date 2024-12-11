aa = input().split()
bb = input().split()
for i in range(5):
    if(aa[i]==bb[i]):
        print('N')
        break
    if i==4:
        print('Y')