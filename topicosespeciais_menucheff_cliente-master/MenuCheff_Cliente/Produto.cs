using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuCheff_Cliente
{
	public class Produto
	{
		public int id;
		public string name;

		public Produto(int id, string name)
		{
			this.id = id;
			this.name = name;
		}

		public override string ToString()
		{
			return name;
		}
	}
}
