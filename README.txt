Proejeto feito em Asp Net core,

Se atentar no arquivo appsettings.json para string de conexão com banco.

Feito a conexão como os migrations estão prontos só é necessario fazer um update no terminal do nugets 
Update-Databe

Depois se atentar no cors na classe Program.cs

O mesmo só permite a comunicação de duas urls, verificar quais portas você esta utilizando para modifica-las de acordo

No meu caso foi utilizado:

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowSpecificOrigins,
                      policy =>
                      {
                          policy.WithOrigins("https://localhost:7080",
                                              "http://localhost:4200")
                          .AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin();
                      });
});

7080 para o back e 4200 para front.