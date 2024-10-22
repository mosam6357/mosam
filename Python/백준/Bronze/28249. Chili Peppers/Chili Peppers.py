a=int(input())
aa = {'Poblano':1500,'Mirasol':6000,'Serrano':15500,'Cayenne':40000,'Thai':75000,'Habanero':125000}
cost = 0
for i in range(a):
    b=input()
    cost+=aa[b]
print(cost)