using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoList.App.Views
{
	internal class View
	{
		public enum ActionTaken
		{
			Quit,
			Add,
			Edit,
			Delete,
			None
		}

		public void RenderLogo()
		{
			Console.Clear();
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("X======================X");
			Console.WriteLine("X                      X");
			Console.WriteLine("X     My Todo List     X");
			Console.WriteLine("X                      X");
			Console.WriteLine("X======================X");
			Console.ResetColor();
		}

		public void RenderMainMenu() 
		{
			RenderLogo();
			Console.WriteLine("1. Show my Todos");
			Console.WriteLine("2. Add a Todo");
			Console.WriteLine("3. Edit a Todo");
			Console.WriteLine("4. Delete a todo");
			Console.WriteLine("0. Quit the program");
		}
	}
}
