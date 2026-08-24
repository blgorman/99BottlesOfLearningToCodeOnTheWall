# 99 Bottles of Learning To Code — Solution Files

Companion code for *99 Bottles of Learning To Code on the Wall* by Brian L. Gorman.

## How to use this repository

Every chapter has two tags: a **starter** (the code as it stands when the chapter
begins) and a **finished** version (the code once the chapter is complete). The
finished version of one chapter is normally the starter for the next, so both tags
point at the same commit. The one exception is `ch04-end` and `ch05-start`: chapter 4
finishes with the song set to 3 bottles so the output is short enough to read, and
chapter 5 picks it back up at 99.

Download any tag as a zip from the **Releases / Tags** page on GitHub, or check one
out locally:

```bash
git checkout ch03-end
cd NinetyNineBottles
dotnet run
```

## Chapter tags

| Tag | State of the code |
|:--|:--|
| `ch01-start` | A brand new console application, straight from `dotnet new console` |
| `ch01-end` / `ch02-start` | One verse printed with hard-coded text |
| `ch02-end` / `ch03-start` | A variable and string interpolation |
| `ch03-end` / `ch04-start` | Decisions with `if` / `else if` / `else` |
| `ch04-end` | The whole song, printed by a `while` loop (starting at 3 bottles, as the chapter shows) |
| `ch05-start` | The same code, with the starting value set back to 99 |
| `ch05-end` / `ch06-start` | Verse printing moved into a `PrintVerse` method |
| `ch06-end` | User input, validated with `int.TryParse` |

## Appendix tags

| Tag | State of the code |
|:--|:--|
| `appendix-a-start` / `appendix-a-end` | The D&D Character Roller |
| `appendix-b-start` / `appendix-b-end` | Rule-Based Decision Making (car rental) |
| `appendix-c-start` / `appendix-c-end` | The "Battle Bot" Controller |
| `appendix-d-start` / `appendix-d-end` | The "High Roller" Dice Game |

Each appendix `-start` tag is an empty project with the instructions written in as
comments. Appendix tags are later in history than the chapter tags, so an appendix
zip also contains the finished `NinetyNineBottles` project.

## A note on the code

These files match the book exactly, which means they are **deliberately imperfect**.
Each one uses only what has been taught up to that point. For example, verses
say "1 bottles" until the singular case is handled.
That is the book working as intended, not a bug to fix.
