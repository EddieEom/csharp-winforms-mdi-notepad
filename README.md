# WinForms MDI 메모장

WinForms의 기초를 공부하며 만든 수업 프로젝트입니다. 하나의 부모 창 안에서 여러 문서를 열고, 선택한 문서에 메뉴 기능을 적용하는 메모장을 만들었습니다.

## 이 프로젝트에서 공부한 것

폼과 컨트롤을 배치하고 이벤트를 연결하는 방법부터 시작했습니다. 이후 부모·자식 폼, 활성 문서 구분, 파일 열기·저장, 글꼴과 배경색 변경을 다뤘습니다.

여러 창을 띄우는 것뿐 아니라 메뉴의 동작이 어느 문서에 적용되는지를 생각해 볼 수 있었습니다. 파일 열기·저장에 사용한 텍스트는 [samples](samples)에 모았습니다.

## 실행 화면

<img src="https://raw.githubusercontent.com/EddieEom/EddieEom/main/assets/screenshots/mdi-notepad.jpg" alt="하나의 부모 창에서 여러 문서를 연 MDI 메모장" width="100%"/>

**다중 문서 편집** · 하나의 부모 창 안에서 여러 문서를 열고 편집합니다.

## 📝 기능 구성

<table><tr>
<td width="33%" valign="top"><b>문서 관리</b><br><br>MDI 부모·자식 폼<br>여러 문서 열기<br>창 배치</td>
<td width="33%" valign="top"><b>파일과 편집</b><br><br>열기 · 저장 · 다른 이름 저장<br>복사 · 붙여넣기 · 실행 취소<br>글꼴 · 배경색 변경</td>
<td width="33%" valign="top"><b>화면 처리</b><br><br>현재 문서에 메뉴 적용<br>상태바 · 시간 갱신<br>BeginInvoke로 UI 갱신</td>
</tr></table>

수업에서 제시한 요구사항을 바탕으로, 현재 활성화된 문서에 편집 명령이 적용되도록 구성했습니다. 인쇄 기능은 페이지 설정·인쇄·미리보기 대화상자 연결 범위입니다.

<details>
<summary><b>📚 연습한 내용</b></summary>

## 연습한 내용

- 버튼과 메뉴의 이벤트 처리
- 현재 활성화된 자식 폼 찾기
- 파일 경로와 문서 내용을 연결해 저장하기
- 파일·글꼴·색상 대화상자 사용
- 별도 스레드에서 처리한 내용을 `BeginInvoke`로 UI에 반영하기

</details>

<details>
<summary><b>⚙️ 설치 및 실행</b></summary>

## 실행 방법

Windows에서 Visual Studio와 .NET Framework 4.7.2 개발 환경을 준비합니다.

1. 저장소를 내려받습니다.
2. Visual Studio에서 `MDI_Test.slnx` 또는 `MDI_Test/MDI_Test.csproj`를 엽니다.
3. 빌드 후 실행합니다.

```bash
git clone https://github.com/EddieEom/csharp-winforms-mdi-notepad.git
```

</details>

