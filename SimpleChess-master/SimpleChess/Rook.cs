using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using System.Transactions;

namespace SimpleChess
{
    class Rook : Piece
    {
        public Rook() : base("Rook"){}
        public override bool Move(string fromPosition, string toPosition)
        {            
            return fromPosition[0] == toPosition[0] || fromPosition[1] == toPosition[1];        
        }
    }
}
