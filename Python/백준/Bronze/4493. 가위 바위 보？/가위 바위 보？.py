a = int(input())
for i in range(a):
    b = int(input())
    score = [0,0]
    for j in range(b):
        aa = input().split()
        if aa[0]==aa[1]:
            pass
        elif 'S' in aa and 'R' in aa:
            score[aa.index('R')]+=1
        elif 'R' in aa and 'P' in aa:
            score[aa.index('P')]+=1
        else:
            score[aa.index('S')]+=1
    if(score[0]==score[1]):
        print('TIE')
    elif(score[0]>score[1]):
        print('Player 1')
    else:
        print('Player 2')