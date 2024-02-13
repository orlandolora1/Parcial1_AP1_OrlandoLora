using Parcial1_AP1_OrlandoLora.Dal;
using Parcial1_AP1_OrlandoLora.Models;
using System.Linq.Expressions;

namespace Parcial1_AP1_OrlandoLora.Services
{
	public class MetasService
{
		private readonly Contexto _contetexto;

		public MetasService(Contexto contetexto)
		{
			_contetexto = contetexto;
		}

			public async Task<bool> Crear(Metas metas)
			 public async Task<bool> Crear(Metas metas)
		{
			if (!await Existe(metas.MetasId))
				return await Insertar(metas);
			else
				return await Modificar(metas);
		}

		private Task<bool> Insertar(Metas metas)
		{
			throw new NotImplementedException();
		}

		public async Task<bool> Existe(int id)
		{
			return await _contexto.METAS.AnyAsync(a => a.MetasId == id);
		}
		public async Task<bool> Insertar(Metas metas)
		{
			_contexto.Metas.Add(metas);
			return await _contexto.SaveChangesAsync() > 0;
		}
		public async Task<bool> Modificar(Metas metas)
		{
			_contexto.Metas.Update(metas);
			var modificar = await _contexto.SaveChangesAsync() > 0;
			_contexto.Entry(metas).State = EntityState.Detached;
			return modificar;
		}
		public async Task<bool> Eliminar(Metas metas)
		{
			var eliminar = await _contexto.METAS
				.Where(a => a.AporteId == metas.MetasId)
				.ExecuteDeleteAsync();
			return eliminar > 0;
		}
		public async Task<Metas?> Buscar(int id)
		{
			return await _contexto.Metas
				.AsNoTracking()
				.FirstOrDefaultAsync(a => a.MetasId == id);
		}
		public async Task<List<Metas>> Listar(Expression<Func<Metas, bool>> criterio)
		{
			return await _contexto.Metas
				.AsNoTracking()
				.Where(criterio)
				.ToListAsync();
		}
	}


										 