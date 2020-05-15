# _Word Counter_

#### _This is an Independent project at Epicodus using Behavior Driven Development and automated testing. 5/15/2020_

### Made by Nitun Datta 
## Description

_This is a console app that gathers both a word and sentence from a user, then checks how frequently the word appears in the sentence._


## Setup/Installation Requirements
1. Clone this repository from GitHub.
2. Open the downloaded directory in a text editor of your choice.
  (VSCode, Atom, etc.)
3. To install the REPL dotnet script, run dotnet tool install -g dotnet-script in your terminal.
4. Initialize the program with the command dotnet build.
5. Run donet restore
6. Run dotnet test


## Specs


1. The program will determine that only letters and capital letters are entered, no number or special characters
  * Input: "1245"
  * Output: False
2.The program will determine that only one word is entered.
  * Input : "The man"
  * OutPut: False
3.The user will input a word and a string. The program will detect if the word is present in the string.
  * Input: "cat", "I have a cat in the cathedral"  
  * OutPut : True.
4. The user will input a word and a string. The program will detect if the word is not present in the string.
  * Input: "dog", "I have a cat in the cathedral"
  * Output: True 
5. The user will input a word and a string. The program will detect if the word is present in the string and count all the incidents to return the total count only for full match.
  * Input: "cat", "I have a cat in the cathedral"
  * Output: 1
6. The user will input a word and a string. The program will detect if the word is present in the string and count all the incidents to return the total count only for full match, regardless of case.
  * Input: "cat", "CAT CAT cat"
  * Output: 3    



---
## Known Bugs


## Support

_Email: nitundatta8@gmail.com_

---
## Built With

## Useful tools




### License

This project is licensed under the MIT License

Copyright (c) 2020 **_Nitun Datta & DJ Zevenbergen_**
