using System;

class Code{


    static void Main(string[] args)
    {
        int numberofplayer1;
        int numberofplayer2;

        int winroundofplayer1 = 0;
        int winroundofplayer2 = 0;

        Random random = new Random();

        for(int i = 0; i <6; i++)
        {
            Console.WriteLine("To continue press any button");
            Console.ReadKey();

            numberofplayer1=random.Next(1,7);
            Console.WriteLine("Player1's dice:"+numberofplayer1);

            numberofplayer2 =random.Next(1,7);
            Console.WriteLine("Player2's dice:"+numberofplayer2);


            if (numberofplayer1 > numberofplayer2)
            {
                winroundofplayer1++;
            }
            else if(numberofplayer1 < numberofplayer2)
            {
                winroundofplayer2++;
            }
            else
            {
                Console.WriteLine("Draw Round!");
            }
            Console.WriteLine(" | Player1's score : " + winroundofplayer1 + " | Player2's score : " + winroundofplayer2);
        }
        if (winroundofplayer1 > winroundofplayer2)
        {
            Console.WriteLine("You WON! Player1 ");
        }
        else if (winroundofplayer1 < winroundofplayer2)
        {
            Console.WriteLine("You WON! Player2 ");
        }
        else
        {
            Console.WriteLine("DRAW!!");
        }
    }
}