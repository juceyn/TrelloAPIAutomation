using System.Configuration;
using Newtonsoft.Json;
using NUnit.Framework;
using RestSharp;
using RestSharp.Authenticators;
using TrelloAPIAutomation.BusinessModel.DataEntities.Create_Board_Pocos;
using TrelloAPIAutomation.BusinessModel.MessageManager;

namespace TrelloAPIAutomation
{
    [TestFixture]
    public class Tests
    {
        
        RestClient restClient;
        RequestManager requestManager;
        ResponseManager responseManager;


        [SetUp]
        public void Setup()
        {
            
            restClient = new RestClient("https://api.trello.com/1")
            {
                Authenticator = new HttpBasicAuthenticator("julio.ynojosa77@gmail.com", "P4ssw0rd."),
            };
            requestManager = new RequestManager(restClient);
            responseManager = new ResponseManager();
        }

        [Test]
        public void CreateBoard()
        {
            IRestResponse response = requestManager.CreateBoard("T3");
            responseManager.ValidateOKResponse(response);
            CreateBoardResponse responseContent = JsonConvert.DeserializeObject<CreateBoardResponse>(response.Content);
            Assert.AreEqual("T2", responseContent.name);
        }
    }
}