# Week 10: Habit Tracker (File I/O) — Study Notes

**Name:**

## File I/O — Reading

**What does `File.ReadAllLines` return, and how did you use it?**
[Think about the return type and what you did with each element]

Answer: It returned a string array, which can be mapped into a c# list.

**Why is it important to skip blank lines when reading a CSV file?**
[What would happen if you tried to split an empty string on `','`?]

Answer: It'd just return a single empty string, which wouldn't be good, since the list would be full of empty string elements.

## File I/O — Writing

**What does `File.WriteAllLines` do, and what arguments does it take?**
[Describe the path argument and what goes in the string array]

Answer: WriteAllLines takes a string array and overwrites the path file with the string array, with each element being its own line.

**What is `Select(...).ToArray()` doing in `SaveHabits`?**
[Break down the two steps: what does `Select` produce, and why call `ToArray()`?]

Answer: Select grabs all the data from the c# list habits, and puts it into a normal string array. Though, "done"/"pending" needs to be changed into a bool, so it's easier to use linq.

## Exception Handling

**What is a `FileNotFoundException` and when does it occur?**
[Describe the scenario where C# throws this specific exception]

Answer: It's when c# tries to read a file, but it can't find it under that path.

**Why do we catch `FileNotFoundException` specifically instead of using `catch (Exception)`?**
[Think about what catching all exceptions can hide from you]

Answer: Because it could be an index out of bounds or some other exception, but the catch would stop everything, so we wouldn't know.

## What I Learned

**Key takeaways from this week:**
[List 3 main things you learned]

1. how to try/catch
2. how to use c# list
3. how to save information permanently to files

**What was the trickiest part of this assignment and how did you work through it?**

Answer: I'm still not super comfortable with linq commands, so it was a bit rough, but I think I figured it out with some google searches.

## Time Spent

**Total time:** 3 hours

**Breakdown:**

- Understanding the starter code and CSV formats: 0.25 hours
- Implementing LoadHabits: 0.5 hours
- Implementing PrintHabits / PrintSummary: 0.5 hours
- Implementing AddHabit / UpdateHabit / SaveHabits: 0.5 hours
- Testing and debugging: 1 hours
- Writing study notes: 0.25 hours

**Most time-consuming part:**

Answer: Testing and debugging. 
