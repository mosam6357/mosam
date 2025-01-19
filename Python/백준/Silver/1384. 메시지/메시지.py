n=1
while(True):
    a = int(input())
    if (a==0):
        break
    list1 = [] #이름 배열
    list2 = [[] for i in range(a)] #NP 2차원 배열
    cnt = 0
    for i in range(a):
        list2[i] = input().split()
        list1.append(list2[i].pop(0))
    print(f"Group {n}")
    for i in range(a):
        for j in range(list2[i].count('N')):
            ind = i-(list2[i].index('N')+1)
            list2[i][list2[i].index('N')] = 'P'
            if ind<0:
                ind+=a
            print(f"{list1[ind]} was nasty about {list1[i]}")
            cnt+=1
    if(cnt == 0):
        print("Nobody was nasty")
    print("")
    n+=1