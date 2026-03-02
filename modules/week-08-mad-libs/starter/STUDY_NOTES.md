# Week 8: Mad Libs (Structure + Debugging) - Study Notes

**Name:** Noah Lee

## Program Structure

**What helper methods did you create (and what does each one do)?**
[List your methods and briefly describe each]

Answer: ChooseTemplate reads a choice between the two templates, returning a story template with a title, list of prompts, and the template itself. CollectWords collects those words from the prompts. ReadYesNo reads if the input is yes or no. ReadIntInRange validates the input as a value in the range. ReadNonEmptyString ensures that the input to the prompt is nonempty.

**Why is it helpful to move code out of `Main` and into helper methods?**
[Explain how this improves readability and reduces bugs]

Answer: So you can zero in on what the issue is and in which method.

## Data Modeling

**What is the purpose of the `StoryTemplate` class in this assignment?**
[Explain what data it stores and why]

Answer: It holds the prompts to ask and the template. This takes all the clutter away from the main program.

**How did using a template make it easier to support two different stories?**
[Explain how the same logic can work with different prompts/text]

Answer: Because it was the same logic (just replacing {0} and {1} and {...}, but just with different templates)

## Testing and Debugging

**Where did you set a breakpoint while debugging this program (what line or method)?**
[Be specific - example: inside GenerateStory, at the beginning of CollectWords, etc.]

Answer: I put one inside after the program took the inputs for the prompts. I wasn't sure I implemented the readnonempty method correctly, so it was easiest to check there.

**What did you learn from stepping through your code line by line?**
[Describe how watching execution helped you understand flow or find bugs]

Answer: It made jumping from class to class easier to follow.

**What bug or logic mistake did you encounter (and how did you fix it)?**
[Describe a real issue you ran into and how breakpoints/stepping helped]

Answer: When reading the non empty string, I forgot that the user could input a whitespace. So, the breakpoint helped me realize it was still passing through even if it was a whitespace. So, I put trim() on it and it was fixed.

## What I Learned

**Key takeaways from this week:**
[3 main things you learned]

1. How to use logger
2. How to use breakpoints
3. How to utilize multiple classes

**What part of this assignment helped you understand program structure the most?**
[Breaking into methods, using public/private methods, separating concerns, etc.]

Answer: Breaking it down into methods

## Time Spent

**Total time:** [3 hours]

**Breakdown:**

- Planning structure (methods/classes): [1 hours]
- Input validation: [0.5 hours]
- Story templates + formatting: [0.5 hours]
- Testing and debugging: [0.8 hours]
- Writing documentation: [0.2 hours]

**Most time-consuming part:** [Which aspect took the longest and why?]

Answer: Planning the structure. I didn't understand how the paramaters for storytemplate worked, I thought that "prompts" were the actual inputs themselves and it confused me a lot.

## Reflection

**What would you improve if you had more time?**
[Ideas: more templates, better formatting, more validation, etc.]

Answer: More templates sounds fun! Maybe more inputs too, maybe having it varied based on the inputs.

**How did breaking your program into smaller parts help you debug?**
[Explain the connection between structure and debugging]

Answer: When there was an error, I could zero in on the specfic method and why it was breaking.
