# SoftUni-Fundamentals-Exercises
Here are all of my exercises during the Programing Fundamentals Course in SoftUni.

1. Exercise: Intro and Basic Syntax
Problems for exercises and homework for the "C# Fundamentals" course @ SoftUni

1.1	Ages

Write a program that determines if a person is baby, child, teenager, adult or elder based on the given age. The boundaries are:
•	0-2 – baby
•	3-13 – child
•	14-19 – teenager
•	20-65 – adult
•	>= 66 – elder
•	All the values are inclusive.


1.2	Divison

You will be given an integer, write a program which checks if the given integer is divisible by 2 or 3,  or 6, or 7, or 10 without a reminder. You should always take the bigger division:
•	If the number is divisible by both 2, 3, and 6, you should print the division by 6 only. 
•	If a number is divisible by 2 and 10, you should print the division by 10. 
If the number is not divisible by any of the given numbers, print "Not divisible". Otherwise, print "The number is divisible by {number}".


1.3	Vacation

You will receive three lines from the console:
•	A count of people who are going on vacation.
•	Type of the group (Students, Business or Regular).
•	The day of the week which the group will stay on (Friday, Saturday or Sunday).
Based on the given information calculate how much the group will pay for the entire vacation. 
The price for a single person is as follows:
		Friday		Saturday	Sunday
Students	8.45		9.80		10.46
Business	10.90		15.60		16
Regular		15		20		22.50
There are also discounts based on some conditions:
•	For Students – if the group is 30 or more people, you should reduce the total price by 15%.
•	For Business – if the group is 100 or more people, 10 of the people stay for free.
•	For Regular – if the group is between 10 and 20  people (both inclusively), reduce the total price by 5%.
Note: You should reduce the prices in that EXACT order!
As an output print the final price which the group is going to pay in the format: 
"Total price: {price}" 
The price should be formatted to the second decimal point.


1.4	Print and Sum
You will receive two whole numbers from the console representing the start and the end of a sequence of numbers. 
Your task is to print two lines:
•	On the first line, print all numbers from the start of the sequence to the end inclusive
•	On the second line, print the sum of the sequence in the format: "Sum: {sum}"


1.5	Login
On the first line, you will be given a username and your task is to try to log in the user. The user's password is the username reversed. On the next lines, you will receive passwords:
•	If the password is incorrect, print "Incorrect password. Try again.".
•	If the password is correct, print "User {username} logged in." and stop the program.
Keep in mind that if the password is still incorrect on the fourth attempt, you should print: "User {username} blocked!".
Then the program stops.


1.6	Strong Number
Write a program that receives a single integer and calculates if it's strong or not. A number is strong, if the sum of the factorials of each digit is equal to the number itself.
Example: 145 is a strong number, because 1! + 4! + 5! = 145. 
Print "yes", if the number is strong and "no", if the number is not strong.


1.7	Vending Machine
Write a program that accumulates coins. Until the "Start" command is given, you will receive coins, and only the valid ones should be accumulated. Valid coins are:
•	0.1, 0.2, 0.5, 1 and 2
If an invalid coin is inserted, print "Cannot accept {money}" and continue to the next line.
On the next lines, until the "End" command is given, you will start receiving products, which a customer wants to buy. The vending machine has only:
•	"Nuts" with a price of 2.0
•	"Water" with a price of 0.7
•	"Crisps" with a price of 1.5
•	"Soda" with a price of 0.8
•	"Coke" with a price of 1.0
If the customer tries to purchase a not existing product, print "Invalid product".
When a customer has enough money to buy the selected product, print "Purchased {product name}", otherwise print "Sorry, not enough money" and continue to the next line.
When the "End" command is given print the reminding balance, formatted to the second decimal point: "Change: {money left}".


2. Lab: Objects and Classes
Problems for in-class lab for the "C# Fundamentals" course @ SoftUni

2.1 Randomize Words
You will be given a string that will contain words separated by a single space. Randomize their order and print each
word on a new line

2.2 Big Factorial
You will receive a number N in the range [0…1000]. Calculate the Factorial of N and print out the result.

II. Defining Simple Classes
2.3 Songs
Define a class called Song that will hold the following information about some songs:
• Type List
• Name
• Time
Input / Constraints
• On the first line, you will receive the number of songs - N.
• On the next N lines, you will be receiving data in the following format: "{typeList}_{name}_{time}".
• On the last line, you will receive Type List or "all".
Output
If you receive Type List as an input on the last line, print out only the names of the songs, which are from that Type
List. If you receive the "all" command, print out the names of all the songs.

2.4  Students
Define a class called Student, which will hold the following information about some students:
• first name
• last name
• age
• home town
Input / Constraints
Read information about some students, until you receive the "end" command. After that, you will receive a city
name.
Output
Print the students who are from the given city in the following format: "{firstName} {lastName} is {age}
years old."

2.5 Students 2.0
Use the class from the previous problem. If you receive a student, which already exists (first name and last name
should be unique) overwrite the information.


2.6 Store Boxes
Define a class Item, which contains these properties: Name and Price.
Define a class Box, which contains these properties: Serial Number, Item, Item Quantity and Price for a Box.
Until you receive "end", you will be receiving data in the following format: "{Serial Number} {Item Name} {Item Quantity} {itemPrice}"
The Price of one box has to be calculated: itemQuantity * itemPrice.
Print all the boxes ordered descending by price for a box, in the following format: 
{boxSerialNumber}
-- {boxItemName} – ${boxItemPrice}: {boxItemQuantity}
-- ${boxPrice}
The price should be formatted to the 2nd digit after the decimal separator.


2.7 Vehicle Catalogue
Your task is to create a Vehicle catalog, which contains only Trucks and Cars.
Define a class Truck with the following properties: Brand, Model, and Weight.
Define a class Car with the following properties: Brand, Model, and Horse Power.
Define a class Catalog with the following properties: Collections of Trucks and Cars.
You must read the input, until you receive the "end" command. It will be in following format: "{type}/{brand}/{model}/{horse power / weight}"
In the end, you have to print all of the vehicles ordered alphabetical by brand, in the following format:
"Cars:
{Brand}: {Model} - {Horse Power}hp
Trucks:
{Brand}: {Model} - {Weight}kg"

3. Objects and Classes - Exercise
Problems for exercise and homework for the "C# Fundamentals" course @ SoftUni

3.1 Advertisement Message
Create a program that generates random fake advertisement messages to advertise a product. The messages must consist of 4 parts: phrase + event + author + city. Use the following predefined parts:
•	Phrases – {"Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can't live without this product."}
•	Events – {"Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!"}
•	Authors – {"Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva"}
•	Cities – {"Burgas", "Sofia", "Plovdiv", "Varna", "Ruse"}
The format of the output message is the following: "{phrase} {event} {author} – {city}."
You will receive the number of messages to be generated. Print each random message at a separate line.

3.2  Articles
Create a class Article with the following properties:
•	Title – a string
•	Content – a string
•	Author – a string
The class should have a constructor and the following methods:
•	Edit (new content) – change the old content with the new one
•	ChangeAuthor (new author) – change the author
•	Rename (new title) – change the title of the article
•	Override the ToString method – print the article in the following format: 
"{title} - {content}: {author}"
Create a program that reads an article in the following format "{title}, {content}, {author}". 
On the next line, you will receive a number n, representing the number of commands, which will follow after it. 
On the next n lines, you will be receiving the following commands: 
•	"Edit: {new content}"
•	"ChangeAuthor: {new author}"
•	"Rename: {new title}"
In the end, print the final state of the article.

3.3  Articles 2.0
Change the program from the previous problem in such a way, that you will be able to store a list of articles. 
You will not need to use the previous methods anymore (except the "ToString()"). On the first line, you will receive the number of articles. 
On the next lines, you will receive the articles in the same format as in the previous problem: "{title}, {content}, {author}". Print the articles. 

3.4 Students
Create a program that sorts some students by their grade in descending order. Each student should have:
•	First name (String)
•	Last name (String)
•	Grade (a floating-point number)
Input
•	On the first line, you will receive a number n - the count of all students.
•	On the next n lines, you will be receiving information about these students in the following format: "{first name} {second name} {grade}".
Output
•	Print out the information about each student in the following format: "{first name} {second name}: {grade}".






