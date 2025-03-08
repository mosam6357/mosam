aa = list(map(int,input().split()))
bb = list(map(int,input().split()))
mm = min([max(aa),max(bb)])
print(sum(aa)+sum(bb)-mm*2)