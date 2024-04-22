# Hight-Performance Patterns
## 1. Frugal Object
StringValues class

## 2. Pooling
ArrayPool class
MemoryPool<T>
SlabMemoryPool

## 3. Zero-Copy (Avoid copying)
Avoid substring
Use Span<T>
Use Memory<T>

## 4. Struct of Arrays

## 5. Stack-based data

## 6. Buffered Builder

Source: [Youtube](https://www.youtube.com/watch?v=3r6gbZFRDHs)

## 7. Using Span
Source: [Medium](https://medium.com/@anupsarkar-dev/high-performance-loop-in-c-e6b54c1c8527)
```csharp
[Benchmark]
public void For_Span()
{
    var asSpanList = CollectionsMarshal.AsSpan(items);

    for (var i=0;i< asSpanList.Length;i++)
    {
        var item = asSpanList[i];
    }
}

[Benchmark]
public void Foreach_Span()
{
    foreach (var item in CollectionsMarshal.AsSpan(items))
    {

    }
}
```
### Understanding Span<T> in C#
A Span<> is an allocation-free representation of contiguous regions of arbitrary memory. Span<> is implemented as a ref struct object that contains a ref to an object T and a length. This means that a Span in C# will always be allocated to stack memory, not heap memory. Let’s consider this simplified implementation of Span<>:
```csharp
public readonly ref struct Span<T>
{
    private readonly ref T _pointer;
    private readonly int _length;
}
```
Using Span<> leads to performance increases because they are always allocated on the stack. Since garbage collection does not have to suspend execution to clean up objects with no references on the heap as often the application runs faster. Pausing an application to collect garbage is always an expensive operation and should be avoided if possible. Span<> operations can be as efficient as operations on arrays. Indexing into a span does not require computation to determine the memory address to index to.

Another implementation of a Span in C# is ReadOnlySpan<>. It is a struct exactly like Span<> other than that its indexer returns a readonly ref T, not a ref T. This allows us to use ReadOnlySpan<> to represent immutable data types such as String.

Spans can use other value types such as int, byte, ref structs, bool, and enum. Spans can not use types like object, dynamic, or interfaces.

### Span Limitations
Span’s implementation limits its use in code, but conversely, it provides span useful properties.

The compiler allocates reference type objects on the heap which means we cannot use spans as fields in reference types. More specifically ref struct objects cannot be boxed like other value-type objects. For the same reason, lambda statements can not make use of spans either. Spans can not be used in asynchronous programming across await and yield boundaries.

Spans are not appropriate in all situations. Because we are allocating memory on the stack using spans, we must remember that there is less stack memory than heap memory. We must consider this when choosing to use spans over strings.

If we want to use a span-like class in asynchronous programming we could take advantage of Memory<> and ReadOnlyMemory<>. We can create a Memory<> object from an array and slice it as we will see, we can do with a span. Once we can synchronously run code, we can get a span from a Memory<> object.
