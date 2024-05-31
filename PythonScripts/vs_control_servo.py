print('Control de servo motores mediante VS y flask')

from flask import *
from sys import exit
from time import sleep
import Board

sensors = [
        {
                "id":0,
                "type_sensor":"battery",
                "type_value":"int",
                "value":0
        }
]

delay_movimiento = 100 #Solo referente al movimineto con la cruceta
delay_rutina_agarrar = 1000
delay_rutina_inclinar = 1000
sensibilidad_movimiento = 10 #Usar preferentemente valores entre 10-100

pos_base = 500
pos_cabeza = 150

tomar = True
inclinar = True

app = Flask(__name__)

@app.route('/up')
def up():
    global pos_cabeza
    global sensibilidad_movimiento
    pos_cabeza = pos_cabeza + sensibilidad_movimiento
    if(pos_cabeza>1000):
        pos_cabeza = 1000
    Board.setBusServoPulse(3,pos_cabeza,delay_movimiento)
    sleep(delay_movimiento/1000)
    return 'Adelante'

@app.route('/down')
def down():
    global pos_cabeza
    global sensibilidad_movimiento
    if(pos_cabeza<0):
        pos_cabeza = 0
    pos_cabeza = pos_cabeza - sensibilidad_movimiento
    Board.setBusServoPulse(3,pos_cabeza,delay_movimiento)
    sleep(delay_movimiento/1000)
    return 'Atras'

@app.route('/left')
def left():
    global pos_base
    global sensibilidad_movimiento
    pos_base = pos_base + sensibilidad_movimiento
    if(pos_base>1000):
        pos_base = 1000
    Board.setBusServoPulse(6,pos_base,delay_movimiento)
    sleep(delay_movimiento/1000)
    return 'Izquierda'

@app.route('/right')
def right():
    global pos_base
    global sensibilidad_movimiento
    pos_base = pos_base - sensibilidad_movimiento
    if(pos_base<0):
        pos_base = 0
    Board.setBusServoPulse(6,pos_base,delay_movimiento)
    sleep(delay_movimiento/1000)
    return 'Derecha'

@app.route('/dance')
def dance():
    return 'baile'

@app.route('/buzzer_on')
def buzzer_on():
    Board.setBuzzer(1)
    return 'buzzer_on'

@app.route('/buzzer_off')
def buzzer_off():
    Board.setBuzzer(0)
    return 'buzzer_off'

@app.route('/pick_leave')
def pick_leave():
    global tomar
    if (tomar == True):
        print('tomar')
        Board.setBusServoPulse(1,800,delay_rutina_agarrar)
        sleep(delay_rutina_agarrar/1000)
        tomar = False
    else:
        print('dejar')
        Board.setBusServoPulse(1,200,delay_rutina_agarrar)
        sleep(delay_rutina_agarrar/1000)
        tomar = True
    return 'Tomar/dejar'

@app.route('/incline')
def incline():
    global inclinar
    if (inclinar == True):
        print('Inclinar hacia adelante')
        Board.setBusServoPulse(4,350,delay_rutina_inclinar)
        sleep(delay_rutina_inclinar/1000)
        inclinar = False
    else:
        print('Inclinar hacia atras')
        Board.setBusServoPulse(4,650,delay_rutina_inclinar)
        sleep(delay_rutina_inclinar/1000)
        inclinar = True
    return 'inclinarse'

@app.route('/resetServos')
def resetServos():
    Board.setBusServoPulse(1,500,1000)
    sleep(1)
    Board.setBusServoPulse(2,500,1000)
    sleep(1)
    Board.setBusServoPulse(3,150,1000)
    sleep(1)
    Board.setBusServoPulse(4,300,1000)
    sleep(1)
    Board.setBusServoPulse(5,700,1000)
    sleep(1)
    Board.setBusServoPulse(6,500,1000)
    sleep(1)
    return 'Restablecer'

@app.route('/get_sensors')
def get_battery():
        sensors[0]["value"] = Board.getBattery()
        return jsonify(sensors)

app.run(host='0.0.0.0', port=15002)