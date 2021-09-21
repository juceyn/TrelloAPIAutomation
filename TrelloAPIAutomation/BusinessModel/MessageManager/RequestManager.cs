using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using RestSharp;
using TrelloAPIAutomation.BusinessModel.Builders;
using TrelloAPIAutomation.BusinessModel.DataEntities.Create_Board_Pocos;

namespace TrelloAPIAutomation.BusinessModel.MessageManager
{
    public class RequestManager
    {
        
        RestClient _restClient;

        public RequestManager (RestClient restClient)
        {
            _restClient = restClient;
        }



        public IRestResponse CreateBoard (string boardName)
        {
            RestRequest createBoardRequest = new RestRequest("/boards/");
            CreateBoardRequest body = new CreateBoardBuilder()
                .WithName(boardName)
                .Build();
            createBoardRequest.AddHeader("Content-Type", "application/json");
            createBoardRequest.AddQueryParameter("key", "ff57a15bb862db8f3fa366345935e1dc");
            createBoardRequest.AddQueryParameter("token", "a6ae2699e6b782fdbc0720209a7d2283638f6bde43261a7120f0649b2ddec5f8");
            createBoardRequest.AddJsonBody(body);          
            return _restClient.Post(createBoardRequest);
        }

    }
}
