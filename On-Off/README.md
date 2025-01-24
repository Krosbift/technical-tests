## Documentación de la API On-Off

### Endpoint

#### POST /raffle-number/generate-number-to-participate/{ClientId}/{RaffleId}/{UserId}

Genera un número pseudoaleatorio para que el usuario participe en una rifa. El número generado se verifica para asegurar que no haya sido elegido para la rifa especificada. Si el número ya ha sido elegido, se generará un nuevo número. El rango de números es de 00001 a 99999 y siempre será una cadena de cinco dígitos.

##### Parámetros

| Nombre   | Tipo | Descripción            |
|----------|------|------------------------|
| ClientId | int  | El ID del cliente      |
| RaffleId | int  | El ID de la rifa       |
| UserId   | int  | El ID del usuario      |

##### Respuesta

- `200 OK`: Devuelve el número generado como una cadena.

##### Ejemplo de Solicitud

```http
POST /raffle-number/generate-number-to-participate/1/2/3
```

##### Ejemplo de Respuesta

```json
"12345"
```
