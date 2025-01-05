
import time


from qrcode import QRCode
from qrcode.constants import ERROR_CORRECT_L
from reportlab.pdfgen import canvas
from reportlab.lib.utils import ImageReader
from io import BytesIO
from services import client
import os

client_final = client()


qr = QRCode(
    version=1,
    error_correction=ERROR_CORRECT_L,
    box_size=10,
    border=4,
)
qr.add_data(client_final['serie_ticket'])
qr.make(fit=True)


img = qr.make_image(fill_color="black", back_color="white")


qr_buffer = BytesIO()
img.save(qr_buffer, format="PNG")
qr_buffer.seek(0)

pdf_file = f"{client_final['nume'].lower()}-{client_final['prenume'].lower()}.pdf"
pdf_canvas = canvas.Canvas(filename=pdf_file)

x: int = 200
y: int = 600

textul: list = [
    f"Nume: {client_final['nume']}",
    f"Prenume: {client_final['prenume']}",
    f"CNP: {client_final['cnp']}",
    f"Email: {client_final['email']}",
    f"Tip Ticket: {client_final['tip_ticket']}",
    f"Serie ticket: {client_final['serie_ticket']}"
]

for linie in textul:
    pdf_canvas.drawString(x, y, linie)
    y = y -15

image_reader = ImageReader(qr_buffer)
pdf_canvas.drawImage(image_reader, 100, 650, width=150, height=150)


pdf_canvas.save()
time.sleep(1)
os.startfile(f"{client_final['nume'].lower()}-{client_final['prenume'].lower()}.pdf")