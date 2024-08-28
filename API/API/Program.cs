// Testar as APIs
// - Rest Client - Extensão do VS Code
// - Postman
// - Insomnia
//MINIMAL APIs
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//EndPoints - Funcionalidades
//Configurar a URL e o metodo/verbo
app.MapGet("/", () => "Hello World! em C#");
app.MapGet("/segundafuncionalidade", () => "segunda funcionalidade da API");
app.MapGet("/retornarendereco", () => 
{
    dynamic endereco = new {
      rua = "Parigot de Souza",
      numero = 5300,
      ceo = "81290-350"  
    };
    return endereco;
});


app.Run();
