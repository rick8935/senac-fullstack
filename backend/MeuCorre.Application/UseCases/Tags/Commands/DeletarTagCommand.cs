using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuCorre.Application.UseCases.Tags.Commands
{
    public class DeletarTagCommad : IRequest<(string, bool)>
    {
        [Required(ErrorMessage = "E necessário informar o id do usuário")]
        public required Guid UsuarioId { get; set; }

        [Required(ErrorMessage = "E necessário informar o id da tag")]
        public required Guid TagId { get; set; }
    }

    internal class DeletarTagCommandHandler : IRequestHandler<DeletarTagCommad, (string, bool)>
    {
        public Task<(string, bool)> Handle(DeletarTagCommad request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
