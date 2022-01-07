from tkinter import *
from PIL import ImageTk, Image

root = Tk(className="button_click_label")
root.geometry("200x200")


def press(x):
    if x == 1:
        l1.config(text='hello')
    else:
        l1.config(text='hi')


b1 = Button(root, text="click me", command=lambda: press(1)).pack()
b2 = Button(root, text='click me', command=lambda: press(2)).pack()

l1 = Label(root, text="waiting for click")
l1.pack()

root.mainloop()






# ekran = Tk()
# ekran2 = Tk()
# ekran.title("Denemeler")
#
#
#
# # img = ImageTk.PhotoImage(Image.open("img/robot_arm.jpg"))
# # img_label=Label(image=img)
# # img_label.pack()
#
#
# # Etiket1 = Label(ekran, text = "Test").grid(row=0,column=0)
# # Etiket2 = Label(ekran, text = "Berkin").grid(row=1,column=0)
# # giris = Entry(ekran, width=50,).grid(row=2,column=0)
# #
# #
# # def click():
# #     etiket3 = Label(ekran2,text=giris.get())
# #     etiket3.pack()
# #
# # # buton = Button(ekran,text="Buton", state=DISABLED, padx=50).grid(row=2,column=0)
# # buton = Button(ekran,text="Buton", padx=50, command=click).grid(row=3,column=0)
#
#
#
# Etiket1 = Label(ekran, text = "Test")
# Etiket1.pack()
# Etiket2 = Label(ekran, text = "Berkin")
# Etiket2.pack()
#
# giris = Entry(ekran, width=50,)
# giris.pack()
# giris.insert(0,"Data")
#
#
# def click():
#     etiket3 = Label(ekran,text=giris.get())
#     etiket3.pack()
#
# # buton = Button(ekran,text="Buton", state=DISABLED, padx=50).grid(row=2,column=0)
# buton = Button(ekran,text="Buton", padx=50, command=click)
# buton.pack()
#
#
#
#
# ekran.mainloop()