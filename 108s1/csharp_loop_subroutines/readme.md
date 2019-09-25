### formatting string using output.write
Response.Output.Write("{0} is bigger than {1}", k, m);  

### for-loop
for[tabl][tab]
for (int i=0; i<10; i++)
{
    Response.Output.Write("{0}", i);
}

foreach[tab][tab]
foreach (string x in colors)
{
    // do something
}


### ! isPostBack
if (! IsPostBack)
{
}

### method
private void myInit()
{
    /// ....
}

### two dimensional array
string[,] colors = { { "紅", "red" }, { "橙", "orange" }, { "黃", "yellow" }, { "綠", "green" } };
