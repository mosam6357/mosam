a = int(input())
s1 = input()
s2 = input()
vic1 = ['PR','RS','SP']
draw = ['PP','RR','SS']
cnt1 = 0
cnt2 = 0
for i in range(a):
    s = s1[i]+s2[i]
    if s in vic1:
        cnt1+=1
    elif s not in draw:
        cnt2+=1
if cnt1>cnt2:
    print('victory')
else:
    print('defeat')