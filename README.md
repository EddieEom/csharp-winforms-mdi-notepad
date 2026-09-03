# 📝 C# WinForms MDI Notepad

<div align="center">

### Multiple Document Interface 기반 데스크톱 메모장

**C# WinForms의 MDI(Multiple Document Interface) 구조를 활용하여
여러 텍스트 문서를 하나의 프로그램에서 생성하고 관리할 수 있도록 구현한 데스크톱 애플리케이션입니다.**

<br>

![CSharp](https://img.shields.io/badge/C%23-512BD4?style=for-the-badge\&logo=dotnet\&logoColor=white)
![.NET](https://img.shields.io/badge/.NET%20Framework%204.7.2-512BD4?style=for-the-badge\&logo=dotnet\&logoColor=white)
![WinForms](https://img.shields.io/badge/Windows%20Forms-0078D4?style=for-the-badge\&logo=windows\&logoColor=white)

</div>

<br>

---

# 📌 Project Overview

Windows 기본 메모장의 주요 기능을 참고하여
**C# WinForms와 MDI 구조를 학습하기 위해 제작한 데스크톱 메모장 프로그램**입니다.

단일 문서만 사용하는 구조가 아니라 하나의 Parent Form 내부에서
여러 Child Form을 생성하여 각각 독립적인 문서를 편집할 수 있도록 구현했습니다.

```text
MainForm
│
├── Document 1
├── Document 2
├── Document 3
└── ...
```

각 문서는 자신의

* Text Editor
* File Path
* Window Title

을 별도로 관리하며, 메뉴와 ToolStrip 기능은 현재 활성화된 문서를 기준으로 동작합니다.

<br>

---

# ✨ Main Features

## 📄 Multiple Document Interface

WinForms의 MDI 기능을 사용하여
하나의 Main Window 내부에서 여러 문서를 동시에 관리할 수 있도록 구현했습니다.

```text
MDI Parent
   │
   ├── Child Form
   │     └── TextBox
   │
   ├── Child Form
   │     └── TextBox
   │
   └── Child Form
         └── TextBox
```

새 문서를 생성할 때마다 새로운 Child Form을 만들고
`MdiParent`를 MainForm으로 지정합니다.

각 문서는

```text
문서 1
문서 2
문서 3
...
```

형태의 기본 이름을 가지며, 파일을 불러오거나 저장하면 실제 파일명으로 제목이 변경됩니다.

<br>

---

# 📂 File Management

`System.IO`와 WinForms File Dialog를 이용하여
기본적인 Text File 관리 기능을 구현했습니다.

### 지원 기능

* 새 문서 생성
* 기존 Text File 열기
* 파일 저장
* 다른 이름으로 저장
* 현재 문서 닫기
* 모든 문서 닫기
* 프로그램 종료

<br>

## Open File

```text
OpenFileDialog
      ↓
Select File
      ↓
File.ReadAllText()
      ↓
New Child Form
      ↓
TextBox
```

파일을 열면 새로운 Child Form을 생성한 뒤
선택된 Text File의 내용을 읽어 Editor에 표시합니다.

<br>

## Save

각 Child Form은 현재 파일 경로를 별도로 관리합니다.

```text
Form2
│
├── FilePath
└── Editor
```

이미 저장된 파일이라면 기존 경로에 바로 저장하고,

```text
FilePath 존재
      ↓
File.WriteAllText()
```

처음 저장하는 문서라면 자동으로 **Save As** 흐름으로 이동합니다.

```text
FilePath 없음
      ↓
SaveFileDialog
      ↓
File 저장
      ↓
FilePath 갱신
      ↓
Window Title 변경
```

<br>

---

# ✏️ Text Editing

현재 활성화된 MDI Child의 Editor를 가져온 뒤
해당 문서에 편집 명령을 적용합니다.

### 지원 기능

* Undo
* Cut
* Copy
* Paste
* Clear

```text
Menu / Toolbar
       ↓
GetActiveForm()
       ↓
GetActiveTextBox()
       ↓
Current Document
       ↓
Edit Operation
```

각 메뉴마다 별도의 Editor를 관리하지 않고
현재 활성화된 문서를 조회하는 공통 로직을 사용했습니다.

<br>

---

# 🎨 Formatting

WinForms의 기본 Dialog Component를 활용하여
현재 문서의 표시 형식을 변경할 수 있습니다.

### Font

`FontDialog`를 통해 글꼴을 변경합니다.

```text
Current Editor
      ↓
FontDialog
      ↓
Selected Font
      ↓
TextBox.Font
```

### Background Color

`ColorDialog`를 이용하여
현재 Editor의 배경색을 변경합니다.

```text
Current Editor
      ↓
ColorDialog
      ↓
Selected Color
      ↓
TextBox.BackColor
```

<br>

---

# 🪟 Window Management

여러 MDI Child Window를 관리하기 위한
WinForms의 `LayoutMdi()` 기능을 사용했습니다.

### 지원 Layout

#### Cascade

```text
┌────────────┐
│ Document 1 │
│  ┌────────────┐
│  │ Document 2 │
│  │  ┌────────────┐
│  │  │ Document 3 │
```

#### Tile Horizontal

여러 문서를 수평 방향으로 배치합니다.

#### Arrange Icons

최소화된 MDI Child Window의 아이콘을 정렬합니다.

<br>

---

# 🖨️ Print UI

WinForms의 Printing 관련 Component를 활용하여
기본적인 인쇄 UI 흐름을 구성했습니다.

### 사용 Component

```text
PrintDocument

PageSetupDialog
PrintDialog
PrintPreviewDialog
```

지원 기능:

* 페이지 설정
* Print Dialog 호출
* Print Preview 호출

현재 구현은 WinForms의 `PrintDocument`와 각 Dialog를 연결하는 단계까지 구성되어 있습니다.

<br>

---

# ⏱️ Background Thread

Main Window 하단 Status 영역에
현재 날짜와 시간을 실시간으로 표시하기 위해 별도의 Background Thread를 사용했습니다.

```text
MainForm Load
      ↓
Background Thread
      ↓
UpdateTimeLoop()
      ↓
Every 1 Second
      ↓
BeginInvoke()
      ↓
UI Thread
      ↓
StatusStrip Update
```

Thread 내부에서 직접 UI를 수정하지 않고

```csharp
BeginInvoke(...)
```

를 이용해 UI Thread에서 Control을 갱신하도록 구현했습니다.

이를 통해 WinForms의 **Cross-Thread UI Access 문제**를 방지했습니다.

<br>

---

# 📊 Status Bar

프로그램의 현재 동작 상태를 StatusStrip으로 표시합니다.

예:

```text
프로그램 시작

문서 1 생성

파일 열기 : sample.txt

저장 완료 : sample.txt

복사

붙여넣기

글꼴 변경

계단식 정렬
```

파일 처리나 편집 작업이 수행될 때마다
`SetStatus()`를 통해 사용자에게 현재 상태를 전달합니다.

<br>

---

# 🧰 Tech Stack

## Language

![CSharp](https://img.shields.io/badge/C%23-512BD4?style=for-the-badge\&logo=dotnet\&logoColor=white)

<br>

## Framework

![.NET](https://img.shields.io/badge/.NET%20Framework%204.7.2-512BD4?style=for-the-badge\&logo=dotnet\&logoColor=white)

`Windows Forms`

<br>

## Core APIs

```text
System.IO

System.Threading

System.Windows.Forms

System.Drawing

System.Drawing.Printing
```

<br>

## Development Environment

![Visual Studio](https://img.shields.io/badge/Visual%20Studio-5C2D91?style=for-the-badge\&logo=visualstudio\&logoColor=white)

<br>

---

# 🏗️ Application Structure

```text
Program
   │
   ▼
MainForm
   │
   ├── MenuStrip
   │
   ├── ToolStrip
   │
   ├── StatusStrip
   │
   │
   └── MDI Container
          │
          ├── Form2
          │    ├── TextBox Editor
          │    └── FilePath
          │
          ├── Form2
          │    ├── TextBox Editor
          │    └── FilePath
          │
          └── ...
```

`MainForm`은 프로그램 전체의 메뉴와 MDI Window 관리를 담당하고,

`Form2`는 각각의 문서를 표현하는 Child Window 역할을 담당합니다.

<br>

---

# 📂 Project Structure

```text
csharp-winforms-mdi-notepad/
│
├── MDI_Test.slnx
│
└── MDI_Test/
    │
    ├── Program.cs
    │
    ├── MainForm.cs
    ├── MainForm.Designer.cs
    ├── MainForm.resx
    │
    ├── Form2.cs
    ├── Form2.Designer.cs
    ├── Form2.resx
    │
    ├── App.config
    └── MDI_Test.csproj
```

### MainForm

```text
Application Menu
File Operations
Edit Operations
Formatting
MDI Window Management
Toolbar
Status Bar
Background Time Thread
```

### Form2

```text
Text Editor
File Path
Individual Document Window
```

<br>

---

# 🚀 Getting Started

## Requirements

```text
Windows
Visual Studio
.NET Framework 4.7.2
```

<br>

## 1. Clone Repository

```bash
git clone https://github.com/EddieEom/csharp-winforms-mdi-notepad.git
```

<br>

## 2. Open Project

Visual Studio에서

```text
MDI_Test.slnx
```

를 엽니다.

<br>

## 3. Build

Visual Studio에서

```text
Build → Build Solution
```

을 실행합니다.

<br>

## 4. Run

```text
F5
```

또는

```text
Start
```

를 통해 실행할 수 있습니다.

<br>

---

# 🎯 What I Learned

이 프로젝트를 통해 C# 문법뿐 아니라
**Windows Desktop Application의 이벤트 기반 프로그램 구조**를 직접 구현해보았습니다.

특히 다음 내용을 다뤘습니다.

* C# Event Handler
* WinForms Control
* MDI Parent / Child 구조
* 활성 Window 관리
* File I/O
* OpenFileDialog / SaveFileDialog
* MenuStrip / ToolStrip / StatusStrip
* FontDialog / ColorDialog
* PrintDocument / Print Dialog
* MDI Window Layout
* Background Thread
* `BeginInvoke()` 기반 UI Thread 처리
* Form 간 데이터 접근
* 공통 기능 메서드 분리

단순히 여러 버튼을 배치하는 데서 끝나지 않고,

```text
User Event
    ↓
Active Document Detection
    ↓
Application Logic
    ↓
File / UI Operation
    ↓
Status Update
```

와 같이 **사용자 이벤트와 현재 문서 상태를 연결하는 Desktop Application의 기본 흐름**을 학습하는 데 초점을 두었습니다.

<br>

---

# 👨‍💻 Developer

**엄인섭**

GitHub
https://github.com/EddieEom
