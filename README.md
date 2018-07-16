# Webapi using ASP.NET CORE 

Good way to understand how .NET CORE is different compared to standard .NET is to build something so I started building API using ASP.NET CORE(https://github.com/Sumeetgaara/Webapi).

Followings things I noticed during development.

1. **Dependency Injection(DI)**:DI is baked in and heavily used in ASP.NET CORE.It is good since it will provide loose coupling.I think you can still use third party DI containers.

2. **Middleware and HTTP pipeline**: Middle ware is new concept introduced in .NET world.
Standard definition from MSDN website(ASP.NET Core Middleware (https://docs.microsoft.com/en-us/aspnet/core/fundamentals/middleware/?view=aspnetcore-2.1&tabs=aspnetcore2x)):
Middleware is software that's assembled into an application pipeline to handle requests and responses.
Each component:
-Chooses whether to pass the request to the next component in the pipeline.
-Can perform work before and after the next component in the pipeline is invoked.
<br/>
Basically, you have good amount of control on how request will flow,in which order and this is interesting because it will help you to write custom middleware for each request.
For example I wrote piece of code that will send mail every time a new request comes{probably not a good idea to do} but writing custom middleware is powerful.
<br/>
<br/>

3. **Krestel Server**
It is default webserver for ASP.NET CORE is lightweight,cross platorm and supports faster I/O operations. Krestel is recommended to use behind IIS that means IIS will act as proxy whereas Krestel will be handling requests.
I know there are more new concepts and features in .net core, I will be exploring them and if possible write a post like this.
Happy Coding and Learning:)

