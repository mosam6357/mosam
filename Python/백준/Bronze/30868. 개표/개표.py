a=int(input())
for i in range(a):
    b=int(input())
    print("++++ "*(b//5),end="")
    print("|"*(b%5))