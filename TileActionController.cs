using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remont_Na_Plo4ki_MVC
{
    public class TileActionController
    {

        Model topicalModel = new Model();
        View topicalView=new View();
        public void Run()
        {
            topicalView.InputInfoSize();
            topicalModel.N = topicalView.N;
            topicalModel.W = topicalView.W;
            topicalModel.L = topicalView.L;
            topicalModel.M = topicalView.M;
            topicalModel.O = topicalView.O;

            topicalModel.CalculateTile();

            topicalView.Tile = topicalModel.Tile;
            topicalView.Time = topicalModel.CalculateTime();
            topicalView.OutputInfoTotal();
        }
    }
}
