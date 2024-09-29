aa=[0 for i in range(26)]
a=int(input())
for i in range(a):
    b=input()
    c=ord(b[0])-97
    aa[c]+=1
if(max(aa)<5):
    print("PREDAJA")
else:
    for i in range(26):
        if(aa[i]>=5):
            print(chr(i+97),end="")