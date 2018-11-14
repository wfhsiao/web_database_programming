string[] colors = { "red", "green", "blue" };
        string path = Server.MapPath("input.txt"); //對應目前專案目錄至系統的實體路徑
        StreamReader sr = new StreamReader(path, System.Text.Encoding.GetEncoding("Big5"));
        //Response.Output.Write(sr.ReadToEnd());
        int cnt = 0;
        while (sr.Peek() > 0)
        {
            string line = sr.ReadLine();
            Response.Output.Write("<span style='color:{0}'>{1}</span><br />", colors[cnt], line);
            cnt = (cnt + 1) % colors.Length;
        }
        sr.Close();

        path = Server.MapPath("output.txt");
        StreamWriter sw = new StreamWriter(path, false, System.Text.Encoding.GetEncoding("Big5"));
        sw.Write("中文測試");
        sw.Close();
