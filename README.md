# GPCE
GPCE (General Purpose Command Executor) is a command executor for many purposes, but it is still under development. It is currently available in C# and Python 3. Feel free to report any bugs on the website or to shrikaanthpruthvispareemail@gmail.com.

# Commands and syntax (C# edition)

## help

Shows list of commands and a brief description of each of them.

### syntax

*help* ENTER

---

## now

Displays the time and date.

### syntax

*now* ENTER

---

## exit

Exits GPCE.

### syntax/method

*exit* ENTER and then PRESS ANY KEY

---

## clear

Clears the console.

### syntax

*clear* ENTER

---

## pcname

Gets the local host's name and displays it.

### syntax

*pcname* ENTER

---

## osver

Displays the version of the system that GPCE is running on.

### syntax

*osver* ENTER

---

## sum

Asks for two numbers and prints the sum.

### syntax

*sum* ENTER **first number** ENTER **second number** ENTER

---

## diff

Asks for two numbers and prints the difference.

### syntax

*diff* ENTER **first number** ENTER **second number** ENTER

---

## prod

Asks for two numbers and prints the product.

### syntax

*prod* ENTER **first number** ENTER **second number** ENTER

---

## div

Asks for two numbers and prints the quotient.

### syntax

*div* ENTER **first number** ENTER **second number** ENTER

---

## rem

Asks for two numbers and prints the remainder after division.

### syntax

*rem* ENTER **first number** ENTER **second number** ENTER

---

## fwrite

Allows you to write to a file. If the file doesn't exist, it returns an error. \n is used for a new line, \t for a tab and \\\ for a backslash. This command is not recommended to use unless you are appending a quick line to a file, it is extremely tedious to use! When saving, asks for an append or overwrite method. Append is the default. Press 'O' for overwrite.

### syntax

*fwrite* ENTER **file name** ENTER **file content** ENTER **edit method** ENTER

---

## fdel

Deletes a file.

### syntax

*fdel* ENTER **file name** ENTER

---

## fopen

Opens a file with the associated program.

### syntax

*fopen* ENTER **file name** ENTER

---

## ftype

Prints the contents of a file.

### syntax

*ftype* ENTER **file name** ENTER

---

## dir

Displays the path that GPCE was called/opened from.

### syntax

*dir* ENTER

---

## fdl

Downloads a file from the web to the local machine. The http (and others) part is required if downloaded from the web, but the /index.html part is not. Also works on local files, so it is very useful for copying and renaming files.

### syntax

*fdl*  ENTER **web url** ENTER **new file name** ENTER

---

## contact

Shows contact information about me.

### syntax

*contact* ENTER

---

## tc

Displays terms and conditions.

### syntax

*tc* ENTER

---

## privacy

Displays privacy policy.

### syntax

*privacy* ENTER

---

## license

Displays license.

### syntax

*license* ENTER

---

## extract

Extracts an archive to a destination directory.

### syntax

*extract* ENTER **archive file name** ENTER **destination folder** ENTER

---

## compress

Compresses a directory into an archive.

### syntax

*compress* ENTER **directory to compress** ENTER **resultant archive name** ENTER

---





# Status

GPCE is currently in active development. Work is currently being done on the C# edition, and there is error handling for the whole program. The Python 3 edition is not complete either, but development on that version will be on standby until otherwise stated. The first pre-release (v0.1) is out! See https://github.com/Blue0Tech/GPCE/releases/tag/v0.1.
