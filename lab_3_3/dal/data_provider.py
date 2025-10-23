import json
import pickle
from datetime import datetime

class JSONProvider:
    @staticmethod
    def save(file_path, data):
        with open(file_path, "w", encoding="utf-8") as f:
            json.dump([vars(d) for d in data], f, ensure_ascii=False, indent=4, default=str)

    @staticmethod
    def load(file_path, cls):
        with open(file_path, "r", encoding="utf-8") as f:
            items = json.load(f)
            result = []
            for i in items:
                i['manufacture_date'] = datetime.strptime(i['manufacture_date'], '%Y-%m-%d %H:%M:%S')
                result.append(cls(**i))
            return result

class BinaryProvider:
    @staticmethod
    def save(file_path, data):
        with open(file_path, "wb") as f:
            pickle.dump(data, f)

    @staticmethod
    def load(file_path):
        with open(file_path, "rb") as f:
            return pickle.load(f)
