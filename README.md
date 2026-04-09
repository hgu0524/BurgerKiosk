# (C# 코딩) 버거 키오스크

## 개요

* C# 프로그래밍 학습

* 1줄 소개: 사용자가 버거 메뉴와 옵션을 선택하여 주문 내역과 총 금액을 확인하는 키오스크 프로그램

* 사용한 플랫폼:

* C#, .NET Windows Forms, Visual Studio, GitHub

* 사용한 컨트롤:

* Label, ListBox, Button, RadioButton, CheckBox, GroupBox

* 사용한 기술과 구현한 기능:

* Visual Studio를 이용하여 UI 디자인

* 조건문을 이용한 메뉴 선택 및 예외 처리 구현

* ListBox를 이용한 주문 내역 출력

* Label을 이용한 총 금액 및 에러 메시지 표시

* 숫자 포맷(ToString("N0"))을 이용하여 금액을 천 단위 콤마 형식으로 출력

---

## 실행 화면

* 코드의 실행 스크린샷과 구현 내용 설명

![실행화면]<img width="1329" height="862" alt="1차 과제 자료" src="https://github.com/user-attachments/assets/812f23f7-e419-491a-8021-c30de2eadf43" />



* 구현한 내용 (위 그림 참조)
* UI 구성 : 메뉴 선택(RadioButton), 옵션 선택(CheckBox), 주문 내역(ListBox), 총 금액(Label), 버튼(Button)
* 메뉴 선택 기능 : RadioButton을 이용하여 하나의 메뉴만 선택 가능
* 옵션 선택 기능 : CheckBox를 이용하여 여러 옵션을 동시에 선택 가능
* 주문하기 버튼 : 선택된 메뉴와 옵션을 기반으로 총 금액 계산 및 출력

## 실행 화면

* 코드의 실행 스크린샷과 구현 내용 설명

![실행화면]<img width="1330" height="855" alt="제목 없음" src="https://github.com/user-attachments/assets/d7eb5e83-0240-4823-830d-66e352552ecc" />


* 구현한 내용 (위 그림 참조)
* 에러 처리 : 메뉴를 선택하지 않았을 경우 Label을 통해 에러 메시지 출력
* Visible 속성을 이용하여 필요할 때만 메시지가 표시되도록 구현

## 실행 화면

코드의 실행 스크린샷과 구현 내용 설명

![실행화면]<img width="1331" height="858" alt="2차 과제 자료" src="https://github.com/user-attachments/assets/6d1077a5-5196-4cda-af7c-1557c3dccb43" />


* 구현한 내용 (위 그림 참조)
* 초기화 기능 : 초기화 버튼 클릭 시 모든 선택 상태 및 출력 내용 초기화
* 금액 표시 개선 : 총 금액과 메뉴 가격을 천 단위 콤마 형식으로 출력하여 가독성 향상

---

## 배운 내용

* Windows Forms를 이용하여 다양한 컨트롤을 배치하고 UI를 구성하는 방법을 익힐 수 있었다.
* RadioButton과 CheckBox의 차이점을 이해하고 상황에 맞게 사용하는 방법을 배웠다.
* 조건문을 활용하여 사용자 입력에 따른 기능을 구현하는 방법을 학습하였다.
* Label을 이용한 에러 메시지 처리 방식이 사용자 경험을 개선하는 데 효과적임을 알게 되었다.
* 숫자 포맷을 활용하여 사용자에게 더 보기 쉬운 형태로 데이터를 출력하는 방법을 익혔다.
