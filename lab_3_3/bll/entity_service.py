class EntityService:
    def __init__(self, context):
        self.context = context

    def add_product(self, product):
        self.context.add(product)

    def remove_product(self, code):
        self.context.remove(code)

    def get_all_products(self):
        return self.context.data
