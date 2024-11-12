aa = [0 for i in range(26)]
a = input()
for i in a:
    aa[ord(i)-65]+=1
for i in range(26):
    if aa[i]==0:
        print(chr(i+65))
        break