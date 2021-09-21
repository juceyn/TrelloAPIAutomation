using System;
using System.Collections.Generic;
using System.Text;
using TrelloAPIAutomation.BusinessModel.DataEntities.Create_Board_Pocos;

namespace TrelloAPIAutomation.BusinessModel.Builders
{
    public class CreateBoardBuilder
    {
        private string _name;

        public CreateBoardBuilder WithName(string name)
        {
            _name = name;
            return this;
        }

        public CreateBoardRequest Build()
        {
            return new CreateBoardRequest
            {
                name = _name
            };
        }
    }
}
