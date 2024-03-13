var now = DateTime.UtcNow;

var longDate = $"{now.DayOfWeek}, {now.Day}, {now.Month}, {now.Year}, {now.Hour}, {now.Minute}, {now.Second}";
var defaultDate = now.ToShortDateString();
var shortTime = now.ToShortTimeString();
var month = now.ToString("dd 'de' MMMM 'de' yyyy");

Console.WriteLine(longDate);
Console.WriteLine(defaultDate);
Console.WriteLine(shortTime);
Console.WriteLine(month);
