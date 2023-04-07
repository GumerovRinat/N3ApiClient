using RestSharp;
using System.Runtime.CompilerServices;

namespace N3ApiClient.N3RestClient.Abstrations
{
    public interface IN3RestClient
    {
        IRestClient Client { get; }

        void Delete(string url, object body, Parameter[] parameters = null, [CallerMemberName] string apiMethodName = null);
        string Get(string url, Parameter[] parameters = null, [CallerMemberName] string apiMethodName = null);
        T Get<T>(string url, Parameter[] parameters = null, [CallerMemberName] string apiMethodName = null);
        void Post(string url, object body, Parameter[] parameters = null, [CallerMemberName] string apiMethodName = null);
        T Post<T>(string url, object body, Parameter[] parameters = null, [CallerMemberName] string apiMethodName = null);
        void Put(string url, object body, Parameter[] parameters = null, [CallerMemberName] string apiMethodName = null);
        void Put(string url, string body, [CallerMemberName] string apiMethodName = null);
    }
}