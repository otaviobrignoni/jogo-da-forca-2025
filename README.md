# Jogo da Forca

![](https://i.imgur.com/4QMyQjZ.gif)

# Projeto
Desenvolvido durante o curso Fullstack da Academia do Programador 2025

# Detalhes
O computador escolhe aleatóriamente uma palavra para o jogador adivinhar chutnado letras.

O jogador pode errar até 5 vezes antes de perder.

# Entrada

O jogador pode adivinhar uma letra por vez. Se acertar, a  letra será revelada nas posições correspondentes na palvara. Se errar, uma parte do boneco será desenhada.

# Funcionalidades

- **Escolha de Palavra Secreta**: Uma palavra é escolhida aleatoriamente no início de cada jogo.
- **Representação da Forca**: A forca é desenhada progressivamente no console, com cada erro do jogador.
- **Feedback Visual**: As letras adivinhadas são exibidas na posição correta.
- **Contagem de Erros**: O jogo acompanha o número de erros cometidos pelo jogador e termina quando o máximo permitido é alcançado

# Requisitos

- .NET SDK (recomendado .NET 8.0 ou superior) para compilação e execução do projeto.

# Como Usar
- Clone o Repositório

```
git clone https://github.com/otaviobrignoni/jogo-da-forca-2025.git
```
 
- Navegue até a pasta raiz da solução

``` 
cd jogo-da-forca-2025
```

 - Restaure as dependências

```	 
dotnet restore
```

 - Navegue até a pasta do projeto

```	 
cd JogoDaForca.ConsoleApp
```	

 - Execute o projeto

```	
dotnet run
```