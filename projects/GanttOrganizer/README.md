# Task Gantt 

> Implementación de un EndPoint para Manejar Jerarquías de Tareas en C#

## Descripción
Este proyecto implementa un EndPoint de tipo `POST` que acepta una lista de objetos del tipo `TareaRequest` y retorna una lista de tipo `TareaResponse` organizando las tareas jerárquicamente. Las tareas con el campo `padre` en `null` son consideradas como tareas principales, y las tareas con un valor en el campo `padre` son tratadas como hijos de otras tareas.

## Requisitos
1. **Jerarquía de Tareas**:
   - Si el campo `padre` es `null`, la tarea es considerada como una tarea principal.
   - Si el campo `padre` tiene un valor, esta tarea es hija de la tarea cuyo `id` coincide con el valor de `padre`.
   
2. **Ordenación**:
Las tareas deben ser ordenadas de forma ascendente por el campo fechaInicio y fechaFin, una vez realizadas las modificaciones en las fechas.

3. **Ajuste de Fechas**:
- **Fecha de Inicio**: Si una tarea hija tiene una fecha de inicio anterior a la del padre, se ajusta la fecha de inicio del padre para que sea la misma que la del hijo.
- **Fecha de Fin**: Si una tarea hija tiene una fecha de fin posterior a la del padre, se ajusta la fecha de fin del padre para que sea la misma que la del hijo.
4. **Profundidad de la Jerarquía**:
   - Se debe calcular la profundidad de la jerarquía para cada tarea.
   - Se deben crear nodos auxiliares para cada nivel de la jerarquía.
   
4. **Salida**:
   - El formato de salida debe organizar las tareas principales en el primer nivel y las tareas hijas dentro de la propiedad `hijo` del objeto de respuesta.

## Ejemplo del JSON de Entrada y Salida

<div style="display: flex; justify-content: space-between;">

<div style="width: 48%;">

### JSON de Entrada `TareaRequest`
```JSON
[
  {
    "id": 1,
    "padre": null,
    "titulo": "Primer elemento",
    "fechaInicio": "2024-01-01",
    "fechaFin": "2024-02-03"
  },
  {
    "id": 3,
    "padre": 1,
    "titulo": "Tercer elemento",
    "fechaInicio": "2024-01-24",
    "fechaFin": "2024-02-01"
  },
  {
    "id": 4,
    "padre": 3,
    "titulo": "Cuarto elemento",
    "fechaInicio": "2024-01-01",
    "fechaFin": "2024-02-01"
  }
]
```
</div> <div style="width: 48%;">


### JSON de Salida `TareaResponse`

```JSON
[
  {
    "id": 1,
    "titulo": "Primer elemento",
    "fechaInicio": "2024-01-01",
    "fechaFin": "2024-02-03",
    "hijo": [
      {
        "id": 3,
        "titulo": "Tercer elemento",
        "fechaInicio": "2024-01-24",
        "fechaFin": "2024-02-01",
        "hijo": [
          {
            "id": 4,
            "titulo": "Cuarto elemento",
            "fechaInicio": "2024-01-01",
            "fechaFin": "2024-02-01",
            "hijo": []
          }
        ]
      }
    ]
  }
]
```
</div> </div>

## Algoritmo para Organizar Tareas (en proceso)
1. **Crear Diccionario de Tareas:** 

Construir un diccionario donde la clave sea el `id` de la tarea y el valor sea la tarea misma. Esto facilita el acceso a cada tarea por su `id`.

2. **Identificar Tareas Principales e Hijas:**

Recorrer todas las tareas y añadirlas a sus respectivos padres si el campo `padre` tiene un valor.
Si el campo `padre` es `null`, la tarea se añade al nivel superior de la jerarquía.

3. **Ordenación de Tareas por Fecha:**

Ordenar las tareas en cada nivel por el campo `fechaInicio`.

4. **Calcular la Profundidad:**

Utilizar una recursión para calcular qué tan profundo llega cada nivel de la jerarquía, basándose en la estructura `hijo`.
