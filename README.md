# _Word Counter_

#### _This is an Independent Project at Epicodus using Behavior Driven Development and automated testing. 5/15/2020_

### Made by Nitun Datta 
## Description

_This is a console app that gathers both a word and sentence from a user, then checks how frequently the word appears in the sentence._


## Setup/Installation Requirements
1. Clone this repository from GitHub.
2. Open the downloaded directory in a text editor of your choice.
  (VSCode, Atom, etc.)
3. Make sure that C#/.netcore2.2 is installed on your computer.  
4. For launching the program navigate to the _WordCounter_ directory and run _dotnet build_.
5. Next,run _dotnet run_ command in the same directory to execute this compiled code.
5. For testing,locate to the WordCounter.Tests directory and run _dotnet test_.



## Specs

1. The program will determine that only letters and capital letters are entered, no number  or special characters
  * Input: "1245"
  * Output: False
2. The program will determine that if any input is null or empty.
  * Input : "The man",  ""
  * OutPut: False.
3. The user will input a word and a string. The program will detect if the word is present  in the string.
  * Input: "cat", "I have a cat in the cathedral"  
  * OutPut : True.
4. The user will input a word and a string. The program will detect if the word is not present in the string.
  * Input: "dog", "I have a cat in the cathedral"
  * Output: False. 
5. The user will input a word and a string. The program will detect if the word is present in the string and return the total number of words count only for the full match, regardless of case.
  * Input: "cat", "I have a cat in the cathedral"
  * Output: 1
   

## Known Bugs


## Support

_Email: nitundatta8@gmail.com_

---
### Technologies Used
    C#
    MSTest
    .NET Core
    Git and GitHub

### License

This project is licensed under the MIT License

Copyright (c) 2020 **_Nitun Datta_**
