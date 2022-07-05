Stack<int> s = new();

void Dump() => Console.WriteLine($"IsEmpty: {s.IsEmpty}; Count: {s.Count}; Content: [{string.Join(',',s)}]");

Dump();

s.Push(1);

Dump();

s.Push(2);

Dump();

s.Push(3);

Dump();

Console.WriteLine($"Pop: {s.Pop()}");

Dump();

s.Push(3);

Dump();

Console.WriteLine($"Pop: {s.Pop()}");
Console.WriteLine($"Pop: {s.Pop()}");
Console.WriteLine($"Pop: {s.Pop()}");

Dump();

s.Push(10);

Dump();

Console.WriteLine($"Pop: {s.Pop()}");

Dump();