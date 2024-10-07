
# FraudWatch

FraudWatch é uma aplicação para realizar o gerenciamento de dentistas e analistas, além de reduzir fraudes em sinistros odontológicos.

## Objetivo
Gerenciar dados de dentistas e analistas.

## Requisitos
- **Funcionais**: Operações de Cadastro, leitura, atualização e remoção de dados.
- **Não Funcionais**: Arquitetura limpa, desempenho, segurança.

## Arquitetura (Clean Architecture)
- **Apresentação**: APIs REST para gerenciar dentistas e analistas, além da interação com a equipe de análise.
- **Aplicação**: Serviços que implementam as operações CRUD e lógica de negócios.
- **Domínio**: Entidades de dentistas, analistas e regras de negócio.
- **Infraestrutura**: Repositórios e persistência de dados com Entity Framework.

## Tecnologias
- C#, ASP.NET Core, Entity Framework Core, Oracle SQL, Swagger.

## Configuração
1. Clone o repositório: `git clone https://github.com/Luiz1614/FraudWatch-Csharp.git`
2. Configure a string de conexão no `appsettings.json`.
3. Execute as migrações: `dotnet ef database update`
4. Inicie a aplicação: `dotnet run`
