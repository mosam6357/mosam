a,b = map(int,input().split())
aa=[]
cnt=0
for i in range(2*a+1):
    s = input()
    if(i<a):
        aa.append(s)
    elif(i==a):
        pass
    else:
        for j in range(len(s)):
            if(s[j]==aa[i-a-1][j]):
                cnt+=1
print(cnt)