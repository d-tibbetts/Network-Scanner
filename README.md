CONTENTS OF THIS FILE
---------------------
   
 * Introduction
 * Requirements
 * Installation
 * Configuration
 * FAQ

 Introduction
 ------------
	This application is a network scanner, that will scan a network every few minutes
	and allow the user to determine whether the connection is wanted or unwanted. 

Requirements
------------
	In order to run this application successfully, you must have administrator priveledges.
	Python 2.7 needs to be installed along with NMAP and PYODBC
	ODBC Driver 13 for SQL Server needs to be installed. 
	 
	
Installation
------------
	Python 2.7 can be found at https://www.python.org/downloads/
		After installation open a command prompt and used the following commands. 
		Pip install python-nmap
		Pip install pyodbc
	ODBC driver 13 for SQL Server can be found at https://www.microsoft.com/en-us/download/details.aspx?id=50420

Configuation
------------
	The application is configured to only run on Windows accounts that have have elevated administration rights.
	You can set this application to run with elevated administration rights by right clicking the desktop icon,
	scrolling all the way down to properties, and clicking the check box for run as administrator. 

FAQ
---

Program will not run after selecting run as administrator?
	Your account does not have administrator privledges, or you are missing dependencies.

Scans are taking longer than 2 minutes?
	Scans can take up to 5 minutes to run.  If a scan is in  progress and the time limit has passed,
	the backgrounder worker that handles the scan is busy and the timer has been reset. 



	