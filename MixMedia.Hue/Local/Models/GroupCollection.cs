using System;
using System.Collections.Generic;
using System.Text;

namespace MixMedia.Hue.Local.Models
{
    public class GroupCollection : Dictionary<string, Group>
    {
        public GroupCollection() : base()
        {
            // Default Group always containing all lights
            Add("0", new Group(){ Name = "All lights"});
        }
    }
}
