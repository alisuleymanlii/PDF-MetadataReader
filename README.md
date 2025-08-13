# 📄 PDF Metadata Reader

A simple **C# console application** that reads metadata from PDF files and keeps a history of accessed PDFs. This project uses the [UglyToad.PdfPig](https://github.com/UglyToad/PdfPig) library to extract information. 🐛📚

## 👤 Author

**Ali Suleymanli**

## ✨ Features

- 📝 Read PDF metadata including:
  - 🏷️ Title
  - 👤 Author
  - 🛠️ Creator
  - 🏭 Producer
  - 📅 Creation Date
  - ✏️ Modified Date
  - 📄 Page Count
- 💾 Save metadata to a history file (`historydata.txt`)
- 📜 View history of previously accessed PDFs
- 🖥️ Simple console-based interface

## 🛠️ Requirements

- .NET Core or .NET Framework
- [UglyToad.PdfPig](https://www.nuget.org/packages/UglyToad.PdfPig/) NuGet package

## ⚡ Installation

1. Clone the repository:
git clone https://github.com/alisuleymanlii/PDF-MetadataReader.git
````

2. Install dependencies:

```
dotnet add package UglyToad.PdfPig
```

3. Build and run the project:

```
dotnet run
```

## 🚀 Usage

1. Run the application.
2. Enter the path of a PDF file to read its metadata. 📂
3. Enter `1` to view the history of previously accessed PDF files. 🕒

## 🤝 Contributing

Feel free to submit issues or pull requests if you want to add new features or improve the project. 💡

## 📄 License

This project is licensed under the MIT License. 🏷️

```
