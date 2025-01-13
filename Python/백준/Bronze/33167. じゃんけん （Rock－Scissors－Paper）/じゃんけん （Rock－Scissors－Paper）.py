a = int(input())
s1 = input()
s2 = input()
cnt1 = 0
cnt2 = 0
for i in range(a):
    s = s1[i]+s2[i]
    if s=='RR' or s=='PP' or s=='SS':
        pass
    elif s=='PR' or s=='RS' or s=='SP':
        cnt1+=1
    else:
        cnt2+=1
print(cnt1,cnt2)