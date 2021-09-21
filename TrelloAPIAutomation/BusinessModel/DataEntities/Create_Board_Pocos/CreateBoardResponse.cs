using System;
using System.Collections.Generic;
using System.Text;

namespace TrelloAPIAutomation.BusinessModel.DataEntities.Create_Board_Pocos
{
    public class CreateBoardResponse
    {
        public string id { get; set; }
        public string name { get; set; }
        public string desc { get; set; }
        public string descData { get; set; }
        public string closed { get; set; }
        public string idOrganization { get; set; }
        public string idEnterprise { get; set; }
        public string pinned { get; set; }
        public string url { get; set; }
        public string shortUrl { get; set; }
        public BoardPrefs prefs { get; set; }
        public BoardLabelNames labelNames { get; set; }
        public BoardLimits limits { get; set; }
    }
}
