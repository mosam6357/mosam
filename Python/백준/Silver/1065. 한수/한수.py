a = int(input())
cnt = 0
for i in range(1,a+1):
    s = str(i)
    if len(s)<=2:
        cnt+=1
    else:
        aa = set()
        for j in range(len(s)-1):
            aa.add(int(s[j+1])-int(s[j]))
        if len(aa)==1:
            cnt+=1
print(cnt)