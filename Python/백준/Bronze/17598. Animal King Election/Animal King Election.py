cnt1 = 0
cnt2 = 0
for i in range(9):
    if(input()=='Lion'):
        cnt1+=1
    else:
        cnt2+=1
if(cnt1>cnt2):
    print('Lion')
else:
    print('Tiger')