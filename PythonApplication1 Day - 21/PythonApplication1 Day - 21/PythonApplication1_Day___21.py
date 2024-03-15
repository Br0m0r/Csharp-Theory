
#commented code on Youtube(doesnt count)


#from colorama import init, Fore, Back, Style
#init() 

# music="\033[31m=\033[0m=\033[34m=\033[33mMusic App\033[31m=\033[0m=\033[34m="
# print(f"{music:>60}")
# gaga="\033[0mRadio Gaga"
# print(gaga)
# queen="\033[033mQueen"
# print(f"{queen:>15}")
# print()
# print("\033[0mPREV")
# next="\033[32mNEXT"
# print(f"{next:>15}")
# pause="\033[35mPAUSE"
# print(f"{pause:>25}")
# print()
# print()
# welcome="\033[0mWELCOME TO"
# print(f"{welcome:>36}")
# arm="\033[34m---    ARMBOOK   ---"
# print(f"{arm:>40}")
# print()
# ripoff="\033[33mDefinitely not a rip off of"
# print(f"{ripoff:>65}")
# certain="\033[33ma certain other social"
# print(f"{certain:>65}")
# network="\033[33mnetworking site"
# print(f"{network:>65}")
# honest="\033[31mHonest."
# print(f"{honest:^50}")
# user=input("\033[0mUsername: ")
# password=input("Password: ")

#* should make a colorchange function



#LISTS -----------------

# timetable = ["Computer Science","Math","English","Art","Sport"]
# for lesson in timetable:
#     print(lesson)

# print()

# timetable[4] = "watch tv"
# print(timetable[0])
# print(timetable[1])
# print(timetable[2])
# print(timetable[3])
# print(timetable[4])

# print()

# colors = ["red","orange","yellow","green","blue","violet"]

# print(f"The first color is {colors[0]}")


from colorama import init, Fore, Back, Style
init() 

import random,time

def GreetGenerator():
    colorList = ["\033[33m","\033[31m","\033[0m"]
    RN1 = random.randint(0,2)
    GreetList = ["Hello","Konnichiwa","Guten Tag","Kalimera"]
    RN2 = random.randint(0,len(GreetList)-1)
    print(f'{colorList[RN1]}{GreetList[RN2]}')
    
for i in range(1,10):
    GreetGenerator()
    time.sleep(0.5)
    


