class Entity:

    def __init__(self):
        self.components = []

    def add(self, com):
        pass

    def remove(self, com):
        pass

    def update(self):
        for com in self.components:
            com.update()

