using LibraryAPI.Interfaces;
using LibraryAPI.Models;
using LibraryAPI.Requests;
using Microsoft.AspNetCore.Mvc;

namespace LibraryAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ControllerToUser : ControllerBase
{
    private readonly IServiceLibrary _service;
    public ControllerToUser(IServiceLibrary service) => _service = service;

    [HttpGet]
    public async Task<IActionResult> GetAll() => await _service.GetAllUsersAsync();

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id) => await _service.GetUserByIdAsync(id);

    [HttpPost]
    public async Task<IActionResult> Create(QueryUsers users) => await _service.CreateNewUserAndLoginAsync(users);

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, QueryUsers users) =>
        await _service.UpdateUserAndLoginAsync(id, users);

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id) => await _service.DeleteUserAndLoginAsync(id);
}