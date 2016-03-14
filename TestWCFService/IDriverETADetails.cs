using System.Collections.Generic;
#region Namespaces
using System.ServiceModel;
using System.ServiceModel.Web;
using TestWCFService.BusinessObjects;
#endregion

namespace TestWCFService
{
    
    /// <summary>
    /// Interface for DriverETA details
    /// </summary>
    [ServiceContract]
    public interface IDriverETADetails
    {
        /// <summary>
        /// Method to return DriverDetails
        /// </summary>
        /// <param name="Id">driver id</param>
        /// <returns>driver details</returns>
        [OperationContract]
        [WebInvoke(Method = "GET", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "driver/{id}")]
        DriverDetail getDriverDetails(string Id);


        /// <summary>
        /// Method to return drivers
        /// </summary>
        /// <returns>list of drivers</returns>
        [OperationContract]
        [WebInvoke(Method = "GET", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "/drivers")]
        List<DriverDetail> getDrivers();

        
    }
}
