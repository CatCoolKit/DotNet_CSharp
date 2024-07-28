using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using StudentManagerVFluentValidation.Entities;

namespace StudentManagerVFinalFantasy.Entities
{
    public class StudentValidator : AbstractValidator<Student>
    {
        public StudentValidator()
        {
            RuleFor(s => s.Name).NotEmpty().WithMessage("Name is required");
            RuleFor(s => s.Yob).InclusiveBetween(1900, DateTime.Now.Year).WithMessage("Year of birth must be between 1900 and current year");
            RuleFor(s => s.Gpa).InclusiveBetween(0, 4).WithMessage("GPA must be between 0 and 4");

        }
    }
}
