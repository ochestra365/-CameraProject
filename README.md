# CameraProject
<br><br>
RFID Reading 이후 WebRtc와 Node.js를 활용해서 서버 구축을 하라고 하신다. 그 이후 회사에 CCTV를 스트리밍해보라고 하신다.
HTML기본부터 빠르게 훑고 서버를 구축해보도록 하겠다.
<br><br>
<img src="https://github.com/ochestra365/-CameraProject/blob/bugFix/Resource/%EC%A0%95%EB%B3%B4%EC%B2%98%EB%A6%AC%EA%B8%B0%EC%82%AC.jpg" width="100%" height="100%" ><br><br>
<br>
~~~
이제 전기기사도 딸거다. 나는 펌웨어 쪽으로도 관심이 있기 때문이다.
내 주전공인 재무, 회계와 프로그래밍, 그리고 여기서 펌웨어 기술과 웹기술들을 배우면서 실력을 쌓아 나갈 거고 LG 쪽의 업무 프로세스도 익힐 거다.

나는 여기 와서 실력을 기르고 자격증도 차곡차곡 쌓고 있다. 어학성적도 딸거다. 나는 그동안 금융공기업에도 서류통과했을 뿐더러, 국방 관련 공기업 최종 면접,대기업 최종면접 까지도 갔다. 또한 수원 쪽, 서울 쪽에서도 Offer가 들어왔다. 그것도 내가 가능성이 있다며 돈주면서 프로그래밍 가르쳐주겠다고 말이다.


다만 내가 프로그래밍을 하는 건 내 꿈을 구현하기 위해서이고, 내가 봤을 때 모순적인 사람들에게 벌주기 위해서이다.

내가 모순적이라고 느끼는 사람들은 자기 잘못을 만들어 놓고, 피해자인척, 착한 척, 자기들은 선량한 척하는 사람들이며, 조금의 경험가지고 오만하게 구는 사람들이다.

조만간이다. 내가 꼭 실력을 키워서 앞에 나타날테니까 기대하고 있어라. 그동안 내가 당한 거 너희가 잘못한 거 꼭 벌 받게 해줄테니까.
너희에게는 다른 누군가가 아닌 내가 심판자가 되어주겠다.
~~~
<br>

<br>상위 프로그래머로 가는 길은 수학의 문제풀이 과정과 같다.<br> 확률과 통계,로그, 편미분, 적분, 삼각함수라는 도구를 통해 수학 문제를 풀듯이 해결해야 하는 것이다.
<br>(그리고 실제로도 저 분야를 해 나가면 코딩을 해야 하는 양이 줄어들 뿐더러 어떠한 산업현장에서 프로그래밍을 하더라도 쉽게 다가갈 수 있다.)<br>
중요한 것은 수식이 아니라 알고 있는 정보를 총 동원해서 현실 세계의 객체를 프로세스화 하는 것이다.<br>
상위 정보를 알기 위해서는 유수한 해외 학자들의 논문을 읽어야 하기에 영어를 공부하는 것이다.<br>
구현은 이전 프로그래머들이 잘 해놓았으니 나는 그것들을 잘 활용할 줄 아는 이치를 깨닳아야 한다.<br>
퇴근하고 나서 수능수학 이과 파트를 필히 단계별로 공부해야 프로그래밍할 수 있다. 그 이전에는 단순한 노무 작업을 하게 된다.<br>
몸값이 높아지고 대우를 잘 받으려면 내가 소스를 직접 짜고 라이브러리까지 구현해야 하는 것이다.<br>이
<img src="https://github.com/ochestra365/-CameraProject/blob/bugFix/Resource/%E3%84%B1%E3%84%B1.png" width="100%" height="100%" ><br><br>
모듈식 장치<br><br>
<br><br>
LG사무실로 들어가기 전 사장님께서 테스트용으로 과제물을 내주셨다. 해당 카메라를 던져주고 나에게 가동시켜 보라고 하셨다. 그리고 추가 기능을 덧붙일 건데, 이건 이강산 과장님의 지시를 받으라고 하셨다.<br><br>
LQC상에서 화성의 통신기기들과 각종 검사기기들을 다루기 때문에 이강산과장님이 멀티쓰레드를 잘 사용하는 것이 기본이라고 하셨다.<br><br>
<img src="https://github.com/ochestra365/-CameraProject/blob/bugFix/Resource/%EC%A0%84%EB%9E%B52.jpg"><br><br>
화면이 잘 구동된다.<br><br>


--------------

## 목차 <br>
1. 진행상황
2. 개념
3. WebRTC에 대하여
------------------



## 1. 진행상황
----------------
경로파일의 파일명을 바꾸려고 노력중이다.<br><br>
<br><br>파일이 생성되기 전의 모습이다.<br><br>
<br><br>파일이 저장되었다.<br><br>
<br><br>잘 저장된 것을 확인할 수 있다.<br><br>
<br><br>
지금은 RFID를 Setting과 Get과 병행중이다.<br><br>
## 2. 학습사항 정리
----------------

## 3. 웹 RTC에 대하여
---------------<br><br>
WebRTC란 브로커 서버없이 P2P통신이 가능하게 하는 것이다. Room을 Create하면 송출자와 구독자가 서로 통신을 직접 하는 것이다.<br>
자바스크립트와 NodeJS를 다뤄도 되는데 유튜브 영상중에 이런 좋은 게 있어서 첨부한다. 따라만 해도 구현이 가능하게 해두었다.<br>
[YoutubeEdu](src="https://www.youtube.com/watch?v=DvlyzDZDEq4")<br>
아직 기술력 습득이 낮으므로 구현이 힘들다. 많이 공부해야 한다. 예제를 많이 타이핑 쳐보는 것이 도움이 될 거 같다.

디버그 과정
-----------
-----------
메모리 문제를 해결해야 했다.<br><br>
<img src="https://github.com/ochestra365/-CameraProject/blob/bugFix/Resource/%EC%A0%84%EB%9E%B53.jpg"  ><br>
비트맵을 누적시키다 보니 메모리 누수가 발생했다. 가비지 콜렉터로 일단 처리함.<br><br>
스레드를 써서 front의 누적 데이터를 지우는 것이 고급 기술임.<br><br>


메모리 누수가 발생한 것을 확인가능했다.<br>

프로세스 메모리가 가득 찼으니 매개변수가 전달될 메인 스레드의 작동이 중단되었다.<br><br>
구글링으로 정보를 찾았다. 비지 콜렉터를 해당 스레드가 돌아가는 라인상에 삽입하니 해결되었다.





