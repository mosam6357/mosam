aa = list(map(int,input().split()))
bb = list(map(int,input().split()))
cc = [i for i in range(min(aa),max(aa)+1)]
dd = [i for i in range(min(bb),max(bb)+1)]
ck=0
for i in cc:
    if i in dd:
        ck=1
        break
if(ck==0):
    print(max(aa)-min(aa)+max(bb)-min(bb))
else:
    cc = aa+bb
    print(max(cc)-min(cc))