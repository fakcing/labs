from bll.entity_service import EntityService
from dal.entity_context import EntityContext
from models.product import Product
from datetime import datetime

class Menu:
    def __init__(self):
        self.context = EntityContext()
        self.service = EntityService(self.context)

    def main_menu(self):
        while True:
            print("\n1. Додати товар")
            print("2. Показати всі товари")
            print("3. Зберегти товари")
            print("4. Завантажити товари")
            print("5. Вихід")
            choice = input("Оберіть дію: ")

            if choice == "1":
                name = input("Назва: ")
                code = input("Код: ")
                manufacture_date = datetime.strptime(input("Дата виготовлення (YYYY-MM-DD): "), "%Y-%m-%d")
                shelf_life = int(input("Термін придатності (днів): "))
                product = Product(name, code, manufacture_date, shelf_life)
                self.service.add_product(product)
            elif choice == "2":
                for p in self.service.get_all_products():
                    print(p)
                    print("Придатний:", "Так" if p.is_consumable() else "Ні")
                    print("Кінцевий строк:", p.expiry_date())
            elif choice == "3":
                file_path = input("Введіть ім'я файлу для збереження: ")
                type_ = input("Тип серіалізації (json/binary): ").lower()
                self.context.provider_type = type_
                self.context.save(file_path)
            elif choice == "4":
                file_path = input("Введіть ім'я файлу для завантаження: ")
                type_ = input("Тип серіалізації (json/binary): ").lower()
                self.context.provider_type = type_
                self.context.load(file_path, Product)
            elif choice == "5":
                break
