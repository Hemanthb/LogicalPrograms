using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class ChangeVendingMachineUc7
    {
        int noOfFives=0,noOfTens=0,noOfFifties=0,noOfHundreds=0,noOfFiveHund=0,noOfThousands=0,value, noOfOnes = 0, noOfTwos = 0, total = 1;
        int[] placeValues; 
        List<int> rupees = new List<int>();
        public void CalculateChange(String amount)
        {
            int len = amount.Length;
            placeValues = new int[len];
            int amt = Convert.ToInt32(amount);
            for (int i = 0; i < len; i++) 
            {
                int rem = amt % 10;
                placeValues[i] = rem * total;
                amt = amt / 10;
                total = total * 10;
            }
            foreach (int cash in placeValues)
            {
                if(cash >= 1000)
                {
                    rupees.Add(1000);
                    noOfThousands = cash / 1000;
                }
                else if(cash>= 100 && cash <= 999)
                {
                    if (cash >= 500)
                    {
                        int remAmt = cash - 500;
                        noOfHundreds = remAmt / 100;
                        noOfFiveHund = 1;
                        rupees.Add(500);
                        rupees.Add(100);
                    }
                    else
                    {
                        noOfHundreds = cash / 100;
                        rupees.Add(100);
                    }
                }
                else if (cash >= 10 && cash <= 99)
                {
                    if (cash >= 50)
                    {
                        int remAmt = cash - 50;
                        noOfTens = remAmt / 10;
                        noOfFifties = 1;
                        rupees.Add(50);
                        rupees.Add(10);
                    }
                    else
                    {
                        noOfTens = cash / 100;
                        rupees.Add(10);
                    }
                }
                else
                {
                    if(cash == 1)
                    {
                        noOfOnes++;
                        rupees.Add(1);
                    }
                    else if(cash == 2)
                    {
                        noOfTwos++;
                        rupees.Add(2);
                    }
                    else if(cash == 5)
                    {
                        noOfFives = 1;
                        rupees.Add(5);
                    }
                    else
                    {
                        if (cash > 5)
                        {
                            noOfFives = 1;
                            rupees.Add(5);
                            if (cash%2 == 0)
                            {
                                noOfOnes = 1;
                                if(cash == 8)
                                {
                                    noOfTwos = 1;
                                    rupees.Add(2);
                                }
                                rupees.Add(1);
                            }
                            else
                            {
                                for (int i = 2; i <= (cash-5); i += 2)
                                {
                                    noOfTwos++;
                                }
                                rupees.Add(2);
                            }
                        }
                        else
                        {
                            if(cash == 3)
                            {
                                noOfTwos++;
                                noOfOnes++;
                                rupees.Add(2);
                                rupees.Add(1);
                            }
                            else
                            {
                                noOfTwos+=2;
                                rupees.Add(2);
                            }
                        }
                    }
                }

            }
            int totalCashNo = noOfOnes + noOfTwos + noOfFives + noOfTens + noOfFifties + noOfHundreds + noOfFiveHund + noOfThousands;
            Console.WriteLine("Minimum no of currencies required for exchange --- "+totalCashNo);
            Console.WriteLine("Currencies used to give exchange are --");
            foreach(int rs in rupees)
            {
                Console.WriteLine("Rs."+rs);
            }
        }
    }
}
