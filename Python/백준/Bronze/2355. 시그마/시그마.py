a,b = map(int,input().split())
if (b>a):
    print((b*(b+1))//2-((a*(a-1))//2))
else:
    print((a*(a+1))//2-((b*(b-1))//2))