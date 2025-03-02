def solution(arr):
    answer = 0
    while(True):
        cnt = 0
        for i in range(len(arr)):
            if arr[i]%2==0 and arr[i]>=50:
                arr[i]//=2
            elif arr[i]%2==1 and arr[i]<50:
                arr[i]=arr[i]*2+1
            else:
                cnt+=1
        if (cnt==len(arr)):
            break
        answer+=1
    return answer