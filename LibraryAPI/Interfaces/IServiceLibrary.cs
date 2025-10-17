using LibraryAPI.Requests;
using Microsoft.AspNetCore.Mvc;


namespace LibraryAPI.Interfaces;

public interface IServiceLibrary
{
    // Users/Login
    Task<IActionResult> GetAllUsersAsync();
    Task<IActionResult> GetUserByIdAsync(int id);
    Task<IActionResult> CreateNewUserAndLoginAsync(QueryUsers newUser);
    Task<IActionResult> EditUserAndLoginAsync(int id, QueryUsers selectedUser);
    Task<IActionResult> DeleteUserAndLoginAsync(int id);

    // Books
    Task<IActionResult> GetAllBooksAsync();
    Task<IActionResult> GetBookByIdAsync(int id);
    Task<IActionResult> CreateBookAsync(QueryBooks book);
    Task<IActionResult> UpdateBookAsync(int id, QueryBooks book);
    Task<IActionResult> DeleteBookAsync(int id);
    Task<IActionResult> GetBooksByGenreAsync(string genreName);
    Task<IActionResult> SearchBooksAsync(string? author, string? title);

    // Users
    Task<IActionResult> CreateUserAsync(QueryUsers User);
    Task<IActionResult> UpdateUserAsync(int id, QueryUsers User);
    Task<IActionResult> DeleteUserAsync(int id);

    // Genres
    Task<IActionResult> GetAllGenresAsync();
    Task<IActionResult> CreateGenreAsync(QueryGenres genre);
    Task<IActionResult> UpdateGenreAsync(int id, QueryGenres genre);
    Task<IActionResult> DeleteGenreAsync(int id);

    // Rentals
    Task<IActionResult> RentBookAsync(QueryRents_StartDate rentalStart);
    Task<IActionResult> ReturnBookAsync(int rentalId);
    Task<IActionResult> GetRentalHistoryByUserAsync(int UserId);
    Task<IActionResult> GetRentalHistoryByBookAsync(int bookId);
    Task<IActionResult> GetCurrentRentalsAsync();
}