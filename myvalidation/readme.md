RequiredValidator<br />
RangeValidator (Integer/0/120)<br />

in web.config add the following block<br />
<pre>
&lt;appSettings>
    &lt;add key="ValidationSettings:UnobtrusiveValidationMode" value="None" />
  &lt;/appSettings>
</pre>
