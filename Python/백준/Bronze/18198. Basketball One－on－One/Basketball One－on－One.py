a = input()
s1 = 0
s2 = 0
for i in range(len(a)//2):
   if(a[i*2]=='A'):
       s1+=int(a[i*2+1])
   else:
       s2+=int(a[i*2+1])
if(s1>s2):
    print('A')
else:
    print('B')