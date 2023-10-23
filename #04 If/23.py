x1 = int(input())
y1 = int(input())
x2 = int(input())
y2 = int(input())
x3 = int(input())
y3 = int(input())
center_x = (x1 + x2 + x3) / 3
center_y = (y1 + y2 + y3) / 3
x4 = 2 * center_x - x1 - x2 - x3
y4 = 2 * center_y - y1 - y2 - y3
print(x4)
print(y4)