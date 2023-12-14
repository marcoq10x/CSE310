 # import the os module to later clear the screen
import os

# clear terminal screen
os.system("cls")

 # set variables for colored letters 
H = "\033[1;32mH\033[00m"  #green W
e = "\033[1;37me\033[00m"  # gray e
W = "\033[1;34mW\033[00m"  # blue H
o = "\033[1;36mo\033[00m"  # aquamarine o
r = "\033[1;31mr\033[00m"  # red r
l = "\033[1;33ml\033[00m"  # yellow l
d =  "\033[1;35md\033[00m"  # violet d
ep =  "\033[1;30m!\033[00m"  # black exclamation point !

# multicolor hello world
print(f"{H}{e}{l}{l}{o} {W}{o}{r}{l}{d}{ep}")


print('\033[33mHello, world!\033[0m') # yellow
print('\033[34mHello, world!\033[0m') # blue
print('\033[31mHello, world!\033[0m') # red
print('\033[35mHello, world!\033[0m') # purple
print('\033[36mHello, world!\033[0m') # cyan
print('\033[37mHello, world!\033[0m') # gray
print('\033[30mHello, world!\033[0m')  # black
print('\033[32mHello, world!\033[0m') # green



print(r"""
 _    _      _ _
| |  | |    | | |
| |__| | ___| | | ___
|  __  |/ _ \ | |/ _ \
| |  | |  __/ | | (_) |
|_|  |_|\___|_|_|\___/

""")


import turtle

# Create a turtle object
unique_turtle = turtle.Turtle()

# Customize the turtle's appearance
unique_turtle.shape("turtle")
unique_turtle.color("green")

# Write "Hello, World!" in a unique pattern
unique_turtle.penup()
unique_turtle.goto(-50, 0)
unique_turtle.pendown()
unique_turtle.write("Hello,", align="center", font=("Arial", 24, "bold"))
unique_turtle.penup()
unique_turtle.goto(50, -50)
unique_turtle.pendown()
unique_turtle.write("World!", align="center", font=("Arial", 24, "bold"))

# Close the turtle graphics window when clicked
turtle.exitonclick()

