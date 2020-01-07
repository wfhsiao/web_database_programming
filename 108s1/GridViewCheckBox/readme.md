當資料欄位中有bit (二元值, 1/0, True/False)時，GridView的欄位會自動轉成checkbox.
<pre>
CREATE TABLE [dbo].[marriage] (
    [Id]      INT        IDENTITY (1, 1) NOT NULL,
    [name]    NCHAR (10) NOT NULL,
    [married] BIT        DEFAULT ((0)) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);</pre>
