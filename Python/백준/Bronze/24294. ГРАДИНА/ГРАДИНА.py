aa=[]; tile = 4
for i in range(4):
    aa.append(int(input()))
if(aa[0]>aa[2]):
    tile+=aa[0]*2
else:
    tile+=aa[2]*2
tile+=(aa[1]+aa[3])*2
print(tile)