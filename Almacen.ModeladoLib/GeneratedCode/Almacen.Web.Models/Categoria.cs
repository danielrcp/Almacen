﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace Almacen.Web.Models
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;

	public class Categoria
	{
		public int ID
		{
			get;
			set;
		}

		public string Nombre
		{
			get;
			set;
		}

		public virtual string Descripcion
		{
			get;
			set;
		}

		public virtual IEnumerable<Producto> Productos
		{
			get;
			set;
		}

	}
}

