
# Selenium C# - Anh Tester HRM System

This is a test project written in C# programming language, with Selenium framework and Nunit library.

## Programming tools
- Visual Studio 2022
- .Net 6.0
- Selenium
- Webdriver Manager
- Nunit
- Browser Driver
- EPPlus
 *Install on Nuget package*

## Creat NUnit project
1. Open Visual Studio
2. Choose create project
3. Find Nunit test project (you also choose .Net core peoject to install more advanced package from NuGet library like: Nunit3 Console Runner, ... )
4. Choose .NET framework 6.0

## Main test case
### Login
- Login basic: Add username and password to function and test.
- Login with data provider: Add more data about username and password.
- Login witd data from excel file: Add data to test function by ExcelReader.
### HomePage
- Test UI from HomePage.
### EmployeePage
- Test HTML table by Selenium C#: find data, total cells, use collections to handle HTML table.

## Run test
- Open commandline and type "dotnet test" to run all test.
- Use Nunit.Console to extend XML report for all test case. (optional, because we can't install Entent Reports from NuGet Library)
### Step to use Nunit.Console
1. Install Nunit.ConsoleRunner on Nuget Pakage
2. Open Terminal, cd to "C:\"FilePath of project in your computer"\packages\NUnit.ConsoleRunner.3.15.0\tools"
3. Enter "nunit3-console.exe" after cd to this folder.
4. Find path "C:\"FilePath of project in your computer"\bin\Debug" to run Project.exe
5. Put the file "SeleniumCSharp1.exe" to previous path.
6. The final command to run test is "nunit3-console.exe "C:\"FilePath of project in your computer"\bin\Debug\SeleniumCSharp1.exe"
7. Results (nunit3) saved as TestResult.xml
### Step to change Browser
1. Open BaseTest.cs 
2. Chang env and env2 to switch Browser.
*Another workaround I explained in the setup function file basetest.cs*
### Step to run seleted test cases or group test case by commandline.
1. Add annotations [Category="name"] to the test case on testclass to select or group tests case you want to test.
2. Open commandline and type " dotnet test --filter Category="nane" " to run test cases you want. 
3. "dotnet test" only run all test case !!!