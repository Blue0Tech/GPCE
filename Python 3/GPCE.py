#GPCE (General Purpose Command Executor - a command line program which can be used for many purposes.
#Copyright © 2019 Pruthvi Shrikaanth "Blue0Tech"
#libraries and packages are imported
import datetime
import platform
import os
#declaring main and default values
command=0
now=datetime.datetime.now()
licensefile=open("license.txt","r")
license=licensefile.read()
privacyfile=open("privacy.txt","r")
privacy=privacyfile.read()
tcfile=open("tc.txt","r")
tc=tcfile.read()
#start of program
print("General Purpose Command Executor (Python 3 edition), Copyright 2019 Pruthvi Shrikaanth. Type help and press enter for help")
while (command!="exit"):
	command=str(input(">"))
	if(command=="help"):
		print("now: shows information about the date and time. Second arguements are all, year, month, day, hour, minute, second, usecond")
		print("contact: shows you my contact details")
		print("help: shows list of commands")
		print("about: shows information about the program")
		print("privacy: displays privacy policy")
		print("tc: displays the terms and conditions of this software")
		print("license: shows this software license")
		print("exit: terminates the program")
		print("platform: displays information about the environment that the program is running in. Second arguements are type, system, os, ver, dvcmdl, processor, arch, node, pybuild, pyver, compiler, imp, release")
		print("currentpath: returns the path of the program")
		continue
	elif(command=="now"):
		command=str(input("What element? >"))
		if(command=="all"):
			now=datetime.datetime.now()
			print(now)
		elif(command=="year"):
			now=datetime.datetime.now()
			print(now.year)
		elif(command=="month"):
			now=datetime.datetime.now()
			print(now.month)
		elif(command=="day"):
			now=datetime.datetime.now()
			print(now.day)
		elif(command=="hour"):
			now=datetime.datetime.now()
			print(now.hour)
		elif(command=="minute"):
			now=datetime.datetime.now()
			print(now.minute)
		elif(command=="second"):
			now=datetime.datetime.now()
			print(now.second)
		elif(command=="usecond"):
			now=datetime.datetime.now()
			print(now.microsecond)
		else:
			print("Invalid second arguement")
		continue
	elif(command=="platform"):
		command=str(input("What element? >"))
		if(command=="type"):
			print(platform.machine())
		elif(command=="system"):
			print(platform.system())
		elif(command=="os"):
			print(platform.platform())
		elif(command=="ver"):
			print(platform.version())
		elif(command=="dvcmdl"):
			print(platform.uname())
		elif(command=="processor"):
			print(platform.processor())
		elif(command=="arch"):
			print(platform.architecture())
		elif(command=="node"):
			print(platform.node())
		elif(command=="pybuild"):
			print(platform.python_build())
		elif(command=="pyver"):
			print(platform.python_version())
		elif(command=="compiler"):
			print(platform.python_compiler())
		elif(command=="imp"):
			print(platform.python_implementation())
		elif(command=="release"):
			print(platform.release())
		else:
			print("Invalid second arguement")
		continue
	elif(command=="currentpath"):
		print(os.getcwd())
		continue
	elif(command=="contact"):
		print("shrikaanthpruthvispareemail@gmail.com")
		print("Our website is currently down, sorry for any inconveniece")
		print("+447712343856")
		continue
	elif(command=="about"):
		print("General Purpose Command Executor Python 3 edition, version: unreleased")
		print("Copyright Pruthvi Shrikaanth 2019")
		continue
	elif(command=="privacy"):
		print(privacy)
		continue
	elif(command=="tc"):
		print(tc)
		continue
	elif(command=="license"):
		print(license)
		continue
	elif(command=="exit"):
		print("Terminating... Copyright 2019 Pruthvi Shrikaanth")
		continue
	else:
		print("\'"+command+"\' is an invalid command")
	#break
#file closing
licensefile.close()
privacyfile.close()
tcfile.close()
#freeing the memory
del licensefile
del license
del privacyfile
del privacy
del tcfile
del tc
del now
del command
#end of program
