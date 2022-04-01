﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UTTT.Ejemplo.Linq.Data.EntityMarket
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="marketplace_bd")]
	public partial class DcMarketDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Definiciones de métodos de extensibilidad
    partial void OnCreated();
    partial void Insertcliente(cliente instance);
    partial void Updatecliente(cliente instance);
    partial void Deletecliente(cliente instance);
    partial void Insertproducto(producto instance);
    partial void Updateproducto(producto instance);
    partial void Deleteproducto(producto instance);
    partial void Insertusuario(usuario instance);
    partial void Updateusuario(usuario instance);
    partial void Deleteusuario(usuario instance);
    partial void Insertvendedor(vendedor instance);
    partial void Updatevendedor(vendedor instance);
    partial void Deletevendedor(vendedor instance);
    #endregion
		
		public DcMarketDataContext() : 
				base(global::UTTT.Ejemplo.Linq.Data.Properties.Settings.Default.marketplace_bdConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DcMarketDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DcMarketDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DcMarketDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DcMarketDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<cliente> cliente
		{
			get
			{
				return this.GetTable<cliente>();
			}
		}
		
		public System.Data.Linq.Table<producto> producto
		{
			get
			{
				return this.GetTable<producto>();
			}
		}
		
		public System.Data.Linq.Table<usuario> usuario
		{
			get
			{
				return this.GetTable<usuario>();
			}
		}
		
		public System.Data.Linq.Table<vendedor> vendedor
		{
			get
			{
				return this.GetTable<vendedor>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.cliente")]
	public partial class cliente : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id_cliente;
		
		private int _id_usuario;
		
		private EntityRef<usuario> _usuario;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onid_clienteChanging(int value);
    partial void Onid_clienteChanged();
    partial void Onid_usuarioChanging(int value);
    partial void Onid_usuarioChanged();
    #endregion
		
		public cliente()
		{
			this._usuario = default(EntityRef<usuario>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_cliente", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id_cliente
		{
			get
			{
				return this._id_cliente;
			}
			set
			{
				if ((this._id_cliente != value))
				{
					this.Onid_clienteChanging(value);
					this.SendPropertyChanging();
					this._id_cliente = value;
					this.SendPropertyChanged("id_cliente");
					this.Onid_clienteChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_usuario", DbType="Int NOT NULL")]
		public int id_usuario
		{
			get
			{
				return this._id_usuario;
			}
			set
			{
				if ((this._id_usuario != value))
				{
					if (this._usuario.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Onid_usuarioChanging(value);
					this.SendPropertyChanging();
					this._id_usuario = value;
					this.SendPropertyChanged("id_usuario");
					this.Onid_usuarioChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="usuario_cliente", Storage="_usuario", ThisKey="id_usuario", OtherKey="id_usuario", IsForeignKey=true)]
		public usuario usuario
		{
			get
			{
				return this._usuario.Entity;
			}
			set
			{
				usuario previousValue = this._usuario.Entity;
				if (((previousValue != value) 
							|| (this._usuario.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._usuario.Entity = null;
						previousValue.cliente.Remove(this);
					}
					this._usuario.Entity = value;
					if ((value != null))
					{
						value.cliente.Add(this);
						this._id_usuario = value.id_usuario;
					}
					else
					{
						this._id_usuario = default(int);
					}
					this.SendPropertyChanged("usuario");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.producto")]
	public partial class producto : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id_producto;
		
		private string _nombre;
		
		private decimal _precio;
		
		private int _id_vendedor;
		
		private EntityRef<vendedor> _vendedor;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onid_productoChanging(int value);
    partial void Onid_productoChanged();
    partial void OnnombreChanging(string value);
    partial void OnnombreChanged();
    partial void OnprecioChanging(decimal value);
    partial void OnprecioChanged();
    partial void Onid_vendedorChanging(int value);
    partial void Onid_vendedorChanged();
    #endregion
		
		public producto()
		{
			this._vendedor = default(EntityRef<vendedor>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_producto", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id_producto
		{
			get
			{
				return this._id_producto;
			}
			set
			{
				if ((this._id_producto != value))
				{
					this.Onid_productoChanging(value);
					this.SendPropertyChanging();
					this._id_producto = value;
					this.SendPropertyChanged("id_producto");
					this.Onid_productoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nombre", DbType="VarChar(30) NOT NULL", CanBeNull=false)]
		public string nombre
		{
			get
			{
				return this._nombre;
			}
			set
			{
				if ((this._nombre != value))
				{
					this.OnnombreChanging(value);
					this.SendPropertyChanging();
					this._nombre = value;
					this.SendPropertyChanged("nombre");
					this.OnnombreChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_precio", DbType="Decimal(18,0) NOT NULL")]
		public decimal precio
		{
			get
			{
				return this._precio;
			}
			set
			{
				if ((this._precio != value))
				{
					this.OnprecioChanging(value);
					this.SendPropertyChanging();
					this._precio = value;
					this.SendPropertyChanged("precio");
					this.OnprecioChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_vendedor", DbType="Int NOT NULL")]
		public int id_vendedor
		{
			get
			{
				return this._id_vendedor;
			}
			set
			{
				if ((this._id_vendedor != value))
				{
					if (this._vendedor.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Onid_vendedorChanging(value);
					this.SendPropertyChanging();
					this._id_vendedor = value;
					this.SendPropertyChanged("id_vendedor");
					this.Onid_vendedorChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="vendedor_producto", Storage="_vendedor", ThisKey="id_vendedor", OtherKey="id_vendedor", IsForeignKey=true)]
		public vendedor vendedor
		{
			get
			{
				return this._vendedor.Entity;
			}
			set
			{
				vendedor previousValue = this._vendedor.Entity;
				if (((previousValue != value) 
							|| (this._vendedor.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._vendedor.Entity = null;
						previousValue.producto.Remove(this);
					}
					this._vendedor.Entity = value;
					if ((value != null))
					{
						value.producto.Add(this);
						this._id_vendedor = value.id_vendedor;
					}
					else
					{
						this._id_vendedor = default(int);
					}
					this.SendPropertyChanged("vendedor");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.usuario")]
	public partial class usuario : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id_usuario;
		
		private string _nombre;
		
		private string _contraseña;
		
		private string _estado;
		
		private string _direccion;
		
		private string _perfil;
		
		private EntitySet<cliente> _cliente;
		
		private EntitySet<vendedor> _vendedor;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onid_usuarioChanging(int value);
    partial void Onid_usuarioChanged();
    partial void OnnombreChanging(string value);
    partial void OnnombreChanged();
    partial void OncontraseñaChanging(string value);
    partial void OncontraseñaChanged();
    partial void OnestadoChanging(string value);
    partial void OnestadoChanged();
    partial void OndireccionChanging(string value);
    partial void OndireccionChanged();
    partial void OnperfilChanging(string value);
    partial void OnperfilChanged();
    #endregion
		
		public usuario()
		{
			this._cliente = new EntitySet<cliente>(new Action<cliente>(this.attach_cliente), new Action<cliente>(this.detach_cliente));
			this._vendedor = new EntitySet<vendedor>(new Action<vendedor>(this.attach_vendedor), new Action<vendedor>(this.detach_vendedor));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_usuario", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id_usuario
		{
			get
			{
				return this._id_usuario;
			}
			set
			{
				if ((this._id_usuario != value))
				{
					this.Onid_usuarioChanging(value);
					this.SendPropertyChanging();
					this._id_usuario = value;
					this.SendPropertyChanged("id_usuario");
					this.Onid_usuarioChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nombre", DbType="VarChar(30)")]
		public string nombre
		{
			get
			{
				return this._nombre;
			}
			set
			{
				if ((this._nombre != value))
				{
					this.OnnombreChanging(value);
					this.SendPropertyChanging();
					this._nombre = value;
					this.SendPropertyChanged("nombre");
					this.OnnombreChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_contraseña", DbType="VarChar(30) NOT NULL", CanBeNull=false)]
		public string contraseña
		{
			get
			{
				return this._contraseña;
			}
			set
			{
				if ((this._contraseña != value))
				{
					this.OncontraseñaChanging(value);
					this.SendPropertyChanging();
					this._contraseña = value;
					this.SendPropertyChanged("contraseña");
					this.OncontraseñaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_estado", DbType="VarChar(30) NOT NULL", CanBeNull=false)]
		public string estado
		{
			get
			{
				return this._estado;
			}
			set
			{
				if ((this._estado != value))
				{
					this.OnestadoChanging(value);
					this.SendPropertyChanging();
					this._estado = value;
					this.SendPropertyChanged("estado");
					this.OnestadoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_direccion", DbType="VarChar(30)")]
		public string direccion
		{
			get
			{
				return this._direccion;
			}
			set
			{
				if ((this._direccion != value))
				{
					this.OndireccionChanging(value);
					this.SendPropertyChanging();
					this._direccion = value;
					this.SendPropertyChanged("direccion");
					this.OndireccionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_perfil", DbType="VarChar(50)")]
		public string perfil
		{
			get
			{
				return this._perfil;
			}
			set
			{
				if ((this._perfil != value))
				{
					this.OnperfilChanging(value);
					this.SendPropertyChanging();
					this._perfil = value;
					this.SendPropertyChanged("perfil");
					this.OnperfilChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="usuario_cliente", Storage="_cliente", ThisKey="id_usuario", OtherKey="id_usuario")]
		public EntitySet<cliente> cliente
		{
			get
			{
				return this._cliente;
			}
			set
			{
				this._cliente.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="usuario_vendedor", Storage="_vendedor", ThisKey="id_usuario", OtherKey="id_usuario")]
		public EntitySet<vendedor> vendedor
		{
			get
			{
				return this._vendedor;
			}
			set
			{
				this._vendedor.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_cliente(cliente entity)
		{
			this.SendPropertyChanging();
			entity.usuario = this;
		}
		
		private void detach_cliente(cliente entity)
		{
			this.SendPropertyChanging();
			entity.usuario = null;
		}
		
		private void attach_vendedor(vendedor entity)
		{
			this.SendPropertyChanging();
			entity.usuario = this;
		}
		
		private void detach_vendedor(vendedor entity)
		{
			this.SendPropertyChanging();
			entity.usuario = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.vendedor")]
	public partial class vendedor : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id_vendedor;
		
		private int _id_usuario;
		
		private EntitySet<producto> _producto;
		
		private EntityRef<usuario> _usuario;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onid_vendedorChanging(int value);
    partial void Onid_vendedorChanged();
    partial void Onid_usuarioChanging(int value);
    partial void Onid_usuarioChanged();
    #endregion
		
		public vendedor()
		{
			this._producto = new EntitySet<producto>(new Action<producto>(this.attach_producto), new Action<producto>(this.detach_producto));
			this._usuario = default(EntityRef<usuario>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_vendedor", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id_vendedor
		{
			get
			{
				return this._id_vendedor;
			}
			set
			{
				if ((this._id_vendedor != value))
				{
					this.Onid_vendedorChanging(value);
					this.SendPropertyChanging();
					this._id_vendedor = value;
					this.SendPropertyChanged("id_vendedor");
					this.Onid_vendedorChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_usuario", DbType="Int NOT NULL")]
		public int id_usuario
		{
			get
			{
				return this._id_usuario;
			}
			set
			{
				if ((this._id_usuario != value))
				{
					if (this._usuario.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Onid_usuarioChanging(value);
					this.SendPropertyChanging();
					this._id_usuario = value;
					this.SendPropertyChanged("id_usuario");
					this.Onid_usuarioChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="vendedor_producto", Storage="_producto", ThisKey="id_vendedor", OtherKey="id_vendedor")]
		public EntitySet<producto> producto
		{
			get
			{
				return this._producto;
			}
			set
			{
				this._producto.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="usuario_vendedor", Storage="_usuario", ThisKey="id_usuario", OtherKey="id_usuario", IsForeignKey=true)]
		public usuario usuario
		{
			get
			{
				return this._usuario.Entity;
			}
			set
			{
				usuario previousValue = this._usuario.Entity;
				if (((previousValue != value) 
							|| (this._usuario.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._usuario.Entity = null;
						previousValue.vendedor.Remove(this);
					}
					this._usuario.Entity = value;
					if ((value != null))
					{
						value.vendedor.Add(this);
						this._id_usuario = value.id_usuario;
					}
					else
					{
						this._id_usuario = default(int);
					}
					this.SendPropertyChanged("usuario");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_producto(producto entity)
		{
			this.SendPropertyChanging();
			entity.vendedor = this;
		}
		
		private void detach_producto(producto entity)
		{
			this.SendPropertyChanging();
			entity.vendedor = null;
		}
	}
}
#pragma warning restore 1591
