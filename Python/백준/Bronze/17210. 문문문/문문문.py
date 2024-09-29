a=int(input())
if(a>=6):
    print("Love is open door")
else:
    b=int(input())
    for i in range(a-1):
        print(int(0.5+((-1)**(i%2-b)*0.5)))