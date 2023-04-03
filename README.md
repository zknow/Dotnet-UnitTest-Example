# Dotnet建立UnitTest流程範例

## Step1

建立sln檔案文件，之後連結專案與測試專案用

```sh
dotnet new sln -o "Dotnet-UnitTest-Example"
```

## Step2

建立Service/lib專案

```sh
dotnet new classlib -o "PrimeService"
```

## Step3

建立unit test專案

```sh
dotnet new xunit -o "PrimeService.Tests"
```

## Step4

將專案連結至測試專案中可讓測試專案引用

```sh
dotnet add ./PrimeService.Tests/PrimeService.Tests.csproj reference ./PrimeService/PrimeService.csproj
```

## Step5

將專案與測試專案加入sln中，方便可以在root目錄下測試指令與編譯

```sh
dotnet sln add ./PrimeService/PrimeService.csproj
dotnet sln add ./PrimeService.Tests/PrimeService.Tests.csproj
```

## Step6

利用以下Attribute，建立單元實作程式範例

```sh
[Fact] 屬性標記表示這是一個單元測試方法

[Theory]：用於定義一個理論（Theory）測試方法，理論測試方法帶有參數，用於測試相同的操作或功能的多個情況。

[InlineData]：與 [Theory] 搭配使用，用於傳遞理論測試方法的參數值。

[SetUp]：用於在每個測試方法之前執行設置操作。

[TearDown]：用於在每個測試方法之後執行拆卸操作。

[Ignore]：用於忽略某個測試方法，不會執行該方法。

[Trait]：用於將屬性與測試方法關聯起來，例如將屬性標記為某個測試方法的分類標籤。
```

## Step7

執行單元測試指令

```sh
dotnet test
```
