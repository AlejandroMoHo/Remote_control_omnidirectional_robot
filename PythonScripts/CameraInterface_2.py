from flask import *
import cv2
import numpy as np

lower_color = np.array([0, 0, 0],np.uint8)
upper_color = np.array([0, 0, 0],np.uint8)
lower_color2 = np.array([0, 0, 0],np.uint8)
upper_color2 = np.array([0, 0, 0],np.uint8)
contourColor = (0, 255, 255)

kernel = np.ones((3, 3), np.uint8)

app = Flask(__name__)

# Función para detectar objetos de un color específico en una imagen
def detectColor(image, lower_color, upper_color):
    hsv = cv2.cvtColor(image, cv2.COLOR_BGR2HSV)
    mask = cv2.inRange(hsv, lower_color, upper_color)
    mask = cv2.erode(mask, kernel, iterations = 1)
    mask = cv2.dilate(mask, kernel, iterations = 1)
    contours, _ = cv2.findContours(mask, cv2.RETR_EXTERNAL, cv2.CHAIN_APPROX_SIMPLE)
    return contours

def drawCircle(frame):
    color_contours = detectColor(frame, lower_color, upper_color)
    color_contours2 = detectColor(frame, lower_color2, upper_color2)
    color_contours_total = color_contours +  color_contours2

    for c in color_contours_total:
        area = cv2.contourArea(c)
        if area > 2500:
            #cv2.drawContours(frame, [c], 0, contourColor, 2)
            x,y,w,h = cv2.boundingRect(c)
            M = cv2.moments(c)
            if (M["m00"]==0): M["m00"] = 1
            xCenter = int(M["m10"]/M["m00"])
            yCenter = int(M["m01"]/M["m00"])
            radius = xCenter-x
            cv2.circle(frame, (xCenter, yCenter), radius, contourColor, 3)
    return

def generate():
    url = "http://192.168.149.23:4747/video"
    cap = cv2.VideoCapture(url)
    #cap = cv2.VideoCapture(0)
    while True:
        ret, frame = cap.read()
        if not ret:
            break
        else:
            drawCircle(frame)

            suc, encode = cv2.imencode('.jpg', frame)
            frame = encode.tobytes()
        yield(b'--frame\r\n' b'content-Type: image/jpeg\r\n\r\n' + frame + b'\r\n')
    cap.release()

@app.route('/')
def index():
    return render_template("index_camera.html")

@app.route('/video_feed')
def video_feed():
    return Response(generate(),
                    mimetype = 'multipart/x-mixed-replace; boundary=frame')

# Sin detección de objetos
@app.route('/cameraRaw')
def cameraRaw():
    global lower_color, upper_color, lower_color2, upper_color2, contourColor
    lower_color = upper_color = lower_color2 = upper_color2 = np.array([255, 255, 0])
    return redirect(url_for('index'))

# Detección de objetos verdes
@app.route('/detectGreen')
def detectGreen():
    global lower_color, upper_color, lower_color2, upper_color2, contourColor
    lower_color = np.array([35, 100, 100],np.uint8)
    upper_color = np.array([90, 255, 255],np.uint8)
    lower_color2 = upper_color2 = np.array([0, 0, 0],np.uint8)
    return redirect(url_for('index'))

# Detección de objetos azules
@app.route('/detectBlue')
def detectBlue():
    global lower_color, upper_color, lower_color2, upper_color2, contourColor
    lower_color = np.array([100, 100, 100],np.uint8)
    upper_color = np.array([125, 255, 255],np.uint8)
    lower_color2 = upper_color2 = np.array([0, 0, 0],np.uint8)
    return redirect(url_for('index'))

# Detección de objetos rojos
@app.route('/detectRed')
def detectRed():
    global lower_color, upper_color, lower_color2, upper_color2, contourColor
    #lower_color = np.array([0, 50, 50],np.uint8)
    #upper_color = np.array([10, 255, 255],np.uint8)
    lower_color2 = np.array([150, 120, 120],np.uint8)
    upper_color2 = np.array([190, 255, 255],np.uint8)
    lower_color = upper_color = np.array([0, 0, 0],np.uint8)
    return redirect(url_for('index'))

@app.teardown_request
def teardown_request(exception):
    cv2.destroyAllWindows()

if __name__ == '__main__':
    app.run(host='0.0.0.0', port='10300', debug=True)