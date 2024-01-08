Console.WriteLine("Exercice 2");

// Entiers signés
System.Sbyte i = 0; // 8bits(1byte signé)   -> 127
System.Int16 i = 0; // 16bits(2bytes signé) -> 32 768
System.Int32 i = 0; // 32bits(4bytes signé) -> 2 147 483 648
System.Int64 i = 0; // 64bits(8bytes signé) -> 9 223 372 036 854 775 808 

// Entiers non signés
System.Byte i = 0; // 8bits(1byte non signé)   -> 255
System.UInt16 i = 0; // 16bits(2bytes non signé) -> 65 535
System.UInt32 i = 0; // 32bits(4bytes non signé) -> 4 294 967 295
System.UInt64 i = 0; // 64bits(8bytes non signé) -> 18 446 744 073 709 551 615

// Nombres décimaux
System.Single i = 0; // 32bits(4bytes) -> 3.402823e38
System.Double i = 0; // 64bits(8bytes) -> 1.79769313486232e308
System.Decimal i = 0; // 128bits(16bytes) -> 7.92281625142643e28


// Alias
System.Sbyte = sbyte
System.Int16 = short
System.Int32 = int
System.Int64 = long

System.Byte = byte
System.UInt16 = ushort
System.UInt32 = uint
System.UInt64 = ulong

System.Single = float
System.Double = double
System.Decimal = decimal

// Types numeriques vraiment utiles
int, byte, decimal (long, short, float)

// Groupements de chiffres
long l = 1_000_000_000;