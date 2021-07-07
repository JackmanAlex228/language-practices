a = input("Enter length of side a: ")
b = input("Enter length of side b: ")
c = input("Enter length of side c: ")

if a == b == c:
    print("This triangle is equalidral")
if a == b or a == c or b == c:
    print("This triangle is isosceles")
if a != b and a != c and b != c:
    print("This triangle is scalene")
    
# Do more input validation and error checking