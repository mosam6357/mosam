a=int(input())
for i in range(a):
    b=int(input())
    print(f"Case #{i+1}:",end=" ")
    if(b<=25):
        print("World Finals")
    elif(b<=1000):
        print("Round 3")
    elif(b<=4500):
        print("Round 2")
    else:
        print("Round 1")