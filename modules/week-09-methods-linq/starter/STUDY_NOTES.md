# Week 9: Score Stats (Methods + LINQ) - Study Notes

**Name:** Noah Lee

## Methods and Decomposition

**Why is it helpful to break a program into small methods?**
[Think about readability, testing, and debugging]

Answer: It makes it so code can be repurposed and resused in other classes as well. It also makes readability and debugging a lot more streamlined, as the flow of the code can be easily followed.

## LINQ (Stats + Method Chaining)

**Which LINQ methods did you use for basic statistics?**
[Examples: Min, Max, Average, Count with predicates]

Answer: Min, max, average, count

**Which LINQ methods did you chain together for reports?**
[Examples: Where + OrderByDescending, OrderByDescending + Take]

Answer: orderby, orderbydescending, where

**Why is it helpful to put score logic in a class (ScoreReport) instead of keeping everything in Program?**
[Think about organization, reuse, and readability]

Answer: If I needed just one method instead of the entire thing, I could just call from this class instead.

## What I Learned

**Key takeaways from this week:**
[3-5 main things you learned]

1. How to use basic linq methods
2. More about array sorting and toarray shenanigans
3. The difference between value and action methods.
4.
5.

**Which concept felt easiest (methods or LINQ) and why?**

Answer: methods. I just have more experience with it, so it makes more sense to me.

## Time Spent

**Total time:** 3 hours

**Breakdown:**

- Understanding the starter code: 0.5 hours
- Implementing the print methods: 0.5 hours
- LINQ method chaining: 0.7 hours
- Testing and debugging: 1 hours
- Writing documentation: 0.3 hours

**Most time-consuming part:** [Which aspect took the longest and why?]

Answer: Debugging. It wasn't anything to do with the logic, I just forgot to specifically put in the ":" or other small bits in the output.

## Reflection

**What would you improve next time?**

Answer: Reading the test file and the readme first to see exactly what they're asking for.

**How did methods make this program easier to work on?**

Answer: Improved readability, streamlined where the bugs were coming from.
