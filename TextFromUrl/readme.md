針對期末考第二題insert資料至資料表的語法:
string sql = String.Format("insert into [outputwords] values('{0}', N'{1}', N'{2}', '{3}', {4})", str[0].Replace("'", "''"), str[1].Replace("'", "''"), str[2].Replace("'", "''"), DateTime.Today.ToString("d"), r.Next(1,6));
