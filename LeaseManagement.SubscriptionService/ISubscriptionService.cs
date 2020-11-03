using LeaseManagement.ClientModels;
using LeaseManagement.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeaseManagement.LeaseService
{
    public interface ISubscriptionService
    {
        bool CreateSubscription(LeaseModel leaseModel);
    }
}
