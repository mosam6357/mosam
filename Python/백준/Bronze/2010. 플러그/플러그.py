import sys

a=int(sys.stdin.readline())
total=0
for i in range(a):
    total+=int(sys.stdin.readline())
sys.stdout.write(str(total-a+1))