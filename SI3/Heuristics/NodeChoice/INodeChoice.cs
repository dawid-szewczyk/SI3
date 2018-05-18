using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SI3.Heuristics.NodeChoice
{
    interface INodeChoice
    {
        Node ChooseNode(Node parent);
    }
}
