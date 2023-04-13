import pygame, sys
from animation import Animation
from component import Component
from pygame.locals import *

pygame.init()

displaySurface = pygame.display.set_mode((960, 540))
pygame.display.set_caption('Hello World!')

white = (255,255,255)

object = Animation("animations")

while True:

    displaySurface.fill(white);

    for event in pygame.event.get():
        if event.type == QUIT:
            pygame.quit()
            sys.exit()
 
    pygame.display.update()