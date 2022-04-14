namespace ObjectStructure
{
	using System;
	using Fluxera.Guards;
	using JetBrains.Annotations;

	/// <summary>
	///     Contains the info of the <see cref="StructureProperty" />.
	/// </summary>
	[PublicAPI]
	public sealed class StructurePropertyInfo
	{
		/// <summary>
		///     Creates a new instance of the <see cref="StructurePropertyInfo" /> type.
		/// </summary>
		/// <param name="name"></param>
		/// <param name="type"></param>
		/// <param name="attributes"></param>
		/// <param name="parent"></param>
		internal StructurePropertyInfo(string name, Type type, Attribute[] attributes, StructureProperty parent = null)
		{
			Guard.Against.NullOrWhiteSpace(name, nameof(name));
			Guard.Against.Null(type, nameof(type));
			Guard.Against.Null(attributes, nameof(attributes));

			this.Name = name;
			this.Type = type;
			this.Attributes = attributes;
			this.Parent = parent;
		}

		/// <summary>
		///     Gets the name of the property.
		/// </summary>
		public string Name { get; }

		/// <summary>
		///     Gets the type of the property.
		/// </summary>
		public Type Type { get; }

		/// <summary>
		///     Gets the attributes of that are added to the property.
		/// </summary>
		public Attribute[] Attributes { get; }

		/// <summary>
		///     Gets the optional parent property.
		/// </summary>
		internal StructureProperty Parent { get; }
	}
}
