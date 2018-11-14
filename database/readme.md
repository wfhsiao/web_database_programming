<pre>
CREATE TABLE [dbo].[cards] (
    [Id]    INT      NOT NULL,
    [shape] CHAR (1) NOT NULL,
    [point] CHAR (1) NOT NULL,
    [score] INT      DEFAULT ((0)) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);
</pre>
