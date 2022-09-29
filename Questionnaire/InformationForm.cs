using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questionnaire;

internal class InformationForm
{
    public string? Name { get; set; }
    public string? Surname { get; set; }
    public string? FatherName { get; set; }
    public string? Country { get; set; }
    public string? City { get; set; }
    public string? Phone { get; set; }
    public string? Gender { get; set; }
    public DateTime BirthDate { get; set; }

    public InformationForm(string? name, string? surname, string? fatherName, string? country, string? city, string? phone, string? gender, DateTime birthDate)
    {
        Name = name;
        Surname = surname;
        FatherName = fatherName;
        Country = country;
        City = city;
        Phone = phone;
        Gender = gender;
        BirthDate = birthDate;
    }
}
