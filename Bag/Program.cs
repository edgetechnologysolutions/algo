Bag<int> bag = new();

void Dump() => Console.WriteLine($"IsEmpty: {bag.IsEmpty}; Count={bag.Count}; Contents: [{string.Join(',', bag)}]");

Dump();

bag.Add(10);
Dump();

bag.Add(9);
Dump();

bag.Add(10);
Dump();

bag.AddRange(new[]{1,2,3});
Dump();



