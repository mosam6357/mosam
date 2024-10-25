aa=[]
for i in range(5):
    aa.append(int(input()))
day1=0
day2=0
if(aa[4]>30):
    day1+=aa[1]*(aa[4]-30)
if(aa[4]>45):
    day2+=aa[3]*(aa[4]-45)
print(aa[0]+day1*21,aa[2]+day2*21)