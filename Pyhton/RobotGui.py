from tkinter import *
from PIL import ImageTk, Image

X=0
Y=0
Aci=0

def XArti(X):
    X += 1
    lblX.config(text="X koordinatı :"+str(X))
def XEksi(X):
    X -= 1
    lblX["text"] = "X koordinatı :" + str(X)
def YArti(Y):
    Y += 1
    lblY["text"] = "Y koordinatı :" + str(Y)
def YEksi(Y):
    Y -= 1
    lblY["text"] = "Y koordinatı :" + str(Y)
def AciArti(Aci):
    Aci += 1
    lblAci["text"] = "Aci :" + str(Aci)
def AciEksi(Aci):
    Aci -= 1
    lblAci["text"] = "Aci :" + str(Aci)



ekran = Tk()
ekran.title("Robot Kol Arayüzü")
ekran.geometry("400x400")

#
# lblBaslik1 = Label(ekran, text="Koordinat Değişimi").grid(row=0,column=0)
# lblBaslik2 = Label(ekran, text="Açısal Değişimi").grid(row=0,column=2)
#
# lblX = Label(ekran, text = "X koordinatı :"+str(X)).grid(row=1,column=0)
# lblY = Label(ekran, text = "Y koordinatı :"+str(Y)).grid(row=1,column=1)
# lblAci = Label(ekran, text = "Açı :"+str(Aci)).grid(row=1,column=2)


lblBaslik1 = Label(ekran, text="Koordinat Değişimi").pack()
lblBaslik2 = Label(ekran, text="Açısal Değişimi").pack()

lblX = Label(ekran, text = "X koordinatı :"+str(X))
lblY = Label(ekran, text = "Y koordinatı :"+str(Y))
lblAci = Label(ekran, text = "Açı :"+str(Aci))

lblX.pack()
lblY.pack()
lblAci.pack()





# btXarti= Button(ekran,text="X +", padx=50, command=lambda:XArti(X)).grid(row=2,column=0)
# btXeksi= Button(ekran,text="X -", padx=50, command=lambda:XEksi(X)).grid(row=3,column=0)
# btYarti= Button(ekran,text="Y +", padx=50, command=lambda:YArti(Y)).grid(row=2,column=1)
# btYeksi= Button(ekran,text="Y -", padx=50, command=lambda:YEksi(Y)).grid(row=3,column=1)
# btAciArti= Button(ekran,text="Açı +", padx=50, command=lambda:AciArti(Aci)).grid(row=2,column=2)
# btAciEksi= Button(ekran,text="Açı -", padx=50, command=lambda:AciEksi(Aci)).grid(row=3,column=2)

btXarti= Button(ekran,text="X +", padx=50, command=lambda:XArti(X)).pack()
btXeksi= Button(ekran,text="X -", padx=50, command=lambda:XEksi(X)).pack()
btYarti= Button(ekran,text="Y +", padx=50, command=lambda:YArti(Y)).pack()
btYeksi= Button(ekran,text="Y -", padx=50, command=lambda:YEksi(Y)).pack()
btAciArti= Button(ekran,text="Açı +", padx=50, command=lambda:AciArti(Aci)).pack()
btAciEksi= Button(ekran,text="Açı -", padx=50, command=lambda:AciEksi(Aci)).pack()










ekran.mainloop()