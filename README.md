# InvalidProgramException with dotCover

dotCover get an _InvalidProgramException_ when executing the test method.

Prerequisites

| Software | Version |
| -------- | ------- |
| JetBrains dotCover Console Runner | **2018.1.2.** |
| nunit3-console | 3.8.0 |

Steps to reproduce exception
1. Compile the solution with VS 2017 (Debug)
2. Run dotCover cover on solution with nunit3-console

## Excepted output

Test success 1

## Actual output

```
JetBrains dotCover Console Runner 2018.1.2. Build 112.0.20180530.115319
Copyright (c) 2009-2018 JetBrains s.r.o. All rights reserved.
[JetBrains dotCover] Coverage session started [2018-09-06 13:03:53]
NUnit Console Runner 3.8.0
Copyright (c) 2018 Charlie Poole, Rob Prouse

Runtime Environment
   OS Version: Microsoft Windows NT 6.3.9600.0
  CLR Version: 4.0.30319.42000

Test Files
    C:\Users\s_dev_builduser\Desktop\InvalidApplicationExceptionDotCover\InvalidApplicationExceptionDotCover\bin\Debug\InvalidApplicationExceptionDotCover.dll


Errors, Failures and Warnings

1) Error : InvalidApplicationExceptionDotCover.UnitTest1.TestMethod1
System.InvalidProgramException : Common Language Runtime detected an invalid program.
   at NUnit.Framework.Constraints.CollectionTally..ctor(NUnitEqualityComparer comparer, IEnumerable c)
   at NUnit.Framework.Constraints.CollectionItemsEqualConstraint.Tally(IEnumerable c) in C:\src\nunit\nunit\src\NUnitFramework\framework\Constraints\CollectionItemsEqualConstraint.cs:line 175
   at NUnit.Framework.Constraints.CollectionEquivalentConstraint.Matches(IEnumerable actual) in C:\src\nunit\nunit\src\NUnitFramework\framework\Constraints\CollectionEquivalentConstraint.cs:line 73
   at NUnit.Framework.Constraints.CollectionEquivalentConstraint.ApplyTo[TActual](TActual actual) in C:\src\nunit\nunit\src\NUnitFramework\framework\Constraints\CollectionEquivalentConstraint.cs:line 99
   at NUnit.Framework.Assert.That[TActual](TActual actual, IResolveConstraint expression, String message, Object[] args) in C:\src\nunit\nunit\src\NUnitFramework\framework\Assert.That.cs:line 245
   at NUnit.Framework.Assert.That[TActual](TActual actual, IResolveConstraint expression) in C:\src\nunit\nunit\src\NUnitFramework\framework\Assert.That.cs:line 228
   at InvalidApplicationExceptionDotCover.UnitTest1.TestMethod1() in C:\Development\Repositories\prototypes\InvalidApplicationExceptionDotCover\InvalidApplicationExceptionDotCover\UnitTest1.cs:line 22

Run Settings
    DisposeRunners: True
    WorkDirectory: D:\build_agent\tools\NUnit.Console.3.8.0
    ImageRuntimeVersion: 4.0.30319
    ImageTargetFrameworkName: .NETFramework,Version=v4.7.1
    ImageRequiresX86: False
    ImageRequiresDefaultAppDomainAssemblyResolver: False
    NumberOfTestWorkers: 4

Test Run Summary
  Overall result: Failed
  Test Count: 1, Passed: 0, Failed: 1, Warnings: 0, Inconclusive: 0, Skipped: 0
    Failed Tests - Failures: 0, Errors: 1, Invalid: 0
  Start time: 2018-09-06 11:03:55Z
    End time: 2018-09-06 11:03:58Z
    Duration: 2.280 seconds

Results (nunit3) saved as TestResult.xml
[JetBrains dotCover] Coverage session finished [2018-09-06 13:03:59]
[JetBrains dotCover] Analyzed application exited with code '1'
[JetBrains dotCover] Coverage results post-processing started [2018-09-06 13:03:59]
[JetBrains dotCover] Coverage results post-processing finished [2018-09-06 13:04:00]
```
