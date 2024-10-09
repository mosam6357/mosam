a=int(input()); aa=[]; cnt=0
for i in range(a):
    b,c = map(int,input().split())
    for j in range(10):
        for k in range(10):
            if([b+j,c+k]) not in aa:
                cnt+=1
                aa.append([b+j,c+k])
print(cnt)