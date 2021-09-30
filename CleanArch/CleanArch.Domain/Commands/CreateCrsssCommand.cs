using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Domain.Commands
{
    public class CreateCrsssCommand : CrsssCommand
    {
        public CreateCrsssCommand(string name, string description, string imageurl)
        {
            Name = name;
            Description = description;
            ImageUrl = imageurl;

        }
    }
}
