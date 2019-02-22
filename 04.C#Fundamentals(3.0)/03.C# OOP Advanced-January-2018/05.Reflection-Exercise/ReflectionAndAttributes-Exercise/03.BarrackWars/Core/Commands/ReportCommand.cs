using _03BarracksFactory.Contracts;
using _03BarracksFactory.Core.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace _03BarrackWars.Core.Commands
{
    public class ReportCommand : Command
    {
        private IRepository repository;

        public ReportCommand(string[] data, IRepository repository) 
            : base(data)
        {
            this.Repository = repository;
        }

        protected IRepository Repository
        {
            get { return this.repository; }
            set { this.repository = value; }
        }
        

        public override string Execute()
        {
            string output = this.Repository.Statistics;
            return output;
        }
    }
}
