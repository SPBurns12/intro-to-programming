# The Todos Resource

`/todos` - Resources in HTTP are just "an important thingy that supports some of the HTTP interface"

- Interface:
    - GET (retrieve a representation of that resource.)
    - POST (append the sent representation to the collection)
    - PUT (replace a resource with a new representation)
    - DELETE (remove a resource.)

## Let the user add an item to their todo list.

```http
POST /todos
Accept: application/json
Content-Type: application/json

{
    "description": "Clean Garage"
}
```

Response:


```http
201 Created
Content-Type: application/json
Location: http://localhost:1337/todos/389389893

{
    "id": "389389893",
    "description": "Clean Garage",
    "status": "Incomplete"
}
## Let the user see the items on their todo list

### See All Items on their Todo List

### See Just the Incomplete Items

### See Just the Completed Items 

## (Perhaps) see just a single item on their todo list.

## Mark an item as complete on their todo list.