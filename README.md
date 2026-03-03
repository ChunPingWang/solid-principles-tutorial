# SOLID Principles Tutorial

SOLID 是物件導向設計中五個重要的設計原則，幫助開發者寫出更好維護、更有彈性的程式碼。

本教學提供 **Java** 與 **.NET Core (C#)** 兩種語言的範例，每個原則都包含：
- **Bad Example（違反原則）**：展示不良設計
- **Good Example（遵循原則）**：展示正確設計

## 五大原則

| 原則 | 全名 | 核心概念 |
|------|------|----------|
| **S** | Single Responsibility Principle | 每個類別只負責一件事 |
| **O** | Open/Closed Principle | 對擴展開放，對修改封閉 |
| **L** | Liskov Substitution Principle | 子類別可以替換父類別 |
| **I** | Interface Segregation Principle | 介面應該小而專一 |
| **D** | Dependency Inversion Principle | 依賴抽象，不依賴具體實作 |

## 專案結構

```
├── java/
│   ├── 1-srp/          # Single Responsibility Principle
│   ├── 2-ocp/          # Open/Closed Principle
│   ├── 3-lsp/          # Liskov Substitution Principle
│   ├── 4-isp/          # Interface Segregation Principle
│   └── 5-dip/          # Dependency Inversion Principle
│
├── dotnet/
│   ├── 1-srp/          # Single Responsibility Principle
│   ├── 2-ocp/          # Open/Closed Principle
│   ├── 3-lsp/          # Liskov Substitution Principle
│   ├── 4-isp/          # Interface Segregation Principle
│   └── 5-dip/          # Dependency Inversion Principle
```

## 如何使用

### Java
```bash
cd java/1-srp
javac bad/*.java
java bad.Main

javac good/*.java
java good.Main
```

### .NET Core (C#)
```bash
cd dotnet/1-srp
dotnet run --project Bad
dotnet run --project Good
```

## 學習建議

1. 先閱讀每個原則的 Bad Example，理解為什麼這樣設計會有問題
2. 再閱讀 Good Example，了解如何改善
3. 嘗試自己修改或擴展範例程式碼
