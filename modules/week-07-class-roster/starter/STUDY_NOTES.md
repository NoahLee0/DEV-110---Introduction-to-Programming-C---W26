# Week 7: Class Roster Builder (Arrays) - Study Notes
Noah Lee
**Name: Noah Lee** Noah Lee
Noah Lee
## Arrays and `count`

**What are “parallel arrays” and how did you use them in this assignment?**
[Explain how rosterNames and rosterCredits stay lined up by index]

Answer: They are two arrays, used in parallel, with [0] of rosterName and [0] rosterCredits lining up with each other (and so on and so forth)

**What is the purpose of the `count` variable?**
[Explain how it tracks how many roster slots are “in use”]

Answer: Since arrays are a set size, count is necessary to know how many roster slots are being used

**Where did you use `count` in loops and why?**
[Explain why you loop 0..count-1 instead of using the full array length]

Answer: Since the array starts at index 1, if it went to the full count, then it would be an index out of bounds exception.

## Printing and Sorting

**How did you print the class roster using a `foreach` loop?**
[Describe building an array of roster lines and then printing each line]

Answer: By combining the rosterName and rosterCredits into one big string array, a foreach loop can go through and print each line.

**How did you sort the roster while keeping names and credits aligned?**
[Describe copying the used roster into new arrays and using Array.Sort on parallel arrays]

Answer: you would keep the old arrays, but you would choose how to order indexed with Array.sort (either by the string array or the int array), which is then copied over into the correct indexes.

## What I Learned

**Key takeaways from this week:**
[3-5 main things you learned]

1. how to use a foreach loop
2. how to copy arrays
3. how to sort arrays
4. how to use out variables in parameters
5.

**Which loop felt most natural to use and why?**

Answer: the for loop. I've had experience with it, so we're all good.

## Time Spent

**Total time:** [2 hours]

**Breakdown:**

- Planning the arrays/menu: [0.2 hours]
- Input validation: [0.2 hours]
- Add + print roster features: [0.2 hours]
- Sorting feature: [1 hours]
- Testing and debugging: [0.2 hours]
- Writing documentation: [0.2 hours]

**Most time-consuming part:** [Which aspect took the longest and why?]

Answer: sorting. I didn't quite understand the out variables in the parameters for the sorting, so I needed to do some of my own research.

## Reflection

**What would you do differently next time?**

Answer: maybe play with the colors, or not use a switch statement for one of the loops near the end.

**How did using `for` and `foreach` improve your understanding of arrays?**

Answer: for is good for numbers, so indexing, but foreach is good when using the whole array.
