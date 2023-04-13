import os
from component import Component

class Animation(Component):

    def __init__(self, path="", fps = 12):
        self.path = path
        self.images = []
        self.fps = fps
        self.currentFrameNumber = 0
        self. __loadImages()

    def __loadImages(self):
    
        for filename in os.listdir("assets/"+self.path):
            f = os.path.join("assets/"+self.path, filename)
            
            if os.path.isfile(f):
                print("fileLoaded")
