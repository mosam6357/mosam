def solution(n):
    answer = 0
    if (n%2==1):
        answer = ((n+1)//2)**2
    else:
        for i in range(2,n+1,2):
            answer+=i**2
    return answer