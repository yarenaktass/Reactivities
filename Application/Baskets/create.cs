// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;
// using Application.Core;
// using Domain;
// using FluentValidation;
// using MediatR;
// using Persistence;

// namespace Application.Baskets
// {
//     public class create
//     {
//         public class Command : IRequest<Result<Unit>>
//         {
//             public Basket Basket { get; set; }
//         }

//         public class CommandValidator : AbstractValidator<Command>
//         {
//             public CommandValidator()
//             {
//                 RuleFor(x => x.Basket).SetValidator(new BasketValidator());
//             }

//         }
//         public class Handler : IRequestHandler<Command, Result<Unit>>
//         {
//             private readonly DataContext _context;
//             public Handler(DataContext context)
//             {
//                 _context = context;
//             }

//             public async Task<Result<Unit>> Handle(Command request, CancellationToken cancellationToken)
//             {
            
//             }
//         }

//     }
// }