# Testing service

This is an ASP.NET Core web-service for creating and passing tests.

# REST API

## Get test session by ID

### Request

`GET /Session/Get/{sessionId}`

### Response

    HTTP/1.1 200 OK
    Date: Tue, 11 Aug 2020 02:19:23 GMT
    Status: 200 OK
    Content-Type: application/json

    {"id": "5f31fb43ae7535891e78e937","testId": "5f31e590643f78230382013f","userName": "Ivan Ivanov","userEmail": null,"result": null}


## Create test session

### Request

`POST /Session/Create`

```json
{
    "testId": "5f31e590643f78230382013f",
    "userName": "Ivan Ivanov"
}
```

### Response

    HTTP/1.1 200 OK
    Date: Tue, 11 Aug 2020 02:19:23 GMT
    Status: 200 OK
    Content-Type: application/json

    {"id": "5f31fb43ae7535891e78e937","testId": "5f31e590643f78230382013f","userName": "Ivan Ivanov","userEmail": null,"result": null}


## Get test by session ID

### Request

`GET /Session/GetTest/{sessionId}`

### Response

    HTTP/1.1 200 OK
    Date: Tue, 11 Aug 2020 02:19:23 GMT
    Status: 200 OK
    Content-Type: application/json

    {"id": "5f31e590643f78230382013f","sessionId": "5f31fb43ae7535891e78e937","title": "First test updated","questions": [{"id": 1,"value": "what access modifiers are available in C#?","answers": [{"id": 1,"value": "public"},{"id": 2,"value": "internal"},{"id": 3,"value": "external"}]},{"id": 2,"value": "Object-oriented concepts?","answers": [{"id": 1,"value": "Abstraction"},{"id": 2,"value": "Interfaces"},{"id": 3,"value": "Encapsulation"}]}]}


## Complete session

### Request

`PUT /Session/Complete`

```json
{
    "id": "5f31fb43ae7535891e78e937",
    "testId": "5f31e590643f78230382013f",
    "userName": "Ivan Ivanov",
    "userEmail": null,
    "result": {
        "questionAnswers": [
            {
                "id": 1,
                "selectedAnswers": [1, 2]
            }
        ]
    }
}
```

### Response

    HTTP/1.1 200 OK
    Date: Tue, 11 Aug 2020 02:19:23 GMT
    Status: 200 OK
    Content-Type: application/json

    {"id": "5f31fb43ae7535891e78e937","testId": "5f31e590643f78230382013f","userName": "Ivan Ivanov","userEmail": null,"result": {"questionAnswers": [{"id": 1,"selectedAnswers": [1, 2],"isCorrect": true},{"id": 2,"selectedAnswers": [],"isCorrect": false}]}}


## Get test by ID

### Request

`GET /TestAdministration/Get/{testId}`

### Response

    HTTP/1.1 200 OK
    Date: Tue, 11 Aug 2020 02:19:23 GMT
    Status: 200 OK
    Content-Type: application/json

    {"id": "5f32047116368aa123cbf305","title": "First test updated","questions": [{"id": 1,"value": "What access modifiers are available in C#?","answers": [{"id": 1,"value": "public","isCorrect": true},{"id": 2,"value": "internal","isCorrect": true},{"id": 3,"value": "external","isCorrect": false}]},{"id": 2,"value": "Object-oriented concepts?","answers": [{"id": 1,"value": "Abstraction","isCorrect": true},{"id": 2,"value": "Interfaces","isCorrect": false},{"id": 3,"value": "Encapsulation","isCorrect": true}]}]}


## Create test

### Request

`POST /TestAdministration/Create`

```json
{
    "title": "First test updated",
    "questions": [
        {
            "id": 1,
            "value": "What access modifiers are available in C#?",
            "answers": [
                {
                    "id": 1,
                    "value": "public",
                    "isCorrect": true
                },
                {
                    "id": 2,
                    "value": "internal",
                    "isCorrect": true
                },
                {
                    "id": 3,
                    "value": "external",
                    "isCorrect": false
                }
            ]
        },
        {
            "id": 2,
            "value": "Object-oriented concepts?",
            "answers": [
                {
                    "id": 1,
                    "value": "Abstraction",
                    "isCorrect": true
                },
                {
                    "id": 2,
                    "value": "Interfaces",
                    "isCorrect": false
                },
                {
                    "id": 3,
                    "value": "Encapsulation",
                    "isCorrect": true
                }
            ]
        }
    ]
}
```

### Response

    HTTP/1.1 200 OK
    Date: Tue, 11 Aug 2020 02:19:23 GMT
    Status: 200 OK
    Content-Type: application/json

    {"id": "5f32047116368aa123cbf305","title": "First test updated","questions": [{"id": 1,"value": "What access modifiers are available in C#?","answers": [{"id": 1,"value": "public","isCorrect": true},{"id": 2,"value": "internal","isCorrect": true},{"id": 3,"value": "external","isCorrect": false}]},{"id": 2,"value": "Object-oriented concepts?","answers": [{"id": 1,"value": "Abstraction","isCorrect": true},{"id": 2,"value": "Interfaces","isCorrect": false},{"id": 3,"value": "Encapsulation","isCorrect": true}]}]}


## Update test

### Request

`PUT /TestAdministration/Update`

```json
{
    "id": "5f32047116368aa123cbf305",
    "title": "First test updated",
    "questions": [
        {
            "id": 1,
            "value": "What access modifiers are available in C#?",
            "answers": [
                {
                    "id": 1,
                    "value": "public",
                    "isCorrect": true
                },
                {
                    "id": 2,
                    "value": "internal",
                    "isCorrect": true
                },
                {
                    "id": 3,
                    "value": "external",
                    "isCorrect": false
                }
            ]
        },
        {
            "id": 2,
            "value": "Object-oriented concepts?",
            "answers": [
                {
                    "id": 1,
                    "value": "Abstraction",
                    "isCorrect": true
                },
                {
                    "id": 2,
                    "value": "Interfaces",
                    "isCorrect": false
                },
                {
                    "id": 3,
                    "value": "Encapsulation",
                    "isCorrect": true
                }
            ]
        }
    ]
}
```

### Response

    HTTP/1.1 200 OK
    Date: Tue, 11 Aug 2020 02:19:23 GMT
    Status: 200 OK
    Content-Type: application/json

    {"id": "5f32047116368aa123cbf305","title": "First test updated","questions": [{"id": 1,"value": "What access modifiers are available in C#?","answers": [{"id": 1,"value": "public","isCorrect": true},{"id": 2,"value": "internal","isCorrect": true},{"id": 3,"value": "external","isCorrect": false}]},{"id": 2,"value": "Object-oriented concepts?","answers": [{"id": 1,"value": "Abstraction","isCorrect": true},{"id": 2,"value": "Interfaces","isCorrect": false},{"id": 3,"value": "Encapsulation","isCorrect": true}]}]}

