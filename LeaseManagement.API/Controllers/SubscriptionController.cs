using AutoMapper;
using LeaseManagement.ClientModels;
using LeaseManagement.Models;
using LeaseManagement.LeaseService;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Http;
using System.Net.Http;
using Microsoft.AspNetCore.Http.Extensions;
using System.Net;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LeaseManagement.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class SubscriptionController : ControllerBase
    {

        private readonly IMapper _mapper;
        private readonly ISubscriptionService _subscriptionService;

        public SubscriptionController(IMapper mapper, ISubscriptionService subscriptionService)
        {
            _mapper = mapper;
            _subscriptionService = subscriptionService;
        }

        [HttpPost]      
        public HttpResponseMessage SaveLease([FromBody] LeaseViewModel leaseModel)
        {
            HttpResponseMessage result;

            try
            {
                if (!ModelState.IsValid)
                {
                    result = new HttpResponseMessage(HttpStatusCode.BadRequest);
                    return result;
                }

                var leaseData = _mapper.Map<LeaseModel>(leaseModel);
                var output =_subscriptionService.CreateSubscription(leaseData);
                result = output ? new HttpResponseMessage(HttpStatusCode.OK) : new HttpResponseMessage(HttpStatusCode.ExpectationFailed);
            }
            catch (Exception ex)
            {
                //Log exception details,stack trace
                result = new HttpResponseMessage(HttpStatusCode.InternalServerError);
            }
            
            return result;
        }
    }
}
