using Parcial1_AP1_OrlandoLora.Models;
using System.Collections.Generic;

namespace Parcial1_AP1_OrlandoLora.Dal
{
	public class Contexto : DbContext
	{
		public Contexto(DbContextOptions<Context> options) : base(options)
		{
		}

	}

	public class DbContextOptions<T>
	{
	}

	public class DbContext
	{
		private DbContextOptions<Context> options;

		public DbContext(DbContextOptions<Context> options)
		{
			this.options = options;
		}
	}
}