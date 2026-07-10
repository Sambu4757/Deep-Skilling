# CustomerCommDemo — Moq + NUnit Hands-On

Unit testing exercise: mocking the `IMailSender` dependency so `CustomerComm`
can be tested without hitting a real SMTP server.

## Structure

```
CustomerCommDemo/
├── CustomerCommDemo.sln
├── CustomerCommLib/                 # Class Library (net8.0)
│   ├── IMailSender.cs               # SendMail contract
│   ├── MailSender.cs                # Real SMTP implementation
│   ├── CustomerComm.cs              # Consumer, takes IMailSender via constructor DI
│   └── CustomerCommLib.csproj
└── CustomerComm.Tests/               # NUnit test project (net8.0)
    ├── CustomerCommTests.cs          # Mocks IMailSender with Moq
    └── CustomerComm.Tests.csproj
```

## How it works

- `CustomerComm` depends on `IMailSender`, not on the concrete `MailSender`
  class, so a fake/mock implementation can be substituted at test time.
- In `CustomerCommTests`, `Moq` creates a `Mock<IMailSender>` whose
  `SendMail(string, string)` is set up to accept **any** two strings
  (`It.IsAny<string>()`) and always return `true` — no real network call.
- `Assert.That(result, Is.True)` verifies `SendMailToCustomer()` returns
  `true` when backed by the mock.

## Run it

```bash
cd CustomerCommDemo
dotnet restore
dotnet test
```

Expected output:

```
Test Name   : SendMailToCustomer_ReturnsTrue
Tests Run   : 1
Passed      : 1
Failed      : 0
Skipped     : 0
```

## Requirements

- .NET 8 SDK
- NuGet packages (restored automatically): `NUnit`, `NUnit3TestAdapter`,
  `Microsoft.NET.Test.Sdk`, `Moq`
