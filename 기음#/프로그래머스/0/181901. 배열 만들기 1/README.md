# [level 0] 배열 만들기 1 - 181901 

[문제 링크](https://school.programmers.co.kr/learn/courses/30/lessons/181901?language=csharp) 

### 성능 요약

메모리: 31.3 MB, 시간: 2.97 ms

### 구분

코딩테스트 연습 > 코딩 기초 트레이닝

### 채점결과

정확성: 100.0<br/>합계: 100.0 / 100.0

### 제출 일자

2025년 02월 28일 11:46:03

### 문제 설명

<p>정수 <code>n</code>과 <code>k</code>가 주어졌을 때, 1 이상 <code>n</code>이하의 정수 중에서 <code>k</code>의 배수를 오름차순으로 저장한 배열을 return 하는 solution 함수를 완성해 주세요.</p>

<hr>

<h5>제한사항</h5>

<ul>
<li><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">1 ≤ </font></font><code>n</code><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">≤ 1,000,000</font></font></li>
<li><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">1 ≤ </font></font><code>k</code><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">≤ 최소(1,000, n)</font></font></li>
</ul>

<hr>

<h5>입출력 예</h5>
<table class="table">
        <thead><tr>
<th><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">N</font></font></th>
<th><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">케이</font></font></th>
<th><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">결과</font></font></th>
</tr>
</thead>
        <tbody><tr>
<td><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">10</font></font></td>
<td><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">3</font></font></td>
<td><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">[3, 6, 9]</font></font></td>
</tr>
<tr>
<td><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">15</font></font></td>
<td><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">5</font></font></td>
<td><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">[5, 10, 15]</font></font></td>
</tr>
</tbody>
      </table>
<hr>

<h5>입출력 예 설명</h5>

<p>입출력 예 #1</p>

<ul>
<li>1 이상 10 이하의 3의 배수는 3, 6, 9 이므로 [3, 6, 9]를 return 합니다.</li>
</ul>

<p>입출력 예 #2</p>

<ul>
<li>1 이상 15 이하의 5의 배수는 5, 10, 15 이므로 [5, 10, 15]를 return 합니다.</li>
</ul>


> 출처: 프로그래머스 코딩 테스트 연습, https://school.programmers.co.kr/learn/challenges