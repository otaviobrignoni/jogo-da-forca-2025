# Jogo da Forca

![](https://i.imgur.com/4QMyQjZ.gif)

# Projeto
Desenvolvido durante o curso Fullstack da Academia do Programador 2025

# Detalhes
O computador escolhe aleat�riamente uma palavra para o jogador adivinhar chutnado letras.

O jogador pode errar at� 5 vezes antes de perder.

# Entrada

O jogador pode adivinhar uma letra por vez. Se acertar, a  letra ser� revelada nas posi��es correspondentes na palvara. Se errar, uma parte do boneco ser� desenhada.

# Funcionalidades

- **Escolha de Palavra Secreta**: Uma palavra � escolhida aleatoriamente no in�cio de cada jogo.
- **Representa��o da Forca**: A forca � desenhada progressivamente no console, com cada erro do jogador.
- **Feedback Visual**: As letras adivinhadas s�o exibidas na posi��o correta.
- **Contagem de Erros**: O jogo acompanha o n�mero de erros cometidos pelo jogador e termina quando o m�ximo permitido � alcan�ado

# Requisitos

- .NET SDK (recomendado .NET 8.0 ou superior) para compila��o e execu��o do projeto.

# Como Usar
- Clone o Reposit�rio

```
git clone https://github.com/otaviobrignoni/jogo-da-forca-2025.git
```
 
- Navegue at� a pasta raiz da solu��o

``` 
cd jogo-da-forca-2025
```

 - Restaure as depend�ncias

```	 
dotnet restore
```

 - Navegue at� a pasta do projeto

```	 
cd JogoDaForca.ConsoleApp
```	

 - Execute o projeto

```	
dotnet run
```