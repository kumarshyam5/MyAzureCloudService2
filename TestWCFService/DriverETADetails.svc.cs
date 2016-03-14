#region namespace
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using TestWCFService.BusinessObjects;
#endregion

namespace TestWCFService
{
    /// <summary>
    /// class for handling driver details
    /// </summary>
    [ServiceBehavior(AddressFilterMode = AddressFilterMode.Any)]
    public class DriverETADetails : IDriverETADetails
    {

        /// <summary>
        /// Method to return driver details
        /// </summary>
        /// <param name="Id">driver id</param>
        /// <returns>driver details</returns>
        public DriverDetail getDriverDetails(string Id)
        {
           //creating a driverDetail object
            DriverDetail details = new DriverDetail();
            try
            {
                using (ETDDbModelContext context = new ETDDbModelContext())
                {
                    context.Configuration.ProxyCreationEnabled = false;
                    int driverID = Convert.ToInt32(Id);
                    //setting the values to details object
                    details = (from c in context.DriverDetails
                               where c.driver_id == driverID
                               select c).FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            //returning the result
            return details;
        }

        /// <summary>
        /// Method to return driver details
        /// </summary>
        /// <returns>list of drivers</returns>
        public List<DriverDetail> getDrivers()
        {
            //creating a list of drivers
            List<DriverDetail> details = new List<DriverDetail>();
            try
            {
                using (ETDDbModelContext context = new ETDDbModelContext())
                {
                    context.Configuration.ProxyCreationEnabled = false;
                    //setting the values to details
                    details = (from c in context.DriverDetails
                               select c).ToList();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            //returning the result
            return details;
        }
    }
}
