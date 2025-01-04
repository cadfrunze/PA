from data import CONNECTION_STRING
import pyodbc


def client() -> dict:
    try:
        connection = pyodbc.connect(CONNECTION_STRING)
        cursor = connection.cursor()
        cursor.execute("SELECT * FROM dbo.evidenta_clienti")
        data_evidenta_clienti = cursor.fetchall()[-1]
        index: int = int("".join([x for x in str(data_evidenta_clienti[0]) if x.isdigit()]))
        cursor.execute(f"SELECT * from dbo.stoc_bilete_cumparate where fk_idevidenta_clienti = {index}")
        data_stocbilete = cursor.fetchall()
        cursor.close()
        connection.close()
    except Exception as e:
        print(e)
    else:
        utilizator: dict = dict()
        utilizator['nume'] = data_evidenta_clienti[1].capitalize()
        utilizator['prenume'] = data_evidenta_clienti[2].capitalize()
        utilizator['cnp'] = data_evidenta_clienti[3]
        utilizator['email'] = data_evidenta_clienti[4]
        if len(data_evidenta_clienti[-1]) > 1:
            utilizator['telefon'] = data_evidenta_clienti[-1]
        utilizator['tip_ticket'] = data_stocbilete[0][3]
        utilizator['serie_ticket'] = data_stocbilete[0][4]
        return utilizator


