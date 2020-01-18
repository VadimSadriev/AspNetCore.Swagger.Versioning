using AspNetCore.Swagger.Versioning.Contracts.v2.Account;
using AspNetCore.Swagger.Versioning.Contracts.v2.Exceptions;
using AspNetCore.Swagger.Versioning.Exceptions;
using AspNetCore.Swagger.Versioning.Models;
using AspNetCore.Swagger.Versioning.Routes.v2;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace AspNetCore.Swagger.Versioning.Controllers.v2
{
    /// <summary> Work with accounts v2 </summary>
    [Route(AppRoutes.Account.AccountRoot)]
    public class AccountController : Controller
    {
        private static readonly List<Account> _accounts = new List<Account>();
        private readonly IMapper _mapper;

        /// <summary> Work with accounts </summary>
        public AccountController(IMapper mapper)
        {
            _mapper = mapper;
        }

        /// <summary>
        /// Creates new Account
        /// </summary>
        [HttpPost]
        [ProducesResponseType(typeof(AccountResponseContract), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ExceptionContract), StatusCodes.Status500InternalServerError)]
        public IActionResult CreateAccount([FromBody]AccountContract accountContract)
        {
            var lastId = !_accounts.Any()
                ? 0
                : _accounts.Max(x => x.Id);

            var newAccount = _mapper.Map<Account>(accountContract);
            newAccount.Id = ++lastId;

            _accounts.Add(newAccount);

            var responseContract = _mapper.Map<AccountResponseContract>(newAccount);

            return Ok(responseContract);
        }

        /// <summary>
        /// Returns Account by identifier
        /// </summary>
        [HttpGet(AppRoutes.Account.GetAccountByName)]
        [ProducesResponseType(typeof(AccountResponseContract), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ExceptionContract), StatusCodes.Status500InternalServerError)]
        public IActionResult GetAccountByName([FromRoute]string name)
        {
            var account = _accounts.FirstOrDefault(x => x.Name == name);

            if (account == null)
                throw new AppException($"Account with name='{name}' not found");

            var responseContract = _mapper.Map<AccountResponseContract>(account);

            return Ok(account);
        }

        /// <summary>
        /// Returnes list of created accounts
        /// </summary>
        [HttpGet]
        [ProducesResponseType(typeof(ICollection<AccountResponseContract>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ExceptionContract), StatusCodes.Status500InternalServerError)]
        public IActionResult GetAccounts()
        {
            var responseAccounts = _mapper.Map<ICollection<AccountResponseContract>>(_accounts);

            return Ok(responseAccounts);
        }
    }
}
