# NUBANK Code Challenge!
Hello, these are the instructions to run the **CapitalGains** project. The following are the two ways to read the JSON string: 

## Command Line
The first one is to execute the project in your terminal **C:\\>CapitalGains.exe** then you will see the **Input:** word, now you can paste your JSON string. 
Please follow this pattern even if it is only one operation and **do not cut the string in parts with new lines** `\n`.

```
[{"operation":"buy","unit-cost":10.00,"quantity": 10000},{"operation":"sell","unit-cost":20.00,"quantity":5000},{"operation":"sell","unit-cost":5.00,"quantity":5000}]
```

![image](https://github.com/Najmna/Payment/assets/80434655/ee5497e6-b4fe-4c45-af7a-2d2537c84a42)

## Text File
The second one is to execute the project also in your terminal but with the name of the file (that contains the JSON string) as an argument  **C:\\>CapitalGains.exe input.txt**, as you can see there si no need to use ~~Input Redirection~~, so avoid the use of `<`.
