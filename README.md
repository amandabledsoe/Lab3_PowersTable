This my solution for Lab 3 of the 2022 C# .NET After-Hours Boot Camp at Grand Circus. (In Progress)

## EXPONENTS / Powers Table
### Objectives: 
User input, calculations

### Task: 
Display a table of powers. Ask the user if they would like to go again, and if so loop back to the beginning.

### What will the application do?
- **1 Point:** The application prompts the user to enter an integer.
- **3 Point:** The application displays a table of squares and cubes from 1 to the value entered.
- **1 Point:** The application prompts the user to continue.

### Build Specifications:
- **1 Point:** Assume that the user will enter valid data.
- **1 Point:** The application should continue only if the user agrees to.

### Additional Requirements:
- **1 Point:** For answering the Lab Summary when submitting to the LMS
- **-2 Points:** if there are any syntax errors or if the program does not run (for example, in a Main method). 

### Hints:
- Don’t mess up the difference between squares and cubes! 
- Use \t to tab to line up columns properly
- Your instructor will provide you with sample loops during class regarding how to ask the user if they would like to go again.

### Extra Challenges:
- **1 Point:** Provide validation by rejecting 0 or negative numbers as user input; keep prompting the user until they enter a valid number.
- **1 Point:** Research formatted strings and right-align the numbers in columns instead of left-aligning them
- **1 Point:** Find out the maximum number whose cube will fit in an int, and limit the user input to that number or less


### Console Preview:
```
Learn your squares and cubes!

Enter an integer: *{user input here, for example: 5}*

Number    Squared     Cubed
=======   =======     ======
  1          1          1
  2          4          8
  3          9          27
  4          16         64
  5          25         125

Continue? (y/n): {user input here, for example: Y}

Enter an integer: …
```
