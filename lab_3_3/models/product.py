from datetime import datetime, timedelta
import json

class Product:
    def __init__(self, name, code, manufacture_date, shelf_life_days):
        self.name = name
        self.code = code
        self.manufacture_date = manufacture_date  # datetime об'єкт
        self.shelf_life_days = shelf_life_days

    def is_consumable(self):
        """Перевірка, чи товар придатний до споживання сьогодні"""
        return datetime.now() <= self.manufacture_date + timedelta(days=self.shelf_life_days)

    def expiry_date(self):
        """Повертає кінцеву дату реалізації"""
        return self.manufacture_date + timedelta(days=self.shelf_life_days)

    def __str__(self):
        return f"Назва: {self.name}, Код: {self.code}, Дата виготовлення: {self.manufacture_date.date()}, Термін придатності: {self.shelf_life_days} днів"
