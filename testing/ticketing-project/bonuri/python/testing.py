from data import CONNECTION_STRING
import pyodbc

try:
    print(type(CONNECTION_STRING))
    print(CONNECTION_STRING)
    connection = pyodbc.connect(CONNECTION_STRING)
    cursor = connection.cursor()
    cursor.execute("SELECT * FROM dbo.evidenta_clienti")
    rows = cursor.fetchall()
    # print(type(rows))
    index : str = "".join([x for x in str(rows[-1][0]) if x.isdigit()])
    print(index)
    cursor.execute(f"SELECT * from dbo.stoc_bilete_cumparate where fk_idevidenta_clienti = {index}")
    data_stocbilete = cursor.fetchall()
    print(data_stocbilete)
    cursor.close()
    connection.close()
except Exception as e:
    print(e)