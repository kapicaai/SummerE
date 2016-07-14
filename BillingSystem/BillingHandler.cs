using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BillingDBModels;
using Billing;

namespace BillingSystem
{
    public class BillingHandler
    {
        public BillingHandler()
        {

        }
        
        public void NewCallInfoHandler(object sender, PhoneStation.CallInfo newItem)
        {

        }

        public void Add(IUser newUser)
        {
            Client client = new Client()
            {
                FullName = newUser.FullName
            };
            using (IBillingRepository<Client> billingRepository = new BillingRepository<Client>())
            {
                billingRepository.Add(client);
                billingRepository.SaveChanges();
            }
        }

        public void Add(IBillingPlan newPlan)
        {

        }

        public void Add(IContract newContract)
        {

        }

        public void Add(PhoneStation.CallInfo newItem)
        {

        }

        public void BindContractToBillingPlan(IContract contract, IBillingPlan plan, DateTime actual) 
            //установка тарифа для договора
        {

        }

        public void CloseContract(IContract contract, DateTime closeDate)
        {

        }
    }
}
