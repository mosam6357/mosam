a=input()
count=0
for i in a:
    if i=='_':
        count+=1
print(len(a)+count*5+2)