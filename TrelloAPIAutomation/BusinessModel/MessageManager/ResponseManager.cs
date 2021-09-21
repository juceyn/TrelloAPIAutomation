using NUnit.Framework;
using RestSharp;


namespace TrelloAPIAutomation.BusinessModel.MessageManager
{
    public class ResponseManager
    {
        public void ValidateOKResponse(IRestResponse response)
        {
            Assert.AreEqual("application/json; charset=utf-8", response.ContentType.ToString());
            Assert.AreEqual("OK", response.StatusCode.ToString());
        }
    }
}
