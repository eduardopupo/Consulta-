Consulta+ - Sistema de Consulta Médica
Consulta+ é uma aplicação web simples que permite aos usuários consultar informações detalhadas sobre consultas médicas. O sistema é composto por um front-end moderno em React e uma API robusta construída com .NET Core e Entity Framework para gerenciamento de dados. A aplicação integra com um banco de dados SQLite, proporcionando uma solução leve e eficiente para armazenar as informações das consultas médicas, pacientes e médicos.

Este projeto foi desenvolvido com foco em aprendizado e implementação de conceitos modernos de desenvolvimento web, utilizando tanto a arquitetura de front-end como back-end para construir uma aplicação funcional e interativa.

Funcionalidades
Consulta de Consultas Médicas: O usuário pode inserir o ID de uma consulta para buscar detalhes sobre a consulta médica.

Exibição de Dados Detalhados: A aplicação retorna informações completas sobre a consulta, incluindo dados do paciente (nome e documento) e do médico (nome e especialidade).

Interface Simples e Intuitiva: A interface foi projetada com foco em usabilidade e experiência do usuário, utilizando uma abordagem minimalista com boa usabilidade.

Sistema Responsivo: A aplicação é responsiva, adaptando-se bem a diferentes tamanhos de tela para garantir uma boa experiência tanto em dispositivos móveis quanto em desktop.

Tecnologias Usadas
Frontend (Interface do Usuário)
React + TypeScript: Desenvolvimento da interface de usuário com segurança de tipos.

Axios: Comunicação assíncrona com a API.

CSS Puro: Estilização com foco em simplicidade e boa experiência visual.

Vite: Bundler e servidor de desenvolvimento para o React.

Backend (API e Banco de Dados)
.NET Core: Desenvolvimento da API RESTful.

Entity Framework Core: ORM para manipulação do banco de dados SQLite.

SQLite: Banco de dados leve para armazenar consultas, pacientes e médicos.

CORS: Configurado para permitir comunicação entre o front-end e o back-end em diferentes portas.

Ferramentas de Desenvolvimento
Visual Studio: Desenvolvimento e gerenciamento do back-end.

Node.js e npm: Ambiente de execução e gerenciamento de pacotes para o front-end.

Postman: Testes de requisições HTTP para a API.

Swagger: Documentação interativa da API.

Pré-requisitos
Antes de começar, você precisa ter instalado em sua máquina:

.NET SDK 8.0 ou superior

Node.js (v18 ou superior)

npm (gerenciador de pacotes que vem junto com o Node.js)

(Opcional) Visual Studio 2022 ou superior para desenvolvimento backend

(Opcional) Postman para testar a API

Configuração do Ambiente
Certifique-se de que o .NET SDK esteja corretamente instalado (dotnet --version).

Certifique-se que o Node.js e o npm estejam instalados (node -v e npm -v).

O banco de dados SQLite já está integrado e será gerado automaticamente na primeira execução da API, sem necessidade de configuração manual.

As portas utilizadas são:

API: http://localhost:5028

Frontend: http://localhost:5173

Se desejar alterar as portas, ajuste:

API: no arquivo launchSettings.json

Frontend: no arquivo vite.config.ts

Como Rodar o Projeto

Backend (API)

Clone o repositório:

git clone https://github.com/eduardopupo/Consulta-
Navegue até a pasta da API:

Restaure os pacotes e compile o projeto:

dotnet build

Rode as migrações (caso necessário para popular o banco inicial):

dotnet ef database update

Inicie a aplicação:

dotnet run

A API estará disponível em http://localhost:5028.

Acesse http://localhost:5028/swagger para visualizar a documentação interativa da API.

Frontend (Aplicação React)

Navegue até a pasta do frontend:

Instale as dependências:

npm install

Inicie o servidor de desenvolvimento:

npm run dev

Abra o navegador e acesse:

http://localhost:5173

Como Usar a Aplicação:

Na tela inicial, insira o ID de uma consulta médica para buscar seus detalhes.

Os detalhes incluem:

Informações do paciente (nome, documento)

Informações do médico (nome, especialidade)

Data e hora da consulta

A API consulta o banco SQLite para retornar os dados em tempo real.

Estrutura do Projeto

consulta-plus/
├── consulta-api/        # Backend em .NET Core
│   ├── Controllers/
│   ├── Models/
│   ├── Data/
│   └── Program.cs
├── consulta-front/      # Frontend em React
│   ├── src/
│   ├── public/
│   └── vite.config.ts
