using markettoptanci.Business.Abstract;
using markettoptanci.Business.Concrete;
using markettoptanci.Entities.Modals;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.Configure<SmtpSettings>(builder.Configuration.GetSection("SmtpSettings"));
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddSingleton<IEmailSender,EmailSenderService>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddCors(c =>
{
    c.AddPolicy("All", p => p.AllowAnyHeader().AllowAnyOrigin().AllowAnyMethod());
});

var app = builder.Build();




// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.UseCors("All");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
