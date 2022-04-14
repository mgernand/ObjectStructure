namespace ObjectStructure
{
	using Fluxera.Guards;
	using JetBrains.Annotations;

	/// <inheritdoc />
	[PublicAPI]
	public sealed class StructureBuilder : IStructureBuilder
	{
		private readonly ISchemaFactory schemaFactory;
		private readonly IStructureIndicesFactory structureIndicesFactory;
		private readonly IStructureTypeFactory structureTypeFactory;

		/// <summary>
		///     Creates a new instance of the  <see cref="StructureBuilder" /> type.
		/// </summary>
		/// <param name="structureTypeFactory"></param>
		/// <param name="schemaFactory"></param>
		/// <param name="structureIndicesFactory"></param>
		public StructureBuilder(
			IStructureTypeFactory structureTypeFactory = null,
			ISchemaFactory schemaFactory = null,
			IStructureIndicesFactory structureIndicesFactory = null)
		{
			this.structureTypeFactory = structureTypeFactory ?? new StructureTypeFactory();
			this.schemaFactory = schemaFactory ?? new SchemaFactory();
			this.structureIndicesFactory = structureIndicesFactory ?? new StructureIndicesFactory();
		}

		/// <inheritdoc />
		public Structure CreateStructure<T>(T item)
		{
			Guard.Against.Null(item, nameof(item));

			StructureType structureType = this.structureTypeFactory.CreateType<T>();
			StructureSchema structureSchema = this.schemaFactory.CreateSchema(structureType);

			StructureIndices structureIndices = this.structureIndicesFactory.CreateIndices(structureSchema, item);
			return new Structure(structureSchema, structureIndices);
		}

		/// <inheritdoc />
		public Structure CreateStructure<T>()
		{
			StructureType structureType = this.structureTypeFactory.CreateType<T>();
			StructureSchema structureSchema = this.schemaFactory.CreateSchema(structureType);

			return new Structure(structureSchema);
		}
	}
}
