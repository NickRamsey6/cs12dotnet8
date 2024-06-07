# Chapter 1 Summary

## Key Concepts
* Set up your development environment
* Discuss the similarities and differences between modern .NET, .NET Core, .NET Framework, Xamarin, and .NET Standard
* Use Visual Studio 2022 and Visual Studio Code with the .NET SDK CLI to create a couple of simple console apps grouped in a solution
* Learned how to download solution code from this book from the github repo
* Learned how to find help via help commands, documentation, articles and AI

## Practice Questions
1. Is Visual Studio better than Visual Studio Code?  
**Answer: Depends on the project and your familiarity with the tools. VS is an IDE, VS Code is a text editor**
2. Is .NET 5 and later better than .NET Framework?  
**Answer: For modern development - yes. .NET Framework is limited to Windows only and mostly legacy projects.**
3. What is .NET Standard and why is it important?  
**Answer: .NET Standard defines API specifications for all .NET platforms. Following it allows for maximum code reuse. Needed for compatibility**
4. Why can a programmer use different languages (C# and F#) to write apps that run on .NET?  
**Answer: .NET compiles C# and F# code to intermediate language code. The IL code is then compiled to Just In Time code that can be run natively on a CPU by the Comman Language Runtime (CLR)**
5. What is a top-level program and how do you access any command-line arguments?  
**Answer: Top level programs do not explicitly define a Program class or Main method to access command-line arguments. You can type statements without the boilerplate code. Command line arguments are accessed via the console.**
6. What is the name of the entry method of a .NET console app and how should it be explicitly declared if you are not using the top-level program feature?  
**Answer: The Main method.**
7. What namespace is the program class defined in with a top level program?  
**Answer: The null namespace**
8. Where would you look for help with a C# keyword?  
**Answer: Microsoft learn website, stackoverflow, GeeksforGeeks, w2 schools, etc.**
9. Where would you look first for solutions to common programming problems?  
**Answer: Stackoverflow**
10. What should you do after getting an AI to write code for you?  
**Answer: Test it**

## Projects List
* HelloCS - Writing to the console and trying out the Null Coalescing Operator
* AboutMyEnvironment - Exploring namespaces

## My Takeaways