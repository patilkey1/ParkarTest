using LeaseManagement.ClientModels;
using LeaseManagement.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeaseManagement.LeaseService
{
    public class SubscriptionService : ISubscriptionService
    {
        public bool CreateSubscription(LeaseModel leaseModel)
        {
            // Save DTO information in database using dapper and response with success or error
            return true;
        }
    }
}
