namespace ObjectStructure.UnitTests.Model
{
	public class Class1
	{
		//[Test]
		//public void ShouldCreateStructureTypeForComplexEnumerableProperty()
		//{
		//	Type type = typeof(ComplexEnumerableModel);
		//	IStructureTypeFactory factory = new StructureTypeFactory();
		//	StructureType structureType = factory.CreateType<ComplexEnumerableModel>();
		//	structureType.Should().NotBeNull();

		//	structureType.Type.Should().Be(type);
		//	structureType.Name.Should().Be(type.Name);
		//	structureType.Properties.Should().NotBeNullOrEmpty();
		//	structureType.Properties.Should().HaveCount(2);

		//	structureType.Properties[0].Type.Should().Be(typeof(IList<ComplexType>));
		//	structureType.Properties[0].Name.Should().Be("ListProperty");
		//	structureType.Properties[0].Path.Should().Be("ListProperty");

		//	structureType.Properties[1].Type.Should().Be(typeof(string));
		//	structureType.Properties[1].Name.Should().Be("StringProperty");
		//	structureType.Properties[1].Path.Should().Be("ListProperty[*].StringProperty");

		//	//structureType.Properties[0].Parent.Should().BeNull();
		//	//structureType.Properties[0].Attributes.Should().HaveCount(0);
		//	//structureType.Properties[0].IsRootProperty.Should().BeTrue();
		//	//structureType.Properties[0].IsEnumerable.Should().BeFalse();
		//	//structureType.Properties[0].IsElement.Should().BeFalse();
		//	//structureType.Properties[0].ElementType.Should().BeNull();
		//}

		//[Test]
		//public void ShouldCreateStructureTypeForComplexProperty()
		//{
		//	Type type = typeof(ComplexModel);
		//	IStructureTypeFactory factory = new StructureTypeFactory();
		//	StructureType structureType = factory.CreateType<ComplexModel>();

		//	structureType.Should().NotBeNull();

		//	structureType.Type.Should().Be(type);
		//	structureType.Name.Should().Be(type.Name);
		//	structureType.Properties.Should().NotBeNullOrEmpty();
		//	structureType.Properties.Should().HaveCount(2);

		//	structureType.Properties[0].Type.Should().Be(typeof(ComplexType));
		//	structureType.Properties[0].Name.Should().Be("ComplexProperty");
		//	structureType.Properties[0].Path.Should().Be("ComplexProperty");

		//	structureType.Properties[1].Type.Should().Be(typeof(string));
		//	structureType.Properties[1].Name.Should().Be("StringProperty");
		//	structureType.Properties[1].Path.Should().Be("ComplexProperty.StringProperty");

		//	//structureType.Properties[0].Parent.Should().BeNull();
		//	//structureType.Properties[0].Attributes.Should().HaveCount(0);
		//	//structureType.Properties[0].IsRootProperty.Should().BeTrue();
		//	//structureType.Properties[0].IsEnumerable.Should().BeFalse();
		//	//structureType.Properties[0].IsElement.Should().BeFalse();
		//	//structureType.Properties[0].ElementType.Should().BeNull();
		//}

		//[Test]
		//public void ShouldCreateStructureTypeForSimpleEnumerableProperty()
		//{
		//	Type type = typeof(SimpleEnumerableModel);
		//	IStructureTypeFactory factory = new StructureTypeFactory();
		//	StructureType structureType = factory.CreateType<SimpleEnumerableModel>();

		//	structureType.Should().NotBeNull();

		//	structureType.Type.Should().Be(type);
		//	structureType.Name.Should().Be(type.Name);
		//	structureType.Properties.Should().NotBeNullOrEmpty();
		//	structureType.Properties.Should().HaveCount(1);

		//	structureType.Properties[0].Type.Should().Be(typeof(IList<string>));
		//	structureType.Properties[0].Name.Should().Be(nameof(SimpleEnumerableModel.ListProperty));
		//	structureType.Properties[0].Path.Should().Be(nameof(SimpleEnumerableModel.ListProperty));

		//	//structureType.Properties[0].Parent.Should().BeNull();
		//	//structureType.Properties[0].Attributes.Should().HaveCount(0);
		//	//structureType.Properties[0].IsRootProperty.Should().BeTrue();
		//	//structureType.Properties[0].IsEnumerable.Should().BeFalse();
		////structureType.Properties[0].IsElement.Should().BeFalse();
		////structureType.Properties[0].ElementType.Should().BeNull();
		//}

		//[Test]
		//public void ShouldCreateStructureTypeForSimpleProperty()
		//{
		//	Type type = typeof(SimpleModel);
		//	IStructureTypeFactory factory = new StructureTypeFactory();
		//	StructureType structureType = factory.CreateType<SimpleModel>();

		//	structureType.Should().NotBeNull();

		//	structureType.Type.Should().Be(type);
		//	structureType.Name.Should().Be(type.Name);
		//	structureType.Properties.Should().NotBeNullOrEmpty();
		//	structureType.Properties.Should().HaveCount(1);

		//	structureType.Properties[0].Type.Should().Be(typeof(string));
		//	structureType.Properties[0].Name.Should().Be(nameof(SimpleModel.StringProperty));
		//	structureType.Properties[0].Path.Should().Be(nameof(SimpleModel.StringProperty));
		//	//structureType.Properties[0].Parent.Should().BeNull();
		//	//structureType.Properties[0].Attributes.Should().HaveCount(0);
		//	//structureType.Properties[0].IsRootProperty.Should().BeTrue();
		//	//structureType.Properties[0].IsEnumerable.Should().BeFalse();
		//	//structureType.Properties[0].IsElement.Should().BeFalse();
		//	//structureType.Properties[0].ElementType.Should().BeNull();
		//}

		//[Test]
		//public void ShouldProvideValueForComplexProperty()
		//{
		//	IStructureBuilder builder = new StructureBuilder();
		//	ComplexModel instance = new ComplexModel
		//	{
		//		ComplexProperty = new ComplexType
		//		{
		//			StringProperty = "Hello"
		//		}
		//	};
		//	Structure structure = builder.CreateStructure(instance);

		//	structure.Should().NotBeNull();
		//	structure.Name.Should().Be(nameof(ComplexModel));
		//	structure.Indices.Should().HaveCount(2);

		//	structure.Indices[0].Type.Should().Be(typeof(ComplexType));
		//	structure.Indices[0].Name.Should().Be("ComplexProperty");
		//	structure.Indices[0].Path.Should().Be("ComplexProperty");
		//	structure.Indices[0].Value.Should().Be(instance.ComplexProperty);

		//	structure.Indices[1].Type.Should().Be(typeof(string));
		//	structure.Indices[1].Name.Should().Be("StringProperty");
		//	structure.Indices[1].Path.Should().Be("ComplexProperty.StringProperty");
		//	structure.Indices[1].Value.Should().Be("Hello");
		//}

		//[Test]
		//public void ShouldProvideValueForSimpleEnumerableProperty()
		//{
		//	IStructureBuilder builder = new StructureBuilder();
		//	SimpleEnumerableModel instance = new SimpleEnumerableModel
		//	{
		//		ListProperty = new List<string> { "Hello", "World" }
		//	};
		//	Structure structure = builder.CreateStructure(instance);

		//	structure.Should().NotBeNull();
		//	structure.Name.Should().Be(nameof(SimpleEnumerableModel));
		//	structure.Indices.Should().HaveCount(3);
		//}

		//[Test]
		//public void ShouldProvideValueForSimpleProperty()
		//{
		//	IStructureBuilder builder = new StructureBuilder();
		//	Structure structure = builder.CreateStructure(new SimpleModel
		//	{
		//		StringProperty = "Hello"
		//	});

		//	structure.Should().NotBeNull();
		//	structure.Name.Should().Be(nameof(SimpleModel));
		//	structure.Indices.Should().HaveCount(1);

		//	structure.Indices[0].Type.Should().Be(typeof(string));
		//	structure.Indices[0].Name.Should().Be("StringProperty");
		//	structure.Indices[0].Path.Should().Be("StringProperty");
		//	structure.Indices[0].Value.Should().Be("Hello");
		//}
	}
}
