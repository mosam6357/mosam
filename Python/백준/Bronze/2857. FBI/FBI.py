aa = []
for i in range(5):
    s = input()
    if 'FBI' in s:
        aa.append(i+1)
if len(aa)==0:
    print('HE GOT AWAY!')
else:
    for i in aa:
        print(i,end =" ")