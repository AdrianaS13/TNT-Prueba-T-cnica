# Prueba Tecnica Convocatoria TNT
#### Realizado por: Adriana Salas
A continuación se explica el desarrollo de la prueba técnica la cual consiste en desarrollar un minijuego con relación al fútbol y un avatar personalizable.

# Juego
El juego contiene 2 escenas:
- Avatar
- Soccer

La escena Avatar contiene toda la sección de personalización del Avatar.
La escena Soccer contiene el minijuego de fútbol.
## Jugador personalizable
Consiste en tres partes:
- Canvas
- Script
- Modelos

### Canvas
El canvas contiene un panel grande de inicio con boton para empezar el juego, una vez se inicia se carga otro panel con opciones de cambio de camisa y pantaloneta del jugador. Las opciones de cambio de ropa se agregan al canvas por medio del script "ChangeCloths" que los instancia.

### Script
El Script "ChangeCloths" tiene la funcion de instanciar n objetos segun sea requiera, en este caso botones al canvas, con los cuales se podrá personalizar la ropa del jugador a gusto. A cada boton se le asigna una imagen y un modelo desde el editor al script. Es importante que la cantidad de modelos y de imagenes sean la misma de los objetos a instanciar para evitar generar botones vacios y errores. 
Cada vez que se selecciona una opcion de personalización deseada, el script "Object" guarda la seleccion para cargarla al iniciar el minijuego.
El script "ChangeScene" se encarga de realizar el cambio de escena.

### Modelos
El modelo del jugador y sus animaciones son descargadas de la pagina Mixamo.

## Juego
Consiste en tres partes:
- Canvas
- Script
- Modelos

### Canvas
El canvas está dividido en 5 partes. Comenzando de izquierda a derecha y arriba a abajo se encuentran:
- Un boton para reiniciar el minijuego
- En el centro un texto para marcar la puntuación de goles.
- Al lado derecho un boton para volver a la personalizacion del avatar.
- En la esquina inferior izquierda un joystick para los controles del jugador en dispositivos táctiles.
- En la esquina inferior derecha un boton que permite realizar la acción de patada al jugador.

### Script

El script "PlayerSaved" carga los PlayerPrefs de la selección de personalización para mostrar en la nueva escena del juego. 
El script "ScoreManager" se encarga de la puntuación por medio de un Singleton y la asignación de puntaje al texto del canvas.
El script "Points" aumenta el puntaje cada que se realiza un gol y recarga la escena para iniciar de nuevo.
El script "PlayerMovement1" contiene todo el funcionamiento del movimiento del jugador. Se agregó la opción de que si se juega en PC, el joystick y boton de patear en el canvas desaparezcan y se juegue con las teclas WASD y Espacio para patear, las demas opciones se controlan con el mouse.
El script "PlayerMovement2" controla el movimiento del arquero, repitiendo la trayectoria de lado a lado.
El script "BallMovement" permite de la pelota de fútbol sea movida o golpeada por el jugador, en la direccion en que este esté, asignandole una velocidad al balón mayor al realizar una patada y menor al moverla corriendo.


### Modelos
El modelo del jugador, arquero y sus respectivas animaciones son descargadas de la pagina Mixamo. El estadio es modelo propio.
 
