using aspnetcore_person_api.Data;
using aspnetcore_person_api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;

[ApiController]
[Route("[controller]")]
public class PersonController : ControllerBase
{
    private readonly AppDBContext _context;

    public PersonController(AppDBContext context)
    {
        _context = context;
    }

    // GET /person
    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var people = await _context.Person.ToListAsync();
        return Ok(people);
    }

    // GET /person/{id}
    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var person = await _context.Person.FindAsync(id);
        if (person == null)
            return NotFound(new { message = "Person not found." });

        return Ok(person);
    }

    // POST /person
    [HttpPost]
    public async Task<IActionResult> Post([FromBody] Person newPerson)
    {
        _context.Person.Add(newPerson);
        await _context.SaveChangesAsync();
        return CreatedAtAction(nameof(GetById), new { id = newPerson.Id }, newPerson);
    }

    // PUT /person/{id}
    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, [FromBody] Person updatedPerson)
    {
        var person = await _context.Person.FindAsync(id);
        if (person == null)
            return NotFound(new { message = "Person not found." });

        person.Name = updatedPerson.Name;
        person.LastName = updatedPerson.LastName;
        person.Age = updatedPerson.Age;

        await _context.SaveChangesAsync();
        return Ok(person);
    }

    // DELETE /person/{id}
    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var person = await _context.Person.FindAsync(id);
        if (person == null)
            return NotFound(new { message = "Person not found." });

        _context.Person.Remove(person);
        await _context.SaveChangesAsync();
        return Ok(new { message = "Person deleted successfully!" });
    }
}
