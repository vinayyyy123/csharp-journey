# Day 03 - Data Types

| Data Type | Stores | Size |
|-----------|---------|------|
| bool | true / false | 1 byte |
| byte | Whole numbers (0 to 255) | 1 byte |
| char | Single character ('A') | 2 bytes |
| short | Small whole numbers | 2 bytes |
| int | Whole numbers | 4 bytes |
| long | Large whole numbers | 8 bytes |
| float | Decimal numbers | 4 bytes |
| double | Decimal numbers | 8 bytes |
| decimal | High-precision decimal numbers (Money) | 16 bytes |
| string | Text | Variable size |

---

## Easy Memory Notes

### bool
Stores only two values.

```csharp
bool isPassed = true;
bool isActive = false;
```

**Memory Trick:** Yes / No

---

### byte
Stores small positive whole numbers.

```csharp
byte age = 25;
```

**Memory Trick:** Small Number

---

### char
Stores a single character.

```csharp
char grade = 'A';
char firstLetter = 'V';
```

**Memory Trick:** One Character

---

### short
Stores small whole numbers.

```csharp
short score = 1000;
```

**Memory Trick:** Small Integer

---

### int
Stores whole numbers.

```csharp
int age = 24;
int quantity = 100;
```

**Memory Trick:** Whole Number

---

### long
Stores very large whole numbers.

```csharp
long population = 1400000000;
```

**Memory Trick:** Big Integer

---

### float
Stores decimal numbers.

```csharp
float height = 5.8f;
```

**Memory Trick:** Small Decimal

---

### double
Stores decimal numbers.

```csharp
double percentage = 85.5;
double salary = 25000.75;
```

**Memory Trick:** Decimal Number

---

### decimal
Stores money values accurately.

```csharp
decimal amount = 9999.99m;
```

**Memory Trick:** Money Data Type

---

### string
Stores text.

```csharp
string name = "Vinay";
string city = "Vadodara";
```

**Memory Trick:** Text

---

## Simple Example

```csharp
string name = "Vinay";
int age = 24;
double percentage = 85.5;
char grade = 'A';
bool isPassed = true;

Console.WriteLine(name);
Console.WriteLine(age);
Console.WriteLine(percentage);
Console.WriteLine(grade);
Console.WriteLine(isPassed);
```

### Output

```text
Vinay
24
85.5
A
True
```

---

## Quick Revision

```text
bool    -> True / False       -> 1 byte
byte    -> Small Number       -> 1 byte
char    -> Single Character   -> 2 bytes
short   -> Small Integer      -> 2 bytes
int     -> Whole Number       -> 4 bytes
long    -> Large Number       -> 8 bytes
float   -> Decimal Number     -> 4 bytes
double  -> Decimal Number     -> 8 bytes
decimal -> Money Values       -> 16 bytes
string  -> Text               -> Variable Size
```

---

## Most Used In Daily Projects

```text
string
int
double
decimal
bool
DateTime
```

These are the data types you'll use most often in ASP.NET Core, MVC, SQL Server, and enterprise applications.

---

## Day 03 Status

✅ Learned Data Types

✅ Learned Variable Storage

✅ Practiced bool, char, int, double, decimal, string

✅ Created Multiple Real-World Examples