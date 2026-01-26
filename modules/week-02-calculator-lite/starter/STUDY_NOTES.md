# Week 2: Calculator Lite - Study Notes

**Name:**

## Understanding Data Types

**What are the four data types you used in this assignment?**
[List each data type (string, bool, int, double) and explain what kind of data each one stores]

Answer: string stores english, so names and such, and is what the console reads when Console.ReadLine() is called. A bool is either true or false, necessary for comparisons. Int is numbers without decimals, while double is numbers with decimals, in a nutshell. 4

**Why did we use `double` instead of `int` for the calculations?**
[Explain the difference between int and double, and why double is better for this calculator]

Answer: Doubles are capable of decimal values, so since ints are only whole numbers, doubles are more accurate and better for this calculator.

**How do you convert a string to a boolean?**
[Explain how you converted the user's "yes/no" input into a true/false value]

Answer: You can use a comparison (string.toequals), which returns a bool.

## Challenges and Solutions

**Biggest challenge with this assignment:**
[What was the hardest part? Understanding data types, getting user input, performing calculations, formatting output, or handling division by zero?]

Answer: Just figuring out how to optimize checking if the line read is the right type or not.

**How you solved it:**
[Explain what you did to overcome the challenge - reviewed documentation, asked for help, tested different approaches, etc.]

Answer: I iterated a lot, improving attempt after attmept.

**Most confusing concept:**
[What was hardest to understand? Parsing input, modulus operator, percentage formula, conditional formatting, or something else?]

Answer: Honestly, explaining what exactly I needed to do in English, the baseline/structure of the program before I started coding was the hardest for me.

## Understanding Arithmetic Operations

**What is the difference between the modulus operator (%) and division (/)?**
[Explain what each operator does and give an example]

Answer: The modulus operator results in the remainer of a division (13 % 3 = 1), since 13 / 3 is 4 with a remainder of 1/3. Division forgoes the remainder, so 13 / 3 woudl just be 4.

**How do you calculate the average of two numbers?**
[Write the formula in your own words]

Answer: Add all the numbers together, then divide it all by the number of entries in the series.

**What is the formula for percentage difference?**
[Explain the formula you used: ((num1 - num2) / num1) * 100]

Answer: Divide the difference of two numbers by the first number, then multiply by 100%.

## Input and Output

**How do you read user input in C#?**
[Explain what Console.ReadLine() does and what type of data it returns]

Answer: It saves the keys typed up until enter is pressed, then returns it all as a string

**How do you convert string input to a number?**
[Explain the Parse methods you used, like double.Parse()]

Answer: tryparse takes an input, then checks to see if it can parse it to the data type stated before it (int.tryparse or char.tryparse). If it can, it returns true and assigns a variable (out string sentence or out int value).

**What is string interpolation and how did you use it?**
[Explain the $ symbol and curly braces {} in Console.WriteLine()]

Answer: it lets you put variables directly into console.writelines() commands. $ automatically takes any variables in {} and replaces them with their string counterpart.

## Conditional Logic

**How do you format numbers with 2 decimal places vs whole numbers?**
[Explain the :F2 and :F0 format specifiers]

Answer: :F tells the computer how many decimal points to go to, with :F0 not going to decimals and :F2 going to two decimal points.

**Why is it important to check for division by zero?**
[Explain what happens if you try to divide by zero and how you handled it]

Answer: The computer crashes. Zero goes into anything infinitely, so the computer can't handle it. To solve this, it's important to check that the denumerator is zero and to avoid the math.

**How did you use the boolean variable to control formatting?**
[Explain how you used if/else to format output differently based on user preference]

Answer: I wasn't sure how to change the decimal numbers dynamically, so I had to hard code in two options: :F2 and :F0 depending on if useDecimals was true or false.

## What I Learned

**Key takeaways from this week:**
[What are the 3-5 most important things you learned?]

1. I learned how to use tryParse to avoid parsing to an invalid data type
2. I figured out how to limit decimals to a certain number of decimals
3. I got the hang of string interpolation
4. Console.ReadLine() makes sense to me now
5. \n for new lines is now in my vocabulary

**Which data type concept was most useful?**
[Explain which data type (string, bool, int, or double) you found most interesting and why]

Answer: String is interesting, as everything else can be derived from it (With a bit of work). It is annoying that you have to parse everything though.

**How does conditional formatting improve user experience?**
[Why is it helpful to let users choose decimal precision?]

Answer: It gives more power to the user depending on their needs and wants, the program can fill multiple uses.

## Testing and Debugging

**What test cases did you use to verify your program works?**
[List the different inputs you tested - positive numbers, negative numbers, decimals, zero, etc.]

Answer: zeros, decimal numbers

**What bugs or errors did you encounter and fix?**
[Describe any errors you got and how you fixed them]

Answer: I didn't realize that tryparse needed to parameters, so a lot of my headaches came from that.

## Time Spent

**Total time:** [6 hours]

**Breakdown:**

-   Understanding data types: [0.2 hours]
-   Reading and parsing user input: [2 hours]
-   Implementing arithmetic operations: [0.4 hours]
-   Adding conditional formatting: [2 hours]
-   Handling division by zero: [0.4 hours]
-   Testing and debugging: [0.5 hours]
-   Writing documentation: [0.5 hours]

**Most time-consuming part:** [Which aspect took the longest and why?]

Answer: Probably the parsing user input. It was just such a pain to parse everything. 

## Reflection

**What would you do differently next time?**
[What would you change in your approach or code?]

Answer: Maybe create a method for parsing to integers or doubles or something.

**How does this assignment prepare you for more complex programs?**
[Why are these skills important for future programming tasks?]

Answer: To optimize and streamline programs that ask for inputs from the user.
