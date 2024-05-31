#Este programa falla al cerrar la tarea relacionada con los motores, cosa de las librerias de rospy, pendiente a solucionar

import subprocess as subp
import threading
import signal
import sys

dir1 = r'/home/ubuntu/Desktop/chassis_control_demo/vs_control_robot.py'
dir2 = r'/home/ubuntu/armpi_pro/src/armpi_pro_demo/expansion_board_demo/vs_control_servo.py'

# Evento para indicar a los hilos que deben detenerse
stop_event = threading.Event()

def flask_motores():
    try:
        result = subp.run(['python3', dir1], check=True)
        print(f'flask_motores terminó con código {result.returncode}')
    except subp.CalledProcessError as e:
        print(f'Error en flask_motores: {e}', file=sys.stderr)
    except Exception as e:
        print(f'Excepción en flask_motores: {e}', file=sys.stderr)
    finally:
        stop_event.set()

def flask_servo_sudo():
    try:
        result = subp.run(['sudo', 'python3', dir2], check=True)
        print(f'flask_servo_sudo terminó con código {result.returncode}')
    except subp.CalledProcessError as e:
        print(f'Error en flask_servo_sudo: {e}', file=sys.stderr)
    except Exception as e:
        print(f'Excepción en flask_servo_sudo: {e}', file=sys.stderr)
    finally:
        stop_event.set()

# Función para manejar la señal SIGINT (Ctrl+C)
def signal_handler(sig, frame):
    print("Interrupción recibida, cerrando hilos...")
    stop_event.set()  # Indica a los hilos que deben detenerse
    thread1.join()    # Espera a que el hilo 1 termine
    thread2.join()    # Espera a que el hilo 2 termine
    sys.exit(0)       # Cierra el programa

# Registrar el manejador de la señal SIGINT
signal.signal(signal.SIGINT, signal_handler)

# Crear y arrancar los hilos
thread1 = threading.Thread(target=flask_motores)
thread2 = threading.Thread(target=flask_servo_sudo)

thread1.start()
thread2.start()

# Esperar a que los hilos terminen
thread1.join()
thread2.join()

# Comprobar si algún hilo ha activado el evento de parada
if stop_event.is_set():
    print("Uno o ambos hilos han terminado con error o se ha alcanzado el final del código.")
else:
    print("Ambos hilos han terminado correctamente.")
