# Week 6: Text Menu App - Study Notes
Noah Lee
**Name: Noah Lee**
Noah Lee
## Loop Types

**How is a `do-while` loop different from a `while` loop?**
[Explain when each loop is best used]

Answer: a do-while loop runs at least once through, then ends when the condition is fufilled.

**Where did you use a `do-while` loop in this assignment and why?**
[Describe how you validated the menu choice and numeric inputs]

Answer: For the main menu, since I wanted it to run once, as well as the checking methods at the bottom.

**Where did you use a `while` loop and why?**
[Describe the menu loop and why it repeats]

Answer: I don't think I used a while loop actually. I didn't technically need it for the main menu, but oh well.

**Where did you use a `for` loop and why?**
[If you didn’t use a for loop, explain why it wasn’t needed]

Answer: Nothing needed to be run repeatedly for a set amount of times. Either once was enough or it needed a specific input to end, so a for loop wasn't needed.

## Input Validation

**Why did you create a helper method for input validation?**
[Explain how it avoids repeating code for multiple prompts]

Answer: It helps to remove tedious code, since it's repeated for most inputs.

**How did you validate the menu choice (1–6)?**
[Explain your range check logic and do-while loop]

Answer: It was just the readintinrange method.

**How did you handle invalid input (non-numbers)?**
[Explain how int.TryParse and double.TryParse work]

Answer: tryparse will return false if the input isn't correct, so as long as its false, you just keep looping the code until the input is true.

## String Operations

**Which string methods did you use across the different menu options?**
[List key methods like Trim, ToUpper, ToLower, Replace, Split, Join, Contains, PadLeft, PadRight, and formatting techniques]

Answer: trim removes any ' ' characters, toupper and tolower makes strings all uppercase or lowercase

**Which four string methods did you demonstrate in Option 6 (String Analysis)?**
[Explain Equals with StringComparison, Substring, EndsWith, and IndexOf]

Answer: there's all forms of comparing a string. It looks at a specific thing, maybe comparing it to another string, the ending character, etc., then sees if it equals to whatever parameter you give it.

**What's the difference between string concatenation and interpolation?**
[Explain when you used each approach and which you prefer]

Answer: I don't remember when I used both, but I prefer interpolation. It's a lot clearer to read instead of string and '+' signs all over the place.

## What I Learned

**Key takeaways from this week:**
[3-5 main things you learned]

1. How to use a switch statement
2. Coloring terminal lines
3. trimming strings
4.
5.

**Which loop felt most natural to use and why?**

Answer: do-whiles. They're simple!

## Time Spent

**Total time:** [5 hours]

**Breakdown:**

- Planning the loops: [0.2 hours]
- Input validation: [0.8 hours]
- String formatting: [2 hours.]
- Testing and debugging: [2.5 hours]
- Writing documentation: [0.5 hours]

**Most time-consuming part:** [Which aspect took the longest and why?]

Answer: testing and debugging. I used the debug to figure out how I neeeded to use the new methods or what parameters I needed to pass through it.

## Reflection

**What would you do differently next time?**

Answer: Maybe make more loops for the ending logic mess. 

**How did using three different loop types improve your understanding of repetition?**

Answer: Each have a good use for each of them, depending on the situation.
