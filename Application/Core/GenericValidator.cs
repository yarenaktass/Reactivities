using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;

namespace Application.Core
{
    public class GenericValidator<T> : AbstractValidator<T> where T : class
    {
        public GenericValidator()
        {
            
        }
    }
}