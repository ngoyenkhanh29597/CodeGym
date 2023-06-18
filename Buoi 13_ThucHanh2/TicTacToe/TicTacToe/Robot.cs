using System;
namespace TicTacToe
{
	public class Robot : Player
	{
        List<int> lstNumber;
		public Robot(char playerSign = 'X') : base (playerSign)
		{
			lstNumber = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
		}
		public void removeCell(int k)
		{
			lstNumber.Remove(k);
		}
		public override int takeTurn()
		{
			Random rd = new Random();
			int k = rd.Next(0, lstNumber.Count);
			return lstNumber[k];
		}
	}
}

