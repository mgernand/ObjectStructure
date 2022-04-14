namespace ObjectStructure
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using Fluxera.Guards;
	using JetBrains.Annotations;

	/// <inheritdoc />
	[PublicAPI]
	public sealed class SchemaFactory : ISchemaFactory
	{
		private static IDictionary<Type, StructureSchema> schemaCache = new Dictionary<Type, StructureSchema>();

		private static readonly string MissingMembersMessage =
			"The item of type '{0}' has no members that can be indexed. " +
			"There's no point in treating items that has nothing to index.";

		/// <inheritdoc />
		public StructureSchema CreateSchema(StructureType structureType)
		{
			Guard.Against.Null(structureType, nameof(structureType));

			if(!schemaCache.TryGetValue(structureType.Type, out StructureSchema structureSchema))
			{
				IndexAccessor[] indexAccessors = this.GetIndexAccessors(structureType);
				if((indexAccessors == null) || (indexAccessors.Length < 1))
				{
					throw new InvalidOperationException(string.Format(MissingMembersMessage, structureType.Name));
				}

				structureSchema = new StructureSchema(structureType, indexAccessors);
				schemaCache.Add(structureType.Type, structureSchema);
			}

			return structureSchema;
		}

		private IndexAccessor[] GetIndexAccessors(StructureType structureType)
		{
			IList<IndexAccessor> indexAccessors = new List<IndexAccessor>(structureType.Properties.Length);

			foreach(StructureProperty structureProperty in structureType.Properties)
			{
				indexAccessors.Add(new IndexAccessor(structureProperty));
			}

			return indexAccessors.ToArray();
		}
	}
}
