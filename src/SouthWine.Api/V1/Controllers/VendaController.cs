using AutoMapper;
using SouthWine.Business.Intefaces;
using SouthWine.Business.Services;
using SouthWine.Data.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SouthWine.Api.Controllers;

namespace SouthWine.Api.V1.Controllers
{
    //[Authorize]
    //[ApiVersion("1.0")]
    //[Route("api/v{version:apiVersion}/fornecedores")]
    //public class VendaController : MainController
    //{
    //    private readonly IVendaRepository _vendaRepository;
    //    private readonly IVendaService _vendaService;
    //    private readonly IMapper _mapper;

    //    public VendaController(IVendaRepository vendaRepository,
    //                               IMapper mapper,
    //                               IVendaService vendaService,
    //                               INotificador notificador,
    //                               IUser user) : base(notificador, user)
    //    {
    //        _vendaRepository = vendaRepository;
    //        _mapper = mapper;
    //        _vendaService = vendaService;
        
    //    }
    //}
}
