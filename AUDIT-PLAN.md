# Audit plan: 99 Bottles solution code

## Context
This audit covers all tagged versions (ch01 to ch06, appendix A to D). It looks for compiler warnings that need fixing and for bugs or confusing code a beginner would trip over. The rules:
- Nothing may use a concept the book hasn't taught by that point. The appendices come **after the whole book**, so they may use everything from Ch1–6 plus their own topic.
- Intentional bad practice stays, unless the concept that fixes it has already been taught.
- **CS8600 (`string x = Console.ReadLine();`) is ignored.**
- **CS8602 on `x.Equals("yes", ...)` gets fixed** with a null-safe equality check.

I built every tag. There are 11 warnings in total: 8× CS8600 (ignored) and 3× CS8602 (to fix). Ch01–Ch04 build clean.

## NinetyNineBottles

### 1. Verse for 2 prints "1 bottles of beer on the wall" (ch03-end → ch06-end)
- **Where:** the final `else` uses `{numberOfBottles - 1} bottles`, so the 2-verse ends "...1 bottles of beer on the wall."
- **Why it matters:** `if/else if` is taught in Ch3, so this is a taught-but-unfixed case. Ch4 runs with 3 bottles, so the reader sees the bug in their own output.
- **Fix:** add a branch before the final `else` in ch03-end, and carry it through ch04-end, ch05-start, ch05-end (inside `PrintVerse`) and ch06-end:
  ```csharp
  else if (numberOfBottles == 2)
  {
      Console.WriteLine($"{numberOfBottles} bottles of beer on the wall, {numberOfBottles} bottles of beer. Take one down, pass it around, 1 bottle of beer on the wall.");
  }
  ```

### 2. Starting with 1 bottle ends "buy some more, 1 bottles of beer" (ch06-end)
- **Where:** `GetInputFromUserAsInteger(..., 1, 10000)` allows 1. The `== 0` branch then prints `{originalNumberOfBottles} bottles`.
- **Fix:** nest an `if (originalNumberOfBottles == 1)` / `else` inside the `numberOfBottles == 0` branch, with a singular and a plural sentence. That uses only if/else, which is taught.
- **No-new-code alternative:** raise the minimum to 2 in the call.

### 3. Left as is (intentional)
- Ch3: the `< 1` clamp makes the `== 0` branch unreachable. The README calls this out.
- Ch6 line 42: CS8600, ignored.

## Appendix A – DNDCharacterRoller

### 4. Finished file doesn't match the starter
- The finished file drops `namespace DNDCharacterRoller;`.
- It adds `using System;`, which no other file uses and which is redundant with ImplicitUsings.
- It moves `Random dice = new Random();` below the inputs, although the starter says *"Place the Random instance as the first line in Main"*.
- **Fix:** restore the namespace, remove the `using`, and put `Random` back as the first line.

### 5. Cast lesson doesn't demonstrate anything
- **Where:** `(double)totalScore / 6.0`. The comment says that without the cast you'd get 11, but `6.0` already forces a double division. A reader who deletes the cast to test this sees no change.
- **Fix:** change it to `(double)totalScore / 6`, which matches the starter hint.

### 6. Comment says "11.66", but `:F2` prints 11.67
- **Fix:** change the comment to "11.67".

## Appendix B – CarRental

### 7. CS8602 at lines 14 and 18
- **Fix:** use `"yes".Equals(licenseInput, StringComparison.OrdinalIgnoreCase)`, and the same for `insuranceInput`.
- This is the same method the reader already knows, with the arguments swapped, so it is null-safe and adds no new concept.
- Setting the variable to `string.Empty` first would *not* clear the warning, because `ReadLine()` reassigns it.

### 8. `out int age` (inline declaration) is never shown in the chapters
- Ch6 declares the variable first and then passes `out valueFromUser`.
- **Fix:** add `int age = 0;` above the call and use `int.TryParse(ageInput, out age)`.

### 9. Optional: the starter says "Try both approaches!", but only the big condition is shown
- Add the nested-if version commented out, in the same style as Appendix A's optional block.

## Appendix C – BattleBot

### 10. Prompt doesn't say which commands exist, and `switch` is case-sensitive
- A reader typing "Fire" or "help" just gets "Unknown command."
- **Fix:** change the prompt to `Console.Write("Enter command (fire, jump, shutdown): ");`

### 11. Optional: "Critical" can never appear with `energy = 100`
- Add a comment along the lines of "change energy to 10 to see the other branch."

## Appendix D – HighRoller

### 12. CS8602 at line 33
- **Fix:** `while ("yes".Equals(playAgain, StringComparison.OrdinalIgnoreCase))`

### 13. `+=` and `"\n"` aren't taught in Ch1–6 or in the starter instructions
- Unless the Appendix D text introduces them, replace them:
  - `totalScore += roll;` → `totalScore = totalScore + roll;`
  - `"\n..."` → a separate `Console.WriteLine();`

### 14. Optional: comment on why `string playAgain;` is declared outside the `do`
- It has to be visible to the `while` condition.

## README
- Update "A note on the code": the "1 bottles" sentence no longer applies once item 1 is in.

## Applying the changes
- Items 1 and 2 change code that tags point to (ch03-end … ch06-end, and the appendix tags that contain NinetyNineBottles). To fix them:
  1. Rebuild the commit chain on a new branch from `e73f110`, applying each fix at the commit where it belongs.
  2. Move every tag to the new commits.
  3. Force-push the tags.
- Force-pushing tags rewrites published history, so I'll confirm before that step.
- The book's text for these listings needs the same edits.

## Verification
- Extract each tag into the scratchpad with `git archive` and run `dotnet build` on it. Expect zero CS8602 and only the ignored CS8600s.
- `dotnet run` at ch04-end: the verse ends "…1 bottle of beer on the wall."
- ch06-end with input 2: the 2-verse is correct. With input 1: the 0-verse says "1 bottle".
- Appendix A: the average prints with 2 decimals, and removing the cast now visibly changes the result.
- Appendix B/C/D: run each with sample input and check the output.
