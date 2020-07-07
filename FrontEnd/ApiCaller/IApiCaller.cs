using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FrontEnd.ApiCaller
{
    public interface IApiCaller
    {
        Task<T> GetServiceResponse<T>(string controller);

        Task<T> GetServiceResponseById<T>(string controller, int id);

        Task<T> PostServiceResponse<T>(string controller, T element);
    }
}
