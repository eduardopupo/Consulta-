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
React: A principal tecnologia utilizada para o desenvolvimento da interface. O React é uma biblioteca popular para construir interfaces de usuário dinâmicas e interativas. Neste projeto, foi utilizado junto ao TypeScript, proporcionando uma tipagem estática e segurança no código.

Axios: Utilizado para realizar as requisições HTTP para a API. O Axios facilita a comunicação entre o front-end e o back-end, permitindo que dados sejam recuperados e exibidos de forma assíncrona.

CSS: A estilização da aplicação é feita com CSS puro. O design é simples e limpo, com ênfase em uma boa experiência visual e interatividade.

Vite: Vite foi utilizado como bundler e servidor de desenvolvimento. Ele permite uma experiência de desenvolvimento muito mais rápida devido ao seu tempo de build e hot-reload rápidos.

Backend (API e Banco de Dados)
.NET Core: A API foi construída utilizando .NET Core, um framework de código aberto da Microsoft para desenvolvimento de aplicações web. O ASP.NET Core é utilizado para criar a API RESTful que manipula as requisições feitas pela aplicação front-end.

Entity Framework (EF): O Entity Framework Core é utilizado para comunicação com o banco de dados SQLite. Ele permite o uso de ORM (Object-Relational Mapping) para acessar e manipular os dados no banco de dados de forma simples e eficiente.

SQLite: O banco de dados utilizado é o SQLite, um banco de dados relacional leve e embutido. Ele é ideal para aplicações de pequeno porte ou para protótipos devido à sua simplicidade e baixo custo de manutenção. Neste projeto, o SQLite armazena dados sobre consultas médicas, pacientes e médicos.

CORS: A configuração de CORS (Cross-Origin Resource Sharing) foi ajustada para permitir que o front-end, que é servido em uma porta diferente da API, possa realizar requisições para o back-end sem enfrentar problemas de segurança relacionados ao compartilhamento de recursos entre origens diferentes.

Ferramentas de Desenvolvimento e Ambiente
Visual Studio: Foi utilizado para o desenvolvimento do backend, com integração do Entity Framework e SQLite.

Node.js e npm: Para o front-end, utilizamos o Node.js junto com npm (Node Package Manager) para gerenciar as dependências e os scripts de desenvolvimento.

Postman: Para testar as APIs durante o desenvolvimento, foi utilizado o Postman, uma ferramenta útil para fazer requisições HTTP e visualizar as respostas.

Swagger: O Swagger foi configurado para a documentação da API, permitindo que desenvolvedores e usuários possam visualizar as rotas e testar a API diretamente na interface do Swagger UI.

Como Rodar o Projeto
Backend (API)
Clone o repositório e navegue até a pasta da API.

Certifique-se de ter o .NET SDK instalado na sua máquina.

Execute o comando dotnet build para compilar o projeto.

Execute o comando dotnet run para iniciar a API no http://localhost:5028.

A API estará disponível e pronta para responder a requisições de consulta com base no ID.

Frontend (Aplicação React)
Clone o repositório e navegue até a pasta consulta-front.

Instale as dependências com o comando:

bash
Copiar
Editar
npm install
Execute o comando:

bash
Copiar
Editar
npm run dev
Abra o navegador e acesse http://localhost:5173 para visualizar a aplicação em funcionamento.
