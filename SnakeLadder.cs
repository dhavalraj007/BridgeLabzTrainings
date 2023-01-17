namespace MyApp
{
    class SnakeLadder
    {
        private int Player1Pos=0;
        private int Player2Pos=0;
        private Random random;
        public bool finished = false;

        public SnakeLadder()
        {
            random = new Random();
            System.Console.WriteLine("Welcome to Snake and Ladder!");
        }

        public void Player1RollMove()
        {
            System.Console.WriteLine("You are on "+Player1Pos);
            PlayerRollMove(ref Player1Pos);
            System.Console.WriteLine("You are now on "+Player1Pos +"\n");
            showPositions();
        }

   
        public void Player2RollMove()
        {
            System.Console.WriteLine("You are on "+Player2Pos);
            PlayerRollMove(ref Player2Pos);
            System.Console.WriteLine("You are now on "+Player2Pos +"\n");
            showPositions();
        }
        public void showPositions()
        {
            System.Console.WriteLine($"\n(Player 1's Position = {Player1Pos} , Player 2's Position = {Player2Pos})\n");
        }
        private void PlayerRollMove(ref int PlayerPos)
        {
            int dice = random.Next(1,7);
            System.Console.WriteLine("Rolled "+dice);
            int action = random.Next(1,4);
            
            if(action==1 && PlayerPos/10 != 9)   // Ladder && (if not the last row)
            {
                System.Console.WriteLine("You Landed on a Ladder!");
                int upper = Math.Min(99,(PlayerPos/10)*10+10+1);
                PlayerPos = random.Next(upper,Math.Min(upper+50,99));
            }
            else if(action==2 && PlayerPos/10!=0) //Snake && (if not the first row)
            {
                System.Console.WriteLine("You Landed on a Snake!");
                int lower = (PlayerPos/10)*10;
                PlayerPos = random.Next(0,lower+1);
            }
            else
            {
                PlayerPos = Math.Min(99,PlayerPos+dice);
            }
            if(PlayerPos>=99)
            {
                System.Console.WriteLine("You Won!");
                finished = true;
            }
        }

        public void reset()
        {
            Player1Pos = 0;
            Player2Pos = 0;
            finished = false;
        }
    }
}