from reis import Reis
from binary_tree import BinaryTree

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

new_reis = Reis(6, "2025-10-16", "Львів", "Чернівці", "09:30", "12:00")
reisy.append(new_reis)
del reisy[0]
reisy[0].arrival = "Кропивницький"

print("=== Пошук рейсу з номером 3 ===")
for r in reisy:
    if r.number == 3:
        r.info()

tree = BinaryTree()
for r in reisy:
    tree.insert(r)

print("=== Центрований (inorder) обхід дерева ===")
tree.inorder(tree.root)
