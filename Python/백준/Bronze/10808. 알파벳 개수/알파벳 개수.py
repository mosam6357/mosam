aa=[0 for i in range(26)]
a=input()
for i in a:
    aa[ord(i)-97]+=1
print(*aa)