## O Desafio
Você deverá criar duas API's uma com dois endpoints e outra com um endpoint:

Responde pelo path relativo v1/taxajuros;
Retorna o juros de 1% ou 0,01 (fixo no código)
Exemplo: v1/taxajuros Resultado esperado: 0,01

e a segunda api: 

Responde pelo path relativo v1/calculajuros;
Ela faz um cálculo em memória, de juros compostos, conforme abaixo: Valor Final =
Valor Inicial * (1 + juros) ^ Tempo 
Valor inicial é um decimal recebido como parâmetro.
Valor do Juros deve ser consultado na API 1.
Tempo é um inteiro, que representa meses, também recebido como parâmetro.
^ representa a operação de potência.
Resultado final deve ser truncado (sem arredondamento) em duas casas decimais.

Exemplo: /calculajuros?valorinicial=100&amp;meses=5 Resultado esperado: 105,10
2) Show me the code
Este responde pelo path relativo /showmethecode Deverá retornar a url de onde
encontra-se o fonte no github

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
