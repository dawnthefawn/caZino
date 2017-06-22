﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
//using System.Threading.Tasks;

//Use .Value and .Face to to return each. 

namespace caZino
{
    public class Card
    {
        public string suit;
        public string face;
        public int rank;
        public int value;
        public string tag;
        public UnityEngine.Object cardskin;

/// <summary>
/// Caled by Shuffle.GenerateDeck(int numdecks)
/// </summary>
/// <param name="r">the rank passed from the Shuffle.GenerateDeck(int numdecks) loop</param>
/// <param name="s">the suit passed from the Shuffle.GenerateDeck(int numdecks) loop</param>

        public void Init(int r, string s)
        {
            rank = r;
            suit = s;
            value = setValue();
            tag = setTag();
            face = Face();
            cardskin = Resources.Load(tag + suit + ".fbx");
        }

//the next 3 functions set the cards variables during the Init phase.
 
       public string setTag()
        {
            string t = "";
                    switch (rank.ToString())
                    {
                        case "1": t = "A"; break;
                        case "11": t = "J"; break;
                        case "12": t = "Q"; break;
                        case "13": t = "K"; break;
                        default:  t = rank.ToString(); break;

                    }
            return t ;
                }
        

       public int setValue() 
        {
        if(rank > 9)
            { return 10; }
        else { return rank; }
        }


        public string Face() => tag + " of " + suit;

    }

   

}
