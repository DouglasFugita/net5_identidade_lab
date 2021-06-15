# Labs de controle de identidade

## Identity
Implementado Identity baseado em um projeto WebAPI

Adicionado ao projeto inicial:
- pasta Data que contem o IdentityContext
- pasta Configuration para segregar as alteracoes do Startup para o Identity

## Identity JWT
Projeto baseado no projeto Identity, que foi alterado para o uso com JWT
- IdentityConfiguration alterado para utilizar JWT
- Criado o CustomAuthorize para validacao de Claims
- No AuthController foi adicionada a geracao do token JWT
- No ConfigureServices, a declaracao do swagger foi alterada para aceitar o token

## Referencias:
- Authorization for ASP.NET Web APIs (https://auth0.com/blog/aspnet-web-api-authorization/)
- ASP.NET 5 – Autenticação e Autorização com Bearer e JWT - (https://balta.io/artigos/aspnet-5-autenticacao-autorizacao-bearer-jwt)
- Canal dotNET - Implementando JWT de forma fácil e customizada no ASP.NET Core Web API (https://www.youtube.com/watch?v=ccVmPgxNE6c)
- Canal dotNET - ASP.NET Core + JWT: do básico ao avançado (https://www.youtube.com/watch?v=hNYw9uz2OeY)
- ASP.NET Core 3.0 MVC Secure Authentication (https://developer.okta.com/blog/2019/11/15/aspnet-core-3-mvc-secure-authentication)
- Demo for Keycloak Integration in ASP.NET Core and Angular. (https://github.com/thinktecture-labs/webinar-keycloak)
- An introduction to OpenID Connect in ASP.NET Core (https://andrewlock.net/an-introduction-to-openid-connect-in-asp-net-core/)
- ASP.NET Core + JWT: Guia de Referência (https://renatogroffe.medium.com/asp-net-core-jwt-guia-de-refer%C3%AAncia-3c071bf2a927)
- .NET Core + JWT + Polly + Refit: consumindo APIs seguras com simplicidade e resiliência (https://renatogroffe.medium.com/net-core-jwt-polly-refit-consumindo-apis-seguras-com-simplicidade-e-resili%C3%AAncia-c259015cb627)