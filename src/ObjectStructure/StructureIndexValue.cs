namespace ObjectStructure
{
	using System;

	internal sealed class StructureIndexValue
	{
		/// <summary>
		///     Creates a new instance of the <see cref="StructureIndexValue" /> type.
		/// </summary>
		/// <param name="path"></param>
		/// <param name="value"></param>
		internal StructureIndexValue(string path, object value)
		{
			ArgumentException.ThrowIfNullOrEmpty(path, nameof(path));

			this.Path = path;
			this.Value = value;
		}

		/// <summary>
		///     Gets the path to the value of the property.
		/// </summary>
		public string Path { get; }

		/// <summary>
		///     Gets the value of the property.
		/// </summary>
		public object Value { get; }
	}
}
