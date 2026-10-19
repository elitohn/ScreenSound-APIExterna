# Screen Sound — API Externa

Aplicação de console em **C#/.NET** para consumir um catálogo de músicas em JSON e explorar consultas usando **LINQ**.

## Funcionalidades
- Requisição HTTP a uma API pública de músicas
- Desserialização JSON em objetos C#
- Filtros por tonalidade, gênero e artista
- Ordenação de artistas
- Modelo de músicas favoritas com opção de exportação JSON

**Estado atual:** a execução principal chama o filtro por tonalidade. Outros exemplos estão presentes no código, mas comentados; para experimentá-los, habilite as chamadas desejadas em `Program.cs`.

## Tecnologias
C#, .NET, `HttpClient`, `System.Text.Json` e LINQ.

## Como executar

Instale um .NET SDK compatível com o arquivo `.csproj` e execute:

```bash
git clone https://github.com/elitohn/ScreenSound-APIExterna.git
cd ScreenSound-APIExterna
dotnet run --project ScreenSound-APIExterna
```

É necessária conexão com a internet para obter os dados da API.

## Estrutura
- `Program.cs`: requisição, desserialização e chamadas dos filtros
- `Modelos/Musica.cs`: representação das músicas
- `Modelos/MusicasPreferidas.cs`: organização de favoritos
- `Filtros/LinqFilter.cs`: filtros LINQ
- `Filtros/LinqOrder.cs`: ordenação

## Conceitos praticados
Programação assíncrona, APIs HTTP, tratamento de exceções, serialização e consultas sobre coleções.

Desenvolvido por **Wellyton Huan** como projeto de estudo.