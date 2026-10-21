<div align="center">

<img src="https://capsule-render.vercel.app/api?type=waving&height=175&color=0:0F172A,55:164E63,100:0891B2&text=Screen%20Sound%20API&fontColor=FFFFFF&fontSize=34&fontAlignY=38&desc=M%C3%BAsicas%2C%20API%20externa%20e%20LINQ&descAlignY=61&descSize=15" alt="Capa do projeto Screen Sound API" width="100%" />

![Tecnologia](https://img.shields.io/badge/C%23%20%26%20.NET-0F172A?style=flat-square) ![Idioma](https://img.shields.io/badge/documentação-pt--BR-0891B2?style=flat-square) ![Tipo](https://img.shields.io/badge/projeto-de%20estudo-334155?style=flat-square)

</div>

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