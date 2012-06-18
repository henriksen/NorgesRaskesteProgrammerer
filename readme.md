Norges raskeste programmerer
============================
(Norway's fastest programmer)
-----------------------------

At the [Norwegian Developer Conference 2012][1] (NDC) the [Norwegian .NET User Group][2] (NNUG) held a competition where participants were given a set of tests and a skeleton of domain objects. They then had to implement the code to make the tests pass. Whoever made the tests pass in the shortest time during the conference won the laptop used for the competition. The laptop was donated by [Komplett][3], a sweet [Samsung 700Z5A][5].

The two files start.ps1 and stop.ps1 are Powershell scripts intended to record the time when starting and stopping coding and to create a git branch for the contestant. Start.ps1 will ask for an e-mail adress and create a branch with that name, a new file and make a commit. Stop.ps1 just makes a commit of all changed files. That way you can use the two commit times and calculate the duration. Also, we get a branch with the result in that can be used to verify that all tests are passing and that they didn't cheat by just rigging the tests.

This is the project used in the competition, made public since someone wanted it :) Feel free to use it for what ever you want. Please note that the code is written solely with the purpose of using it in a competition and not intended for any other purpose, including education or to reflect any sort of best practice. If you copy and paste this stuff into production [you're on your own][4]. Your mileage may vary, etc, etc. 

It's a Visual Studio 2012 project and if you want to have a go at it, the best time was just shy of 10 minutes: 9:05 But remember, you're not doing it on a conference floor with the pressure of a competition hanging over your head :)

Happy coding!

[1]:http://www.ndcoslo.com/
[2]:http://nnug.no/
[3]:http://www.komplett.no/
[4]:http://www.quickmeme.com/meme/3prg4b/
[5]:http://www.komplett.no/k/ki.aspx?sku=659558