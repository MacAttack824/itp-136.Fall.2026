# Review of the current C# files

Your repository name says C programming, but all eight program files are C#. The projects target .NET 10. Your completed exercises progress from console input to arithmetic, decisions, loops, and methods, so a small checkout application is a suitable next practice assignment.

## Suggestions

- **HomeworkWeek2.2/Program.cs, line 13:** `ReadLine()` can return null, and the name can be blank. Check the input before greeting the patient. Nullable reference checking is enabled in this project.
- **module.3.HW/Program.cs, lines 20–28:** `double.Parse` throws for invalid input. Practice `TryParse` with a retry loop, and reject negative costs. Prefer `decimal` for money.
- **module.4.HW/Program.cs, lines 18, 28, and 41:** Input comparisons require exact lowercase text. Trim input and normalize its case. Invalid child/adult input currently ends that branch without showing a bill; an invalid labs answer silently behaves like no. Validate both answers.
- **module.4.HW/Program.cs, lines 33–67:** The child and adult branches repeat the labs question and surcharge. Determine the base charge first, then handle labs once. Methods can help with this now that you have covered them.
- **module.5.HW/Program.cs, line 33:** The loop begins at `startNumber + 1`, so it skips the starting number. The comment says to count from the starting number. Confirm your instructor's intent: for inclusive counting, begin at `startNumber` and use `endNumber - startNumber + 1` for the count. Your current count matches the numbers your current loop prints.
- **module.6.HW.methods/Program.cs, lines 43 and 56:** Conversion methods can throw for nonnumeric input. Validate measurements and explain whether the tax rate should be entered as `6` or `0.06`. Consider names such as `WelcomeStatement`, `AskNumber`, and `FindArea` to follow the usual PascalCase method convention.
- **module.3.HW, module.4.HW, module.5.HW, and module.6.HW.methods:** `ReadKey()` requires an interactive console and complicates redirected-input checks. These programs can finish without a keypress pause.
- **classwork.9.16/Program.cs:** The active digit switch covers 0–9. The earlier commented sorting example does not cover equal first and second numbers; account for ties if you return to that exercise.
- **CloneCW/CloneCW/Program.cs and module.6.CW.Videopractice/Program.cs:** These are still Hello World placeholders.

The suggested assignment is in [practice.repair.checkout/ASSIGNMENT.md](practice.repair.checkout/ASSIGNMENT.md), with a compiling starter and expected results. Existing coursework has been left unchanged. This review is based on source inspection; it does not establish that the existing assignments satisfy every instructor requirement.
