from .data_provider import JSONProvider, BinaryProvider
from datetime import datetime

class EntityContext:
    def __init__(self, provider_type="json"):
        self.data = []
        self.provider_type = provider_type

    def add(self, entity):
        self.data.append(entity)

    def remove(self, entity_code):
        self.data = [e for e in self.data if e.code != entity_code]

    def save(self, file_path):
        if self.provider_type == "json":
            JSONProvider.save(file_path, self.data)
        elif self.provider_type == "binary":
            BinaryProvider.save(file_path, self.data)

    def load(self, file_path, cls=None):
        if self.provider_type == "json" and cls:
            self.data = JSONProvider.load(file_path, cls)
        elif self.provider_type == "binary":
            self.data = BinaryProvider.load(file_path)
