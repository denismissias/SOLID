using SOLID;

var j = new Journal();
j.AddEntry("I cried today.");
j.AddEntry("I ate a bug.");

PersistenceManager pm = new();
var filename = "journal.txt";
pm.SaveToFile(j, filename, true);

