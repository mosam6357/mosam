t = int(input())
for i in range(t):
    s1 = input()
    s2 = input()
    cnt = 0
    for i in range(len(s1)):
        if (s1[i]!=s2[i]):
            cnt+=1
    print(f"Hamming distance is {cnt}.")