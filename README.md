# Calculadora Tabajara 2024

## Descrição
Uma calculadora de console simples mas poderosa que permite realizar as quatro operacoes matemáticas.

## Funcionalidades
- **Operações Básicas**:
	- Soma
	- Subtração
	- Multiplicação
	- Divisão

- **Suporte a Decimais**:
	- Trabalhe com números que tem até duas casas decimais.
	
- **Tratamento de Divisão por 0**:
	- A calculadora é capaz de validar erros de divisão por zero.

___

## Como Usar

1. Clone o repositório ou baixe o código fonte da Calculadora.
2. Abra o terminal ou o prompt de comando e navegue até a pasta raiz da Calculadora.
3. Utilize o comando abaixo para restaurar as dependências do projeto:
```
dotnet restore
```

4. Em seguida, compile a solução utilizando o comando:
```
dotnet build --configuration Release
```

5. Para executar o projeto complicando em tempo real:
```
dotnet run --project Calculadora.ConsoleApp
```

6. Para executar o projeto compilado, navegue até a pasta bin:
```
cd .\Calculadora.ConsoleApp\bin\Release\net8.0\
```
E Execute o Arquivo:
```
Calculadora.ConsoleApp.exe
```

## Requisitos

- .NET SDK (recomendado .NET 5.0 ou superior) para compilação e execução do projeto.