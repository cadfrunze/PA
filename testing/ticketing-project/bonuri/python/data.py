import os
# CONNECTION_STRING: str = os.getenv(r"route_data_base")
CONNECTION_STRING =(
    "DRIVER={ODBC Driver 17 for SQL Server};"
    f"SERVER={os.getenv("device_name")}\\SQLEXPRESS;"
    f"DATABASE={os.getenv("data_base_name")};"
    "Trusted_Connection=yes;"
)