﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckoutKata
{
    public class PriceCalculations
    {
        public static int UnitPriceA = 10;
        public static int UnitPriceB = 15;
        public static int UnitPriceC = 40;
        public static int UnitPriceD = 55;

        public static decimal TotalPriceA(int PriceA, int QuantA)
        {
            return PriceA * QuantA;
        }

        public static decimal TotalPriceB(int PriceB, int QuantB)
        {
            //discount condition; if B is bought in batches of 3, pay 40 for 3
            int DiscountPriceB = 40;
            int DiscountBatchB = 3;
            
            if (QuantB % DiscountBatchB == 0)
            { 
                return DiscountPriceB * (QuantB/ DiscountBatchB); 
            }
            //just return normal price otherwise
            else
            {
                return PriceB * QuantB;
            }

                
        }

        public static decimal TotalPriceC(int PriceC, int QuantC)
        {
            return PriceC * QuantC;
        }

        public static decimal TotalPriceD(int PriceD, int QuantD)
        {
            //discount condition; apply a 25% off discount for all pairs of items
            decimal DiscountPriceD = 0.75m;
            int DiscountBatchD = 2;
            if (QuantD % DiscountBatchD == 0)
            {
                return PriceD * DiscountPriceD * QuantD;
            }
            //for odd numbers, don't count the last item in a discount
            else if (QuantD % DiscountBatchD != 0)
            {
                return PriceD * (DiscountPriceD * (QuantD -1 ) + 1);
            }
            //if there's only one item
            else
            {
                return PriceD * QuantD;
            }
            
            
        }

        public static decimal TotalPrice( decimal TotA, decimal TotB, decimal TotC, decimal TotD)
        {
            return TotA + TotB + TotC + TotD;
        }
    }
}
