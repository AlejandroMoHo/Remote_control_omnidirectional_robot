# Remote Control Omnidirectional Robot

Este repositorio contiene los códigos y proyectos necesarios para el control de los motores y la cámara de un robot ArmPi Pro.
Está organizado en varias carpetas las cuales albergan los distintos archivos.

## Estructura del Repositorio

El repositorio está estructurado en las siguientes carpetas principales:

### 1. `AppControlRobot` (Aplicación e Instalador)

Esta carpeta contiene todos los archivos relacionados con el proyecto de Visual Studio. Dentro de esta carpeta, encontrarás dos subcarpetas importantes:

- **`AppControlRobot`**: Contiene los códigos y recursos gráficos para la interfaz gráfica de control.
- **`OmniRobot_Controller_Installer`**: Incluye el instalador del proyecto. Dentro de esta carpeta, hay una subcarpeta llamada `Debug` que contiene el archivo Setup.exe (instalador) y OmniRobot_Controller_Installer.msi disponibles para su descarga.

### 2. `PS4controller`

Esta carpeta contiene una aplicación desarrollada en Visual Studio para verificar el correcto funcionamiento del control. Es útil si se ha conectado un control de PS4, en cuyo caso se recomienda utilizar esta aplicación para pruebas.

### 3. `PythonScripts`

Aquí se encuentran los códigos principales implementados en Ubuntu en la Raspberry Pi. Los scripts presentes son:

- **`CameraInterface_2.py`**: Código del sistema de detección de colores y su servidor dedicado.
- **`main_control_vs.py`**: Código del servidor que recibe todas las instrucciones para el manejo de los motores y servomotores del robot.
- **`vs_control_robot.py`**: Recibe instrucciones del `main_control_vs.py` y se encarga del manejo de los motores de corriente continua (DC) de las ruedas.
- **`vs_control_servo.py`**: Similar al anterior, pero maneja el control de los servomotores del brazo robótico.


## Proceso de Instalación AppControlRobot

Para instalar la aplicación, sigue estos pasos:

1. **Navega al Repositorio**: Dirígete a la carpeta del instalador en el repositorio. Puedes encontrar la ruta desde la carpeta raíz del repositorio en:
   
Enlace directo al instalador:
[OmniRobot_Controller_Installer/Debug](https://github.com/AlejandroMoHo/Remote_control_omnidirectional_robot/tree/main/AppControlRobot/OmniRobot_Controller_Installer/Debug)

2. **Descarga los Archivos**: Dentro de la carpeta `Debug`, encontrarás dos archivos necesarios para la instalación: `OmniRobot_Controller_Installer.msi` y `setup.exe`. Es recomendable descargar ambos archivos.

![Ícono del instalador](Images/Install1.png)

3. **Ejecuta el Instalador**: Abre el archivo `setup.exe` o `OmniRobot_Controller_Installer.msi` para iniciar el asistente de instalación.

![Asistente de instalación](Images/Install2.png)

4. **Proceso de Instalación**:
- Al abrir el instalador, sigue las instrucciones del asistente.
- Presiona “Siguiente” para seleccionar la carpeta de instalación.
- Elige si deseas instalar el programa para todos los usuarios o solo para el usuario actual.

![Ruta de instalación](Images/Install3.png)

5. **Finaliza la Instalación**: Continúa pulsando “Siguiente” hasta que el programa se haya instalado. Cuando el asistente indique que la instalación se ha completado, puedes pulsar “Cerrar”.

![Instalación completada](Images/Install4.png)

6. **Verifica la Instalación**: Busca el ícono del programa en el escritorio o ábrelo directamente. Asegúrate de conectar un control antes de abrir la aplicación.

![Ícono de la aplicación](Images/Install5.png)

---

# Instrucciones para Conectar, Utilizar y/o Reiniciar el Robot

## Verificar Instalación de SSH

1. Abre CMD o PowerShell en Windows.
2. Escribe el siguiente comando y presiona Enter:
   ```sh
   ssh -V
   ```
3. Deberías ver una salida similar a:
   `
   OpenSSH_for_Windows_8.6p1, LibreSSL 3.4.3
   `

## Instalación de SSH

- Si no tienes SSH instalado, puedes seguir las instrucciones en la página de Microsoft: 
   [Instalación de OpenSSH](https://learn.microsoft.com/es-es/windows-server/administration/openssh/openssh_install_firstuse?tabs=powershell)

- Alternativamente, puedes instalar [PuTTY]( https://www.putty.org/).

## Conexión con SSH

1. Conéctate a la red `HW-E82EC0F1`.
2. Abre PowerShell o CMD en Windows.
3. Escribe el siguiente comando y presiona Enter:
   ```sh
   ssh ubuntu@192.168.149.1
   ```
4. Introduce la contraseña `hiwonder` y presiona Enter.
   - `Nota`:  La contraseña no será visible mientras la introduces.

## Conexión con PuTTY

1. Conéctate a la red `HW-E82EC0F1`.
2. Abre el programa PuTTY.
3. En **Host Name (or IP address)** escribe `192.168.149.1`.
4. El **Port** debe ser `22`.
5. El **Connection type** debe ser `SSH`.
6. Haz clic en **Open**.

   - `Nota`: Si es la primera vez que te conectas, probablemente aparezca una advertencia. Solo escribe `yes` o `y`, o dale clic en **OK** (dependiendo del método de conexión).

## Acceso al Robot

Una vez hayas accedido al robot puedes:

### Iniciar los módulos del Robot

1. Escribe en la terminal del robot:
   ```sh
   cd Desktop/chassis_control_demo/
   ```
2. Luego, ejecuta:
   ```sh
   python3 main_control_vs.py
   ```
   Se recomienda no cerrar la terminal de comandos en caso de que se quiera detener el programa. En caso de cerrarlo, se recomienda reiniciar el robot.
3. Una vez realizado esto, deberas abrir la aplicación de control del robot en Windows. `ADVERTENCIA:` Recuerda conectar el control y abrir DS4Windows antes de abrir la aplicación. En caso de no contar con DS4Windows se puede descargar desde su [página oficial](https://ds4-windows.com/download/ryochan7-ds4windows/).

### Reiniciar el Robot

En caso de presentar algún problema o anomalía se recomienda realizar lo siguiente:

1. Escribe en la terminal del robot:
   ```sh
   sudo reboot
   ```
2. Introduce la contraseña `hiwonder` y presiona Enter.
   - `Nota`: La contraseña no será visible mientras la introduces.
4. Espera a que el robot arranque de nuevo. Puedes identificar que ha arrancado porque la red se activará nuevamente.

---

Si tienes alguna pregunta o necesitas más información, no dudes en contactar al mantenedor del proyecto.
