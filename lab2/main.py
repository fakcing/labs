from datetime import datetime, timedelta

# -----------------------------
# Клас Рейс
# -----------------------------
class Reis:
    def __init__(self, number, date, departure, arrival, time_out, time_in):
        self.number = number
        self.date = date
        self.departure = departure
        self.arrival = arrival
        self.time_out = time_out
        self.time_in = time_in

    def duration(self):
        t1 = datetime.strptime(self.time_out, "%H:%M")
        t2 = datetime.strptime(self.time_in, "%H:%M")
        d = t2 - t1
        if d.days < 0:
            d = timedelta(days=1) + d
        return d

    def time_since_end(self):
        now = datetime.now()
        end = datetime.strptime(self.date + " " + self.time_in, "%Y-%m-%d %H:%M")
        return now - end

    def info(self):
        print("Рейс №", self.number)
        print("Маршрут:", self.departure, "->", self.arrival)
        print("Час виїзду:", self.time_out, "Час прибуття:", self.time_in)
        print("Тривалість:", self.duration())
        print("--------------------------")

# -----------------------------
# Масиви та колекції
# -----------------------------
reisy = [
    Reis(1, "2025-10-15", "Київ", "Львів", "08:00", "12:00"),
    Reis(2, "2025-10-15", "Львів", "Одеса", "13:00", "21:00"),
    Reis(3, "2025-10-15", "Харків", "Київ", "06:30", "10:00"),
    Reis(4, "2025-10-15", "Дніпро", "Харків", "09:00", "11:30"),
    Reis(5, "2025-10-15", "Київ", "Одеса", "07:00", "14:30")
]

print("=== Всі рейси ===")
for r in reisy:
    r.info()

# Додавання нового рейсу
new_reis = Reis(6, "2025-10-16", "Львів", "Чернівці", "09:30", "12:00")
reisy.append(new_reis)

# Видалення (наприклад першого)
del reisy[0]

# Оновлення (змінимо пункт прибуття)
reisy[0].arrival = "Кропивницький"

# Пошук
print("=== Пошук рейсу з номером 3 ===")
for r in reisy:
    if r.number == 3:
        r.info()

# -----------------------------
# Бінарне дерево (просте)
# -----------------------------
class Node:
    def __init__(self, value):
        self.value = value
        self.left = None
        self.right = None

class BinaryTree:
    def __init__(self):
        self.root = None

    def insert(self, value):
        if self.root == None:
            self.root = Node(value)
        else:
            self._insert(self.root, value)

    def _insert(self, node, value):
        if value.number < node.value.number:
            if node.left == None:
                node.left = Node(value)
            else:
                self._insert(node.left, value)
        else:
            if node.right == None:
                node.right = Node(value)
            else:
                self._insert(node.right, value)

    def inorder(self, node):
        if node != None:
            self.inorder(node.left)
            print("Рейс №", node.value.number, node.value.departure, "->", node.value.arrival)
            self.inorder(node.right)

# -----------------------------
# Створення дерева
# -----------------------------
tree = BinaryTree()
for r in reisy:
    tree.insert(r)

print("=== Центрований (inorder) обхід дерева ===")
tree.inorder(tree.root)
