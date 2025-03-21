using lang_features;

Variables.Main();
Literals.Main();
VariablesScopes.Main();
Overflow.Main();
IncDec.Main();
SomeMathOperations.Main();

string name = "randomName";
string name1 = new string("randomName1");

bool isContains = name.Contains("randomName");

string abs = string.Concat(name, name1);

int x = 1;
string strX = x.ToString();

Console.WriteLine(strX);