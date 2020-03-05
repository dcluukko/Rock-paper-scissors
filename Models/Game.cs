
namespace Game.Models
{
	public class Players
	{	
		public string PlayerOne { get; set; }
		public string PlayerTwo { get; set; }

		public Players (string playerOne, string playerTwo)
		{
			PlayerOne = playerOne;
			PlayerTwo = playerTwo;
			
		}
		public static void Win()
		{
			if (playerOne == playerTwo)
			{
				Console.WriteLine("Its a Draw!");
			}
			else if (playerOne == "scissors" && playerTwo == "paper" || playerOne == "paper" && playerTwo == "rock" || playerOne == "rock" && playerTwo == "scissors")
			{
				Console.WriteLine("Player one wins!");
			}
			else (playerTwo == "scissors" && playerOne == "paper" || playerTwo == "paper" && playerOne == "rock" || playerTwo == "rock" && playerOne == "scissors")
			{
				Console.WriteLine("Player Two Wins!!");
			}
		}		
	}
}