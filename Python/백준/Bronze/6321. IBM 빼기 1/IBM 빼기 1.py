a=int(input())
for i in range(a):
    b=input()
    print(f"String #{i+1}")
    for j in range(len(b)):
        c=ord(b[j])
        if(c!=90):
            print(chr(c+1),end="")
        else:
            print("A",end="")
    if(i!=a-1):
        print("\n")
