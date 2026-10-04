# C# practice assignment: Mac of All Trades Checkout

This suggested practice assignment builds on your module 3 repair bill, module 4 menus, module 5 loops, and module 6 methods. It is not an official course assignment.

## Goal

Build a console program that lets a customer add services to a bill, then prints a receipt. Use a class with `static Main` and static methods, as in your existing projects. No arrays, databases, or additional classes are required.

## Requirements

1. Display a greeting and ask for the customer's name. Reject blank names.
2. Repeatedly display this menu using a loop:

   | Choice | Service | Price |
   | --- | --- | --- |
   | 1 | Oil change | $40.00 |
   | 2 | Tire rotation | $30.00 |
   | 3 | Inspection | $20.00 |
   | 4 | Checkout | — |

3. Read a whole-number menu choice. Use `int.TryParse` and a loop to reject blank input, text, and numbers outside 1–4 without crashing.
4. Use a `switch` statement to process the choice. Each selection of 1–3 adds one service to the subtotal and increments the service count. Customers may select a service more than once. Choice 4 ends the ordering loop.
5. At checkout, ask whether the customer has a coupon. Accept `yes` or `no`, ignoring capitalization and surrounding spaces. Repeat the question for any other answer.
6. A coupon gives a 10% discount **only when the subtotal is at least $100.00**. Otherwise the discount is zero.
7. Calculate a fictional 6% tax on the subtotal **after** subtracting the discount. These prices and tax rules are for practice.
8. Print the customer's name, service count, original subtotal, discount, tax, and final total. Format all money with two decimal places using currency formatting (`C2`). The examples assume US currency formatting.
9. Checkout with no services must produce a count of zero and zero for all money amounts.

Use `decimal` for money and decimal literals such as `40m`, `0.10m`, and `0.06m`. Round the discount and tax to two places with `Math.Round(value, 2, MidpointRounding.AwayFromZero)` before calculating the final total.

## Required methods

Keep the ordering loop and calls to these methods in `Main`:

```csharp
static void WelcomeStatement()
static int ReadMenuChoice()
static decimal GetServicePrice(int choice)
static decimal CalculateDiscount(decimal subtotal, bool hasCoupon)
static decimal CalculateTax(decimal taxableAmount)
static void PrintReceipt(string customerName, int serviceCount,
    decimal subtotal, decimal discount, decimal tax)
```

`GetServicePrice` should use a switch and return zero for checkout. Calculation methods should return values without reading input or printing. `PrintReceipt` calculates the final total from its arguments and prints the receipt. You may add methods for reading a name or coupon answer.

## Suggested order

1. Implement the greeting, name prompt, and menu input validation.
2. Implement service prices and the ordering loop.
3. Implement discount and tax calculations.
4. Implement the receipt and check the cases below.

## Check your results

Each row describes a separate run. Menu inputs are entered one at a time; 4 means checkout.

| Menu inputs | Coupon | Count | Subtotal | Discount | Tax | Total |
| --- | --- | --- | --- | --- | --- | --- |
| 1, 2, 3, 4 | yes | 3 | $90.00 | $0.00 | $5.40 | $95.40 |
| 1, 1, 3, 4 | yes | 3 | $100.00 | $10.00 | $5.40 | $95.40 |
| 1, 1, 3, 4 | no | 3 | $100.00 | $0.00 | $6.00 | $106.00 |
| 1, 1, 2, 3, 4 | yes | 4 | $130.00 | $13.00 | $7.02 | $124.02 |
| 4 | yes | 0 | $0.00 | $0.00 | $0.00 | $0.00 |

Also try a blank name; menu entries `hello`, blank, `0`, `5`, and `2.5`; and coupon entries `maybe` and ` YES `. Invalid input must not change the subtotal or count. ` YES ` must be accepted.

## Suggested rubric (100 points)

| Area | Points |
| --- | --- |
| Greeting and validated customer name | 10 |
| Repeating menu and input validation | 20 |
| Switch, service prices, count, and subtotal | 20 |
| Required methods with parameters and return values | 20 |
| Correct discount, tax, rounding, and total | 20 |
| Clear receipt, naming, and readable code | 10 |

## Starter project

From the repository root, run:

```bash
dotnet run --project practice.repair.checkout/practice.repair.checkout.csproj
```

The starter compiles, but its TODOs are intentionally unfinished. Implement them before checking the expected results. Submit your completed `Program.cs` and a short record of the five runs above and your invalid-input checks.
