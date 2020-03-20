# Programa de consola para obtener ventas del POS

1. Clonar el proyecto.
2. Entrar en la ruta del proyecto
3. Cambiar el nombre del archivo **appsettings.json.example** (ubicado dentro del directorio **GeneradorDeVentas**) a **appsettings.json**.
4. Asignar el valor a las variables de configuración en el archivo de appsettings.json
5. Restaurar paquetes


---

## Configuración

```js
{
  "Logging": {
    "LogFile": "Path al archivo de log"
  },
  "Endpoint": "url azure function",
  "Pos":  "[eva || gk]"
}

```