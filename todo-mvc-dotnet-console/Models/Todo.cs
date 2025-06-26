using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoList.App.Models
{
	public class Todo
	{
		public Guid Id { get; } = Guid.NewGuid();
		public string _description;

		public string Description
		{
			get => _description;
			set
			{

				if (string.IsNullOrWhiteSpace(value))
				{
					throw new ArgumentNullException("The description can't be empty.");
				}
				else
				{
					_description = value;
				}
			}
		}

		public Todo(string description)
		{
			Description = description;
		}
	}
}
