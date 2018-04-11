# Todo API
## overview
This is a simple, locally hosted API. It has end points to get all Todo tasks, a specific Todo by Id, Put, Post, or Delete by Id. It works like a web api while running entirely locally.

## use
### Requirements
- .netcore entity framework
- sql server
- postman or equivalent to test/interact with the API

### Getting Started
To utilize this API, you must download it, download/implement .NET core EntityFramework, and add a migration to your sql server app. There likely are alternative set ups.

Once you have the API running on your machine, start the program. It will open a browser window and the address bar will say something like ```//localhost:12345/api/values```
Copy that URL into your postman or equivalent, althrough change it to read ```//localhost:12345/api/todo/``` and perform a get request. You should get a 200 status code and the response body JSON should look like
```
[
    {
        "id": 1,
        "name": "Turn in Lab",
        "isComplete": true
    },
    {
        "id": 2,
        "name": "Get Job",
        "isComplete": false
    },
    {
        "id": 3,
        "name": "Get Haircut",
        "isComplete": false
    },
    {
        "id": 4,
        "name": "Get Sleep",
        "isComplete": false
    },
}
```

To interact with a specific item via put, post, get, or delete, change the method of the url and append `/id` where `id` is the unique id number of the item you are interacting with.

## Architecture
This is a .net core web API, hosted locally. It interacts with a local sql database. Then endpoints are in the controllers, the form of the data is in models, and since this API has no front end that really is all there is to it. Since this is not hosted it only exists locally.

## Sources
This tutorial https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-web-api
This video https://binged.it/2v2AXFe

## versions
2018-04-10 v1.0 released. Web API has rudimentary MVP functionality for experienced and well prepared users