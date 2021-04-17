## O Desafio
Você deverá criar duas API's uma com dois endpoints e outra com um endpoint:

![Action test Integration](https://github.com/paulosjunior7/desafio-softplan/actions/workflows/dotnet.yml/badge.svg)

## Atenção
* [docker](https://www.docker.com/) deverá estar instalado no ambiente. 

## Executar aplicação
```
> git clone https://github.com/paulosjunior7/desafio-softplan
> cd desafio-softplan
> docker-compose up
```
## Documentação Swagger
* Api1: http://localhost:8081/swagger
* Api2: http://localhost:8080/swagger

#### API 1
1) Retorna taxa de juros  
Responde pelo path relativo "/v1/taxajuros" onde será retornada a taxa de juros.

#### API 2  
1) Calcula Juros
Responde pelo path relativo "/v1/calculajuros"
Calculo de juros composto, possui integração com a API1, para a busca do parametro
taxa de juros.

2) Show me the code 
Este responde pelo path relativo /v1/showmethecode onde será retornado o repositório do código no github

#### TESTE

1) A aplicação possui teste unitário para todas as funções listadas acima, criadas através do MSTEST. atendendo alguns cenários.
2) Também possui integração com Actions do github para teste automatizado.
