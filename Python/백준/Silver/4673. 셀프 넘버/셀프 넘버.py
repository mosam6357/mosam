aa = [0 for i in range(10000)]
for i in range(10000):
    n = i+1
    s = str(i+1)
    for j in s:
        n+=int(j)
    if n<=10000:
        aa[n-1]=1
for i in range(10000):
    if aa[i]==0:
        print(i+1)