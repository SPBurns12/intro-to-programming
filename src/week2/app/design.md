

## Get the users TodoList

GET /todos


200 Ok

{
    "list": [
        {
            
        }

    ]

}

## Add an Item to the Todo List

POST /todos

{
    "description": "Buy Beer",
    "dueDate": "ISO8601 Date String",
    "priority": "High" | "Low" | undefined
}


200

{
    "id": "38938938",
    "dueDate": "893893",
    "description": "Buy Beer",
    "priority": "Low"
}
## Mark an Item as Complete

## Mark an Item as Incomplete