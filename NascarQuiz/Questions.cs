
﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NascarQuiz
{
    class Questions
    {
        // use the bool to check answers
        // round 1 will be ten questions
        
        public static void init() 
        {
          string[] round1Questions = new string[10];
            // populate the array with data
            round1Questions[0] = "When was the 1st Daytona 500 ran?";
            round1Questions[1] = "Where was the first NASCAR race held";
            round1Questions[2] = "Who was the first driver to win 3 NASCAR Cup series Championships?";
            round1Questions[3] = "What is the longest track on the NASCAR Cup Series Circut?";
            round1Questions[4] = "Who was the first foreign manufactuer to win a NASCAR Cup Race?";
            round1Questions[5] = "As of 2020, Jimmie Johnson, Dale Earnhardt and one other person have won 7 Championships. Who is the other person?";
            round1Questions[6] = "When was the first televised NASCAR Race?";
            round1Questions[7] = "What was the closest margin of victory in NASCAR History";
            round1Questions[8] = "When was the first NASCAR Race on asphalt?";
            round1Questions[9] = "How many races did Micheal Waltrip win during his entire NASCAR Career in the Cup Series";
            // round 2 will have 5 question
             string[] round2Questions = new string[5];
            round2Questions[0] = "What year was the current playoff format intoduced?";
            round2Questions[1] = "Who was the 1st NASCAR Cup Series Champion";
            round2Questions[2] = "Where was the original start of the NASCAR Cup series Season?";
            round2Questions[3] = "Who was the first African American to win a NASCAR Cup Series Championship?";
            round2Questions[4]= "What year was the first Talladega 500?";
        
        }
    }
}
