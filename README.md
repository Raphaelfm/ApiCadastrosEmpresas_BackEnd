# ApiCadastrosEmpresas_BackEnd

#Como rodar o projeto

## No Visual Studio
### Dotnet 6
#### Com o dotnet 6 instalado, em seu visual studio:
1 - vá em Ferramentas/Settings
2 - Gerenciador de pacotes do NuGet ou NuGet Package Manager
3 - Console do Gerenciador de pacotes ou Package Manager Console

#### No console do gerenciador de pacotes:
1 - Digite o comando "update-database"

Com o comando acima o gerenciador de pacotes criará o banco aplicando as migrations
##### Obs: Caso deseje, estou fornecendo o banco em SqLite para facilitar e não precisar instalar outros bancos de dados.
##### Para recriar aplicando as migrations, apague o arquivo Empresas.db e rode o comando descrito no passo 1 dessa seção.

Agora execute o projeto no botão run.

## No Visual Studio Code
### Abra a pasta do projeto em um nivel acima da pasta que se encontra o .sln, ou seja ApiEmpresas\ApiEmpresas
### Dotnet 6
#### Com o dotnet 6 instalado, em seu visual studio:

Abra um terminal no VS Code

E digite o comando "update-database"

Com o comando acima o gerenciador de pacotes criará o banco aplicando as migrations
##### Obs: Caso deseje, estou fornecendo o banco em SqLite para facilitar e não precisar instalar outros bancos de dados.
##### Para recriar aplicando as migrations, apague o arquivo Empresas.db e rode o comando descrito no passo 1 dessa seção.

Agora execute o projeto digitando no terminal o comando "dotnet run".

## No Terminal do windows ou do Linux
### Abra a pasta do projeto em um nivel acima da pasta que se encontra o .sln, ou seja ApiEmpresas\ApiEmpresas
### Dotnet 6
#### Com o dotnet 6 instalado.

Abra o terminal na pasta sugerida, e digite o comando "update-database"

Com o comando acima o gerenciador de pacotes criará o banco aplicando as migrations
##### Obs: Caso deseje, estou fornecendo o banco em SqLite para facilitar e não precisar instalar outros bancos de dados.
##### Para recriar aplicando as migrations, apague o arquivo Empresas.db e rode o comando descrito no passo 1 dessa seção.

Agora execute o projeto digitando no terminal o comando "dotnet run".



## Após seguir os passos acima a api iniciará em seu navegador web da seguinte maneira:

![image](https://github.com/Raphaelfm/ApiCadastrosEmpresas_BackEnd/assets/51061090/bca1a5b3-d593-48e1-b029-76cafce962ff)


