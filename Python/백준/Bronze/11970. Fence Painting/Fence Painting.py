aa = list(map(int,input().split()))
bb = list(map(int,input().split()))
if(bb[1]<=aa[0] or aa[1]<=bb[0]):
    print(max(aa)+max(bb)-(min(aa)+min(bb)))
else:
    cc=aa+bb
    print(max(cc)-min(cc))