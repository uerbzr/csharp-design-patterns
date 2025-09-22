using Microsoft.AspNetCore.Mvc;
using System;

namespace patterns.wwwapi.Endpoints
{
    public static class CarEndpoints
    {
        public static void ConfigureCar(this WebApplication app)
        {
            var cars = app.MapGroup("cars");

            

        }
        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetAll(IRepository repository)
        {
            var results = await repository.GetAll();
            return TypedResults.Ok(results);
        }
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public static async Task<IResult> Add(IRepository repository, PersonPost model)
        {
            try
            {

                Person person = new Person()
                {
                    Name = model.Name,
                    Age = model.Age,
                    Email = model.Email
                };
                await repository.Add(person);

                return TypedResults.Created($"https://localhost:7010/people/{person.Id}", person);
            }
            catch (Exception ex)
            {
                return TypedResults.Problem(ex.Message);
            }
        }
    }
}
