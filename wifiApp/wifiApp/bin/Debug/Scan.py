import nmap, datetime, pyodbc, sys,time

DefGateway = sys.argv[1]
UserName = sys.argv[2]
password = sys.argv[3]
clientID = sys.argv[4]
#clientID = 'cxgovers'

def nmapScan(DefGateway,username,password):
	# Set up connection to the SQL database
	Driver='{ODBC Driver 13 for SQL Server}'
	Server='tcp:Wifi--intrusion.database.windows.net'
	Database='Database-WIFI'
	cnxn = pyodbc.connect('DRIVER='+Driver+';SERVER='+Server+';PORT=1443;DATABASE='+Database+';UID='+username+';PWD='+ password+';Encrypt=yes;TrustServerCertificate=no')
	cursor = cnxn.cursor()
	# Grab all currently connected items from the database
	cursor.execute("SELECT corbin.username, corbin.MAC_address, corbin.connection_time, disconnect_time FROM corbin WHERE username = ? and disconnect_time IS Null",clientID)
	tables = cursor.fetchall()
	connectedMacs = []
	for entry in tables:
		connectedMacs.append(str(entry.MAC_address));
	print(connectedMacs)
	nm=nmap.PortScanner()
	nm.scan(DefGateway, arguments="-v")
	newMacs=[]
	for host in nm.all_hosts():
		if nm[host]['status']['state'] != 'down':
			try:
				mac = nm[host]['addresses']['mac']
				newMacs.append(mac)
			except:
				mac = 'unknown'
	print(newMacs)
	for entry in newMacs:
		if entry not in connectedMacs:
			connectionTime = str(datetime.datetime.now())
			cursor.execute("insert into corbin(Username, MAC_address, connection_time,disconnect_time) values(?,?,?,?)",clientID, entry, connectionTime, None)
			cnxn.commit()
			print("Inserting ", entry)
			
	for entry in connectedMacs:
		if entry not in newMacs:
			connectionTime = str(datetime.datetime.now())
			cursor.execute("update corbin SET disconnect_time= ? where (MAC_address= ? and disconnect_time IS Null)",connectionTime,entry)
			cnxn.commit()
			print("Disconnecting ", entry)

def databaseTest(username,password):
	Driver='{ODBC Driver 13 for SQL Server}'
	Server='tcp:Wifi--intrusion.database.windows.net'
	Database='Database-WIFI'
	cnxn = pyodbc.connect('DRIVER='+Driver+';SERVER='+Server+';PORT=1443;DATABASE='+Database+';UID='+username+';PWD='+ password+';Encrypt=yes;TrustServerCertificate=no')
	print("Connection Achieved")
	cursor = cnxn.cursor()
	print("SELECT corbin.username, corbin.MAC_address, corbin.connection_time FROM corbin where username = ?;", username)
	cursor.execute("SELECT corbin.username, corbin.MAC_address, corbin.connection_time FROM corbin")
	tables = cursor.fetchall()
	print("table size: ", len(tables))
	for entry in tables:
		print(entry.username)
		print(entry.MAC_address)
		print(entry.connection_time)
		
		
def Test():
	nmapScan('10.0.0.1/24','SeniorProject','Password12345!')
	#databaseTest('SeniorProject','Password12345!')
	

#Test()
#Uncomment when ready to run on the real thing.

nmapScan(DefGateway, UserName,password)