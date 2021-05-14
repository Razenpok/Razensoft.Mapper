Razensoft.Mapper
======================================================

A simple and fast (fastest?) object to object mapper that does not use reflection. Read [A Simple and Fast Object Mapper](https://rehansaeed.com/a-simple-and-fast-object-mapper/) for more information.

## DISCLAIMER

Most of the code in this library is originating from the awesome [Dotnet-Boxed](https://github.com/Dotnet-Boxed/Framework) framework which you should definitely check out.

Differences between **Razensoft.Mapper** (1.0.0) and **Dotnet-Boxed** (v5.2.0):

- Renamed root namespace from `Boxed.Mapping` to `Razensoft.Mapper`
- Replaced `Task` with `UniTask` in async mapping
- Splitted extensions into separate files grouped by extension name

## Installation

Add this line to your `manifest.json` file:

```
"com.razensoft.mapper": "https://github.com/Razenpok/Razensoft.Mapper.git?path=src/Razensoft.Mapper#1.0.0",
```

UPM should automatically install the package.

## Usage

```c#
public class MapFrom
{
    public bool BooleanFrom { get; set; }
    public int IntegerFrom { get; set; }
    public List<MapFromChild> ChildrenFrom { get; set; }
}
public class MapFromChild
{
    public DateTimeOffset DateTimeOffsetFrom { get; set; }
    public string StringFrom { get; set; }
}

public class MapTo
{
    public bool BooleanTo { get; set; }
    public int IntegerTo { get; set; }
    public List<MapToChild> ChildrenTo { get; set; }
}
public class MapToChild
{
    public DateTimeOffset DateTimeOffsetTo { get; set; }
    public string StringTo { get; set; }
}

public class DemoMapper : IMapper<MapFrom, MapTo>
{
    private readonly IMapper<MapFromChild, MapToChild> childMapper;

    public DemoMapper(IMapper<MapFromChild, MapToChild> childMapper) => this.childMapper = childMapper;

    public void Map(MapFrom source, MapTo destination)
    {
        destination.BooleanTo = source.BooleanFrom;
        destination.IntegerTo = source.IntegerFrom;
        destination.ChildrenTo = childMapper.MapList(source.ChildrenFrom);
    }
}

public class DemoChildMapper : IMapper<MapFromChild, MapToChild>
{
    public void Map(MapFromChild source, MapToChild destination)
    {
        destination.DateTimeOffsetTo = source.DateTimeOffsetFrom;
        destination.StringTo = source.StringFrom;
    }
}

public class UsageExample
{
    private readonly IMapper<MapFrom, MapTo> mapper = new DemoMapper();

    public MapTo MapOneObject(MapFrom source) => this.mapper.Map(source);

    public MapTo[] MapArray(List<MapFrom> source) => this.mapper.MapArray(source);

    public List<MapTo> MapList(List<MapFrom> source) => this.mapper.MapList(source);

    public IAsyncEnumerable<MapTo> MapAsyncEnumerable(IAsyncEnumerable<MapFrom> source) =>
        this.mapper.MapEnumerableAsync(source);
}
```

Also includes `IImmutableMapper<TSource, TDestination>` which is for mapping to immutable types like C# 9 `record`'s and can also be used for `enum` types.

```c#
public record MapFrom(bool BooleanFrom, int IntegerFrom);
public record MapTo(bool BooleanTo, int IntegerTo);

public class DemoImmutableMapper : IImmutableMapper<MapFrom, MapTo>
{
    public MapTo Map(MapFrom source) =>
        new MapTo(source.BooleanFrom, source.IntegerFrom);
}
```

## Contributors
A big thanks to the project author, [Rehan Saeed](https://github.com/RehanSaeed), and to all of the contributors of the original project. Again, [don't forget to check it out](https://github.com/Dotnet-Boxed/Framework)!