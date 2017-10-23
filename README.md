# HackerRankVSEngine
Support Engine for easy make HackerRank practices into Visual Studio 2015 or superior and then copy - pasing into the web.

### Getting started

Donwload the solution, and just compile it. It will ouput a few example test into the bin folder.

### Add new excercice

1- Make a folder inside Excercise foler with the name of the test (without spaces or dashes (-)). 

2- Add a new Class with the name you want. That class MUST inherit Engine class.

3- Write the constructor in the new class, make sure you call one of base contructors.

4- Add input & output Files inside the folder you make in the step 1 (input.txt, output.txt naming by default). Make it Content and Copy always when compiles the solution.

5- Implement abstract method Main into your class. Build up your exercise in this class.

6- Go to Program.cs and call the new class. Invoke Validate Method to check the result.

7- When you finish, just copy the the content of your class inside HackerRank editor box.

8- Change Main method 'override' to 'static' after you paste the code into HackerRank.

