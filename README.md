# NU Code Challenge!
Welcome to my **CapitalGains** command line code challenge project that calculates how much tax you should pay based on the profit or losses of a stock market investment and these are the two ways to run the project: 

## Command Line
The first one is to execute the project in your terminal **C:\\>CapitalGains.exe** then you will see the **Input:** word, now you can paste your JSON string. 
Please follow this pattern even if it is only one operation and **do not cut the string into parts with new lines** `\n`, if you want to work with multiple JSON strings do it in a single line.

```
[{"operation":"buy","unit-cost":10.00,"quantity":10000},{"operation":"sell","unit-cost":20.00,"quantity":5000},{"operation":"sell","unit-cost":5.00,"quantity":5000}]
```

![image](https://github.com/Najmna/Payment/assets/80434655/ee5497e6-b4fe-4c45-af7a-2d2537c84a42)

## Text File
The second one is to execute the project also in your terminal but with the name of the file (that contains the JSON strings) as an argument **C:\\>CapitalGains.exe input.txt**, as you can see there is no need to use ~~Input Redirection~~, so avoid the use of `<`. For the JSON strings in your file, follow the same instructions above, but here you can have multiple ones with the use of new line `\n`.

```
[{"operation":"buy","unit-cost":10.00,"quantity":100},{"operation":"sell","unit-cost":15.00,"quantity":50},{"operation":"sell","unit-cost":15.00,"quantity":50}]
[{"operation":"buy","unit-cost":10.00,"quantity":10000},{"operation":"sell","unit-cost":20.00,"quantity":5000},{"operation":"sell","unit-cost":5.00,"quantity":5000}]
```

## Unit Test
There is a Unit Test project along with the main one where you can run some tests. This project was created in **Visual Studio** using **.NET 7.0** with **MSTest**, so you only need to go to **View > Test Explorer** and run the tests.

![image](https://github.com/Najmna/Payment/assets/80434655/b824e886-6674-4b09-9395-f7fe00423193)

> [!NOTE]
> In the ZIP file you will see 2 folder the **CapitalGains** is the main project and the **CapitalGainsTest** is the Unit Test project.

Please, enjoy!
