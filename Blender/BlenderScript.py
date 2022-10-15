import bpy
from bpy.app.handlers import persistent
import math
import time

from mathutils import Vector
import sys
import serial
import glob
import numpy as np
from threading import Thread
from bpy.app.handlers import persistent


from bpy.types import (Panel, Operator)

# ------------------------------------------------------------------------
#    Operators
# ------------------------------------------------------------------------

ser = serial.Serial()
ser.baudrate = 9600
ser.port = 'COM14'
ser.setDTR(False)


class SimpleOperator(Operator):
    """Print object name in Console"""
    bl_idname = "object.simple_operator"
    bl_label = "Simple Object Operator"

    def execute(self, context):
        print ("Gotovo")
      
        bpy.app.handlers.depsgraph_update_post.remove(ograniciRootZRot)    
        bpy.app.handlers.depsgraph_update_post.remove(ogranici_RotHvataljkaBone)   
        bpy.app.handlers.depsgraph_update_post.remove(ogranici_HvataljkaBone) 
        bpy.app.handlers.depsgraph_update_post.remove(SerialSender)
        bpy.app.handlers.frame_change_post.remove(SerialSender)
        #bpy.app.timers.remove(SerialSender)
        
        raise TypeError('Zaustavljena skripta')
        return {'FINISHED'}
    

# ------------------------------------------------------------------------
#    Panel in Object Mode
# ------------------------------------------------------------------------




class OBJECT_PT_CustomPanel(Panel):
    bl_idname = "object.custom_panel"
    bl_label = "My Panel"
    bl_space_type = "VIEW_3D"   
    bl_region_type = "UI"
    bl_category = "Tools"
    bl_context = "objectmode"   


    @classmethod
    def poll(self,context):
        return context.object is not None

    def draw(self, context):
        layout = self.layout
        obj = context.object


        layout.label(text="Operators:")

        col = layout.column(align=True)
        col.operator(SimpleOperator.bl_idname, text="Execute Something", icon="CONSOLE")

        layout.separator()

# ------------------------------------------------------------------------
#    Registration
# ------------------------------------------------------------------------

def register():
    bpy.utils.register_class(OBJECT_PT_CustomPanel)
    bpy.utils.register_class(SimpleOperator)

def unregister():
    bpy.utils.unregister_class(OBJECT_PT_CustomPanel)
    bpy.utils.unregister_class(SimpleOperator)

if __name__ == "__main__":
    register()
    
    
#Konstante za lakse izmjene granicnih uglova. Uglovi ograniceni na robotu zbog konstrukcije su hard kodovani    
GranicniUgaoHvataljka = 80    
GranicniUgaoRotHvataljka_Desno = 90
GranicniUgaoRotHvataljka_Lijevo = -90
GranicniUgaoBaza = 180


Zglob1Bone = bpy.data.objects["Armature"].pose.bones["Zglob1Bone"]
Zglob2Bone = bpy.data.objects["Armature"].pose.bones["Zglob2Bone"]
Zglob3Bone = bpy.data.objects["Armature"].pose.bones["Zglob3Bone"]

RotBone = bpy.data.objects["Armature"].pose.bones["RottBase"]
RotHvataljkaBone = bpy.data.objects["Armature"].pose.bones["RotHvataljkaBone"]
HvataljkaBone = bpy.data.objects["Armature"].pose.bones["HvataljkaBone"]




def ograniciRootZRot(a,b):
    
    #axis = 'Z'
    
    if(math.degrees(RotBone.rotation_euler[2])>180):
        #bpy.data.objects["Armature"].pose.bones["RottBase"].rotation_euler.rotate_axis(axis, math.radians(angle))
        RotBone.rotation_euler[2]=math.radians(180)
        
    elif(math.degrees(RotBone.rotation_euler[2]) < 0):
        RotBone.rotation_euler[2]=0
    
def ogranici_RotHvataljkaBone(a,b):
    
    #axis = 'Z'
    
    if(math.degrees(RotHvataljkaBone.rotation_euler[1])>GranicniUgaoRotHvataljka_Desno):
        #bpy.data.objects["Armature"].pose.bones["RottBase"].rotation_euler.rotate_axis(axis, math.radians(angle))
        RotHvataljkaBone.rotation_euler[1]=math.radians(GranicniUgaoRotHvataljka_Desno)
        
    elif(math.degrees(RotHvataljkaBone.rotation_euler[1]) < GranicniUgaoRotHvataljka_Lijevo):
        RotHvataljkaBone.rotation_euler[1] = math.radians(GranicniUgaoRotHvataljka_Lijevo)

def ogranici_HvataljkaBone(a,b):
    
    #axis = 'Z'
    
    if(math.degrees(HvataljkaBone.rotation_euler[2])>GranicniUgaoHvataljka):
        #bpy.data.objects["Armature"].pose.bones["RottBase"].rotation_euler.rotate_axis(axis, math.radians(angle))
        HvataljkaBone.rotation_euler[2]=math.radians(GranicniUgaoHvataljka)
        
    elif(math.degrees(HvataljkaBone.rotation_euler[2]) < 0):
        HvataljkaBone.rotation_euler[2]=0

StringToSend = ""

def SerialSender(a,b):
    
    #Dobijanje uglova kostiju
    #matrix.to_euler()[n] se koristi za neaktivne kosti odnosno iz transform panela
    #rotation_euler[n] se koristi za aktivnu kost odnosno kakvo je realno stanje u viewportu
    
    #Dobijanje uglova:
    UgaoRotBone = int((math.degrees(RotBone.rotation_euler[2]))) 
    UgaoZglob1Bone = int((math.degrees(Zglob1Bone.matrix.to_euler()[0]))) 
    UgaoZglob2Bone = int((math.degrees(Zglob2Bone.matrix.to_euler()[0]))) 
    UgaoZglob3Bone = int((math.degrees(Zglob3Bone.matrix.to_euler()[0]))) #X-osa matrix.to_euler()[0]
    UgaoRotHvataljkaBone = int((math.degrees(RotHvataljkaBone.rotation_euler[1])))  #Y-osa rotation_euler[1]
    UgaoHvataljkaBone = int((math.degrees(HvataljkaBone.rotation_euler[2]))) #Z-osa rotation_euler[2]
    
    #Ponistavanje efekata parent kostiju na child kosti
    UgaoZglob2Bone = UgaoZglob2Bone-UgaoZglob1Bone
    UgaoZglob3Bone = UgaoZglob3Bone-UgaoZglob2Bone-UgaoZglob1Bone
    

    #Korigovanje uglova za slanje na Serial
    
    #UgaoZglob1Bone
    if(UgaoZglob1Bone<0): #Ako je neg onda je desna poluravan
        UgaoZglob1Bone = 90 + np.absolute(UgaoZglob1Bone) 
    else:
        UgaoZglob1Bone = 90 - np.absolute(UgaoZglob1Bone)
         
    #UgaoZglob2Bone
    if(UgaoZglob2Bone<0): #Ako je neg onda je desna poluravan
        UgaoZglob2Bone = 90 + np.absolute(UgaoZglob2Bone) 
    else:
        UgaoZglob2Bone = 90 - np.absolute(UgaoZglob2Bone)    
    
    #UgaoZglob3Bone
    if(UgaoZglob3Bone<0): #Ako je neg onda je desna poluravan
        UgaoZglob3Bone = 90 + np.absolute(UgaoZglob3Bone) 
    else:
        UgaoZglob3Bone = 90 - np.absolute(UgaoZglob3Bone)  
        
        
    #Dodatna korekcija
    
    UgaoZglob2Bone =  90 + (90 - UgaoZglob2Bone) 
    UgaoHvataljkaBone = 90 - UgaoHvataljkaBone
    UgaoRotBone = UgaoRotBone + 90
    UgaoRotHvataljkaBone = UgaoRotHvataljkaBone + 90
    

    if bpy.context.scene.frame_current % 25 == 0:
            
        #Kreiranje stringova uglova kostiju
        StringToSend = "Baza:" + str(UgaoRotBone) + " Zglob1:" + str(UgaoZglob1Bone)
        print(StringToSend)
        StringToSend = "Zglob2:" + str(UgaoZglob2Bone) + " Zglob3:" + str(UgaoZglob3Bone)
        print(StringToSend)
        StringToSend = "RotHvataljkaBone:" + str(UgaoRotHvataljkaBone) + " HvataljkaBone:" + str(UgaoHvataljkaBone)
        print(StringToSend)
    
    
    
    StringToSend = str(UgaoRotBone) + "a/" + str(UgaoZglob1Bone) + "b/" + str(UgaoZglob2Bone) + "c/" + str(UgaoZglob3Bone) + "d/" + str(UgaoRotHvataljkaBone) + "e/" + str(UgaoHvataljkaBone) + "f/"
    print(StringToSend)
    

    if(ser.isOpen()!= True):
        
           
        ser.open()
        ser.write(bytes(StringToSend, 'ascii')) 
        print("Poslano: " + str(StringToSend))   
        
        ser.close() 
        return 0.5



bpy.app.handlers.depsgraph_update_post.append(ograniciRootZRot)    
bpy.app.handlers.depsgraph_update_post.append(ogranici_RotHvataljkaBone)   
bpy.app.handlers.depsgraph_update_post.append(ogranici_HvataljkaBone) 
bpy.app.handlers.depsgraph_update_post.append(SerialSender) 
bpy.app.handlers.frame_change_post.append(SerialSender)
#bpy.app.timers.register(SerialSender)


    
    
    