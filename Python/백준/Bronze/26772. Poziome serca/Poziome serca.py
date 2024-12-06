a = int(input())
aa = [" @@@   @@@ ","@   @ @   @","@    @    @","@         @"," @       @ ","  @     @  ","   @   @   ","    @ @    ","     @     "]
for i in range(9):
    for j in range(a):
        if(j==a-1):
            print(aa[i])
        else:
            print(aa[i],end=" ")