a = int(input())
aa = []
bb = []
for i in range(a):
    aa.append(int(input()))
aa.sort()
for i in range(a): #두 집 선정(브루트포스)
    for j in range(i+1,a):
        s=0
        for k in range(a):
            p1 = (aa[k]-aa[i])**2
            p2 = (aa[k]-aa[j])**2
            if p1<p2:
                s+=p1
            else:
                s+=p2
        bb.append(s)
print(min(bb))