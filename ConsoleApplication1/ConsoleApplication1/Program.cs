using System;
class Test { static void Main() { uint usCnt; uint usSum = 0; for (usCnt = 10; usCnt >= 0; usCnt--) { Console.WriteLine("{0}", usCnt); usSum = usSum + usCnt; } } }