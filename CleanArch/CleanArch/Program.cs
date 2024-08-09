using Application.Features.Books;
using Application.Interfaces;
using Domain;
using Infrastructure;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<IBookRepository, BookRepository>();

var app = builder.Build();


//app.UseHttpsRedirection();


app.MapGet("/books", (IBookRepository bookRepository) =>
{
    var getBooksQuery = new GetBooksQuery(bookRepository);
    return getBooksQuery.Handle();
});

app.MapGet("/books/{id}", (int id, IBookRepository bookRepository) =>
{
    var getBooksQuery = new GetBookByIdQuery(bookRepository);
    return getBooksQuery.Handle(id);
});

app.MapPost("/books/", ([FromBody] BookEntity book, IBookRepository bookRepository) =>
{
    var getBooksQuery = new CreateBookCommand(bookRepository);
    getBooksQuery.Handle(book);
});

app.Run();

