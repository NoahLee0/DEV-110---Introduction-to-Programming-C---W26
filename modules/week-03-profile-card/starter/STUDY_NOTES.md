# Week 3: Personal Profile Card - Study Notes
Noah Lee
**Name:** Noah Lee
Noah Lee

## Understanding Variables and Data Types

**What are the four main data types you used in this assignment?**
[List string, int, double, and bool - explain what each stores and give examples from your profile card]

Answer: Strings as words and english for names and favorite colors, ints as whole numbers for graduation year and age, doubles as decimals numbers for gpa, and bool as true/false values for is honor student.

**Why did you use `double` for GPA instead of `int`?**
[Explain the difference and why decimal precision matters for GPA]

Answer: Because int cannot have decimals, while GPA has two. This is why doubles are necessary.

**How did you convert the yes/no input into a boolean?**
[Explain the comparison operation you used]

Answer: You can use .Equals to compare two strings.

## Data Modeling Decisions

**How did you organize the information into logical groups?**
[Explain why you grouped certain pieces of information together (personal, academic, etc.)]

Answer: So things would be nice and orderly. It's like an actual report card.

**Which pieces of information did you calculate rather than ask for?**
[List the derived data: birth year, years to graduation, height conversion, honor status, age in months]

Answer: The birth year, years to graduation, height to feet and inches, honor student status, and their age in months.

**Why is it better to calculate birth year from age rather than ask for both?**
[Explain data consistency and reducing redundant input]

Answer: It's better for the user, as it's more annoying if they need to do both.

## Challenges and Solutions

**Biggest challenge with this assignment:**
[What was the hardest part? Type conversion, calculations, formatting, choosing data types?]

Answer: Nothing really, just formatting everything at the end.

**How you solved it:**
[Explain your approach to overcoming the challenge]

Answer: I made a formula I could copy and paste to make formatting easier.

**Most confusing concept:**
[What was hardest to understand? Type casting, modulus for height, boolean logic, or formatting?]

Answer: Formatting.

## Type Conversion and Calculations

**How do you convert string input to a number?**
[Explain Parse methods: int.Parse(), double.Parse()]

Answer: int.Parse() looks if the string has integers that it can transform into an int, while double.Parse() does the same but changes it to a double.

**What calculation did you use to convert height from inches to feet and inches?**
[Explain: feet = inches / 12, remaining = inches % 12]

Answer: You can get how many feet in inches with inches / 12, then you get those last inches (the number left when divided away) with inches % 12.

**How did you determine if someone is an honor student?**
[Explain the boolean comparison: gpa >= 3.5]

Answer: if gpa is above or equal to 3.5, then the boolean is set to true.

## Output Formatting

**How did you format the GPA to show exactly 2 decimal places?**
[Explain the :F2 format specifier]

Answer: with the ToString("F2"), it manually changes the double to a string, then limits it to two decimal places.

**How did you display different text based on whether someone is full-time or part-time?**
[Explain the conditional/ternary operator you used]

Answer: you can use a conditional to check if the boolean was true or false, then print out a different console output.

**What techniques did you use to make the output look organized?**
[Discuss alignment, spacing, section headers, borders]

Answer: It was mainly spacing and section headers. I separated each section with two line spaces, then used section headers to separate the sections.

## Real-World Data Modeling

**What other calculated fields could you add to a profile?**
[Think of other derived data: BMI from height/weight, time to birthday, etc.]

Answer: Which zodiac animal they are is one

**Why is choosing the right data type important in real applications?**
[Explain memory, precision, and type safety]

Answer: it's necessary to conserve memory, in case of very large applications. For precision, it just means the type of data should fully encompass any important values it should hold.

**How does this profile card relate to real-world applications?**
[Think about social media profiles, job applications, student records systems]

Answer: This automatically calculates information based on user input, like a lot of other apps.

## What I Learned

**Key takeaways from this week:**
[What are the 3-5 most important things you learned about variables and data modeling?]

1. Its a lot easier to make a method to do my tryparsing for me.
2. It's good that I can cast a method if it returns a value.
3. Sometimes temp variables are necessary to tryparse.
4.
5.

**Which data type was most challenging to work with and why?**
[Reflect on your experience with string, int, double, or bool]

Answer: Bool. It's weird tryparsing from string to string to bool.

**How does understanding data types help you write better programs?**
[Explain the benefits of type safety and appropriate data representation]

Answer: It ensures that nothing breaks, that at least all the types work the way they are supposed to.

## Testing and Debugging

**What test cases did you use to verify your calculations?**
[List different inputs you tested - edge cases, typical values, etc.]

Answer: Edge cases, the boarders for the >= and <= values, negative values, strings, ints, etc.

**What bugs or errors did you encounter and fix?**
[Describe any type conversion errors, calculation mistakes, or formatting issues]

Answer: I forgot to cast a double to an int.

**How did you validate that your data types were correct?**
[Explain how you checked that GPA, heights, ages worked correctly]

Answer: I put a bunch of different decimal numbers in.

## Time Spent

**Total time:** [2 hours]

**Breakdown:**

-   Understanding data types and planning variables: [0.2 hours]
-   Collecting user input with correct types: [0.6 hours]
-   Implementing calculations: [0.2 hours]
-   Formatting output: [0.2 hours]
-   Testing and debugging: [0.2 hours]
-   Writing documentation: [0.6 hours]

**Most time-consuming part:** [Which aspect took the longest and why?]

Answer: Writing this document. There's a lot to type.

## Reflection

**What would you do differently if you started over?**
[Consider variable names, calculation order, organization, etc.]

Answer: Nothing really, maybe colors, I remember I wanted to do that.

**How does proper data modeling make programs easier to maintain?**
[Think about readability, consistency, and reducing errors]

Answer: It acts like a consistant blueprint. Readable variables makes it so even noncoders can understand what's going on. 

**What real-world system would you like to model next?**
[Shopping cart, game character, recipe calculator, etc.]

Answer: Game character, something with UI hopefully...?
