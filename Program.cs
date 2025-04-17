using BV425_C__DZ.Advertising;
var data = new Data();
var advertising = new Advertising();

var domen1 = new List<string>();
domen1.Add(data[Domen.ru]);
advertising.Update(data[Location.Яндекс_Директ], domen1);

var domen2 = new List<string>();
domen2.Add(data[Domen.ru_svrd_revda]);
domen2.Add(data[Domen.ru_svrd_pervik]);
advertising.Update(data[Location.Ревдинский_рабочий], domen2);

var domen3 = new List<string>();
domen3.Add(data[Domen.ru_msk]);
domen3.Add(data[Domen.ru_permobl]);
domen3.Add(data[Domen.ru_chelobl]);
advertising.Update(data[Location.Газета_уральских_москвичей], domen3);

var domen4 = new List<string>();
domen4.Add(data[Domen.ru_svrd]);
advertising.Update(data[Location.Крутая_реклама], domen4);

advertising.Search(data[Location.Яндекс_Директ]);
advertising.Search(data[Location.Ревдинский_рабочий]);
advertising.Search(data[Location.Газета_уральских_москвичей]);
advertising.Search(data[Location.Крутая_реклама]);