a = int(input())
for i in range(a):
    q,w,e,r,t,y = map(int,input().split())
    s = e+y+abs(q-r)+abs(w-t)
    print(s)