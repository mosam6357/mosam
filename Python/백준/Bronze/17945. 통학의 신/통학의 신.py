b,c = map(int,input().split())
aa = [int(-b+(b*b-c)**0.5),int(-b-(b*b-c)**0.5)]
if min(aa)==max(aa):
    print(min(aa))
else:
    print(min(aa),max(aa))