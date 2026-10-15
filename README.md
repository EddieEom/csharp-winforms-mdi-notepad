<div align="center">

# MDI Notepad

**여러 문서를 하나의 창에서 관리하는 WinForms 메모장**

</div>

<p align="center"><img alt="C#" src="https://img.shields.io/badge/C%23-512BD4?style=flat-square"/> <img alt="WinForms" src="https://img.shields.io/badge/WinForms-512BD4?style=flat-square"/> <img alt=".NET Framework 4.7.2" src="https://img.shields.io/badge/.NET%20Framework%204.7.2-5C2D91?style=flat-square"/></p>


| 형태 | 구현 목표 | 다룬 내용 |
| :--- | :--- | :--- |
| **수업 과제** | 제시된 화면·기능 구현 | 다중 문서 · 파일 입출력 · 이벤트 |

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

