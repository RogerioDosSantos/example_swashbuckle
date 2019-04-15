# Swashbuckle

[Swashbuckle.AspNetCore](https://github.com/domaindrivendev/Swashbuckle.AspNetCore) is an open source project for generating Swagger documents for ASP.NET Core Web APIs. For more information about Swashbuckle [click here](http://rogeriodossantos.github.io/Wiki/stage/swashbuckle.html)

## How to use

From this folder execute the following commands

```shell
# Build Solution
docker-compose.exe -f .\build\docker-compose-build-linux.yaml build

# Run Solution
docker-compose.exe -f .\debug\docker-compose.yaml up
```

From your preffered browser go to the following URL:

- Swagger Specification: [http://localhost:8080/swagger/v1/swagger.json](http://localhost:8080/swagger/v1/swagger.json)

- Swagger User Interface: [http://localhost:8080/swagger](http://localhost:8080/swagger)

