# SSDT_UnitTestingFunctions

## Compatibility Notes
* This project was created with Visual Studio 2017 Professional.
* The SQL Server Database project is configured for SQL Server 2017 compatibility.

## Introduction
Having a need to create unit tests for my own SQL Server databases, I found an option at [Walkthrough: Creating and Running a SQL Server Unit Test] (https://msdn.microsoft.com/en-us/library/jj851212(v=vs.103).aspx). As of today (2018-02-01) the examples on that document only show stored procedures. After figuring out through trial-and-error how to use the SSDT Unit Testing tool for functions, I am sharing a simple "hello world" type of database with one scalar function and multiple unit tests against that function.

Look at the wiki to read a walkthrough to show you how to start with a blank database project and end with a set of unit tests verifying expected output of a function when given inputs.

