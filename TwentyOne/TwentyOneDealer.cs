﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
   public class TwentyOneDealer : Dealer

    {
        private List<Card> _hand = new List<Card>(); 

         public bool isBusted { get; set; }
         public bool Stay {  get; set; }

        public List<Card> Hand { get { return _hand; } set { _hand = value; } }
    }
}
