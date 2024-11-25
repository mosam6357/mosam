a=int(input())
while(a**0.5!=int(a**0.5)):
    a-=1
print(f"The largest square has side length {int(a**0.5)}.")