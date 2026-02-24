# Week 5: Guess the Number - Study Notes

<<<<<<< HEAD
**Name: Noah Lee** Noah Lee
Noah Lee
=======
**Name:**

>>>>>>> 6152f1b5048162c84e28aa0e9aefae0dbe81bdcc
## Loop Types

**How is a `do-while` loop different from a `while` loop?**
[Explain when each loop is best used]

<<<<<<< HEAD
Answer: do-while runs though the loop at least once first. It's good for things like ensuring a TryParse loop. While loops have a chance to never run.
=======
Answer:
>>>>>>> 6152f1b5048162c84e28aa0e9aefae0dbe81bdcc

**Where did you use a `do-while` loop in this assignment and why?**
[Describe the input validation use]

<<<<<<< HEAD
Answer: For the int tryparse loops, like stated above. based around a tryparse function, it only returns a value once an int is returned.
=======
Answer:
>>>>>>> 6152f1b5048162c84e28aa0e9aefae0dbe81bdcc

**Where did you use a `while` loop and why?**
[Describe the guessing loop]

<<<<<<< HEAD
Answer: To check while guess != secret. It constantly loops to check if secret was equal to guess.
=======
Answer:
>>>>>>> 6152f1b5048162c84e28aa0e9aefae0dbe81bdcc

**Where did you use a `for` loop and why?**
[Describe the rounds loop]

<<<<<<< HEAD
Answer: For the rounds. It started at 1 and incrimented until it reached rounds.
=======
Answer:
>>>>>>> 6152f1b5048162c84e28aa0e9aefae0dbe81bdcc

## Input Validation

**Why did you create a helper method for input validation?**
[Explain how it avoids repeating code for max value and rounds]

<<<<<<< HEAD
Answer: So I didn't need to constantly clog up the code with copied logic.
=======
Answer:
>>>>>>> 6152f1b5048162c84e28aa0e9aefae0dbe81bdcc

**How did you make sure the max value was between 10 and 100?**
[Explain your range check logic]

<<<<<<< HEAD
Answer: Just to ensure that the input wasn't above 100 or below 10. That makes it inclusive.
=======
Answer:
>>>>>>> 6152f1b5048162c84e28aa0e9aefae0dbe81bdcc

**How did you make sure the number of rounds was between 1 and 3?**
[Explain your range check logic]

<<<<<<< HEAD
Answer: Also the same logic. 
=======
Answer:
>>>>>>> 6152f1b5048162c84e28aa0e9aefae0dbe81bdcc

**How did you handle invalid input (non-numbers)?**
[Explain how int.TryParse works]

<<<<<<< HEAD
Answer: Using a do-while loop, tying it to a boolean makes the tryparse return true or false depending if the string can be parsed into whatever other data type. If it can return true, then it can put said value into another "out" variable.
=======
Answer:
>>>>>>> 6152f1b5048162c84e28aa0e9aefae0dbe81bdcc

## Guessing Logic

**How did you compare the guess to the secret number?**
[Explain the if/else logic for too low, too high, and correct]

<<<<<<< HEAD
Answer: Same as all the other range checks. If guess > secret, too high, if guess < secret, too low. Then, since the while loop would end once guess = secret, all logic could be put outside of the while loop.
=======
Answer:
>>>>>>> 6152f1b5048162c84e28aa0e9aefae0dbe81bdcc

**How did you count the number of guesses?**
[Explain where you incremented the counter]

<<<<<<< HEAD
Answer: for loop. set i to 1, increment it every loop.
=======
Answer:
>>>>>>> 6152f1b5048162c84e28aa0e9aefae0dbe81bdcc

## Random Numbers

**How did you generate the secret number?**
[Explain Random and Next(min, max)]

<<<<<<< HEAD
Answer: set a new random outside of the loop, then use next to ensure randomness.
=======
Answer:
>>>>>>> 6152f1b5048162c84e28aa0e9aefae0dbe81bdcc

**Why does `Random.Next(1, max + 1)` include the max value?**
[Explain why +1 is needed]

<<<<<<< HEAD
Answer: since random gives a decimal up to the number given, which is then cast into an int, it will never be the value passed to it. So, one needs to be added.
=======
Answer:
>>>>>>> 6152f1b5048162c84e28aa0e9aefae0dbe81bdcc

## Testing and Debugging

**What inputs did you test to confirm your loops worked correctly?**
[List several test cases]

<<<<<<< HEAD
Answer: too low numbers, too high numbers, negative numbers, strings, etc.
=======
Answer:
>>>>>>> 6152f1b5048162c84e28aa0e9aefae0dbe81bdcc

**What bugs or errors did you encounter and fix?**
[Describe any logic or loop errors]

<<<<<<< HEAD
Answer: I needed to initialize the "out values" for the tryparse loops first.
=======
Answer:
>>>>>>> 6152f1b5048162c84e28aa0e9aefae0dbe81bdcc

## What I Learned

**Key takeaways from this week:**
[3-5 main things you learned]

<<<<<<< HEAD
1. Do-while loops make tryparsing so much easier
2. private methods
3. How to use random
=======
1.
2.
3.
>>>>>>> 6152f1b5048162c84e28aa0e9aefae0dbe81bdcc
4.
5.

**Which loop felt most natural to use and why?**

<<<<<<< HEAD
Answer: while. I've already had experience with it, and logically (and english-ly), it makes sense what it does.
## Time Spent

**Total time:** [1 hours]

**Breakdown:**

- Planning the loops: [0.1 hours]
- Input validation: [0.2 hours]
- Guessing logic: [0.3 hours]
- Testing and debugging: [0.1 hours]
- Writing documentation: [0.3 hours]

**Most time-consuming part:** [Which aspect took the longest and why?]

Answer: Documentation and guessing logic. It was just a lot to write for both sections.
=======
Answer:

## Time Spent

**Total time:** [X hours]

**Breakdown:**

- Planning the loops: [X hours]
- Input validation: [X hours]
- Guessing logic: [X hours]
- Testing and debugging: [X hours]
- Writing documentation: [X hours]

**Most time-consuming part:** [Which aspect took the longest and why?]

Answer:
>>>>>>> 6152f1b5048162c84e28aa0e9aefae0dbe81bdcc

## Reflection

**What would you do differently next time?**

<<<<<<< HEAD
Answer: Nothing really, I think it all went well this time.

**How did using three different loop types improve your understanding of repetition?**

Answer: I enjoyed learning how to use the do-while loops, they seem extremely helpful for tryparsing. I also look forward to using foreach loops as well.
=======
Answer:

**How did using three different loop types improve your understanding of repetition?**

Answer:
>>>>>>> 6152f1b5048162c84e28aa0e9aefae0dbe81bdcc
