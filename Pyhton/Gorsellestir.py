import cv2
import numpy as np
import glob

img_array = []
for filename in sorted(glob.glob('data/*.png')):
    img = cv2.imread(filename)
    height, width, layers = img.shape
    size = (width, height)
    img_array.append(img)

# out = cv2.VideoWriter('project.avi', cv2.VideoWriter_fourcc(*'DIVX'), 8, size)
out = cv2.VideoWriter('mobile_envelope.mp4', cv2.VideoWriter_fourcc(*'mp4v'), 8, size)

for i in range(len(img_array)):
    out.write(img_array[i])
out.release()