a=input()
count1=0
count2=0
for i in range(len(a)):
    if a[i]=='A':
        count1+=1
    else:
        count2+=1
print(f"{count1} : {count2}")