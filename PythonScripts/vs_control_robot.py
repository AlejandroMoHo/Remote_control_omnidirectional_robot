print('Control de motores mediante VS y flask')

from flask import *
import sys
import rospy
from chassis_control.msg import *

if sys.version_info.major == 2:
    print('Ejecuta este programa con python3!')
    sys.exit(0)

app = Flask(__name__)

velocidad = 200 #-100 a 100
velRotacion = 0.7 # -2 a 2
delay = 1.3 #Segundos

#constantes
adelante = 90
atras = 270
derecha = 0
izquierda = 180
sinRotacion = 0

def stop():
    global start

    start = False
    print('Programa terminado...')
    set_velocity.publish(0,0,0)  #Se paran los motores

rospy.init_node('vs_control_robot', log_level=rospy.DEBUG)
rospy.on_shutdown(stop)

set_velocity = rospy.Publisher('/chassis_control/set_velocity', SetVelocity, queue_size=1)

start = True

@app.route('/up')
def up():
    set_velocity.publish(velocidad,90.0,sinRotacion)
    return 'Adelante';

@app.route('/down')
def down():
    set_velocity.publish(velocidad,270.0,sinRotacion)
    return 'Atras';

@app.route('/left')
def left():
    set_velocity.publish(velocidad,180.0,sinRotacion)
    return 'Izquierda';

@app.route('/right')
def right():
    set_velocity.publish(velocidad,0.0,sinRotacion)
    return 'Derecha';

@app.route('/diagonalUL')
def diagonalUL():
    set_velocity.publish(velocidad, 135.0, sinRotacion)
    return 'DiagonalSI'

@app.route('/diagonalUR')
def diagonalUR():
    set_velocity.publish(velocidad, 45.0, sinRotacion)
    return 'DiagonalSD'

@app.route('/diagonalBL')
def diagonalBL():
    set_velocity.publish(velocidad, 225.0, sinRotacion)
    return 'DiagonalII'

@app.route('/diagonalBR')
def diagonalBR():
    set_velocity.publish(velocidad, 315.0, sinRotacion)
    return 'DiagonalID'

@app.route('/rotationL')
def rotationL():
    set_velocity.publish(velocidad, 90.0, velRotacion)
    return 'DiagonalSI'

@app.route('/rotationR')
def rotationR():
    set_velocity.publish(velocidad, 90.0, -velRotacion)
    return 'DiagonalSI'

@app.route('/stopMotors')
def stopMotors():
    set_velocity.publish(0,0,0)
    return 'Parar'

app.run(host='0.0.0.0', port=15001)