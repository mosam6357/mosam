def solution(a, b, c, d):
    answer = 0
    arr = [a,b,c,d]
    if min(arr)==max(arr):
        return 1111*a
    elif min(arr)!=max(arr) and (arr.count(min(arr))==3 or arr.count(max(arr))==3):
        if arr.count(min(arr))==3:
            return (10*min(arr)+max(arr))**2
        else:
            return (10*max(arr)+min(arr))**2
    elif min(arr)!=max(arr) and arr.count(max(arr))==2 and arr.count(min(arr))==2:
        print('여기좋아')
        return (min(arr)+max(arr))*(max(arr)-min(arr))
    for i in arr:
        if arr.count(i)==2:
            arr.remove(i)
            arr.remove(i)
            return min(arr)*max(arr)
        if i==d:
            return min(arr)