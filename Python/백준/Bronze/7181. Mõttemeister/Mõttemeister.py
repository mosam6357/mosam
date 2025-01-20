n = input()
a = int(input())
for i in range(a):
    b = input()
    cnt1 = 0
    cnt2 = 0
    for j in range(4):
        if b[j] in n:
            cnt1+=1
            if b[j]==n[j]:
                cnt2+=1
    print(cnt1,cnt2)