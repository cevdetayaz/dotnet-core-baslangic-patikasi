// See https://aka.ms/new-console-template for more information

Console.WriteLine("********** INTERFACE **********");

Focus focus = new Focus();
Console.WriteLine(focus.HangiMarkaninAraci().ToString());
Console.WriteLine(focus.KacTekerlektenOlusur().ToString());
Console.WriteLine(focus.StandartRengiNe().ToString());

Console.WriteLine("************");
Civic civic = new Civic();
Console.WriteLine(civic.HangiMarkaninAraci().ToString());
Console.WriteLine(civic.KacTekerlektenOlusur().ToString());
Console.WriteLine(civic.StandartRengiNe().ToString());

Console.WriteLine("************");
Corolla corolla = new Corolla();
Console.WriteLine(corolla.HangiMarkaninAraci().ToString());
Console.WriteLine(corolla.KacTekerlektenOlusur().ToString());
Console.WriteLine(corolla.StandartRengiNe().ToString());

Console.WriteLine("************ ABSTRACT ***********");
NewFocus focus1 = new NewFocus();
Console.WriteLine(focus.HangiMarkaninAraci().ToString());
Console.WriteLine(focus.KacTekerlektenOlusur().ToString());
Console.WriteLine(focus.StandartRengiNe().ToString());

Console.WriteLine("************");
NewCivic civic1 = new NewCivic();
Console.WriteLine(civic.HangiMarkaninAraci().ToString());
Console.WriteLine(civic.KacTekerlektenOlusur().ToString());
Console.WriteLine(civic.StandartRengiNe().ToString());

Console.WriteLine("************");
NewCorolla corolla1 = new NewCorolla();
Console.WriteLine(corolla.HangiMarkaninAraci().ToString());
Console.WriteLine(corolla.KacTekerlektenOlusur().ToString());
Console.WriteLine(corolla.StandartRengiNe().ToString());

