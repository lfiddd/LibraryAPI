using LibraryAPI.Interfaces;
using LibraryAPI.Requests;
using Microsoft.AspNetCore.Mvc;

namespace LibraryAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ControllerToGenre
{
    private readonly IServiceLibrary _service;

    public ControllerToGenre(IServiceLibrary service) => _service = service;

    [HttpGet]
    public async Task<IActionResult> GetAll() => await _service.GetAllGenresAsync();

    [HttpPost]
    public async Task<IActionResult> Create(QueryGenres genre) => await _service.CreateGenreAsync(genre);

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, QueryGenres genre) => await _service.UpdateGenreAsync(id, genre);

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id) => await _service.DeleteGenreAsync(id);
}