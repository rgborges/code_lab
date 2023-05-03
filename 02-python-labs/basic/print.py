# this script explores the print function
# print a simple message
print('Hello world')

# printing variables 
print("Example 02 - printing a string")
name = "rafael"
print("Hello " + name)

print("Example 03 - printing an array using loop")
ages = [1, 24, 4, 453, 6, 454]
for i in range(len(ages)):
    print(ages[i])


print("Example 04 - Printing directly an array object")
print(ages)

print("Example 05 - Printing float numbers in screen")
apple_price = 12.90
print(f'the apple price is $ {apple_price}')

# or
print('the price of the apple using the format is {}'.format(apple_price))
# print using interoplation

# printing a table

print("Example 6 - printing a table")
accounts = {'Mary' : 234.90, 'John' : 34565.90 }
print('Print the Mary account:: {Mary:f}'.format(**accounts))