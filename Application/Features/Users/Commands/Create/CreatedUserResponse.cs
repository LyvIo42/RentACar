using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System.Globalization;

namespace Application.Features.Users.Commands.Create
{
    public class CreatedUserResponse
    {
        public int Id { get; set; }
        public string FirsTName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public bool Status { get; set; }
        public CreatedUserResponse()
        {
            FirsTName = string.Empty;
            LastName = string.Empty;
            Email = string.Empty;
        }

        public CreatedUserResponse(int id, string firsTName, string lastName, string email, bool status)
        {
            Id = id;
            FirsTName = firsTName;
            LastName = lastName;
            Email = email;
            Status = status;
        }
    }

}